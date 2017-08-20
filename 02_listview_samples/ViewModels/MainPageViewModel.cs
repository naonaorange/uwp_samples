using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Windows.Mvvm;
using Prism.Commands;
using Windows.UI.Popups;

namespace uwp_listview_samples.ViewModels
{

    class MainPageViewModel : ViewModelBase
    {
        private List<int> numList;
        public List<int> NumList
        {
            get { return numList; }
            set { SetProperty(ref numList, value); }
        }

        private IEnumerable<int> selectedNum;
        public IEnumerable<int> SelectedNum
        {
            get { return selectedNum; }
            set { SetProperty(ref selectedNum, value); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        private object selectedObj;
        public object SelectedObj
        {
            get { return selectedObj; }
            set { SetProperty(ref selectedObj, value); }
        }

        public DelegateCommand ShowSelectedObjCommand;

        public MainPageViewModel()
        {
            NumList = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                NumList.Add(i);
            }

            Message = "Show multi selected numbers";

            ShowSelectedObjCommand = new DelegateCommand(ShowSelectedObj);
        }

        public async void ShowSelectedObj()
        {
            int num = (int)SelectedObj;
            await new MessageDialog(num.ToString(), "ShowSelectedObj").ShowAsync();
        }
    }
}
