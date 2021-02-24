using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantKiosk.Controllers;

namespace RestaurantKiosk
{
   public partial class LoginForm : Form
   {
      private FormController formController;

      public LoginForm()
      {
         InitializeComponent();
      }

      public void addController(FormController controller)
      {
         formController = controller;
      }

      private void btn_login_Click(object sender, EventArgs e)
      {
         if (txtbx_userName.Text.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))
         {
            formController.showAdminForm();
         }
         else
         {
            formController.showOrderForm();
         }
      }

      private void LoginForm_Load(object sender, EventArgs e)
      {
         panel_login.Left = (this.Width - panel_login.Width) / 2;
         panel_login.Top = (this.Height - panel_login.Height) / 2;


      }

      private void LoginForm_SizeChanged(object sender, EventArgs e)
      {
         panel_login.Left = (this.Width - panel_login.Width) / 2;
         panel_login.Top = (this.Height - panel_login.Height) / 2;
      }

      private void btn_exit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         Application.Exit();
      }
   }
}
