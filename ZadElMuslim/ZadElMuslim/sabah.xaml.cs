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
	public partial class sabah : ContentPage, IMenuContainerPage
    {
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public sabah ()
		{
			InitializeComponent ();
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
	}
}