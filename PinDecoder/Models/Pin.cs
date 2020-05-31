using System;

namespace PinDecoder.Models
{
    public class Pin
    {
        public string Id { get; set; }
        public string TextName { get; set; }
        public int PinRow { get; set; }
        public int PinCol { get; set; }
        public int Value { get; set; }
        public int pinType { get; set; }  //0=blank  1=active  2=center  3=orient
        public bool clickedOn { get; set; }
    }
}
