using Prism.Unity.Windows;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace uwp_listview_samples
{
    sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            this.NavigationService.Navigate("Main", null);
            return Task.CompletedTask;
        }

    }
}