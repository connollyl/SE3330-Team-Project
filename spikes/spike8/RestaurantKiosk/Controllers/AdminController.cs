using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace RestaurantKiosk
{
   public class AdminController
   {
      private List<MenuItem> restaurantMenu;
      private List<string> restaurantCategories;
      Items itemList;

      public AdminController()
      {
         restaurantMenu = new List<MenuItem>();
         restaurantCategories = new List<string>();
         XmlSerializer xml = new XmlSerializer(typeof(Items));
         FileStream fs = new FileStream("XmlSerialization.xml", FileMode.Open);
         itemList = new Items();
         itemList = (Items)xml.Deserialize(fs);
         restaurantMenu = itemList.ItemsList;
         foreach (MenuItem item in restaurantMenu)
         {
            restaurantCategories.Add(item.categoryAtt);
         }
         restaurantCategories = restaurantCategories.Distinct().ToList();
         fs.Close();
      }

      /* 
      * Create a new category for the menu. Adds new string to restaurantCategories. 
      * Note that the add category button should then call load categories to update
      * the alphabetical sorting in the list. Note: Need to add a '+' next to category
      * in GUI. Returns the new list of categories
      */
      public List<string> createNewCategory(string newName)
      {
         restaurantCategories.Add(newName);
         sortRestaurantCategories();
         return restaurantCategories;
      }

      /*
      * Loads categories by calling the sort function and returning the vector 
      * categories.
      */
      public List<string> loadCategories()
      {
         sortRestaurantCategories();
         return restaurantCategories;
      }

      /*
      * Adds a new Category to the list.
      */
      public void addNewCategory(string name)
      {
         restaurantCategories.Add(name);
      }

      /*
      * Sort categories by alphabetical order.
      */
      public void sortRestaurantCategories()
      {
         restaurantCategories = restaurantCategories.OrderBy(s => s).ToList();
      }

      /*
       * Gets a menu item's corresponding list of options 
       */
      public List<Option> loadItemOptions(int selectedItemIndex)
      {
         return restaurantMenu[selectedItemIndex].Options;
      }

      /*
      * Adds an option to an existing menu item referenced by the index of the
      * item in the vector.
      */
      public void addOptionToItem(int selectedItemIndex, string name, float price)
      {
         restaurantMenu.ElementAt(selectedItemIndex).addOption(new Option(name, price, 0));
      }

      /* 
      * Checks for a duplicate name; returns -1 if the name is unique or
      * index of item if name already exists 
      */
      public int verifyNewMenuItem(string name)
      {
         for (int i = 0; i < restaurantMenu.Count; i++)
            if (restaurantMenu[i].nameAtt.Equals(name))
               return i;
         return -1;
      }

      /*
      * Loads a menu item referenced by the index of the item in the vector. Returns
      * the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
      */
      public List<MenuItem> loadRestaurantMenu()
      {
         return restaurantMenu;
      }

      /*
      * Loads a menu item referenced by the index of the item in the vector. Returns
      * the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
      */
      public MenuItem loadMenuItem(int selectedItemIndex)
      {
         return restaurantMenu.ElementAt(selectedItemIndex);
      }

      /*
      * Loads a menu item referenced by the index of the item in the vector. Returns
      * the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
      */
      public List<MenuItem> addMenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost, string category)
      {
         MenuItem newItem = new MenuItem(cal, desc, itemName, itemPrice, itemTimeCost, category);
         if (verifyNewMenuItem(newItem.nameAtt) == -1)
            restaurantMenu.Add(newItem);
         return restaurantMenu;
      }

      /*
       * Removes a specified menu item from the
       * restaurant menu.
       */
      public void removeMenuItem(int index)
      {
         restaurantMenu.RemoveAt(index);
      }

      /*
      * Sorts the restaurant menu based on name. 
      */
      public void sortRestaurantMenu()
      {
         restaurantMenu = restaurantMenu.OrderBy(x => x.nameAtt).ToList();
      }

      /*
      * Returns the size of the menu.
      */
      public int menuSize()
      {
         return restaurantMenu.Count;
      }

      /*
      * Returns the size of the category list.///
      */
      public int categorySize()
      {
         return restaurantCategories.Count;
      }

      /*
      * Returns how many menu items are in a category based on category name.
      */
      public int getCategoryMenuSize(string category)
      {
         int count = 0;
         foreach (MenuItem mi in restaurantMenu)
            if (mi.categoryAtt.Equals(category))
               ++count;
         return count;
      }

      /*
       * Updates a menu item's attributes based on the given parameters
       */
      public void updateMenuItem(int index, string desc, string itemName, float itemPrice, string category)
      {
         restaurantMenu[index].updateCategory(category);
         restaurantMenu[index].descriptionAtt = desc;
         restaurantMenu[index].nameAtt = itemName;
         restaurantMenu[index].priceAtt = itemPrice;
      }

      /*
       * Saves all changes to the xml file upon closing. Serializes the itemList through
       * a file serialization. 
       */
      public void onAdminClose()
      {
         itemList.ItemsList = restaurantMenu;
         XmlSerializer xml = new XmlSerializer(typeof(Items));
         FileStream fs = new FileStream("XmlSerialization.xml", FileMode.Open);
         fs.SetLength(0);
         xml.Serialize(fs, itemList);
         fs.Close();
      }

      public bool checkPrice(string price)
      {
         return (Regex.Matches(price, @"[0-9]").Count == price.Length 
            || (Regex.Matches(price, @"[0-9]").Count == price.Length - 1 
            && Regex.Matches(price, @"[.]").Count == 1));
      }
   }
}