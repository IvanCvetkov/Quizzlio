using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Quizes.Database;
using Programming_Quizes.Quizzes.FirstIntro;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexPage : ContentPage
    {
        public void ResetNavigationStack()
        {
            if (Navigation != null && Navigation.NavigationStack.Count() > 0)
            {
                var existingPages = Navigation.NavigationStack.ToList();
                foreach (var page in existingPages)
                {
                    Navigation.RemovePage(page);
                }
            }
        }
        //public async Task<Page> PopAllModals()
        //{
        //    Page root = null;

        //    if (Navigation.ModalStack.Count() == 0)
        //        return null;

        //    for (var i = 0; i <= Navigation.ModalStack.Count(); i++)
        //    {
        //        root = await Navigation.PopModalAsync(false);
        //    }
        //    return root;
        //}

        public IndexPage()
        {
            InitializeComponent();

            Button[] btns = { introOneBtn, introTwoBtn, variablesBtn,
                strFirst, strSecond,arrays, arraysAdvanced, methodsFirst,
                methodsSecond, classesFirst, classesSecond };
            List<BtnToDb> btnList = new List<BtnToDb>();

            for (int i = 1; i <= btns.Length; i++)
            {
                BtnToDb btn = new BtnToDb();
                btn.Id = i;

                if (!btnList.Contains(btn))
                    btnList.Add(btn);
            }

            using (QuizContext context = new QuizContext())
            {
                for (int i = 0; i < btnList.Count; i++)
                {
                    if (!context.Buttons.Contains(btnList[i]))
                    {
                        context.Buttons.Add(btnList[i]);
                        context.SaveChanges();
                    }
                }

                var firstBtn = context.Buttons.First(a => a.Id == 1);
                var secondBtn = context.Buttons.First(a => a.Id == 2);
                var thirdBtn = context.Buttons.First(a => a.Id == 3);
                var forthBtn = context.Buttons.First(a => a.Id == 4);
                var fifthBtn = context.Buttons.First(a => a.Id == 5);
                var sixthBtn = context.Buttons.First(a => a.Id == 6);
                var seventhBtn = context.Buttons.First(a => a.Id == 7);
                var eighthBtn = context.Buttons.First(a => a.Id == 8);
                var ninthBtn = context.Buttons.First(a => a.Id == 9);
                var tenthBtn = context.Buttons.First(a => a.Id == 10);
                var eleventhBtn = context.Buttons.First(a => a.Id == 11);

                if (firstBtn.DoneBefore == true)
                {
                    introOneBtn.BackgroundColor = Color.LightGreen;
                    introOneBtn.BorderColor = Color.LightGreen;
                }
                if (secondBtn.DoneBefore == true)
                {
                    introTwoBtn.BackgroundColor = Color.LightGreen;
                    introTwoBtn.BorderColor = Color.LightGreen;
                }
                if (thirdBtn.DoneBefore == true)
                {
                    variablesBtn.BackgroundColor = Color.LightGreen;
                    variablesBtn.BorderColor = Color.LightGreen;
                }
                if (forthBtn.DoneBefore == true)
                {
                    strFirst.BackgroundColor = Color.LightGreen;
                    strFirst.BorderColor = Color.LightGreen;
                }
                if (fifthBtn.DoneBefore == true)
                {
                    strSecond.BackgroundColor = Color.LightGreen;
                    strSecond.BorderColor = Color.LightGreen;
                }
                if (sixthBtn.DoneBefore == true)
                {
                    arrays.BackgroundColor = Color.LightGreen;
                    arrays.BorderColor = Color.LightGreen;
                }
                if (seventhBtn.DoneBefore == true)
                {
                    arraysAdvanced.BackgroundColor = Color.LightGreen;
                    arraysAdvanced.BorderColor = Color.LightGreen;
                }
                if (eighthBtn.DoneBefore == true)
                {
                    methodsFirst.BackgroundColor = Color.LightGreen;
                    methodsFirst.BorderColor = Color.LightGreen;
                }
                if (ninthBtn.DoneBefore == true)
                {
                    methodsSecond.BackgroundColor = Color.LightGreen;
                    methodsSecond.BorderColor = Color.LightGreen;
                }
                if (tenthBtn.DoneBefore == true)
                {
                    classesFirst.BackgroundColor = Color.LightGreen;
                    classesFirst.BorderColor = Color.LightGreen;
                }
                if (eleventhBtn.DoneBefore == true)
                {
                    classesSecond.BackgroundColor = Color.LightGreen;
                    classesSecond.BorderColor = Color.LightGreen;
                }
            }

            ResetNavigationStack();
            //PopAllModals();

            Task.WhenAll(
            introOneBtn.FadeTo(0, 1),
            introTwoBtn.FadeTo(0, 1),
            variablesBtn.FadeTo(0, 1),
            strFirst.FadeTo(0, 1),
            strSecond.FadeTo(0, 1),
            arrays.FadeTo(0, 1),
            arraysAdvanced.FadeTo(0, 1));
        }
        //async void NavigateToAdPage()
        //{
        //    await Navigation.PushModalAsync(new AdViewPage());
        //}
        protected async override void OnAppearing()
        {
            await Task.Delay(1500);
            await Task.WhenAll(
             introOneBtn.FadeTo(1, 500),
             introTwoBtn.FadeTo(1, 500),
             variablesBtn.FadeTo(1, 500),
             strFirst.FadeTo(1, 500),
             strSecond.FadeTo(1, 500),
             arrays.FadeTo(1, 500),
             arraysAdvanced.FadeTo(1, 500));


            // if (App.adCheck == 1) { }
            // NavigateToAdPage();

            //Color color = Color.FromHex("#5DFC0A");
            //introOneBtn.BackgroundColor = color; 
        }

        private async void IntroOne_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionOne());
        }

        private async void introTwoBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.SecondIntro.FirstQuestion());
        }

        private async void variablesBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.Variables.FirstQuestion());
        }

        private async void strFirst_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.FirstStr.FirstQuestion());
        }

        private async void strSecond_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.SecondStr.FirstQuestion());
        }

        private async void arrays_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.Arrays.FirstQuestion());
        }

        private async void arraysAdvanced_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.ArraysAdvanced.FirstQuestion());
        }

        private async void methodsFirst_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.FirstMethods.FirstQuestion());

        }

        private async void methodsSecond_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.SecondMethods.FirstQuestion());
        }

        private async void classesFirst_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.Classes.First.QuestionOne());
        }

        private async void classesSecond_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Quizzes.Classes.Second.FirstQuestion());
        }
    }
}
