using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PinDecoder.Views
{
    public partial class PinCenterPage : ContentPage
    {
        public PinCenterPage()
        {
            InitializeComponent();
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
