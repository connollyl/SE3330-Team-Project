//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: 
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk
{
   public class Order
   {
      private int estimatedDelivery;
      private float finalPrice;
      private int orderNumber;
      private int orderTime;
      private float recommendedTip;
      private int tableNumber;
      List<MenuItem> orderItems;

      //---------------------------------------------------------------------
      //  Default constructor that initilizes the order to default values.
      //---------------------------------------------------------------------
      public Order()
      {
         estimatedDelivery = 0;
         finalPrice = 0.0f;
         orderNumber = 0;//Change in future when we want unique
         orderTime = 0;
         recommendedTip = 0.0f;
         tableNumber = 1;
         orderItems = new List<MenuItem>();
      }

      //---------------------------------------------------------------------
      // Gets the list of items in the order.
      //---------------------------------------------------------------------
      public List<MenuItem> getOrderItems()
      {
         return orderItems;
      }

      //---------------------------------------------------------------------
      // Removes a specific order item based on the generated unique ID.
      //---------------------------------------------------------------------
      public void removeOrderItem(string uniqueID)
      {
         orderItems.Remove(orderItems.Select(s => s).Where(s => s.uniqueIDAtt.Equals(uniqueID)).FirstOrDefault());
      }

      //---------------------------------------------------------------------
      // Gets and returns the table number.
      //---------------------------------------------------------------------
      public int getTableNumber()
      {
         return tableNumber;
      }

      //---------------------------------------------------------------------
      // Sets the table number to the number provided
      //---------------------------------------------------------------------
      public void setTableNumber(int table)
      {
         tableNumber = table;
      }

      //---------------------------------------------------------------------
      // Checks if the order is empty with no meal items.
      //---------------------------------------------------------------------
      public bool isEmpty() { return orderItems.Count == 0; }

      //---------------------------------------------------------------------
      // Takes in an instance of a menu item to add to the order.
      //---------------------------------------------------------------------
      public void addToOrder(MenuItem newItem)
      {
         newItem.uniqueIDAtt = Guid.NewGuid().ToString("N");
         orderItems.Add(newItem);
      }

      //---------------------------------------------------------------------
      // Gets and returns the orderNumber
      //---------------------------------------------------------------------
      public int getOrderNumber()
      {
         return this.orderNumber;
      }

      //---------------------------------------------------------------------
      // Sets the order number to a new value
      //---------------------------------------------------------------------
      public void setOrderNumber(int num)
      {
         this.orderNumber = num;
      }

      //---------------------------------------------------------------------
      // Return all categories from restaurantCategories.
      //---------------------------------------------------------------------
      public float calculatePrice()
      {
         float sum = 0;
         foreach (MenuItem item in orderItems)
         {
            sum += item.priceAtt;
            foreach (Option option in item.Options)
            {
               sum += option.priceAtt;
            }
         }
         finalPrice = sum;
         return sum;
      }

      //---------------------------------------------------------------------
      // Return all unique ID from the items in the order.
      //---------------------------------------------------------------------
      public List<string> getUniqueIDs()
      {
         return orderItems.Select(s => s.uniqueIDAtt).ToList();
      }
   }
}
