using SlideOverKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZadElMuslim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeathPrayer : ContentPage, IMenuContainerPage
    {
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public DeathPrayer ()
		{
			InitializeComponent ();
            var fontModel = new MyFontModel();
            BindingContext = fontModel;
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