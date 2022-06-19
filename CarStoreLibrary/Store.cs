//using CarStoreLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreLibrary
{
    public class Store : IStore
    {
        public List<Car> CarList { get; set; }
        public List<Car> CarShoppingList { get; set; }

        public List<Part> PartList { get; set; }
        public List<Part> PartShoppingList { get; set; }


        public Store()
        {
            CarList = new List<Car>();
            CarShoppingList = new List<Car>();

            CarList.Add(new Car { Make = "Ford", Model = "Focus", Price = 34000, Color = "Yellow", Year = 2006, Miles = 233344, isNew = "Used", bodyType = "Sedan" });
            CarList.Add(new Car { Make = "Mercedes", Model = "CLA", Price = 53000, Color = "Dark grey", Year = 2022, Miles = 0, isNew = "New", bodyType = "Sedan" });
            CarList.Add(new Car { Make = "Aston martin", Model = "GT", Price = 125000, Color = "White", Year = 20020, Miles = 0, isNew = "New", bodyType = "Coupe" });
            CarList.Add(new Car { Make = "Mercedes", Model = "GLC", Price = 55000, Color = "Silver", Year = 2014, Miles = 600000, isNew = "Used", bodyType = "Cabriolet" });
            CarList.Add(new Car { Make = "BMW", Model = "F30", Price = 15000, Color = "Blue", Year = 2021, Miles = 0, isNew = "New", bodyType = "Coupe" });
            CarList.Add(new Car { Make = "Ford", Model = "Mustang", Price = 85000, Color = "Red", Year = 2008, Miles = 100000, isNew = "Used", bodyType = "Coupe" });
            CarList.Add(new Car { Make = "Audi", Model = "A5", Price = 25500, Color = "Black", Year = 20012, Miles = 255000, isNew = "Used", bodyType = "Combi" });


            PartList = new List<Part>();
            PartShoppingList = new List<Part>();
            Part prt = new Part();
            PartList.Add(new Part { Name = "Styling 128 19 Inches", Type = "Rims", Price = 3000 });
            PartList.Add(new Part { Name = "Retro 122 15 Inches", Type = "Rims", Price = 2599 });
            PartList.Add(new Part { Name = "Mercedes GLC Bumper", Type = "Car body", Price = 590 });
            PartList.Add(new Part { Name = "Mercedes GLC Doors", Type = "Car body", Price = 160 });
            PartList.Add(new Part { Name = "Citroen C5 Outside Mirrors", Type = "Car body", Price = 520 });
            PartList.Add(new Part { Name = "Right BMW e60 Headlights", Type = "Headlights", Price = 250 });
            PartList.Add(new Part { Name = "Left BMW e60 Headlights", Type = "Headlights", Price = 120 });
            PartList.Add(new Part { Name = "Audi A5 Fuel Filter", Type = "Filters", Price = 50 });
            PartList.Add(new Part { Name = "BMW E90 Fuel Filter", Type = "Filters", Price = 290 });
        }

        public decimal Checkout()
        {
            if (CarShoppingList.Count >= 1)
            {
                foreach (var c in CarShoppingList)
                {
                    totalCost += c.Price;
                }
            }

            if (PartShoppingList.Count >= 1)
            {
                foreach (var c in PartShoppingList)
                {
                    totalCost += c.Price;
                }
            }
            return totalCost;
        }
    private decimal totalCost = 0;
    }
}