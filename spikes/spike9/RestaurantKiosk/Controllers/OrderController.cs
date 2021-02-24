using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Serialization;
using System.Data.SQLite;

namespace RestaurantKiosk
{
   public class OrderController
   {
      private List<MenuItem> restaurantMenu;
      private List<string> restaurantCategories;
      AdminController adminControl;
      private Items itemList;
      private Order currentOrder;
      // ListView cartSummary = new ListView();
      //List<ListViewGroup> categoryViews = new List<ListViewGroup>();
      private const string STAT_FILE_PATH = "OrderStatistics.sqlite";
      private static string connectionString = @"Data Source=OrderStatistics.sqlite; Version=3; 
                                  FailIfMissing=True; Foreign Keys=True;";
      private static string create_table = @"CREATE TABLE IF NOT EXISTS OrderStatistics (
                        MenuItem TEXT PRIMARY KEY,
                        Quantity INTEGER)";

      /*
      *  Default constructor for an order initializes the lists and loads XML data.
      */
      public OrderController()
      {
         restaurantMenu = new List<MenuItem>();
         restaurantCategories = new List<string>();
         createNewOrder();
         loadXMLData();
         foreach(string category in restaurantCategories)
         {
            ListViewGroup group = new ListViewGroup(category, category);
            group.Name = category;
           // categoryViews.Add(group);
         //   cartSummary.Groups.Add(group);
         }

         CreateOrderStatisticsTable();
      }

      /*
      *  Constructor for testing purposes only. Doesn't have sqlite stuff
      */
      public OrderController(string testing)
      {
         restaurantMenu = new List<MenuItem>();
         restaurantCategories = new List<string>();
         createNewOrder();
         loadXMLData();
         foreach (string category in restaurantCategories)
         {
            ListViewGroup group = new ListViewGroup(category, category);
            group.Name = category;
            // categoryViews.Add(group);
            //   cartSummary.Groups.Add(group);
         }
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

      public List<string> getMenuItemOptions(string name)
      {
         List<string> options = new List<string>();

         foreach(MenuItem item in restaurantMenu)
         {
            if(item.nameAtt.Equals(name))
            {
               options.AddRange(item.Options.Select(s => s.nameAtt).ToList());
            }
         }

         return options;
      }

      /*
       *  Return description of menu item corresponding
       *  to specified item name.
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
      *  Creates and initializes a new order.
      */
      public void createNewOrder()
      {
         currentOrder = new Order();
      }

      /*
      *  Updates the customers order with the specified item that they are adding to the cart.
      */
      public void updateOrder(string menuItem, List<string> optionsToRemove)
      {
         List<MenuItem> freshList = new List<MenuItem>(restaurantMenu);
         MenuItem newItem = new MenuItem();

         foreach(MenuItem item in freshList)
         {
            if(item.nameAtt.Equals(menuItem))
            {
               List<Option> newOptionsList = new List<Option>( item.Options );
               newItem = new MenuItem(item.caloriesAtt, item.descriptionAtt, item.nameAtt, item.priceAtt, item.timeCostAtt, item.categoryAtt);

               foreach(Option opt in item.Options)
                  if(optionsToRemove.Contains(opt.nameAtt))
                     newOptionsList.Remove(opt);

               newItem.Options = newOptionsList;
               newItem.uniqueIDAtt = Guid.NewGuid().ToString("N");
            }
         }
         currentOrder.addToOrder(newItem);
      }

      /*
      *  Removes the selected item from the order.
      */
      public void removeItem(string uniqueID)
      {
         currentOrder.getOrderItems().Remove(currentOrder.getOrderItems().Select(s => s).Where(s => s.uniqueIDAtt.Equals(uniqueID)).FirstOrDefault());
      }

      /*
       * Returns the order menu item name based on the unique id.
       */
      public string getOrderMenuItemNameByID(string uniqueID)
      {
         return currentOrder.getOrderItems().Where(s => s.uniqueIDAtt.Equals(uniqueID)).Select(s => s.nameAtt).FirstOrDefault();
      }

      /*
       * Returns the price of the order menu item based on the unique id.
       */
      public float getOrderMenuItemPriceByID(string uniqueID)
      {
         return currentOrder.getOrderItems().Where(s => s.uniqueIDAtt.Equals(uniqueID)).Select(s => s.priceAtt).FirstOrDefault();
      }

      /*
       * Returns a list of the order menu item unque ids.
       */
      public List<string> getOrderMenuItemUniqueIDs()
      {
         return currentOrder.getUniqueIDs();
      }

      /*
       * Returns the options of a specific order menu item (optionName_price).
       */
      public List<string> getOptionsAndPricesByID(string uniqueID)
      {
         List<string> returnData = new List<string>();
         foreach(Option option in getOrderMenuItemByID(uniqueID).Options)
         {
            returnData.Add(option.nameAtt + "_" + option.priceAtt.ToString("$0.00"));
         }

         return returnData;
      }

      /*
       * Returns an order menu item based on its unique id.
       */
      public MenuItem getOrderMenuItemByID(string uniqueID)
      {
         return currentOrder.getOrderItems().Select(s => s).Where(s => s.uniqueIDAtt.Equals(uniqueID)).FirstOrDefault();
      }

      /*
      *  Returns the order subtotal.
      */
      public float getSubTotal()
      {
         return currentOrder.calculatePrice();
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


      /*
      * Processes order into the statistics database. If there is no entry for the item 
      * add one. Otherwise update the existing quantity by 1. NOTE: this is not testable
      * because there is no way to add sqlite packages to the test folder... :(
      */
      public void ProcessOrder(string menu_item_name)
      {
         try
         {
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand(dbConnection);
            command.CommandText = "insert into OrderStatistics (MenuItem, Quantity) values (@Item, 1)";
            command.Prepare();
            command.Parameters.AddWithValue("@Item", menu_item_name);
            command.ExecuteNonQuery();
            dbConnection.Close();
         }
         catch (Exception uniqueness)
         {
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();

            int quantity = 0;
            string query = "SELECT * FROM OrderStatistics WHERE MenuItem = '" + menu_item_name + "'";

            SQLiteCommand command = new SQLiteCommand(dbConnection);
            command = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
               quantity = Int32.Parse(reader["Quantity"].ToString());
            reader.Close();
            quantity++;//Maybe have parameter for quantity???
            query = "UPDATE OrderStatistics "
                + "SET Quantity = @NewQuantity "
                + "WHERE MenuItem = @ItemName";
            command = new SQLiteCommand(query, dbConnection);
            command.Prepare();
            command.Parameters.AddWithValue("@NewQuantity", quantity);
            command.Parameters.AddWithValue("@ItemName", menu_item_name);
            command.ExecuteNonQuery();
            dbConnection.Close();
         }
      }

      /*
       * Queries to create a new table if one doesnt exist. Note that this is not testable
       * because the sqlite package cannot be added to the test folder... :(
       */
      public void CreateOrderStatisticsTable()
      {
         if (!File.Exists(STAT_FILE_PATH))
            SQLiteConnection.CreateFile(STAT_FILE_PATH);
         SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
         dbConnection.Open();
         SQLiteCommand command = new SQLiteCommand(create_table, dbConnection);
         command.ExecuteNonQuery();
         dbConnection.Close();
      }
   }
}
