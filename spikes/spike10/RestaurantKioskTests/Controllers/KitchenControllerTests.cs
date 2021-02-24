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
   public class KitchenControllerTests
   {
      [TestMethod()]
      public void FetchOrderTest()
      {
         Order testOrder = new Order();
         MenuItem m = new MenuItem();
         m.nameAtt = "test";
         testOrder.addToOrder(m);
         KitchenController kc = new KitchenController(testOrder);
         List<Order> testList = kc.FetchOrders();
         Assert.IsTrue(testList.Count != 0);
      }

      [TestMethod()]
      public void PrintOrderTest()
      {
         Order testOrder = new Order();
         MenuItem m = new MenuItem(), m2 = new MenuItem();
         Option o = new Option();
         o.nameAtt = "testOp";
         m.nameAtt = "test";
         m2.nameAtt = "test2";
         m2.Options.Insert(0,o);
         testOrder.addToOrder(m);
         testOrder.addToOrder(m2);
         KitchenController kc = new KitchenController(testOrder);
         string str = kc.PrintOrder(-1);
         Assert.AreEqual(str, "");
         str = kc.PrintOrder(0);
         Assert.AreNotEqual(str, "");
      }
   }
}
