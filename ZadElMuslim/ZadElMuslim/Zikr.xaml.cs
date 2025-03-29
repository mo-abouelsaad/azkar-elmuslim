using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Clipboard;
using Plugin.LocalNotifications;
using Plugin.Share;
using Plugin.Vibrate;
using SlideOverKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZadElMuslim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zikr : ContentPage, IMenuContainerPage
    {
        public Main main;
        public List<Azkar> items;
        public Azkar result;
        public int zikrid;
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public string[] m = new string[] { "nouman.jpg", "masjed.jpg", "mecca.png" };
        public string _img;


        public Zikr(int id)
        {
            InitializeComponent();
            Random r = new Random();
            int no = r.Next(0, 2);
            _img = m[no];
            this.BackgroundImage = _img;
            var fontModel = new MyFontModel();
            BindingContext = fontModel;
            zikrid = id;
            AzkarDB favourite = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            Azkar zikr = favourite.GetZikr(zikrid);
            title.Text = zikr.title;
            body.Text = zikr.body;
            tasbih.Text = "عدد التسبيح " + zikr.tasb;
            if (zikr.isfavourite == true)
            {
                fav.Text = "حذف من المفضلة";
            }
            else
            {
                fav.Text = "إضافة الي المفضلة";

            }
            var menu = this.ToolbarItems.First();
            menu.Command = new Command(() =>
            {
                if (this.SlideMenu.IsShown)
                {
                    HideMenuAction?.Invoke();
                }
                else
                {
                    ShowMenuAction?.Invoke();
                }
            });
            this.SlideMenu = new Left();
        }
        public async void zakr(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Tazkir(zikrid));
        }
        public async void favorize(object sender, EventArgs args)
        {
            AzkarDB favourite = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            var zikr = favourite.GetZikr(zikrid);
            string Message = favourite.Favourise(zikr.id);
            fav.Text = Message;
        }
        public void addtasbih(object sender, EventArgs args)
        {
            AzkarDB gettasbih = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));

            string t = gettasbih.addtasbih(zikrid);
            tasbih.Text = t;
            LocationDB locationB = new LocationDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "location.db3"));
            List<LocationModel> locB = locationB.GetLoc();
            LocationModel set = locB.Last<LocationModel>();
            if (set.snd == true)
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("done.mp3");
                player.Play();
            }

            if (set.vib == true)
            {
                CrossVibrate.Current.Vibration(TimeSpan.FromMilliseconds(1500));

            }
            if (set.nav == true)
            {
                if (zikrid < 37)
                {

                    Navigation.PushAsync(new Zikr(zikrid + 1));
                }
            }


        }
        public void resettasbih(object sender, EventArgs args)
        {
            AzkarDB gettasbih = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));

            string t = gettasbih.resettasbih(zikrid);
            tasbih.Text = t;
        }
        public async void copy(object sender, EventArgs args)
        {
            AzkarDB f = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            var zikr = f.GetZikr(zikrid);
            DisplayAlert("تم النسخ", zikr.title, "OK");
            CrossClipboard.Current.SetText(zikr.title + "    " + zikr.body);
        }
        void share(Object s, EventArgs e)
        {

            AzkarDB f = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            var zikr = f.GetZikr(zikrid);
            CrossShare.Current.Share(new Plugin.Share.Abstractions.ShareMessage
            {
                Text = zikr.body + " Shared Via ZadElMuslim App © تم النشر بواسطة تطبيق زاد المسلم اليومي",
                Title = zikr.title
            });
        }




    }
}
