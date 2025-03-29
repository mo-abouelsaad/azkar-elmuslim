using Plugin.Geolocator;
using System;
using System.Text;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Geolocator.Abstractions;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using SlideOverKit;
using System.Linq;


namespace ZadElMuslim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Location : ContentPage, IMenuContainerPage
    {
        Position savedPosition;
        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }
        public Location ()
        {
            InitializeComponent();
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
        private async void GetLoc(Object sender,EventArgs e)
        {
            try
            {
                status.Text = "جاري تحديد الموقع";
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(560), null);
                savedPosition = position;
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("https://maps.googleapis.com/maps/api/geocode/xml?latlng="+position.Latitude +","+position.Longitude+"&location_type=ROOFTOP&result_type=street_address&key=AIzaSyDdXtH7SX4CmpOoHdW2pFfjdIqYpYvFURk");

                XmlNodeList xNodelst = xDoc.GetElementsByTagName("result");
                XmlNode xNode = xNodelst.Item(0);
                /*
                string adress = xNode.SelectSingleNode("formatted_address").InnerText;
                string mahalle = xNode.SelectSingleNode("address_component[3]/long_name").InnerText;
                string ilce = xNode.SelectSingleNode("address_component[4]/long_name").InnerText;
                */
                string il = xNode.SelectSingleNode("address_component[5]/long_name").InnerText;
                city.Text = il + "موقعك الحالي ";
                var client = new WebClient();
                var content = client.DownloadString("https://api.sunrise-sunset.org/json?lat=" + position.Latitude + "&lng=" + position.Longitude + "&date=today");
                var sb = new StringBuilder(content);
                sb.Replace("\\\t", "\t");
                JToken token = JToken.Parse(sb.ToString());
                string sunrise = token.SelectToken("results.sunrise").ToString();
                rise.Text = sunrise + "موعد اذكار الصباح ";
                string t = sunrise.Replace("AM", "");
                TimeSpan val = TimeSpan.Parse(t);
                DateTime val2 = DateTime.Today.AddMinutes(val.Minutes);
                val2 = DateTime.Today.AddHours(val.Hours).AddMinutes(val.Minutes);
                var main = new Main();
                string sunset = token.SelectToken("results.sunset").ToString();
                set.Text = sunset + "موعد اذكار المساء";

                string s = sunset.Replace("PM", "");
                TimeSpan sunsettime = TimeSpan.Parse(s);
                DateTime sunsetalarm = DateTime.Today.AddMinutes(sunsettime.Minutes);
                sunsetalarm = DateTime.Today.AddHours(sunsettime.Hours).AddMinutes(sunsettime.Minutes);
                var sunsetpm = sunsetalarm.AddHours(Double.Parse("12"));
                LocationDB location = new LocationDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "location.db3"));
                location.AddLoc((new LocationModel(){City=il,Longitude=position.Longitude,Latitude=position.Latitude }));
            }
            catch (Exception ex)
            {
                await DisplayAlert("تعذر تحديد موقعك", "لم يتم تحديد موقعك من فضلك التأكد من تشغيل محدد الموقع GPS و الانترنت لديك", "OK");
            }
        }
        }
}