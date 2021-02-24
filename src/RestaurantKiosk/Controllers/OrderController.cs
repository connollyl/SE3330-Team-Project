//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Order Controller recieves item data from the menu and 
//          transmits it in the form of string lists. Order Controller
//          also takes in strings and converts searches for items
//          into usable form data.
//
// SPECIAL NOTE: We could not test methods that use the SQLite database 
// for saving orders. This is due to the database being saved outside the 
// test solution and the SQL library not being accessible in the test 
// solution. To fix the issue of file paths, we would need to have 
// duplicate methods for all SQLite methods that define different paths 
// for the database. 
//---------------------------------------------------------------------

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
      private const string STAT_FILE_PATH = "OrderStatistics.sqlite";
      private static string connectionString = @"Data Source=OrderStatistics.sqlite; Version=3; 
                                  FailIfMissing=True; Foreign Keys=True;";
      private static string create_table = @"CREATE TABLE IF NOT EXISTS OrderStatistics (
                        MenuItem TEXT PRIMARY KEY,
                        Quantity INTEGER)";

      // ----------------------------------------------------------------
      // Default constructor for an order initializes the lists 
      // and loads XML data.
      // ----------------------------------------------------------------
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
         }

         createOrderStatisticsTableSQL();
         createOrdersTableSQL();
      }

      // ----------------------------------------------------------------
      //  Constructor for testing purposes only. Doesn't have sqlite stuff
      // ----------------------------------------------------------------
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
         }
      }

      // ----------------------------------------------------------------
      //  Creates a serializer to retrieve all "Items" from the XML file and 
      //  fills the restaurantMenu with the items in the menu.
      // ----------------------------------------------------------------
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

      // ----------------------------------------------------------------
      //  Return the strings of all of the names in the restaurant menu.
      // ----------------------------------------------------------------
      public List<string> getMenuItemNames()
      {
         List<string> menuItemNames = new List<string>();
         return restaurantMenu.Select(s => s.nameAtt).ToList();
      }

      // ----------------------------------------------------------------
      // Returns a string list of all options associated with a MenuItem
      // ----------------------------------------------------------------
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

      // ----------------------------------------------------------------
      //  Return description of menu item corresponding
      //  to specified item name.
      // ----------------------------------------------------------------
      public string getDescription(string name)
      {
         foreach (MenuItem item in restaurantMenu)
         {
            if (item.nameAtt.Equals(name))
            {
               return item.descriptionAtt + "\n Calories: " + item.caloriesAtt;
            }
         }
         return "Failed, Sorry";
      }
      // ----------------------------------------------------------------
      //  Returns the string category of the name given for the menu item
      //  If name is not found, return null.
      // ----------------------------------------------------------------
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

      // ----------------------------------------------------------------
      //  Returns the price of an item given its name. If the name is 
      //  not found, return 0 for the price.
      // ----------------------------------------------------------------
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

      // ----------------------------------------------------------------
      //  Return all categories from restaurantCategories.
      // ----------------------------------------------------------------
      public List<string> loadCategoryButtons()
      {
         return restaurantCategories;
      }

      // ----------------------------------------------------------------
      //  Creates and initializes a new order.
      // ----------------------------------------------------------------
      public void createNewOrder()
      {
         currentOrder = new Order();
      }

      // ----------------------------------------------------------------
      // Updates the customers order with the specified item that 
      // they are adding to the cart.
      // ----------------------------------------------------------------
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
            }
         }
         currentOrder.addToOrder(newItem);
      }

      // ----------------------------------------------------------------
      //  Removes the selected item from the order.
      // ----------------------------------------------------------------
      public void removeItem(string uniqueID)
      {
         currentOrder.removeOrderItem(uniqueID);
      }

      // ----------------------------------------------------------------
      // Returns the order menu item name based on the unique id.
      // ----------------------------------------------------------------
      public string getOrderMenuItemNameByID(string uniqueID)
      {
         return currentOrder.getOrderItems().Where(s => s.uniqueIDAtt.Equals(uniqueID)).Select(s => s.nameAtt).FirstOrDefault();
      }

      // ----------------------------------------------------------------
      // Returns the price of the order menu item based on the unique id.
      // ----------------------------------------------------------------
      public float getOrderMenuItemPriceByID(string uniqueID)
      {
         return currentOrder.getOrderItems().Where(s => s.uniqueIDAtt.Equals(uniqueID)).Select(s => s.priceAtt).FirstOrDefault();
      }

      // ----------------------------------------------------------------
      // Returns a list of the order menu item unque ids.
      // ----------------------------------------------------------------
      public List<string> getOrderMenuItemUniqueIDs()
      {
         return currentOrder.getUniqueIDs();
      }

       // ----------------------------------------------------------------
       // Returns the options of a specific order menu item (optionName_price).
       // ----------------------------------------------------------------
      public List<string> getOptionsAndPricesByID(string uniqueID)
      {
         List<string> returnData = new List<string>();
         foreach(Option option in getOrderMenuItemByID(uniqueID).Options)
         {
            returnData.Add(option.nameAtt + "_" + option.priceAtt.ToString("$0.00"));
         }

         return returnData;
      }

      // ----------------------------------------------------------------
      // Returns an order menu item based on its unique id.
      // ----------------------------------------------------------------
      public MenuItem getOrderMenuItemByID(string uniqueID)
      {
         return currentOrder.getOrderItems().Select(s => s).Where(s => s.uniqueIDAtt.Equals(uniqueID)).FirstOrDefault();
      }

      // ----------------------------------------------------------------
      // Returns the order subtotal.
      // ----------------------------------------------------------------
      public float getSubTotal()
      {
         return currentOrder.calculatePrice();
      }
      public void processOrderSQL(string menu_item_name)
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
            quantity++;
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

         currentOrder.setOrderNumber(getNewOrderNumberSQL());
      }

      // ----------------------------------------------------------------
      // Queries to create a new table if one doesnt exist. 
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static void createOrderStatisticsTableSQL()
      {
         if (!File.Exists(STAT_FILE_PATH))
            SQLiteConnection.CreateFile(STAT_FILE_PATH);
         SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
         dbConnection.Open();
         SQLiteCommand command = new SQLiteCommand(create_table, dbConnection);
         command.ExecuteNonQuery();
         dbConnection.Close();
      }

      // ----------------------------------------------------------------
      // Creates a new OrdersTable if one doesn't already exist.
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static void createOrdersTableSQL()
      {
         if (!File.Exists(@"OrdersTable.sqlite"))
            SQLiteConnection.CreateFile(@"OrdersTable.sqlite");
         SQLiteConnection db = new SQLiteConnection(@"Data Source=OrdersTable.sqlite; Version=3; FailIfMissing=True; Foreign Keys=True;");
         db.Open();
         SQLiteCommand cmd = new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS OrdersTable (OrderNumber Integer, Done Integer, MenuItem TEXT, Options TEXT, TableNumber Integer)", db);
         cmd.ExecuteNonQuery();
         db.Close();
      }

      // ----------------------------------------------------------------
      // Add a whole order to the OrdersTable.
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static void saveOrderSQL(Order order)
      {
         int j = 0;
         foreach (MenuItem mi in order.getOrderItems())
         {
            string options_parse = "";
            foreach(Option o in mi.Options)
               options_parse += o.nameAtt + ", ";
            SQLiteConnection dbConnection = new SQLiteConnection(@"Data Source=OrdersTable.sqlite; Version=3; FailIfMissing=True; Foreign Keys=True;");
            dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand(dbConnection);
            command.CommandText = "insert into OrdersTable (OrderNumber, Done, MenuItem, Options, TableNumber) values (@num, 0, @item, @options, @table)";
            command.Prepare();
            command.Parameters.AddWithValue("@num", order.getOrderNumber());
            command.Parameters.AddWithValue("@item", mi.nameAtt);
            command.Parameters.AddWithValue("@options", options_parse);
            command.Parameters.AddWithValue("@table", order.getTableNumber());
            command.ExecuteNonQuery();
            dbConnection.Close();
         }
      }

      // ----------------------------------------------------------------
      // Update an order's status by changing done to 1 based off the
      //  order numberin the parameters.
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static void updateOrderSQL(int orderNum)
      {
         SQLiteConnection conn = new SQLiteConnection(@"Data Source=OrdersTable.sqlite; Version=3; FailIfMissing=True; Foreign Keys=True;");
         conn.Open();

         SQLiteCommand command = new SQLiteCommand(conn);
         command.CommandText = "UPDATE OrdersTable SET Done = 1 WHERE OrderNumber = " + orderNum;
         command.Prepare();
         command.ExecuteNonQuery();

         conn.Close();
      }

      // ----------------------------------------------------------------
      // Selects the max order number in the database and returns 
      // that value + 1.
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static int getNewOrderNumberSQL()
      {
         int orderNumber = -1;
         SQLiteConnection conn = new SQLiteConnection(@"Data Source=OrdersTable.sqlite; Version=3; FailIfMissing=True; Foreign Keys=True;");
         conn.Open();

         SQLiteCommand command = new SQLiteCommand(conn);
         command.CommandText = "SELECT max(OrderNumber) FROM OrdersTable";
         command.Prepare();
         
         object val = command.ExecuteScalar();//generic placeholder
         try
         {
            orderNumber = int.Parse(val.ToString());
         }
         catch(Exception e)
         {
            System.Console.WriteLine("OrdersTable generated, order number starts at 100. " + e.ToString());
            orderNumber = 99;
         }
         
         return ++orderNumber;
      }

      // ----------------------------------------------------------------
      // Generates all unique orders in the OrdersTable that are not done.
      // Returns a list of all those orders.
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static List<Order> getOrdersSQL()
      {
         List<Order> orders = new List<Order>();
         List<int> orderNumbers = new List<int>();
         int tempOrderNum, tableNum;
         Order tempOrder;
         string itemName, itemOptions;

         SQLiteConnection conn = new SQLiteConnection(@"Data Source=OrdersTable.sqlite; Version=3; FailIfMissing=True; Foreign Keys=True;");
         conn.Open();

         SQLiteCommand command = new SQLiteCommand(conn);
         command.CommandText = "SELECT * FROM OrdersTable WHERE Done = 0";
         SQLiteDataReader reader = command.ExecuteReader();
         while (reader.Read())
         {
            tempOrderNum = Int32.Parse(reader["OrderNumber"].ToString());
            if (!orderNumbers.Contains(tempOrderNum))
            {
               orderNumbers.Add(tempOrderNum);
               tempOrder = new Order();
               tableNum = Int32.Parse(reader["TableNumber"].ToString());
               tempOrder.setTableNumber(tableNum);
               tempOrder.setOrderNumber(tempOrderNum);
               orders.Add(tempOrder);
            }
            itemName = reader["MenuItem"].ToString();
            itemOptions = reader["Options"].ToString();
            tempOrder = orders.Find(order => order.getOrderNumber() == tempOrderNum);
            tempOrder.addToOrder(generateItemSQL(itemName, itemOptions));
         }
         reader.Close();


         orders.Sort((order1, order2) => order1.getOrderNumber().CompareTo(order2.getOrderNumber()));
         return orders;
      }

      // ----------------------------------------------------------------
      // Generates a menu item made from the sqlite database.
      // NOTE: Couldn't get 100% coverage, see coverage report for more
      //       details on why.
      // ----------------------------------------------------------------
      public static MenuItem generateItemSQL(string name, string options)
      {
         MenuItem orderItem = new MenuItem();
         int parseIndex;
         orderItem.nameAtt = name;
         while(options.Length > 1)
         {
            parseIndex = options.IndexOf(",");
            orderItem.addOption(new Option(options.Substring(0, parseIndex).Trim(), 0.0f, 0));
            options = options.Substring(parseIndex + 1);
         }
         int i  = 0;

         return orderItem;
      }

      // ----------------------------------------------------------------
      // Returns the most recent order
      // ----------------------------------------------------------------
      public Order getCurrentOrder()
      {
         return currentOrder;
      }
   }
}
