using Xamarin.Forms;
using Xamarin.Essentials;
using Programming_Quizes.views;

namespace Programming_Quizes
{
    public partial class App : Application
    {
        public static int adCheck { get; set; }
        public static int adCounter { get; set; }
        public static int counter { get; set; }
        public static int pagesCounter { get; set; }
        public static string DB_PATH = "";
        public App()
        {
            InitializeComponent();

            VersionTracking.Track();
            var firstLaunch = VersionTracking.IsFirstLaunchForCurrentVersion;

            if (firstLaunch)
                MainPage = new NavigationPage(new MainPage());
            else
                MainPage = new NavigationPage(new MainTabPage());
        }

        public App(string DB_Path)
        {

            InitializeComponent();

            DB_PATH = DB_Path;
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
