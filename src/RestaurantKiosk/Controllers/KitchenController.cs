//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Manages a list of uncompleted orders, which includes:
//          printing order information, loading orders, and
//          removing (completing) orders.
// SPECIAL NOTE: We could not test methods that use the SQLite database 
// for updating orders. This is due to the database being saved outside the 
// test solution and the SQL library not being accessible in the test 
// solution. To fix the issue of file paths, we would need to have 
// duplicate methods for all SQLite methods that define different paths 
// for the database.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk
{
   public class KitchenController
   {
      private List<Order> currentOrders;

      // --------------------------------------------------------------
      // Loads all uncompleted orders into the current orders list
      // --------------------------------------------------------------
      public KitchenController()
      {
         currentOrders = new List<Order>();
         currentOrders = OrderController.getOrdersSQL();
      }

      // --------------------------------------------------------------
      // Test Constructor: Creates a list of orders with
      // one uncompleted order
      // --------------------------------------------------------------
      public KitchenController(Order o)
      {
         currentOrders = new List<Order>();
         currentOrders.Add(o);
      }

      // --------------------------------------------------------------
      // Updates the given order's "completed" and removes
      // the order from current order list.
      // --------------------------------------------------------------
      public void CompleteOrder(int index) 
      {
         if (currentOrders.Count > -1)
         {
            OrderController.updateOrderSQL(currentOrders[index].getOrderNumber());
            currentOrders.RemoveAt(index);
         }
      }

      // --------------------------------------------------------------
      // Returns the list of current uncompleted orders
      // --------------------------------------------------------------
      public List<Order> FetchOrders ()
      {
         return currentOrders;
      }

      // --------------------------------------------------------------
      // Prints all order information necessary for the
      // cooks, including: order number, table number, and
      // all items w/ corresponding options.
      // --------------------------------------------------------------
      public string PrintOrder(int index)
      {
         string text = "";
         if (index > -1)
         {
            text += "Order #" + currentOrders[index].getOrderNumber().ToString() + '\n';
            text += "Table #" + currentOrders[index].getTableNumber().ToString() + "\n\n";
            text += PrintItems(index);
         }
         return text;
      }

      // --------------------------------------------------------------
      // Creates a string representation of all items 
      //and their corresponding options in a given order.
      // --------------------------------------------------------------
      public string PrintItems(int index)
      {
         string text = "";
         if (index > -1)
         {
            List<MenuItem> items = currentOrders[index].getOrderItems();
            foreach (MenuItem item in items)
            {
               text += item.nameAtt + '\n';
               foreach (Option op in item.Options)
               {
                  text += "   +" + op.nameAtt + '\n';
               }
               text += '\n';
            }
         }
         return text;
      }
   }
}
