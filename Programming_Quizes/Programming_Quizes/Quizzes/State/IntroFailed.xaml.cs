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
    public partial class IntroFailed : ContentPage
    {
        public IntroFailed()
        {
            InitializeComponent();

            App.adCheck = 1;
            App.counter = 0;
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