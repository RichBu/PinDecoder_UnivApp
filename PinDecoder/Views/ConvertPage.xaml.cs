using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

using PinDecoder.Models;
using PinDecoder.Views;
using PinDecoder.ViewModels;


namespace PinDecoder.Views
{
    [DesignTimeVisible(false)]
    public partial class ConvertPage : ContentPage
    {
        public string[] pinNames = new string[25];
        public int[] pinDefaultStatus = new int[25];
        public int[] pinStatus = new int[25];

        public ConvertPage()
        {
            //clearAllPins();
            InitializeComponent();
            clearAllPins();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Item)layout.BindingContext;
            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }

        async void Orientation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OrientationPinPage()));
        }

        async void Center_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new PinCenterPage()));
        }

        void clearAllPins()
        {
            //clear out all of the pins
            pinNames[0] = "B11";
            pinNames[1] = "B12";
            pinNames[2] = "B13";
            pinNames[3] = "B14";
            pinNames[4] = "B15";

            pinNames[5] = "B21";
            pinNames[6] = "B22";
            pinNames[7] = "B23";
            pinNames[8] = "B24";
            pinNames[9] = "B25";

            pinNames[10] = "B31";
            pinNames[11] = "B32";
            pinNames[12] = "B33";
            pinNames[13] = "B34";
            pinNames[14] = "B35";

            pinNames[15] = "B41";
            pinNames[16] = "B42";
            pinNames[17] = "B43";
            pinNames[18] = "B44";
            pinNames[19] = "B45";

            pinNames[20] = "B51";
            pinNames[21] = "B52";
            pinNames[22] = "B53";
            pinNames[23] = "B54";
            pinNames[24] = "B55";

            //set default status  0=blank  1=active  2=center  3=orient
            pinDefaultStatus[0] = 3;
            pinDefaultStatus[1] = 0;
            pinDefaultStatus[2] = 1;
            pinDefaultStatus[3] = 0;
            pinDefaultStatus[4] = 0;

            pinDefaultStatus[5] = 0;
            pinDefaultStatus[6] = 1;
            pinDefaultStatus[7] = 0;
            pinDefaultStatus[8] = 1;
            pinDefaultStatus[9] = 0;

            pinDefaultStatus[10] = 1;
            pinDefaultStatus[11] = 0;
            pinDefaultStatus[12] = 2;
            pinDefaultStatus[13] = 0;
            pinDefaultStatus[14] = 1;

            pinDefaultStatus[15] = 0;
            pinDefaultStatus[16] = 1;
            pinDefaultStatus[17] = 0;
            pinDefaultStatus[18] = 1;
            pinDefaultStatus[19] = 0;

            pinDefaultStatus[20] = 0;
            pinDefaultStatus[21] = 0;
            pinDefaultStatus[22] = 1;
            pinDefaultStatus[23] = 0;
            pinDefaultStatus[24] = 0;


            pinNames[0] = "B11";
            pinNames[1] = "B12";
            pinNames[2] = "B13";
            pinNames[3] = "B14";
            pinNames[4] = "B15";

            pinNames[5] = "B21";
            pinNames[6] = "B22";
            pinNames[7] = "B23";
            pinNames[8] = "B24";
            pinNames[9] = "B25";

            pinNames[10] = "B31";
            pinNames[11] = "B32";
            pinNames[12] = "B33";
            pinNames[13] = "B34";
            pinNames[14] = "B35";

            pinNames[15] = "B41";
            pinNames[16] = "B42";
            pinNames[17] = "B43";
            pinNames[18] = "B44";
            pinNames[19] = "B45";

            pinNames[20] = "B51";
            pinNames[21] = "B52";
            pinNames[22] = "B53";
            pinNames[23] = "B54";
            pinNames[24] = "B55";


            Console.WriteLine("Setting the color");
            for (int i=0; i<20; i++)
            {
                //loop thru all the pins and set the data
                ButtonGrid.Children[i].BackgroundColor=Color.Red;
                B11.Color = Color.Pink;
                Console.WriteLine(ButtonGrid);
                object buttonObj = this.FindByName(pinNames[i]);
                BoxView boxObj = (BoxView)this.FindByName(pinNames[i]);
                boxObj.Color = Color.Green;
                Console.WriteLine(buttonObj);
                //this.LoadFromXaml(buttonObj).    LoadFromXaml.Color = "Black";
            }
        }
    }
}
