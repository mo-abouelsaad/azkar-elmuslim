using Plugin.LocalNotifications;
using SlideOverKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZadElMuslim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tazkir : ContentPage, IMenuContainerPage
    {
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public static List<alarmproperties> alarm { get; set; }
        public int zikrid;

        public Tazkir()
        {
            var fontModel = new MyFontModel();
            BindingContext = fontModel;
            List<alarmproperties> tazkir = Tazkir.alarm;

        
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
        public Tazkir(int a)
        {
            InitializeComponent();
            alarm = new List<alarmproperties>();
            zikrid = a;
            var fontModel = new MyFontModel();
            BindingContext = fontModel;
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

        public async void sbmt(object sender, EventArgs args)
        {
            AzkarDB x = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            TimeSpan val = time.Time;
            DateTime val2 = DateTime.Today.AddMinutes(val.Minutes);
            val2 = DateTime.Today.AddHours(val.Hours).AddMinutes(val.Minutes);
            AzkarDB favourite = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            var zikr = favourite.GetZikr(zikrid);
            alarm.Add(new alarmproperties { time = val2, title = zikr.title, body = zikr.body });
            if (alarm == null)
            {
            }
            else
            {
                foreach (alarmproperties a in alarm)
                {
                    if (a.time < DateTime.Now)
                    {
                    }
                    else
                    {
                        Random rnnd = new Random();
                        int rand = rnnd.Next(1, 500);
                        CrossLocalNotifications.Current.Show(a.title, a.body, rand, a.time);
                    }
                }


            }
            alarm.Clear();
            await Navigation.PopModalAsync();

        }
    }
}