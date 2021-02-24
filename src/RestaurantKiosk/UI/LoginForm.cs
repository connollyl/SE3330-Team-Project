//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Login form is the gateway to the other forms.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantKiosk
{
   public partial class LoginForm : Form
   {
      private FormController formController;
      private const string ADMINUSER = "admin";
      private const string ADMINPASS = "admin";
      private const string GUESTUSER = "guest";
      private const string GUESTPASS = "guest";
      private const string KITCHENUSER = "chef";
      private const string KITCHENPASS = "chef";
      private Color transparentColor = Color.FromArgb(100, Color.White);

      // ---------------------------------------------------------------------
      // Constructor for login form
      // ---------------------------------------------------------------------
      public LoginForm()
      {
         this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
         InitializeComponent();
         formController = new FormController(this);
      }

      // ---------------------------------------------------------------------
      // Click event for login
      // ---------------------------------------------------------------------
      private void btn_login_Click(object sender, EventArgs e)
      {
         login();
         
      }

      // ---------------------------------------------------------------------
      // Checks if the username and password are correct.
      // ---------------------------------------------------------------------
      private void login()
      {

         if (string.IsNullOrEmpty(txtbx_password.Text))
            pwLabel.ForeColor = Color.Red;
         if (string.IsNullOrEmpty(txtbx_userName.Text))
            unLabel.ForeColor = Color.Red;
        
         if (txtbx_userName.Text.Equals(ADMINUSER, StringComparison.InvariantCultureIgnoreCase))
         {
            unLabel.ForeColor = Color.Black;
            if (txtbx_password.Text.Equals(ADMINPASS))
            {
               formController.showAdminForm();
               pwLabel.ForeColor = Color.Black;
            }
            else
               pwLabel.ForeColor = Color.Red;
         }
         else if (txtbx_userName.Text.Equals(GUESTUSER, StringComparison.InvariantCultureIgnoreCase))
         {
            unLabel.ForeColor = Color.Black;
            if (txtbx_password.Text.Equals(GUESTPASS))
            {
               formController.showOrderForm();
               pwLabel.ForeColor = Color.Black;
            }
            else
               pwLabel.ForeColor = Color.Red;
         }
         else if (txtbx_userName.Text.Equals(KITCHENUSER, StringComparison.InvariantCultureIgnoreCase))
         {
            unLabel.ForeColor = Color.Black;
            if (txtbx_password.Text.Equals(KITCHENPASS))
            {
               formController.showKitchenForm();
               pwLabel.ForeColor = Color.Black;
            }
            else
               pwLabel.ForeColor = Color.Red;
         }
         else
         {
            unLabel.ForeColor = Color.Red;
         }
      }

      // ---------------------------------------------------------------------
      // Click event for exit, closes the application
      // ---------------------------------------------------------------------
      private void btn_exit_Click(object sender, EventArgs e)
      {
        
         Application.Exit();
      }

      // ---------------------------------------------------------------------
      // Click event for exit, closes the application
      // ---------------------------------------------------------------------
      private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         Application.Exit();
      }

      // ---------------------------------------------------------------------
      // Keyboard shortcut for login
      // ---------------------------------------------------------------------
      private void txtbx_password_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            login();
         }
      }

      // ---------------------------------------------------------------------
      // Keyboard shortcut for login
      // ---------------------------------------------------------------------
      private void txtbx_userName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            login();
         }
      }
   }
}
