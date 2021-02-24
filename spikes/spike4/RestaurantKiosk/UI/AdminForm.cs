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
   public partial class AdminForm : Form
   {
      private FormController formController;

      public AdminForm()
      {
         InitializeComponent();
      }

      public void addController(FormController controller)
      {
         formController = controller;
      }

      private void btn_addItem_Click(object sender, EventArgs e)
      {
         this.cmbBx_items.Items.Add(txtBx_itemName.Text);
         this.txtBx_itemName.Text = "";
         this.cmbBx_items.SelectedIndex = 1;
         this.lBx_customOptions.Focus();
         this.Visible = true;
      }

      private void btn_addOption_Click(object sender, EventArgs e)
      {

      }

      private void btn_exit_Click(object sender, EventArgs e)
      {
         formController.showLoginForm();
      }

      private void AdminForm_Load(object sender, EventArgs e)
      {
         this.btn_addItem.Visible = false;
      }

      private void cmbBx_items_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cmbBx_items.SelectedItem.Equals("<New Item>"))
         {
            this.txtBx_itemName.Enabled = true;
            this.txtBx_itemName.Text = "Item Name";
            this.txtBx_itemName.Focus();
            this.btn_addItem.Visible = true;
         }
      }
   }
}
