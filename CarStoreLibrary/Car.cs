using System;

namespace CarStoreLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public string isNew { get; set; }
        public string bodyType { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
            Color = "nothing yet";
            Year = 0;
            Miles = 0;
            isNew = "nothing yet";
            bodyType = "nothing yet";
        }
        public Car(string a, string b, decimal c, string d, int e, int f, string g, string h)
        {
            Make = a;
            Model = b;
            Price = c;
            Color = d;
            Year = e;
            Miles = f;
            isNew = g;
            bodyType = h;
        }
        override public string ToString()
        {
            return "\n\tMake: " + Make + " \n\tModel: " + Model + " \n\tPrice: $" + Price + " \n\tColor: " + Color + "\n\tYear: " + Year + "\n\tMiles: " + Miles + "\n\tisNew: " + isNew + "\n\tbodyType: " + bodyType;
        }
    }
}