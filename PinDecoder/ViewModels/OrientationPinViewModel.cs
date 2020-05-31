using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PinDecoder.Models;
using PinDecoder.Views;
using PinDecoder.ViewModels;

namespace PinDecoder.ViewModels
{
    public class OrientationPinViewModel : BaseViewModel
    {
        public OrientationPinViewModel()
        {
            Title = "Orientation Pin Description";
        }
    }
}
