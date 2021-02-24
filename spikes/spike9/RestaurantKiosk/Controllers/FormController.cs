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
     // private MainFrame mainForm;

      public FormController(LoginForm log)
      {
         loginForm = log;
         //mainForm = mainFrameForm;
         //loginForm = new LoginForm();
         
         //loginForm.Width = mainForm.Width;
       // loginForm.Height = mainForm.Height;
         
        // loginForm.MdiParent = mainForm;
        // loginForm.Show();
         //loginForm.addController(this);
         
      }

      /*
       * Disposes all forms then displays the order form in the mdiParent 
       * main form.
       */
      public void showOrderForm()
      {
         disposeForms();
         orderForm = new OrderForm();

         //orderForm.Width = mainForm.Width;
         //orderForm.Height = mainForm.Height;
         // orderForm.MdiParent = mainForm;
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
         //loginForm = new LoginForm();
        // loginForm.Width = mainForm.Width;
        // loginForm.Height = mainForm.Height;
        // loginForm.MdiParent = mainForm;
         loginForm.Show();
         //loginForm.addController(this);
      }

      /*
       * Displays the admin form by clearing all forms and then showing the admin 
       * form in the mainForm mdiParent.
       */
      public void showAdminForm()
      {
         disposeForms();
         adminForm = new AdminForm();
        // adminForm.Width = mainForm.Width;
        // adminForm.Height = mainForm.Height;
         //  adminForm.MdiParent = mainForm;
         adminForm.Show();
         adminForm.addController(this);
         //loginForm.Dispose();
      }

      /*
       * Disposes all forms. (Deletes them)
       */
      public void disposeForms()
      {
         if (orderForm != null) { orderForm.Dispose(); }
         //if (loginForm != null) { loginForm.Dispose(); }
         if (adminForm != null) { adminForm.Dispose(); }
      }
   }
}
