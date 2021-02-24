using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttonResearch
{
   public class Option
   {
      private int addedCalories;
      private string name;
      private string picture;
      private float price;

      public Option(string optionName, float optionPrice, int cal)
      {
         name = optionName;
         price = optionPrice;
         addedCalories = cal;
      }

      public string getName() { return name; }
   }
}
