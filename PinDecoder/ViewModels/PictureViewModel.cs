using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

using System.Collections.Generic;



namespace PinDecoder.ViewModels
{
    public class PictureViewModel : BaseViewModel
    {
        public PictureViewModel()
        {
            Title = "Picture Explanation";
            PictPageCommand = new Command(async () => await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new Views.PicturePage())));
        }


        public async void PictButton_Clicked()
        {
            //Application.Current.MainPage.Navigation
            Console.WriteLine("***** RPB ******");
            Console.WriteLine("pict button clicked");
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new Views.PicturePage()));
        }

        public ICommand PictPageCommand { get; }
        /*
        public void PictButton_Clicked()
        {
            //clicked the picture button
        }
        */
    }
}
