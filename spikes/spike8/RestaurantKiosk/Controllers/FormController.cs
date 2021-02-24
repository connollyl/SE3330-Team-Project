using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Controllers
{
   public class FormController
   {
      private LoginForm loginForm;
      private OrderForm orderForm;
      private AdminForm adminForm;
      private MainFrame mainForm;

      public FormController(MainFrame mainFrameForm)
      {
         mainForm = mainFrameForm;
         loginForm = new LoginForm();
         loginForm.MdiParent = mainForm;
         loginForm.addController(this);
         loginForm.Show();
      }

      /*
       * Disposes all forms then displays the order form in the mdiParent 
       * main form.
       */
      public void showOrderForm()
      {
         disposeForms();
         orderForm = new OrderForm();
         orderForm.MdiParent = mainForm;
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
         loginForm = new LoginForm();
         loginForm.MdiParent = mainForm;
         loginForm.Show();
         loginForm.addController(this);
      }

      /*
       * Displays the admin form by clearing all forms and then showing the admin 
       * form in the mainForm mdiParent.
       */
      public void showAdminForm()
      {
         disposeForms();
         adminForm = new AdminForm();
         adminForm.MdiParent = mainForm;
         adminForm.Show();
         adminForm.addController(this);
      }

      /*
       * Disposes all forms. (Deletes them)
       */
      public void disposeForms()
      {
         if (orderForm != null) { orderForm.Dispose(); }
         if (loginForm != null) { loginForm.Dispose(); }
         if (adminForm != null) { adminForm.Dispose(); }
      }
   }
}
