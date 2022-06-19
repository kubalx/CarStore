using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarStoreLibrary
{
    public class PartOperations : IPartOperations
    {

        public void searchByType(Store pa)
        {
            Console.Write("\nEnter the type of the part you are looking for: ");
            string type = Console.ReadLine();
            var searchBy = pa.PartList.Where(p => p.Type == type);
            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"\n{result} parts match your search criteria, try to search again:\n");
                choosePartAction();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\n{result} parts match your search criteria:");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nPart #" + i + " => " + item);
                    i++;
                }
                Console.WriteLine("\nWhich auto part would you like to buy? (number)");
                int partChosen = int.Parse(Console.ReadLine());

                pa.PartShoppingList.Add(searchBy.ElementAt(partChosen));
                pa.PartList.Remove(searchBy.ElementAt(partChosen));
                printShoppingCart(pa);
            }
        }
        public void searchByKey(Store pa)
        {
            Console.Write("\nEnter the key word of the part you are looking for: ");
            string name = Console.ReadLine();
            var searchBy = pa.PartList.Where(p => p.Name.Contains(name));
            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"\n{result} parts match your search criteria, try to search again:\n");
                choosePartAction();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\n{result} parts match your search criteria:");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nPart #" + i + " => " + item);
                    i++;
                }
                Console.WriteLine("\nWhich auto part would you like to buy? (number)");
                int partChosen = int.Parse(Console.ReadLine());

                pa.PartShoppingList.Add(searchBy.ElementAt(partChosen));
                pa.PartList.Remove(searchBy.ElementAt(partChosen));
                printShoppingCart(pa);
            }
        }

        public void advancedSearch(Store pa)
        {
            Console.Write("\nEnter the name of the part you are looking for: ");
            string nameValue = Console.ReadLine();
            Console.Write("\nEnter the type of the part you are looking for: ");
            string typeValue = Console.ReadLine();
            Console.Write("\nPrice up to: ");
            int priceValue = int.Parse(Console.ReadLine());


            var searchBy = pa.PartList.Where(p => p.Name.Contains(nameValue))
                                      .Where(p => p.Type == typeValue)
                                      .Where(p => p.Price < priceValue);

            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"\n{result} parts match your search criteria, try to search again: \n");
                choosePartAction();
            }
            else
            {
                Console.Write($"\n{result} parts match your search criteria: ");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nPart #" + i + " => " + item);
                    i++;
                }
                Console.WriteLine("Which item would you like to buy? (number)");
                int PartChosen = int.Parse(Console.ReadLine());
                pa.PartShoppingList.Add(searchBy.ElementAt(PartChosen));
                pa.PartList.Remove(searchBy.ElementAt(PartChosen));
                printShoppingCart(pa);
            }
        }

        public void printDefaultListCart(Store pa)
        {
            Console.Clear();
            Console.WriteLine("Available car parts:\n");
            printPartList(pa);
        }

        public void printShoppingCart(Store pa)
        {
            Console.Clear();
            Console.WriteLine("Parts you have choose to buy:\n");
            for (int i = 0; i < pa.PartShoppingList.Count; i++)
            {
                Console.WriteLine("Part # " + i + " => {0}\n", pa.PartShoppingList[i]);
            }

        }

        public void printShoppingList(Store pa)
        {
            if (pa.PartShoppingList.Count >= 1)
            {
                Console.WriteLine("Parts: \n");
                for (int i = 0; i < pa.PartShoppingList.Count; i++)
                {
                    Console.WriteLine("Part # " + i + " => {0}\n", pa.PartShoppingList[i]);
                }
            }
            if (pa.CarShoppingList.Count >= 1)
            {
                Console.WriteLine("Cars: \n");
                for (int i = 0; i < pa.CarShoppingList.Count; i++)
                {
                    Console.WriteLine("Cars # " + i + " => {0}\n", pa.CarShoppingList[i]);
                }
            }
        }

        public void printPartList(Store pa)
        {
            for (int i = 0; i < pa.PartList.Count; i++)
            {
                Console.WriteLine("\nPart #" + i + " =>" + pa.PartList[i]);
            }
        }


        public int choosePartAction()
        {
            int choice; 
            Console.WriteLine("___________________________________________");
            Console.WriteLine("\n" +
                "[1] Show list of available parts \n" +
                "[2] Add a new part to store \n\n" +
                "[3] Search and Buy a part \n\n" +
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

        public void printDefaultListParts(Store pa)
        {
            throw new NotImplementedException();
        }
    }
}
