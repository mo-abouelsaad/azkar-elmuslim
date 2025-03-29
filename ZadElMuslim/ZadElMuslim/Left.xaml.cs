using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlideOverKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZadElMuslim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Left : SlideMenuView
    {
        public Left()
        {
            InitializeComponent();

            // You must set HeightRequest in this case
            this.WidthRequest = 250;
            // You must set IsFullScreen in this case, 
            // otherwise you need to set WidthRequest, 
            // just like the QuickInnerMenu sample
            this.IsFullScreen = true;
            this.MenuOrientations = MenuOrientation.RightToLeft;

            // You must set BackgroundColor, 
            // and you cannot put another layout with background color cover the whole View
            // otherwise, it cannot be dragged on Android
            this.BackgroundColor = Color.FromHex("#644103");
            this.BackgroundViewColor = Color.Transparent;

            // In some small screen size devices, the menu cannot be full size layout.
            // In this case we need to set different size for Android.
            if (Device.RuntimePlatform == Device.Android)
                this.HeightRequest += 50;
        }
            public  void fav(object sender, EventArgs args)
            {
           Navigation.PushAsync(new favorite());

        }
        public void about(object sender, EventArgs args)
        {
            Navigation.PushAsync(new About());
        }
        public void loc(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Location());

        }
        public void setting(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Setting());

        }
        public void fawaed(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FawaedZikr());

        }
        public void moharamat(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Moharamat());
            var main = new About();

        }
        public void books(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Books());

        }
        public void sonan(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Sonan());

        }
        public void aamal(object sender, EventArgs args)
        {
           // Navigation.PushAsync(new A3malElmuslim());

        }
        public void main(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Main());

        }
        public void masaa(object sender, EventArgs args)
        {
            Navigation.PushAsync(new masaa());

        }
        public void sabah(object sender, EventArgs args)
        {
            Navigation.PushAsync(new sabah());

        }

    }
}