using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using System.Collections.Generic;
using System.Reflection;

namespace MvxSqlite.Droid
{
    public class MvxSqliteSetup : MvxAndroidSetup
    {
        public MvxSqliteSetup(Context applicationContext) : base(applicationContext)
        {
            
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
            
    }
}