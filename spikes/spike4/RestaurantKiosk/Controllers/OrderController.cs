using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk
{
    class OrderController
    {
        private List<MenuItem> restaurantMenu;
        private List<string> restaurantCategories;

        OrderController()
        {

        }

        /*
        *  Return all categories from restaurantCategories.
        */
        List<string> loadCategoryButtons()
        {
            List<string> categories = new List<string>();
            return categories;
        }

        /*
        *  Generates a new vector<CustomItem*> with only items from the selected
        *  category. Then returns the new vector. Triggered by clicking on a category
        *  button before displaying the menu items.
        */
        List<MenuItem> loadCategoryMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            return menuItems;
        }

        /*
        *  Triggered by selecting a menu item button. Only display options if 
        *  there are any. Loads options based on menuItemName (run a search through
        *  restaurantMenu for the name to find its option list). Return those options.
        */
        List<Option> loadItemOptions(string menuItemName)
        {
            List<Option> options = new List<Option>();
            return options;
        }

        //etc................
    }
}
