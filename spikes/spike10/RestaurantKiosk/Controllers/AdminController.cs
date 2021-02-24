using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RestaurantKiosk.Controllers;
using System.Text.RegularExpressions;

namespace RestaurantKiosk
{
   /*
    * Handles all major functionality in the admin form. Acts as the policy layer in 
    * the layered architecture.
    */
   public class AdminController
   {
      private List<MenuItem> restaurantMenu;
      private List<string> restaurantCategories;
      private Items itemList;
      private AdminHistory history;
      
      /*
       * Default constructor that initializes all xml and sqlite files.
       */
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

         history = new AdminHistory(restaurantMenu);
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
         if (selectedItemIndex >= 0)
            restaurantMenu.ElementAt(selectedItemIndex).addOption(new Option(name, price, 0));
      }

      /*
       * Removes an option from an existing menu item referenced by the index  
       * of the item in the vector.
       */
      public void removeItemOption(int selectedItemIndex, int optionIndex)
      {
         if (optionIndex >= 0)
            restaurantMenu.ElementAt(selectedItemIndex).removeOption(optionIndex);
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
         restaurantMenu = history.getMenu();
         return restaurantMenu;
      }

      /*
      * Loads a menu item referenced by the index of the item in the vector. Returns
      * the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
      */
      public MenuItem loadMenuItem(int selectedItemIndex)
      {
         if (selectedItemIndex >= 0)
            return restaurantMenu.ElementAt(selectedItemIndex);
         return null;
      }

      /*
      * Loads a menu item referenced by the index of the item in the vector. Returns
      * the MenuItem pointer as apposed to each piece of data (cal, price, desc...).
      */
      public List<MenuItem> addMenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost, string category)
      {
         MenuItem newItem = new MenuItem(cal, desc, itemName, itemPrice, itemTimeCost, category);
         
         if (verifyNewMenuItem(newItem.nameAtt) == -1)
         {
            Command cmd = new UpdateCommand(restaurantMenu, newItem);
            cmd.execute();
            history.undone_commands.Clear();
            history.done_commands.Push(cmd);
         }
 
         sortRestaurantMenu();
         return restaurantMenu;
      }

      /*
       * Removes a specified menu item from the
       * restaurant menu.
       */
      public void removeMenuItem(int index)
      {
         /*
         if (index >= 0)
            restaurantMenu.RemoveAt(index);
            */
         Command cmd = new RemoveCommand(restaurantMenu, restaurantMenu[index]);
         cmd.execute();
         history.done_commands.Push(cmd);
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
       * Updates or adds a (new) menu item's 
       * attributes based on the given parameters
       */
      public void updateMenuItem(int index, string desc, string itemName, float itemPrice, string category, int calorie)
      {
         if (index != -1)
         {
            restaurantMenu[index].updateCategory(category);
            restaurantMenu[index].descriptionAtt = desc;
            restaurantMenu[index].nameAtt = itemName;
            restaurantMenu[index].priceAtt = itemPrice;
            restaurantMenu[index].caloriesAtt = calorie;
         }
         else
         {
            addMenuItem(calorie, desc, itemName, itemPrice, 3.0f, category);
         }
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

      /*
       * Makes sure the price fits standard price format.
       */
      public bool checkPrice(string price)
      {
         return (Regex.Matches(price, @"[0-9]").Count == price.Length
            || (Regex.Matches(price, @"[0-9]").Count == price.Length - 1
            && Regex.Matches(price, @"[.]").Count == 1));
      }

      /*
       * Checks to see if the option already exists in the menu items list
       * of options. Returns -1 if option is not found.
       */
      public int verifyItemOption(int index, string name)
      {
         if (index >= 0)
         {
            for (int i = 0; i < restaurantMenu[index].Options.Count; i++)
            {
               if (restaurantMenu[index].Options[i].nameAtt.Equals(name))
                  return i;
            }
         }
         return -1;
      }

      /*
       * Verifies validity of the calorie field. 
       */
      public bool verifyCalories(string calories)
      {
         return (Regex.Matches(calories, @"[0-9]").Count == calories.Length);
      }

      /*
       * Checks if there are any done commands 
       */
      public bool CheckDone()
      {
         return history.DoneIsEmpty();
      }

      /*
       * Checks if there are any undone commands
       */
      public bool CheckUnDone()
      {
         return history.UndoneIsEmpty();
      }

      /*
       * Gets the current history
       */
      public AdminHistory getHistory()
      {
         return history;
      }
   }



}