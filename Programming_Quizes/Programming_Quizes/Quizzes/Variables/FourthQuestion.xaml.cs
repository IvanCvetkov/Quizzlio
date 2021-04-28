using Programming_Quizes.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.Quizzes.Variables
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FourthQuestion : ContentPage
    {
        public FourthQuestion()
        {
            InitializeComponent();
        }
        private async void cntnBtn_Clicked(object sender, EventArgs e)
        {
            if (!rightOption.IsChecked && !wrongOption1.IsChecked && !wrongOption2.IsChecked && !wrongOption3.IsChecked)
            {
                uint timeout = 50;

                await cntnBtn.TranslateTo(-15, 0, timeout);
                await cntnBtn.TranslateTo(15, 0, timeout);
                await cntnBtn.TranslateTo(-10, 0, timeout);
                await cntnBtn.TranslateTo(10, 0, timeout);
                await cntnBtn.TranslateTo(-5, 0, timeout);
                await cntnBtn.TranslateTo(5, 0, timeout);

                cntnBtn.TranslationX = 0;
            }

            else if (rightOption.IsChecked)
            {
                cntnBtn.IsEnabled = false;

                Color color = Color.FromHex("#5DFC0A");
                cntnBtn.Text = "Correct!";
                cntnBtn.BackgroundColor = color;

                AudioService audio = new AudioService();
                audio.PlayAudioFile("correct.mp3");

                App.counter++;

                await Task.Delay(1300);
                await Navigation.PushModalAsync(new FifthQuestion());
            }
            else
            {
                cntnBtn.IsEnabled = false;

                Color color = Color.FromHex("#FF0000");
                cntnBtn.Text = "Wrong!";
                cntnBtn.BackgroundColor = color;

                AudioService audio = new AudioService();
                audio.PlayAudioFile("wrong.mp3");

                await Task.Delay(1300);
                await Navigation.PushModalAsync(new FifthQuestion());
            }
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