using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreLibrary
{
    public class Part
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }


        public Part()
        {
            Name = "nothing yet";
            Type = "nothing yet";
            Price = 0.00M;
        }

        public Part(string n, string t, decimal c)
        {
            Name = n;
            Type = t;
            Price = c;
        }

        override public string ToString()
        {
            return "\n\tName: " + Name + " \n\tType: " + Type + " \n\tPrice: $" + Price;
        }
    }
}
