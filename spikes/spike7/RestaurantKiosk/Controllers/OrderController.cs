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
        private Items itemList;
        private List<MenuItem> restaurantMenu;
        private List<string> restaurantCategories;
        AdminController adminControl;

        public OrderController()
        {
            restaurantMenu = new List<MenuItem>();
            restaurantCategories = new List<string>();
            XmlSerializer xml = new XmlSerializer(typeof(Items));
            FileStream fs = new FileStream("C:\\Users\\ItsZs\\Desktop\\3300\\spike10\\RestaurantKiosk\\XmlSerialization\\XmlSerialization.xml", FileMode.Open);
            itemList = new Items();
            //MenuItem testItem = new MenuItem(100, "Delicious food.", "Badger Burger", 9.95f, 10.0f, "Meals");
            //MenuItem testItem2 = new MenuItem(50, "Horrible food.", "Salad", 19.95f, 5.0f, "Meals");

            //Option option1 = new Option("Test", 5.99f, 20);
            //testItem.addOption(option1);
            //itemList.ItemsList.Add(testItem);
            //itemList.ItemsList.Add(testItem2);

            //xml.Serialize(fs, itemList);

            itemList = (Items)xml.Deserialize(fs);

            int i = 0;
        }

        public List<MenuItem> getMenuItems()
        {
            return restaurantMenu;
        }

        public List<string> getMenuItemNames()
        {
            List<string> menuItemNames = new List<string>();
            //return restaurantMenu.Select(s => s.getName()).ToList();
            return menuItemNames;
        }

        public string getCategoryOfMenuItem(string menuItemName)
        {
            foreach (MenuItem item in restaurantMenu)
            {
                //if(item.getName().Equals(menuItemName, StringComparison.InvariantCultureIgnoreCase))
                {
                    //return item.getCategory();
                }
            }
            return null;
        }

        /*
        *  Return all categories from restaurantCategories.
        */
        public List<string> loadCategoryButtons()
        {
            return restaurantCategories;
        }

        /*
        *  Generates a new List<CustomItem> with only items from the selected
        *  category. Then returns the new vector. Triggered by clicking on a category
        *  button before displaying the menu items.
        */
        public List<MenuItem> loadCategoryMenuItems()
        {
            return restaurantMenu;
        }

        /*
        *  Triggered by selecting a menu item button. Only display options if 
        *  there are any. Loads options based on menuItemName (run a search through
        *  restaurantMenu for the name to find its option list). Return those options.
        */
        public List<Option> loadItemOptions(string menuItemName)
        {
            List<Option> options = new List<Option>();//Temp until future release...
            return options;
        }

        //etc................
    }
}
