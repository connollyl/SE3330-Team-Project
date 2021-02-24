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
   public class AdminControllerTests
   {
      [TestMethod()]
      public void createNewCategoryTest()
      {
         AdminController ac = new AdminController();
         List<string> categories = ac.createNewCategory("Pizza");
         Assert.AreEqual(categories.Exists(x => x.ToString().Equals("Pizza")), true);
      }


      [TestMethod()]
      public void sortRestaurantCategoryTest()
      {
         AdminController ac = new AdminController();
         List<string> categories = ac.createNewCategory("ZZZ");//Calls sort...
         Assert.AreEqual(categories.IndexOf("ZZZ"), categories.Count - 1);
      }


      [TestMethod()]
      public void addOptionTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         ac.addOptionToItem(0, "Bacon", 0.0f);
         MenuItem menuItem = ac.loadMenuItem(0);
         Assert.AreEqual(menuItem.getOption("Bacon").nameAtt, "Bacon");
         Assert.AreEqual(menuItem.getOption("Spag"),null);
      }
      
      [TestMethod()]
      public void verifyNewMenuItemTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         Assert.IsFalse(ac.verifyNewMenuItem("AAAA") == -1);
         Assert.IsTrue(ac.verifyNewMenuItem("New") == -1);
      }
      
      [TestMethod()]
      public void loadMenuItemTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         Assert.IsTrue(ac.loadMenuItem(0).nameAtt.Equals("1111"));
         Assert.IsTrue(ac.loadMenuItem(-1) == null);
      }

      [TestMethod()]
      public void addMenuItemTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         Assert.IsTrue(ac.loadMenuItem(0).nameAtt.Equals("1111"));
      }
      

      [TestMethod()]
      public void getCategoryMenuSizeTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         Assert.IsTrue(ac.getCategoryMenuSize("Meals") > 0);
      }

      [TestMethod()]
      public void loadCategoriesTest()
      {
         AdminController ac = new AdminController();
         ac.addNewCategory("Salads");
         Assert.IsTrue(ac.loadCategories().Exists(x => x == "Salads"));
      }

      [TestMethod()]
      public void menuSizeTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         Assert.IsTrue(ac.menuSize() > 0);
      }

      [TestMethod()]
      public void categorySizeTest()
      {
         AdminController ac = new AdminController();
         ac.addNewCategory("Salads");
         Assert.IsTrue(ac.categorySize() > 0);
      }

      [TestMethod()]
      public void loadRestaurantMenuTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         Assert.IsTrue(ac.loadRestaurantMenu().Count > 0);
      }

      [TestMethod()]
      public void loadItemOptionsTest()
      {
         AdminController ac = new AdminController();
         Assert.IsTrue(ac.loadItemOptions(0).Count() >= 0);
      }

      [TestMethod()]
      public void onAdminCloseTest()
      {
         AdminController ac = new AdminController();
         ac.onAdminClose();//Confirm by checking XML file...
         Assert.IsTrue(ac.loadRestaurantMenu().Count > 0);
      }

      [TestMethod()]
      public void updateMenuItemTest()
      {
         AdminController ac = new AdminController();
         ac.updateMenuItem(0, "NEW", "NEW NAME", 5.54f, "MEALS", 1000);
         Assert.IsTrue(ac.loadMenuItem(0).descriptionAtt.Equals("NEW"));
         ac.updateMenuItem(-1, "Old", "1111", 5.54f, "MEALS", 1000);
         ac.sortRestaurantMenu();
         Assert.IsFalse(ac.loadMenuItem(0).descriptionAtt.Equals("1111"));
      }

      [TestMethod()]
      public void checkPriceTest()
      {
         AdminController ac = new AdminController();
         Assert.IsFalse(ac.checkPrice("XXX.]"));
         Assert.IsTrue(ac.checkPrice("6.99"));
         Assert.IsFalse(ac.checkPrice("2A.9A"));
         Assert.IsTrue(ac.checkPrice(""));
      }

      [TestMethod()]
      public void removeMenuItem()
      {
         AdminController ac = new AdminController();
         int size = ac.menuSize();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         Assert.IsTrue(ac.menuSize().Equals(size + 1));
         ac.removeMenuItem(0);
         Assert.IsTrue(ac.menuSize().Equals(size));
      }

      
      [TestMethod()]
      public void removeItemOption()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         ac.addOptionToItem(0, "BBBB", 12.22f);
         ac.removeItemOption(0, 0);
         Assert.IsTrue(ac.loadRestaurantMenu()[0].getOption("BBBB") == null);
      }

      [TestMethod()]
      public void verifyItemOption()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "AAAA", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         ac.addOptionToItem(0, "BBBB", 12.22f);
         Assert.IsTrue(ac.verifyItemOption(0, "BBBB") != -1);
         Assert.IsTrue(ac.verifyItemOption(0, "1234") == -1);
      }

      [TestMethod()]
      public void verifyCalories()
      {
         AdminController ac = new AdminController();
         Assert.IsFalse(ac.verifyCalories("XXX"));
         Assert.IsTrue(ac.verifyCalories("699"));
         Assert.IsTrue(ac.verifyCalories(""));
      }

      [TestMethod()]
      public void undoUpdateCommandTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals");
         ac.undo();
         Assert.IsTrue(ac.loadRestaurantMenu().IndexOf(new MenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals")) == -1);
      }

      [TestMethod()]
      public void redoUpdateCommandTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals");
         ac.done_commands.Peek().see_details();
         ac.undo();
         ac.redo();
         ac.sortRestaurantMenu();
         Assert.IsTrue(ac.loadRestaurantMenu()[0].nameAtt.Equals("1111"));
      }

      [TestMethod()]
      public void undoRemoveCommandTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         ac.removeMenuItem(0);
         ac.undo();
         ac.sortRestaurantMenu();
         Assert.IsTrue(ac.loadRestaurantMenu()[0].nameAtt.Equals("1111"));
      }

      [TestMethod()]
      public void redoRemoveCommandTest()
      {
         AdminController ac = new AdminController();
         ac.addMenuItem(100, "DESC", "1111", 4.0f, 3.0f, "Meals");
         ac.sortRestaurantMenu();
         ac.removeMenuItem(0);
         ac.done_commands.Peek().see_details();
         ac.undo();
         ac.redo();
         ac.sortRestaurantMenu();
         Assert.IsFalse(ac.loadRestaurantMenu()[0].nameAtt.Equals("1111"));
      }
   }
}