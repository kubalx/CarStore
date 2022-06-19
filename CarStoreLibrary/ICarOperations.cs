using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreLibrary
{
    public interface ICarOperations
    {
        void searchByMade(Store s);
        void advancedSearch(Store s);
        void printDefaultListCart(Store s);
        void printShoppingCart(Store s);
        void printShoppingList(Store s);
        void printCarList (Store s);
        int chooseCarAction();
    }
}
