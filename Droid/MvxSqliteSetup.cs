using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;

namespace MvxSqlite.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
            
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
            
    }
}