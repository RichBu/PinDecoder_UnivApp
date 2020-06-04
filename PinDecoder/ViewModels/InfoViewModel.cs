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
            PictPageCommand = new Command(async () => await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new Views.PicturePage())));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand PictPageCommand { get; }

    }
}
