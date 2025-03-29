using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.LocalNotifications;
using Android;

namespace ZadElMuslim.Droid
{
    [Activity(Label = "XF_SplashScreen", Icon = "@drawable/icon", Theme = "@style/MainTheme",
          MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LocalNotificationsImplementation.NotificationIconId = Resource.Drawable.icon;
            LoadApplication(new App());
            string[] PermissionsLocation =
  {
      Manifest.Permission.AccessCoarseLocation,
      Manifest.Permission.AccessFineLocation
    };
            const int RequestLocationId = 0; RequestPermissions(PermissionsLocation, RequestLocationId);
        }
    }
}