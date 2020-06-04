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
        Color pinSet = Color.Green;
        Color pinClear = Color.Red;

        public string[] pinNames = new string[25];
        public int[] pinDefaultStatus = new int[25];
        public int[] pinValue = new int[25];
        public int[] pinStatus = new int[25];

        int serialNum;

        public ConvertPage()
        {
            //clearAllPins();
            initPins();
            InitializeComponent();
            clearAllPins();
        }


        void Pin_Clicked(object sender, EventArgs e)
        {
            //clicked on a pin
            BoxView boxClicked = (BoxView)sender;

            if (boxClicked.Color == pinClear)
            {
                //pin was clear, set it now
                boxClicked.Color = pinSet;
            } else if (boxClicked.Color == pinSet)
            {
                //pin was set, now clear it
                boxClicked.Color = pinClear;
            };

            calcSerialNum();
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

        void Clear_Clicked(object sender, EventArgs e)
        {
            clearAllPins();
        }


        void calcSerialNum()
        {
            serialNum = 0;
            for (int i = 0; i < 25; i++)
            {
                //loop thru all the pins and set the data
                object buttonObj = this.FindByName(pinNames[i]);
                BoxView boxObj = (BoxView)this.FindByName(pinNames[i]);

                //set default status  0=blank  1=active  2=center  3=orient
                if (boxObj.Color == pinSet)
                {
                    //pin is set
                    serialNum = serialNum + pinValue[i];
                };
            };

            //calculate the serial number and then output it
            Span resultObj = (Span)this.FindByName("Result");
            resultObj.Text = "Serial Num = " + serialNum.ToString();
        }


        void initPins()
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

            //set default binary values
            pinValue[0] = 0;
            pinValue[1] = 0;
            pinValue[2] = 1;
            pinValue[3] = 0;
            pinValue[4] = 0;

            pinValue[5] = 0;
            pinValue[6] = 128;
            pinValue[7] = 0;
            pinValue[8] = 2;
            pinValue[9] = 0;

            pinValue[10] = 64;
            pinValue[11] = 0;
            pinValue[12] = 0;
            pinValue[13] = 0;
            pinValue[14] = 4;

            pinValue[15] = 0;
            pinValue[16] = 32;
            pinValue[17] = 0;
            pinValue[18] = 8;
            pinValue[19] = 0;

            pinValue[20] = 0;
            pinValue[21] = 0;
            pinValue[22] = 16;
            pinValue[23] = 0;
            pinValue[24] = 0;
        }


        void clearAllPins()
        {
            initPins();

            serialNum = 0;
            for (int i=0; i<25; i++)
            {
                //loop thru all the pins and set the data
                object buttonObj = this.FindByName(pinNames[i]);
                BoxView boxObj = (BoxView)this.FindByName(pinNames[i]);

                //set default status  0=blank  1=active  2=center  3=orient
                if (pinDefaultStatus[i]==0)
                {
                    boxObj.Color = Color.AntiqueWhite;
                } else if (pinDefaultStatus[i]==1)
                {
                    boxObj.Color = pinClear;
                } else if (pinDefaultStatus[i]==2)
                {
                    boxObj.Color = Color.SlateGray;
                } else if (pinDefaultStatus[i]==3)
                {
                    boxObj.Color = Color.Black;
                };
            }

            //calculate the output and put it to the GUI
            calcSerialNum();
        }
    }
}
