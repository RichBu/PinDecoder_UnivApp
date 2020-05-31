using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace PinDecoder.ViewModels
{
    public class InfoViewModel : BaseViewModel
    {
        public InfoViewModel()
        {
            Title = "Info";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://www.redblup.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
