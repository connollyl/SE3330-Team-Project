using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantKiosk.Controllers
{
   public class FormController
   {
      
      private OrderForm orderForm;
      private AdminForm adminForm;
      private LoginForm loginForm;
      private KitchenForm kitchenForm;
      public FormController(LoginForm log)
      {
         OrderController.CreateOrdersTable();
         OrderController.GetOrders();
         loginForm = log;      }

      /*
       * Disposes all forms then displays the order form in the mdiParent 
       * main form.
       */
      public void showOrderForm()
      {
         disposeForms();
         orderForm = new OrderForm();
         orderForm.Show();
         orderForm.addController(this);
      }

      /*
       * Displays the login form by clearing all forms and then showing the 
       * login form.
       */
      public void showLoginForm()
      {
         disposeForms();
         loginForm.Show();
      }

      /*
       * Displays the admin form by clearing all forms and then showing the admin 
       * form in the mainForm mdiParent.
       */
      public void showAdminForm()
      {
         disposeForms();
         adminForm = new AdminForm();
         adminForm.Show();
         adminForm.addController(this);
      }

      public void showKitchenForm()
      {
         disposeForms();
         kitchenForm = new KitchenForm();
         kitchenForm.Show();
         kitchenForm.addController(this);
      }

      /*
       * Disposes all forms. (Deletes them)
       */
      public void disposeForms()
      {
         if (orderForm != null) { orderForm.Dispose(); }
         if (adminForm != null) { adminForm.Dispose(); }
         if (kitchenForm != null) { kitchenForm.Dispose();  }
      }
   }
}
