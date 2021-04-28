using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using Android.Gms.Ads;
using Xamarin.Forms;
using Lottie.Forms.Droid;

namespace Programming_Quizes.Droid
{
    [Activity(Label = "Quizzlio", Theme = "@style/MainTheme",Icon = "@drawable/logo", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;


            base.OnCreate(savedInstanceState);

            string fileName = "quiz_db.sqlite";
            string fileLocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string filePath = System.IO.Path.Combine(fileLocation, fileName);

            CarouselViewRenderer.Init();

            MobileAds.Initialize(ApplicationContext, "ca-app-pub-5262128722831196~4145410405");

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(filePath));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}