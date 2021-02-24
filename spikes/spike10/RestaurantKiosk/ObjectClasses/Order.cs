﻿using System;
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

      /*
      *  Constructor for an order given information for the order.
      */
      public Order(int estDelivery, float finPrice, int ordNum, int ordTime, float tip, int table)
      {
         estimatedDelivery = estDelivery;
         finalPrice = finPrice;
         orderNumber = ordNum;
         orderTime = ordTime;
         recommendedTip = tip;
         tableNumber = table;
         orderItems = new List<MenuItem>();
      }

      /*
      *  Default constructor that initilizes the order to default values.
      */
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

      /*
       * Gets the list of items in the order.
       */
      public List<MenuItem> getOrderItems()
      {
         return orderItems;
      }

      /*
       * Gets and returns the table number.
       */
      public int getTableNumber()
      {
         return tableNumber;
      }

      /*
       * Sets the table number to the number provided
       */
      public void setTableNumber(int table)
      {
         tableNumber = table;
      }

      /*
      *  Checks if the order is empty with no meal items. 
      */
      public bool isEmpty() { return orderItems.Count == 0; }

      /*
      *  Takes in an instance of a menu item to add to the order.
      */
      public void addToOrder(MenuItem newItem)
      {
         orderItems.Add(newItem);
      }
      
      /*
       * Gets and returns the orderNumber
       */
      public int getOrderNumber()
      {
         return this.orderNumber;
      }

      /*
       * Sets the order number to a new value
       */
      public void setOrderNumber(int num)
      {
         this.orderNumber = num;
      }

      /*
      *  Calculates a tip given a percentage. May add a parameter for custom 
      *  tip percentages in the future.
      */
      //public float calculateTip()
    //  {
      //   return finalPrice * TIP_PERCENTAGE;
     // }

      /*
      *  Return all categories from restaurantCategories.
      */
      public float calculatePrice()
      {
         float sum = 0;
         foreach(MenuItem item in orderItems)
         {
            sum += item.priceAtt;
            foreach(Option option in item.Options)
            {
               sum += option.priceAtt;
            }
         }
         finalPrice = sum;
         return sum;
      }

      public List<string> getUniqueIDs()
      {
         return orderItems.Select(s => s.uniqueIDAtt).ToList();
      }
   }
}