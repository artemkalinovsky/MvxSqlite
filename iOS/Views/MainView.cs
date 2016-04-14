using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MvxSqlite.ViewModels;

namespace MvxSqlite.iOS.Views
{
    public partial class MainView : MvxViewController
    {
        public MainView()
            : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(Text).To(vm => vm.Value);
            set.Bind(Load).To(vm => vm.Load);
            set.Bind(Save).To(vm => vm.Save);
            set.Apply();
        }
    }
}


