using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk
{
   public class MenuItem
   {
      private bool availible;
      private int calories;
      private string description;
      private string name;
      private List<Option> options;
      private float price;
      private float timeCost;

      public MenuItem()
      {
         availible = false;
         calories = 0;
         description = "";
         name = "";
         price = 0.0f;
         timeCost = 0.0f;
      }

      public MenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost)
      {
         calories = cal;
         description = desc;
         name = itemName;
         price = itemPrice;
         timeCost = itemTimeCost;
         availible = true;
      }

      //MenuItem(const MenuItem & cpy) : calories(cpy.calories), description(cpy.description), name(cpy.name), price(cpy.price), timeCost(cpy.timeCost), availible(cpy.availible) { }

      public void addOption(Option newOption)
      {
         options.Add(newOption);
      }

      public void removeOption(int index)
      {
         options.RemoveAt(index);
      }

      public void updateName(string newName)
      {
         name = newName;
      }

      public void updateDescription(string newDesc)
      {
         description = newDesc;
      }

      public void updateCalories(int newCal)
      {
         calories = newCal;
      }

      public void updatePrice(float newPrice)
      {
         price = newPrice;
      }

      public void updatetimeCost(float newTime)
      {
         timeCost = newTime;
      }

      public Option getOption(string name)
      {
         foreach (var option in options)
         {
            if (option.getName().Equals(name, StringComparison.InvariantCultureIgnoreCase))
            {
               return option;
            }
         }
         return null;
      }

      public int getCalories()
      {
         return calories;
      }

      public string getName()
      {
         return name;
      }

      public float getPrice()
      {
         return price;
      }

      public float getTimeCost()
      {
         return timeCost;
      }

      public string getDescription()
      {
         return description;
      }

      public int getOptionsListSize()
      {
         return options.Count;
      }

   }
}
