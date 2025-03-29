using SlideOverKit;
using System;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZadElMuslim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class favorite : ContentPage, IMenuContainerPage
    {
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public void gozikr(object sender, ItemTappedEventArgs e)
        {
            var zikr = e.Item as Azkar;

            Navigation.PushAsync(new Zikr(zikr.id));
        }
        public favorite ()
		{
			InitializeComponent ();
            AzkarDB x = new AzkarDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azkar.db3"));
            var fontModel = new MyFontModel();
            BindingContext = fontModel;
            var xy = x.GetAzkar();
            var source = x.Favourite();
            fav.ItemsSource = source;

            this.ToolbarItems.Add(new ToolbarItem
            {
                Command = new Command(() => {
                    if (this.SlideMenu.IsShown)
                    {
                        HideMenuAction?.Invoke();
                    }
                    else
                    {
                        ShowMenuAction?.Invoke();
                    }
                }),
                Icon = "menu.png",
                Priority = 0,


            });
            this.SlideMenu = new Left();
        }
    }
}