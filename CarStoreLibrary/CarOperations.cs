using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarStoreLibrary
{
    public class CarOperations : ICarOperations
    {
        public void searchByMade(Store s)
        {
            Console.Write("\nEnter the make of the car you are looking for: ");
            string makeValue = Console.ReadLine();
            var searchBy = s.CarList.Where(p => p.Make == makeValue);
            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"\n{result} cars match your search criteria, try to search again:\n");
                chooseCarAction();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\n{result} cars match your search criteria:");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nCar #" + i + " => " + item);
                    i++;
                }
                Console.WriteLine("\nWhich item would you like to buy? (number)");
                int carChosen = int.Parse(Console.ReadLine());

                s.CarShoppingList.Add(searchBy.ElementAt(carChosen));
                s.CarList.Remove(searchBy.ElementAt(carChosen));
                printShoppingCart(s);
            }
        }
        public void advancedSearch(Store s)
        {
            Console.Write("\nEnter the make of the car you are looking for: ");
            string makeValue = Console.ReadLine();
            Console.Write("\nEnter the model of the car you are looking for: ");
            string modelValue = Console.ReadLine();
            Console.WriteLine("\nPrice up to: ");
            int priceValue = int.Parse(Console.ReadLine());


            var searchBy = s.CarList.Where(p => p.Make.Contains(makeValue))
                                    .Where(p => p.Model == modelValue)
                                    .Where(p => p.Price < priceValue);
            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"\n{result} cars match your search criteria, try to search again:\n");
                chooseCarAction();
            }
            else
            {
                Console.WriteLine($"\n{result} cars match your search criteria:");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nCar #" + i + " => " + item);
                    i++;
                }
                Console.WriteLine("Which item would you like to buy? (number)");
                int carChosen = int.Parse(Console.ReadLine());
                s.CarShoppingList.Add(searchBy.ElementAt(carChosen));
                s.CarList.Remove(searchBy.ElementAt(carChosen));
                printShoppingCart(s);
            }
        }
        public void printDefaultListCart(Store s)
        {
            Console.Clear();
            Console.WriteLine("Available car parts:\n");
            printCarList(s);
        }

        
        public void printShoppingCart(Store s)
        {
            Console.Clear();
            Console.WriteLine("Cars you have choose to buy:\n");
            for (int i = 0; i < s.CarShoppingList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " => {0}\n", s.CarShoppingList[i]);
            }
        }

        public void printShoppingList(Store s)
        {
            Console.Clear();
            if (s.PartShoppingList.Count >= 1)
            {
                for (int i = 0; i < s.PartShoppingList.Count; i++)
                {
                    Console.WriteLine("Part # " + i + " => {0}\n", s.PartShoppingList[i]);
                }
            }
            if (s.CarShoppingList.Count >= 1)
            {
                for (int i = 0; i < s.CarShoppingList.Count; i++)
                {
                    Console.WriteLine("Car # " + i + " => {0}\n", s.CarShoppingList[i]);
                }
            }

        }


        public void printCarList(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("\nCar #" + i + " =>" + s.CarList[i]);
            }
        }


        public int chooseCarAction()
        {
            int choice;
            Console.WriteLine("___________________________________________");
            Console.WriteLine("\n" +
                "[1] Show list of available cars \n" +
                "[2] Add a new car to store \n\n" +
                "[3] Search and Buy a car \n\n" +
                "[4] Show shopping card \n" +
                "[5] Checkout \n\n" +
                "[8] Back to main menu \n" +
                "[9] How to use \n" +
                "[0] Exit");
            Console.WriteLine("___________________________________________");
            Console.Write($"\nChoose an action: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        

    }
}
