using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk
{
   public class AdminController
   {
      private List<MenuItem> restaurantMenu;
      private List<string> restaurantCategories;

      /// <summary>
      /// 
      /// </summary>
      public AdminController()
      {
         restaurantCategories = new List<string>();
         restaurantMenu = new List<MenuItem>();
         //restaurantCategories.Add("Meals");
         //restaurantCategories.Add("Specials");
         //restaurantCategories.Add("Sides");
         //restaurantCategories.Add("Drinks");
         //MenuItem testItem = new MenuItem(100, "Delicious food.", "Badger Burger", 9.95f, 10.0f, "Meals");
         //MenuItem testItem2 = new MenuItem(50, "Horrible food.", "Salad", 19.95f, 5.0f, "Meals");
         //restaurantMenu.Add(testItem);
         //restaurantMenu.Add(testItem2);
      }

      /* 
     *  Create a new category for the menu. Adds new string to restaurantCategories. 
     *  Note that the add category button should then call load categories to update
     *  the alphabetical sorting in the list. Note: Need to add a '+' next to category
     *  in GUI. Returns the new list of categories
     */
      public List<string> createNewCategory(string newName)
      {
         restaurantCategories.Add(newName);
         sortRestaurantCategories();
         return restaurantCategories;
      }

      /*
      *  Loads categories by calling the sort function and returning the vector 
      *  categories.
      */
      public List<string> loadCategories()
      {
         sortRestaurantCategories();
         return restaurantCategories;
      }

      /*
      *  Adds a new Category to the list.
      */
      public void addNewCategory(string name)
      {
         restaurantCategories.Add(name);
      }

      /*
      *  Sort categories by alphabetical order.
      */
      public void sortRestaurantCategories()
      {
         restaurantCategories = restaurantCategories.OrderBy(s => s).ToList();
      }

      /*
      *  Adds an option to an existing menu item referenced by the index of the
      *  item in the vector.
      */
      public void addOptionToItem(int selectedItemIndex, string name, float price)
      {
         //restaurantMenu.ElementAt(selectedItemIndex).addOption(new Option(name, price, 0));
      }

      /* 
      *  Checks for a duplicate name, returns true if the name is unique. 
      */
      public bool verifyNewMenuItem(string name)
      {
         //return !restaurantMenu.Exists(x => x.getName().Equals(name));
         return true;
      }

      /*
      *  Loads a menu item referenced by the index of the item in the vector. Returns
      *  the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
      */
      public List<MenuItem> loadRestaurantMenu()
      {
         return restaurantMenu;
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
      public List<MenuItem> addMenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost, string category)
      {
         //restaurantMenu.Add(new MenuItem(cal, desc, itemName, itemPrice, itemTimeCost, category));
         return restaurantMenu;
      }

      /*
      *  Sorts the restaurant menu based on name. 
      */
      public void sortRestaurantMenu()
      {
         //restaurantMenu = restaurantMenu.OrderBy(x => x.getName()).ToList(); 
      }

      /*
      *  Returns the size of the menu.
      */
      public int menuSize()
      {
         return restaurantMenu.Count;
      }

      /*
      *  Returns the size of the category list.///
      */
      public int categorySize()
      {
         return restaurantCategories.Count;
      }

      /*
      *  Returns how many menu items are in a category based on category name.
      */
      public int getCategoryMenuSize(string category)
      {
         int count = 0;
         //foreach(MenuItem mi in restaurantMenu)
            //if (mi.getCategory().Equals(category))
               //++count;
         return count;
      }
   }
}
