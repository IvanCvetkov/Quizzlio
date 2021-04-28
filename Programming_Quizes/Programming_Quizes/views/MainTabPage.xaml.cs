using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabPage : TabbedPage
    {
        public MainTabPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.Quit();
            return false;
        }
        protected override void OnAppearing()
        {

        }
    }
}