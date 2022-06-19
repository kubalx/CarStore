using CarStoreLibrary;
using Pastel;
//using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    class Program
    {

        static readonly CarOperations CarOperator = new CarOperations();
        static readonly PartOperations PartOperator = new PartOperations();

        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"\tWelcome to the Car Store Application.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("\t\t--> [1] Car store\n\t\t--> [2] Auto parts store");
            Console.Write("\n\t\t     ");
            var menu = int.Parse(Console.ReadLine());
            WyborMenu(menu, store);
        }
        public static void WyborMenu(int wybor, Store _store)
        {
            switch (wybor)
            {
                case 2:
                    Console.Clear();
                    int partAct = PartOperator.choosePartAction();
                    while (partAct != 0)
                    {
                        switch (partAct)
                        {
                            case 1:
                                PartOperator.printDefaultListCart(_store);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("You choose to add a new part to store");

                                string partName = "";
                                string partType = "";
                                decimal partPrice = 0;

                                Console.WriteLine("\nWhat is the part name? (styling 128)");
                                Console.Write("\t=> ");
                                partName = Console.ReadLine();

                                Console.WriteLine("What is the type of part? (rims, hedlights, filters)");
                                Console.Write("\t=> ");
                                partType = Console.ReadLine();

                                Console.WriteLine("What is the part price?");
                                Console.Write("\t=> ");
                                partPrice = int.Parse(Console.ReadLine());

                                Part newPart = new Part(partName, partType, partPrice);
                                _store.PartList.Add(newPart);
                                Console.Clear();

                                PartOperator.printPartList(_store);
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("You choose to buy a part");
                                Console.WriteLine("- - - - - - - - - - - - - -\n");
                                Console.WriteLine("(1) Search car part by type (Rims, Headlights, Filters etc.) ");
                                Console.WriteLine("\n(2) Search car part by key words (Doors, BMW, Headlights, Mirrors, e60 etc.) ");
                                Console.WriteLine("\n(3) Advanced search (Name, Type, Price..) \n");
                                Console.Write("Choose search options: ");
                                Console.Write("--> ");
                                var advse = Console.ReadLine();
                                if (int.TryParse(advse, out int num))
                                {
                                    if (num == 1)
                                    {
                                        PartOperator.searchByType(_store);
                                    }
                                    if (num == 2)
                                    {
                                        PartOperator.searchByKey(_store);
                                    }
                                    else 
                                    {
                                        PartOperator.advancedSearch(_store);
                                    }
                                }
                                else
                                    Console.Clear();
                                    Console.WriteLine("\nInput number!");


                                break;

                            case 4:
                                PartOperator.printShoppingList(_store);
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Type your email to complete order");
                                string email = Console.ReadLine();
                                var orderDet = new CompleteOrder(email);
                                Console.Clear();
                                PartOperator.printShoppingList(_store);
                                Console.WriteLine("\n\nThe total cost of your items is: ${0}\n\n", _store.Checkout());
                                Console.WriteLine("Thank you for purchase!\n\n");
                                Console.WriteLine("Check order details in your email -> {0}",orderDet);
                                var line = Console.ReadLine();
                                if (string.IsNullOrEmpty(line))
                                    Environment.Exit(0);
                                else
                                    Console.WriteLine(line);
                                break;
                            case 8:
                                Console.Clear();
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("\t\t--> [1] Car store\n\t\t--> [2] Auto parts store");
                                var menu = int.Parse(Console.ReadLine());
                                WyborMenu(menu, _store);
                                break;
                            case 9:
                                Console.WriteLine(
                                "First you can check list of available parts. Then you may add some parts to the shop. " +
                                "\nIf u want to buy a part - choose search option then and type #number of the part which you want to buy." +
                                "\nFinally go to checkout, to complete the purchase.");
                                break;
                            default:
                                break;
                        }

                        partAct = PartOperator.choosePartAction();
                        Console.Clear();
                    }
                    return;
                case 1:
                    Console.Clear();
                    int carAct = CarOperator.chooseCarAction();
                    while (carAct != 0)
                    {
                        switch (carAct)
                        {
                            case 1:
                                CarOperator.printDefaultListCart(_store);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("You choose to add a new car to store");

                                string carMake = "";
                                string carModel = "";
                                decimal carPrice = 0;
                                string carColor = "";
                                int carYear = 0;
                                int carMiles = 0;
                                string carisNew = "";
                                string carbodyType = "";

                                Console.WriteLine("\nWhat is the car make? ford, mercedes, nissan etc.");
                                Console.Write("\t=> ");
                                carMake = Console.ReadLine();

                                Console.WriteLine("What is the car model? corvette, focus, ranger etc.");
                                Console.Write("\t=> ");
                                carModel = Console.ReadLine();

                                Console.WriteLine("What is the car price?");
                                Console.Write("\t=> ");
                                carPrice = int.Parse(Console.ReadLine());

                                Console.WriteLine("What is the car color?");
                                Console.Write("\t=> ");
                                carColor = Console.ReadLine();

                                Console.WriteLine("What is the car year");
                                Console.Write("\t=> ");
                                carYear = int.Parse(Console.ReadLine());

                                Console.WriteLine("What is the car's mileage?");
                                Console.Write("\t=> ");
                                carMiles = int.Parse(Console.ReadLine());

                                Console.WriteLine("Was the car used or not?");
                                Console.Write("\t=> ");
                                carisNew = Console.ReadLine();

                                Console.WriteLine("What is the car body type?");
                                Console.Write("\t=> ");
                                carbodyType = Console.ReadLine();

                                Car newCar = new Car(carMake, carModel, carPrice, carColor, carYear, carMiles, carisNew, carbodyType);
                                _store.CarList.Add(newCar);
                                Console.Clear();

                                CarOperator.printCarList(_store);
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("- - - - - - - - - - - - - -\n");
                                Console.WriteLine("(1) Search only by make. (Ford, Mercedes, Nissan etc.) ");
                                Console.WriteLine("\n(2) Advanced search (Make, Model, Price..) \n");
                                Console.WriteLine("Choose search options");
                                Console.Write("--> ");
                                var advse = Console.ReadLine();
                                if (int.TryParse(advse, out int num))
                                {
                                    if (num == 1)
                                    {
                                        CarOperator.searchByMade(_store);
                                    }
                                    else
                                    {
                                        CarOperator.advancedSearch(_store);
                                    }
                                }
                                else
                                    Console.WriteLine("Input number!");

                                break;

                            case 4:
                                CarOperator.printShoppingList(_store);
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Type your email to complete order");
                                string email = Console.ReadLine();
                                var orderDet = new CompleteOrder(email);
                                Console.Clear();
                                CarOperator.printShoppingList(_store);
                                Console.WriteLine("\n\nThe total cost of your items is: ${0}\n\n", _store.Checkout());
                                Console.WriteLine("Thank you for purchase!\n\n");
                                Console.WriteLine("Check order details in your email -> {0}", orderDet);
                                var line = Console.ReadLine();
                                if (string.IsNullOrEmpty(line))
                                    Environment.Exit(0);
                                else
                                    Console.WriteLine(line);
                                break;
                            case 8:
                                Console.Clear();
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("\t\t--> [1] Car store\n\t\t--> [2] Auto parts store");
                                var menu = int.Parse(Console.ReadLine());
                                WyborMenu(menu, _store);
                                break;
                            case 9:
                                Console.WriteLine(
                                "First you can check list of available parts. Then you may add some parts to the shop. " +
                                "\nIf u want to buy a part - choose search option then and type #number of the part which you want to buy." +
                                "\nFinally go to checkout, to complete the purchase.");
                                break;
                            default:
                                break;
                        }

                        carAct = CarOperator.chooseCarAction();
                        Console.Clear();
                    }
                    return;
            }
        }
    }

    public class Prog
    {
    }
}