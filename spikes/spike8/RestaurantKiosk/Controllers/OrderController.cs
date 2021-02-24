using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestaurantKiosk
{
   public class OrderController
   {
      private List<MenuItem> restaurantMenu;
      private List<string> restaurantCategories;
      AdminController adminControl;
      private Items itemList;
      private Order currentOrder;

      /*
      *  Default constructor for an order initializes the lists and loads XML data.
      */
      public OrderController()
      {
         restaurantMenu = new List<MenuItem>();
         restaurantCategories = new List<string>();
         createNewOrder();
         loadXMLData();
      }

      /*
      *  Creates a serializer to retrieve all "Items" from the XML file and 
      *  fills the restaurantMenu with the items in the menu.
      */
      public void loadXMLData()
      {
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
      *  Return the strings of all of the names in the restaurant menu.
      */
      public List<string> getMenuItemNames()
      {
         List<string> menuItemNames = new List<string>();
         return restaurantMenu.Select(s => s.nameAtt).ToList();
      }

      /*
       *  Return description of menu item corresponding
       *  to specified item name
       */
      public string getDescription(string name)
      {
         foreach (MenuItem item in restaurantMenu)
         {
            if (item.nameAtt.Equals(name))
            {
               return item.descriptionAtt;
            }
         }
         return "Failed, Sorry";
      }
      /*
      *  Returns the string category of the name given for the menu item
      *  If name is not found, return null.
      */
      public string getCategoryOfMenuItem(string menuItemName)
      {
         foreach (MenuItem item in restaurantMenu)
         {
            if (item.nameAtt.Equals(menuItemName, StringComparison.InvariantCultureIgnoreCase))
            {
               return item.categoryAtt;
            }
         }
         return null;
      }

      /*
      *  Returns the price of an item given its name. If the name is not found,
      *  return 0 for the price.
      */
      public float getPrice(string name)
      {
         foreach (MenuItem item in restaurantMenu)
         {
            if (item.nameAtt.Equals(name))
            {
               return item.priceAtt;
            }
         }
         return 0.0f;
      }

      /*
      *  Return all categories from restaurantCategories.
      */
      public List<string> loadCategoryButtons()
      {
         return restaurantCategories;
      }

      /* 
      *  Creates and initializes a new order
      */
      public void createNewOrder()
      {
         currentOrder = new Order();
      }

      /* 
      *  Use in the future when we have custom orders, so not in release 1...
      */
      /*
      public void addItemToOrder(string itemName, List<string> chosenOptions)
      {
         MenuItem newItem = new MenuItem();
         
         foreach(MenuItem item in restaurantMenu)
         {
            if(item.nameAtt.Equals(itemName))
            {
               newItem = item;
            }
         }
         for(int i = 0; i < newItem.Options.Count; i++)
         {
            if (!chosenOptions.Contains(newItem.Options[i].nameAtt))
               newItem.Options.RemoveAt(i);
         }
         currentOrder.addToOrder(newItem);
      }*/
   }
}
