using CarouselView.FormsPlugin.Abstractions;
using Programming_Quizes.views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Programming_Quizes
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Task.Delay(1000);
            Task.WhenAll(pancakeView.FadeTo(0, 1),
               mainText.FadeTo(0, 1),
               cntBtn.FadeTo(0, 1));
            //mainAnim.Play();

            //var myCarousel = new CarouselViewControl();
            //myCarousel.ItemsSource = new ObservableCollection<int> { 1, 2, 3, 4, 5 }; // ADD/REMOVE PAGES FROM CAROUSEL ADDING/REMOVING ELEMENTS FROM THE COLLECTION
            //myCarousel.ItemTemplate = new DataTemplate(typeof(View)); //new DataTemplate (typeof(MyView));
            //myCarousel.Position = 0; //default
            //myCarousel.InterPageSpacing = 10;
            //myCarousel.Orientation = CarouselViewOrientation.Horizontal;
        }

        private async void splashBtn_Clicked(object sender, EventArgs e)
        {
            //uint timeout = 50;

            //await Task.WhenAll(logo.TranslateTo(-15, 0, timeout),
            // logo.TranslateTo(15, 0, timeout),
            // logo.TranslateTo(-10, 0, timeout),
            // logo.TranslateTo(10, 0, timeout),
            // logo.TranslateTo(-5, 0, timeout),
            // logo.TranslateTo(5, 0, timeout));

            //logo.TranslationX = 0;

            await Navigation.PushModalAsync(new MainTabPage());
        }

        protected async override void OnAppearing()
        {
            // mainAnim.Play();

            await Task.WhenAll(pancakeView.FadeTo(1, 1000),
                mainText.FadeTo(1, 1000),
                cntBtn.FadeTo(1, 1000));
        }
    }
}
