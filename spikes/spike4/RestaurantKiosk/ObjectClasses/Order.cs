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
      //vector<CustomItem> mealItems;
      private int orderNumber;
      private int orderTime;
      private float recommendedTip;
      private int tableNumber;
      private const float TIP_PERCENTAGE = .18f;

      //test map
      private Dictionary<string, float> itemPricing;
      //private typedef pair<string, float> itemPrice;

      public Order(int et, float fp, int oNum, int oTime, float rTip, int tNum)
      {
         estimatedDelivery = et;
         finalPrice = fp;
         orderNumber = oNum;
         orderTime = oTime;
         recommendedTip = rTip;
         tableNumber = tNum;
      }

      public bool isEmpty() { return itemPricing.Count() == 0; }

      public void removeItem(string itemName)
      {
         itemPricing.Remove(itemName);
      }

      public float calculateTip()
      {
         return finalPrice * TIP_PERCENTAGE;
      }
      public float calculatePrice()
      {
         float sum = 0;
         foreach (string dictKey in itemPricing.Keys)
         {
            sum += itemPricing[dictKey];
         }
         finalPrice = sum;
         return sum;
      }
   }
}
