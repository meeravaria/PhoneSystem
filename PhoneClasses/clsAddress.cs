﻿using System;

namespace PhoneClasses
{
    public class clsAddress
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int Capacity { get; set; }
        public int PhoneID { get; set; }
        public int Price { get; set; }
        public string Colour { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool StockStatus { get; set; }
    }
}