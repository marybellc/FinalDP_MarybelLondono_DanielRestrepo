
using Android.App;
using Android.OS;
using Ecuation.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Ecuation.Android.Views
{

    [Activity(Label = "@string/app_name")]
    public class EcuationView : MvxActivity<EcuationViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.EcuationPage);
        }
    }
}