using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PinDecoder.Views
{
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        async void PictButton_Clicked()
        {
            await Navigation.PushModalAsync(new NavigationPage(new PicturePage()));
        }
    }
}
