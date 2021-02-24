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
      private const string ADMINUSER = "admin";
      private const string ADMINPASS = "admin";
      private const string GUESTUSER = "guest";
      private const string GUESTPASS = "guest";
      private const string KITCHENUSER = "chef";
      private const string KITCHENPASS = "chef";
      private Color transparentColor = Color.FromArgb(100, Color.White);

      
      public LoginForm()
      {
         this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
         InitializeComponent();
        // foreach (Control con in this.Controls)
         //   con.Visible = false;
         // this.
         
         formController = new FormController(this);

      }
      

      private void btn_login_Click(object sender, EventArgs e)
      {
         login();
         
      }

      /*
       * Checks if the username and password are correct.
       */
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

      private void LoginForm_Load(object sender, EventArgs e)
      {
         //this.BackColor = Color.White;
         //lbl_title.Location = new Point((panel_login.Width - lbl_title.Width) / 2, panel_login.Location.Y);
         //pnl_inner.Location = new Point(panel_login.Width / 2 - pnl_inner.Width / 2, lbl_title.Location.Y + lbl_title.Height);
         //pnl_inner.Height = panel_login.Height - pnl_inner.Location.Y;
         //panel_login.Left = (this.Width - panel_login.Width) / 2;
         //panel_login.Top = (this.Height - panel_login.Height) / 2;
         
      }

      

      private void btn_exit_Click(object sender, EventArgs e)
      {
        
         Application.Exit();
      }

      private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         Application.Exit();
      }

      private void txtbx_password_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            login();
         }
      }

      private void txtbx_userName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            login();
         }
      }
      

      private void LoginForm_Shown(object sender, EventArgs e)
      {
         //foreach (Control con in this.Controls)
           // con.Visible = true;
      }

      private void panel_login_Paint(object sender, PaintEventArgs e)
      {

      }
   }
}
