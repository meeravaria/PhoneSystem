using System;

namespace PhoneClasses
{
    public class clsPhone
    {
        public bool Active { get; set; }
        public int PhoneID { get; set; }
        public int Capacity { get; set; }
        public Decimal Price { get; set; }
        public string Colour { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool StockStatus { get; set; }



    }
}