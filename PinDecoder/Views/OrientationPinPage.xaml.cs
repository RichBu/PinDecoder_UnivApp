using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PinDecoder.Views
{
    public partial class OrientationPinPage : ContentPage
    {
        public OrientationPinPage()
        {
            InitializeComponent();
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
