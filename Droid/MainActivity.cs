using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxSqlite.Droid
{
    [Activity(Label = "MvxSqlite")]
    public class MainActivity : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
        }
    }
}