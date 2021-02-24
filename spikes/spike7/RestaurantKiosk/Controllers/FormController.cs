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

      public FormController(LoginForm logForm, OrderForm oForm, AdminForm aForm)
      {
         loginForm = logForm;
         orderForm = oForm;
         adminForm = aForm;
      }

      public void showOrderForm()
      {
         orderForm.Show();
         loginForm.Hide();
         adminForm.Hide();
      }

      public void showLoginForm()
      {
         loginForm.Show();
         orderForm.Hide();
         adminForm.Hide();
      }

      public void showAdminForm()
      {
         adminForm.Show();
         orderForm.Hide();
         loginForm.Hide();
      }
   }
}
