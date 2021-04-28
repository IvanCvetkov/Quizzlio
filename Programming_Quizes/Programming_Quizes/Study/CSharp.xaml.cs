using Programming_Quizes.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plugin.TextToSpeech;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.Study
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CSharp : ContentPage
    {
        public CSharp()
        {
            InitializeComponent();

            CrossTextToSpeech.Current.Speak(CSharpDescription.Text);
        }
        protected override bool OnBackButtonPressed()
        {
            BackButtonPressed();
            return true;
        }

        public async Task BackButtonPressed()
        {
            await Navigation.PushModalAsync(new MainTabPage());
        }
    }
}