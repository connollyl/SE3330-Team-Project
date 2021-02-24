using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantKiosk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Tests
{
   [TestClass()]
   public class OrderControllerTests
   {
      //Note for most tests we are assuming that there is preloaded data in the XML.
      [TestMethod()]
      public void loadXMLDataTest()
      {
         OrderController oc = new OrderController("test");
         oc.loadXMLData();
         Assert.IsTrue(oc.getMenuItemNames().Count() > 0);
      }

      [TestMethod()]
      public void getCategoryOfMenuItemTest()
      {
         OrderController oc = new OrderController("test");
         string category = oc.getCategoryOfMenuItem(oc.getMenuItemNames().ElementAt(0));
         Assert.IsTrue(category != null);
         Assert.IsFalse(oc.getCategoryOfMenuItem("POOP") != null);
      }

      [TestMethod()]
      public void getPriceTest()
      {
         OrderController oc = new OrderController("test");
         float price = oc.getPrice(oc.getMenuItemNames().ElementAt(0));
         Assert.IsTrue(price > 0.0f);
         Assert.IsFalse(oc.getPrice("Garbage") > 0.0f);
      }

      [TestMethod()]
      public void loadCategoryButtonsTest()
      {
         OrderController oc = new OrderController("test");
         Assert.IsTrue(oc.loadCategoryButtons().Count() > 0);
      }

      [TestMethod()]
      public void getDescriptionTest()
      {
         OrderController oc = new OrderController("test");
         string description = oc.getDescription("Garbage");
         Assert.IsTrue(description.Equals("Failed, Sorry"));
         string description2 = oc.getDescription(oc.getMenuItemNames().ElementAt(0));
         Assert.IsFalse(description2.Equals("Failed, Sorry"));
      }
      [TestMethod()]
      public void getSubtotalTest()
      {
         OrderController oc = new OrderController("test");
         Assert.IsTrue(oc.getSubTotal() == 0.0f);
         List<string> list = new List<string>();
         list.Add("Tomatos");
         oc.updateOrder(oc.getMenuItemNames().ElementAt(0), list);
         Assert.IsTrue(oc.getSubTotal() > 0.0f);
      }
      [TestMethod()]
      public void getMenuItemOptionTest()
      {
         OrderController oc = new OrderController("test");
         List<string> options = new List<string>();
         Assert.IsTrue(options.Count == 0);
         string name = oc.getMenuItemNames().ElementAt(0);
         options = oc.getMenuItemOptions(name);
         Assert.IsTrue(options.Count > 0);
      }
      [TestMethod()]
      public void getOptionsAndPriceByIDTest()
      {
         //requires unique ID
         OrderController oc = new OrderController("test");
         List<string> options = new List<string>();
         List<string> uniqueIDs = new List<string>();
         List<string> orderItemOptions = new List<string>();

         oc.createNewOrder();
         options.Add("BBQ sauce");
         oc.updateOrder("Chicken Strips", options);
         
         uniqueIDs = oc.getOrderMenuItemUniqueIDs();
         orderItemOptions = oc.getOptionsAndPricesByID(uniqueIDs.First());

         Assert.IsTrue(orderItemOptions.Count > 0);
      }
      [TestMethod()]
      public void getOrderMenuItemByID()
      {
         //requires unique ID
         OrderController oc = new OrderController("test");
         List<string> options = new List<string>();
         List<string> uniqueIDs = new List<string>();
         MenuItem orderItem = new MenuItem();

         oc.createNewOrder();
         options.Add("BBQ sauce");
         oc.updateOrder("Chicken Strips", options);

         uniqueIDs = oc.getOrderMenuItemUniqueIDs();
         orderItem = oc.getOrderMenuItemByID(uniqueIDs.First());

         Assert.IsTrue(orderItem.nameAtt.Equals("Chicken Strips"));

      }
      [TestMethod()]
      public void getOrderMenuNameByID()
      {
         //requires unique ID
         OrderController oc = new OrderController("test");
         List<string> options = new List<string>();
         List<string> uniqueIDs = new List<string>();
         string orderItem = string.Empty;

         oc.createNewOrder();
         options.Add("BBQ sauce");
         oc.updateOrder("Chicken Strips", options);

         uniqueIDs = oc.getOrderMenuItemUniqueIDs();
         orderItem = oc.getOrderMenuItemNameByID(uniqueIDs.First());

         Assert.IsTrue(orderItem.Equals("Chicken Strips"));
      }
      [TestMethod()]
      public void getOrderMenuPriceByID()
      {
         //requires unique ID
         OrderController oc = new OrderController("test");
         List<string> options = new List<string>();
         List<string> uniqueIDs = new List<string>();
         float orderItemPrice = 0.0f;

         oc.createNewOrder();
         options.Add("BBQ sauce");
         oc.updateOrder("Chicken Strips", options);

         uniqueIDs = oc.getOrderMenuItemUniqueIDs();
         orderItemPrice = oc.getOrderMenuItemPriceByID(uniqueIDs.First());

         Assert.IsTrue(orderItemPrice == 7.99f);
      }

      [TestMethod()]
      public void removeItemTest()
      {
         //requires unique ID
         OrderController oc = new OrderController("test");
         List<string> options = new List<string>();
         List<string> uniqueIDs = new List<string>();
         string orderItem = string.Empty;

         oc.createNewOrder();
         options.Add("BBQ sauce");
         oc.updateOrder("Chicken Strips", options);

         uniqueIDs = oc.getOrderMenuItemUniqueIDs();
         Assert.IsTrue(uniqueIDs.Count > 0);
         oc.removeItem(uniqueIDs.First());
         uniqueIDs = oc.getOrderMenuItemUniqueIDs();
         Assert.IsTrue(uniqueIDs.Count == 0);
      }

      [TestMethod()]
      public void getCurrentOrderTest()
      {
         OrderController oc = new OrderController("test");
         oc.createNewOrder();
         Assert.IsTrue(oc.getCurrentOrder() != null);
      }

      /*[TestMethod()]
      public void getCurrentOrderTest()
      {
         OrderController oc = new OrderController("test");
         oc.createNewOrder();
         Assert.IsTrue(oc.getCurrentOrder() != null);
      }*/
   }
}