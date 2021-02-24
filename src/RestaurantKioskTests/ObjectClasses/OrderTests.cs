using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantKiosk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Tests
{
   //Order is to be implemented in a future release
   
   [TestClass()]
   public class OrderTests
   {
      [TestMethod()]
      public void OrderTest()
      {
         Order newOrder = new Order();
         Assert.IsTrue(newOrder != null);
      }

      [TestMethod()]
      public void isEmptyTest()
      {
         Order newOrder = new Order();
         Assert.IsTrue(newOrder.isEmpty());
      }

      [TestMethod()]
      public void removeItemTest()
      {
         Order newOrder = new Order();
         MenuItem newItem = new MenuItem(0, "", "MenuItem", 6.55f, 0f, "Meal");
         newOrder.addToOrder(newItem);
         Assert.IsTrue(newOrder.getOrderItems().Count > 0);
         List<string> uniqueIDs = newOrder.getUniqueIDs();

         newOrder.removeOrderItem(uniqueIDs.First());
         Assert.IsTrue(newOrder.isEmpty());
      }

      [TestMethod()]
      public void getOrderItemsTest()
      {
         Order newOrder = new Order();
         MenuItem newItem = new MenuItem(0, "", "MenuItem", 6.55f, 0f, "Meal");
         newOrder.addToOrder(newItem);
         Assert.IsTrue(newOrder.getOrderItems().Count == 1);
      }

      [TestMethod()]
      public void tableNumberTest()
      {
         Order newOrder = new Order();
         MenuItem newItem = new MenuItem(0, "", "MenuItem", 6.55f, 0f, "Meal");
         newOrder.addToOrder(newItem);
         newOrder.setTableNumber(1);
         Assert.IsTrue(newOrder.getTableNumber() == 1);
      }

      [TestMethod()]
      public void orderNumberTest()
      {
         Order newOrder = new Order();
         MenuItem newItem = new MenuItem(0, "", "MenuItem", 6.55f, 0f, "Meal");
         newOrder.addToOrder(newItem);
         newOrder.setOrderNumber(1);
         Assert.IsTrue(newOrder.getOrderNumber() == 1);
      }
   }
}