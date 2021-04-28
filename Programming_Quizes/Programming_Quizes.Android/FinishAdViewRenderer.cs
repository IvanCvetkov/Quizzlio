using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Gms.Ads;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Xamarin.Forms;
using Programming_Quizes.Controls;
using Programming_Quizes.Droid;

[assembly: ExportRenderer(typeof(FinishAdControlView), typeof(FinishAdViewRenderer))]
namespace Programming_Quizes.Droid
{
    public class FinishAdViewRenderer : ViewRenderer<FinishAdControlView, AdView>
    {
        public FinishAdViewRenderer(Context context) : base(context)
        {
        }

        //string adUnitId = "ca-app-pub-5262128722831196/2755396982"; // (Open an Application ad)
        //string adUnitId = "ca-app-pub-3940256099942544/2934735716"; // (test ad)
        // ca-app-pub-5262128722831196/3849164413 (banner ad)
        // ca-app-pub-3940256099942544/6300978111 (test banner ad)
        string adUnitId = "ca-app-pub-5262128722831196/5989968360"; // (whole screen ad)
        public AdSize adSize = AdSize.WideSkyscraper;
        AdView adView;

        private AdView CreateAdView()
        {

            if (adView != null)
                return adView;

            adView = new AdView(Context)
            {
                AdSize = adSize,
                AdUnitId = adUnitId
            };
            var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            adView.LayoutParameters = adParams;
            adView.LoadAd(new AdRequest.Builder().Build());

            return adView;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FinishAdControlView> e)
        {
            base.OnElementChanged(e);
            if (Control == null && e.NewElement != null)
            {
                SetNativeControl(CreateAdView());
            }
        }
    }
}