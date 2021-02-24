using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantKiosk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantKiosk;

namespace RestaurantKiosk.Tests
{
   [TestClass()]
   public class MenuItemTests
   {
      [TestMethod()]
      public void addOptionTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Option o = new Option("Lettuce", .30f, 0);
         burger.addOption(o);
         Assert.AreEqual<Option>(burger.getOption("Lettuce"), o);
      }

      [TestMethod()]
      public void removeOptionTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Option o = new Option("Lettuce", .30f, 0);
         burger.addOption(o);
         burger.removeOption(0);
         Assert.IsNull(burger.getOption("Lettuce"));
      }

      [TestMethod()]
      public void updateNameTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         string newName = "Bacon Burger";
         burger.nameAtt = newName;
         Assert.AreEqual<string>(burger.nameAtt, newName);
      }

      [TestMethod()]
      public void updateDescriptionTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         string newDesc = "Old angus beef.";
         burger.descriptionAtt = newDesc;
         Assert.AreEqual<string>(burger.descriptionAtt, newDesc);
      }

      [TestMethod()]
      public void updateCaloriesTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         int newCal = 55;
         burger.caloriesAtt = newCal;
         Assert.AreEqual<int>(burger.caloriesAtt, newCal);
      }

      [TestMethod()]
      public void updatePriceTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         float newPrice = 11.50f;
         burger.priceAtt = newPrice;
         Assert.AreEqual<float>(burger.priceAtt, newPrice);
      }

      [TestMethod()]
      public void updatetimeCostTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         float newCost = 6f;
         burger.updatetimeCost(newCost);
         Assert.AreEqual<float>(burger.timeCostAtt, newCost);
      }

      [TestMethod()]
      public void getOptionTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Option o = new Option("Lettuce", .30f, 0);
         burger.addOption(o);
         burger.removeOption(0);
         Assert.IsNull(burger.getOption("Lettuce"));
      }

      [TestMethod()]
      public void getCaloriesTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Assert.AreEqual<int>(burger.caloriesAtt, 100);
      }

      [TestMethod()]
      public void getNameTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Assert.AreEqual<string>(burger.nameAtt, "Badger Burger");
      }

      [TestMethod()]
      public void getPriceTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Assert.AreEqual<float>(burger.priceAtt, 12.99f);
      }

      [TestMethod()]
      public void getTimeCostTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Assert.AreEqual<float>(burger.timeCostAtt, 7f);
      }

      [TestMethod()]
      public void getDescriptionTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Assert.AreEqual<string>(burger.descriptionAtt, "Fresh angus beef.");
      }

      [TestMethod()]
      public void getOptionsListSizeTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Option o = new Option("Lettuce", .30f, 0);
         burger.addOption(o);
         Assert.AreEqual<int>(burger.getOptionsListSize(), 1);
      }

      [TestMethod()]
      public void updateCategoryTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         burger.updateCategory("New");
         Assert.AreEqual<string>(burger.categoryAtt, "New");
      }

      [TestMethod()]
      public void setOptionTest()
      {
         MenuItem burger = new MenuItem(100, "Fresh angus beef.", "Badger Burger", 12.99f, 7f, "Meals");
         Option lettuce = new Option("Lettuce", .25f, 5);
         burger.addOption(lettuce);
         burger.Options = new List<Option>();

         Assert.IsTrue(burger.Options.Count == 0);
      }
   }
}