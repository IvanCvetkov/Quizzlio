using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.Quizzes.Classes.First
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionThree : ContentPage
    {
        public QuestionThree()
        {
            InitializeComponent();
        }
        private async void cntnBtn_Clicked(object sender, EventArgs e)
        {

            ExtensionMethods.Extensions extentions = new ExtensionMethods.Extensions();
            Task<int> temp = extentions.Next(rightOption, wrongOption1, null, null, cntnBtn);

            if (temp.Result == 1)
                await Navigation.PushModalAsync(new Classes.First.QuestionFor());
            else
                await Navigation.PushModalAsync(new Programming_Quizes.Quizzes.State.IntroFailed());
        }

        public async Task BackButtonPressed()
        {
            var action = await DisplayAlert("Exit", "Are you sure you want to leave the current quiz? " +
                            "You will lose all your progress!", "Yes", "No");
            if (action)
            {
                await Navigation.PushModalAsync(new views.MainTabPage());
                App.counter = 0;
            }
        }

        protected override bool OnBackButtonPressed()
        {
            App.adCheck = 1;
            BackButtonPressed();
            return true;
        }

    }
}