using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxSqlite.Droid
{
    [Activity(Label = "MvxSqlite", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
        }
    }
}