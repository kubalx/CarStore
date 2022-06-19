using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreLibrary
{
    public interface IPartOperations
    {
        void searchByType(Store pa);
        void advancedSearch(Store pa);
        void printDefaultListParts(Store pa);
        void printShoppingCart(Store pa);
        void printShoppingList(Store pa);
        void printPartList(Store pa);
        int choosePartAction();
    }
}
