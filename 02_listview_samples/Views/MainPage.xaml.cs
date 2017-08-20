using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using uwp_listview_samples.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace uwp_listview_samples.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel ViewModel => this.DataContext as MainPageViewModel;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void numMultiListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ViewModel.SelectedNum = this.numMultiListView.SelectedItems.Cast<int>();

            
            this.ViewModel.Message = "";
            foreach(int num in this.ViewModel.SelectedNum)
            {
                this.ViewModel.Message += num.ToString() + " , ";
            }
            
        }
    }
}
