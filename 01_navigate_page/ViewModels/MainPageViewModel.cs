using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Windows.Mvvm;
using Prism.Commands;
using Prism.Windows.Navigation;

namespace uwp_navigate_page.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }

        public DelegateCommand NavigateNextPageCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;

            NavigateNextPageCommand = new DelegateCommand(NavigateNextPage);
        }

        public void NavigateNextPage()
        {
            this.NavigationService.Navigate("Next", "受け渡したい文字列");
        }
    }
}
