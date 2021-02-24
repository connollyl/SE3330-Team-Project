using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttonResearch
{
    class AdminController
    {
        private List<MenuItem> restaurantMenu = new List<MenuItem>();
        private List<string> restaurantCategories;

        public  AdminController()
        {

        }

        /* 
       *  Create a new category for the menu. Adds new string to restaurantCategories. 
       *  Note that the add category button should then call load categories to update
       *  the alphabetical sorting in the list. Note: Need to add a '+' next to category
       *  in GUI. Returns the new list of categories
       */
        List<string> createNewCategory(string newName)
        {
            return restaurantCategories;
        }

        /*
        *  Loads categories by calling the sort function and returning the vector 
        *  categories.
        */
        List<string> loadCategories()
        {
            return restaurantCategories;
        }

        /*
        *  Sort categories by alphabetical order. sort(.begin(), .end());
        */
        void sortRestaurantCategories()
        {
            
        }

        /*
        *  Adds an option to an existing menu item referenced by the index of the
        *  item in the vector.
        */
        void addOptionToItem(int selectedItemIndex, string name, float price)
        {

        }

        /* 
        *  Checks for all fields filled out and makes sure that there aren't duplicate
        *  menu item names. 
        */
        bool verifyNewMenuItem()
        {
            return false;
        }

        /*
        *  Loads a menu item referenced by the index of the item in the vector. Returns
        *  the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
        */
        public MenuItem loadMenuItem(int selectedItemIndex)
        {
            return restaurantMenu.ElementAt(selectedItemIndex);
        }

        /*
        *  Loads a menu item referenced by the index of the item in the vector. Returns
        *  the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
        */
        public List<MenuItem> addMenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost)
        {
           /*Temporary Code*/
           
            MenuItem temp = new MenuItem(cal, desc, itemName, itemPrice, itemTimeCost);
            restaurantMenu.Add(temp);
            return restaurantMenu;
         //Actual Code needed
      }

      /*
      *  Sorts the restaurant menu based on operator<. 
      */
      void sortRestaurantMenu()
        {

        }
    }
}
