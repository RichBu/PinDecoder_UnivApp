using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace PinDecoder.ViewModels
{
    public class ConvertViewModel: BaseViewModel
    {
        public ConvertViewModel()
        {
            Title = "Convert";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://www.redblup.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}

