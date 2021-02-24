//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Hides and shows the forms, origninally used to integrate
//          midi parent contrainer by managing the child forms.
//          Now converted into a general form manager.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantKiosk
{
   public class FormController
   {
      
      private OrderForm orderForm;
      private AdminForm adminForm;
      private LoginForm loginForm;
      private KitchenForm kitchenForm;
      // ---------------------------------------------------------------------
      // Contrustor for form controller.
      // Why does form controller exist?
      // Answer: Due to the nature of our program the forms can not simply
      //         manage themselves. On exit, admin form and order form
      //         must be destroyed to correctly maintain the list of items
      //         and list of orders respectively.
      // ---------------------------------------------------------------------
      public FormController(LoginForm log)
      {
         OrderController.createOrdersTableSQL();
         OrderController.getOrdersSQL();
         loginForm = log;
      }

      // ---------------------------------------------------------------------
      // Disposes all forms then displays the order form in the mdiParent 
      // main form.
      // ---------------------------------------------------------------------
      public void showOrderForm()
      {
         disposeForms();
         orderForm = new OrderForm();
         orderForm.Show();
         orderForm.addController(this);
      }

      // ---------------------------------------------------------------------
      // Displays the login form by clearing all forms and then showing the 
      // login form.
      // ---------------------------------------------------------------------
      public void showLoginForm()
      {
         disposeForms();
         loginForm.Show();
      }

      // ---------------------------------------------------------------------
      // Displays the admin form by clearing all forms and then showing the 
      // admin form.
      // ---------------------------------------------------------------------
      public void showAdminForm()
      {
         disposeForms();
         adminForm = new AdminForm();
         adminForm.Show();
         adminForm.addController(this);
      }
      // ---------------------------------------------------------------------
      // Displays the Kitchen form and disposes all other forms.
      // ---------------------------------------------------------------------
      public void showKitchenForm()
      {
         disposeForms();
         kitchenForm = new KitchenForm();
         kitchenForm.Show();
         kitchenForm.addController(this);
      }

      // ---------------------------------------------------------------------
      // Disposes all forms. (Deletes them)
      // ---------------------------------------------------------------------
      public void disposeForms()
      {
         if (orderForm != null) { orderForm.Dispose(); }
         if (adminForm != null) { adminForm.Dispose(); }
         if (kitchenForm != null) { kitchenForm.Dispose();  }
      }
   }
}
