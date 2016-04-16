using MvvmCross.iOS.Platform;
using UIKit;
using MvvmCross.Core.ViewModels;

namespace MvxSqlite.iOS
{
    public class MvxSqliteSetup : MvxIosSetup
    {
        public MvxSqliteSetup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}

