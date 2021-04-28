using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.Quizzes.State
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroPassed : ContentPage
    {
        public int counter
        {
            get
            {
                return App.counter;
            }
        }
        public int pagesCounter
        {
            get
            {
                return App.pagesCounter;
            }
        }
        public IntroPassed()
        {
            InitializeComponent();

            result.Text = "You Scored: " + counter + "/" + pagesCounter;

            App.adCheck = 1;
            App.counter = 0;
            App.pagesCounter = 0;
        }

        protected async override void OnAppearing()
        {
            await rocket.TranslateTo(0, -1000, 3000, Easing.CubicIn);
        }
        protected override bool OnBackButtonPressed()
        {
            return false;
        }
        private async void cntnBtn_Clicked(object sender, EventArgs e)
        {
            var navigationStack = Navigation.NavigationStack.ToList();
            foreach (var page in navigationStack)
            {
                Navigation.RemovePage(page);
            }

            await Navigation.PushModalAsync(new views.MainTabPage());
        }
    }
}