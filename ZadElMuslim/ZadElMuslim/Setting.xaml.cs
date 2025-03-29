 using SlideOverKit;
 using System;
 using System.Collections.Generic;
 using System.IO;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZadElMuslim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Setting : ContentPage, IMenuContainerPage
    {
        FontDB fontdb = new FontDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "font.db3"));
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public Setting()
        {
            InitializeComponent();
            LocationDB locationB = new LocationDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "location.db3"));
            List<LocationModel> locB = locationB.GetLoc();
            LocationModel set = locB.Last<LocationModel>();
            if (set.snd == true)
            {
                so.Text = "ايقاف الصوت";
            }
            else
            {
                so.Text = "تشغيل الصوت";

            }
            if (set.vib == true)
            {
                vibr.Text = "ايقاف الاهتزاز";
            }
            else
            {
                vibr.Text = "تشغيل الاهتزاز";

            }
            if (set.nav == true)
            {
                navi.Text = "ايقاف الانتقال للذكر التالي";
            }
            else
            {
                navi.Text = "الانتقال للذكر التالي";

            }
            var fontModel = new MyFontModel();
            BindingContext = fontModel.fdb;
            moh.SelectedIndexChanged += OnPickerSelectedIndexChanged;
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
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {

        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        fontdb.SetActiveFont(selectedIndex);
        FontModel f=fontdb.GetActiveFont();
            fstatus.Text = "تم تعديل نوع الخط بنجاح";
        }
        void change(object sender, EventArgs e)
        {
            int value = (int)((Slider)sender).Value;
            FontDB fontdb = new FontDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "font.db3"));
            fontdb.Setsize(value);
           List<FontModel> f=fontdb.GetFonts();


        }
        public void sound(object sender, EventArgs args)
        {
            LocationDB locationB = new LocationDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "location.db3"));
            List<LocationModel> location = locationB.GetLoc();
            LocationModel loc = location.Last<LocationModel>();
            if (loc.snd == true)
            {
                locationB.sound(0);
                so.Text = "تشغيل الصوت";

            }
            else
            {
                locationB.sound(1);
                so.Text = "ايقاف الصوت";


            }
        }
        public void navigation(object sender, EventArgs args)
        {
            LocationDB locationB = new LocationDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "location.db3"));
            List<LocationModel> location = locationB.GetLoc();
            LocationModel loc = location.Last<LocationModel>();
            if (loc.nav == true)
            {
                locationB.nav(0);
                navi.Text = "الانتقال للذكر التالي";

            }
            else
            {
                locationB.nav(1);
                navi.Text = "ايقاف الانتقال للذكر التالي";


            }
        }
        public void vibration(object sender, EventArgs args)
        {
            LocationDB locationB = new LocationDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "location.db3"));
            List<LocationModel> location = locationB.GetLoc();
            LocationModel loc = location.Last<LocationModel>();
            if (loc.vib == true)
            {
                locationB.vib(0);
                vibr.Text = "تشغيل الاهتزاز";

            }
            else
            {
                locationB.vib(1);
                vibr.Text = "ايقاف الاهتزاز";


            }
        }

    }
    }
          