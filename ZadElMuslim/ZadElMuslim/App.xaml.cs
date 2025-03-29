using SlideOverKit;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using Plugin.LocalNotifications;
using System.IO;
using System.ComponentModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ZadElMuslim
{
    public class MyFontModel
    {
        FontDB fontdb = new FontDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "font.db3"));
        public FontDB fdb;
        public string _Android;
        public string _ios;
        public string size { get; set; }
        public string IOS
        {
            get
            {
                return _ios;
            }
            set
            {
                _ios = value;
            }
        }
        public string Android
        {
            get
            {
                return _Android;
            }
            set
            {
                _Android = value;
            }
        }

        public MyFontModel()
        {
            List<FontModel> fontlist = new List<FontModel>()
            {new FontModel(){
                id=1,
                Android = "BShiraz.ttf#BShiraz",
                IOS = "BShiraz.ttf",
                Active=false
                ,size="16"
            },
            new FontModel(){
                                id=2,
                Android = "alarabiyafont.ttf#alarabiyafont",
                IOS = "alarabiyafont.ttf",
                Active=true
                                ,size="16"

            },new FontModel(){
                                id=3,

                Android = "BEsfehanBold.ttf#BEsfehanBold",
                IOS = "BEsfehanBold.ttf",
                Active=false
                                ,size="16"

            },new FontModel(){
                                id=4,
                Android = "Uthman Taha Naksh.otf#Uthman Taha Naksh",
                IOS = "Uthman Taha Naksh.otf",
                Active=false
                                ,size="16"

            },new FontModel(){
                                id=5,
                Android = "THARWATEMARARUQAA.ttf#THARWATEMARARUQAA",
                IOS = "THARWATEMARARUQAA.ttf",
                Active=false
                                ,size="16"

            },
            };
            var x = fontdb.GetFonts();
            if (x.Count >= 4)
            {
            }
            else
            {
                foreach (FontModel f in fontlist)
                {
                    fontdb.AddFont(f);
                }
            }
            FontModel fdb = fontdb.GetActiveFont();
            Android = fdb.Android;

        }
    }
    public partial class App : Application
    {
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public FontDB fdb;
        public string Android;
        public string IOS;


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ZadElMuslim.Main())
            {
                BarBackgroundColor = Color.FromHex("#492602"),
                BarTextColor = Color.White
            };



        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            notification();
        }
        void notification()
        {


        }
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
