using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdViewPage : ContentPage
    {
        public AdViewPage()
        {
            InitializeComponent();

            App.adCheck = 0;
            ClearNavStack();
        }

        public void ClearNavStack()
        {
            var navigationStack = Navigation.NavigationStack.ToList();
            foreach (var page in navigationStack)
            {
                Navigation.RemovePage(page);
            }
        }
    }
}