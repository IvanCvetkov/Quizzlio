﻿using Programming_Quizes.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Programming_Quizes.App;
using Programming_Quizes.Database;

namespace Programming_Quizes.Quizzes.FirstIntro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdQuestion : ContentPage
    {
        public ThirdQuestion()
        {
            InitializeComponent();

            App.pagesCounter = 3;
            App.adCheck = 1;
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

                using (QuizContext context = new QuizContext())
                {
                    var button = context.Buttons.First(a => a.Id == 1);
                    button.Passed = true;
                    button.DoneBefore = true;

                    context.SaveChanges();
                }

                await Task.Delay(1300);
                await Navigation.PushModalAsync(new State.IntroPassed());
            }
            else
            {
                using (QuizContext context = new QuizContext())
                {
                    var button = context.Buttons.First(a => a.Id == 1);

                    button.Passed = false;
                    context.SaveChanges();
                }

                cntnBtn.IsEnabled = false;

                Color color = Color.FromHex("#FF0000");
                cntnBtn.Text = "Wrong!";
                cntnBtn.BackgroundColor = color;

                AudioService audio = new AudioService();
                audio.PlayAudioFile("wrong.mp3");

                await Task.Delay(1300);
                await Navigation.PushModalAsync(new State.IntroFailed());
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
            return false;
        }
    }
}