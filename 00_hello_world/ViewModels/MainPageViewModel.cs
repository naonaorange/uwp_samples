using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Commands;
using Prism.Windows.Mvvm;

namespace uwp_hello_world.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        private int pushTimeNum;

        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }


        public DelegateCommand ChangeMessageCommand { get; }


        public MainPageViewModel()
        {
            pushTimeNum = 0;
            Message = "Please push the button!";

            ChangeMessageCommand = new DelegateCommand(ChangeMessage);
        }


        public void ChangeMessage()
        {
            Message = "Hello UWP : " + pushTimeNum;

            pushTimeNum++;
        }
    }
}
