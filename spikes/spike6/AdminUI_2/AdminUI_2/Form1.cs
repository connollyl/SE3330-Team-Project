using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminUI_2
{
   public partial class AdminForm : Form
   {
      public AdminForm()
      {
         InitializeComponent();
      }

      private void submit_btn_Click(object sender, EventArgs e)
      {
         itemInfo_pnl.Visible = false;
         menuItems_cmbBx.Items.Add(name_txtBx.Text);
         this.resetItemInfoPanel();
         
      }

      private void AdminForm_Load(object sender, EventArgs e)
      {
         itemInfo_pnl.Visible = false;
         update_btn.Visible = false;
      }

      private void item_cmbBx_SelectedIndexChanged(object sender, EventArgs e)
      {
         update_btn.Visible = true;
      }

      private void update_btn_Click(object sender, EventArgs e)
      {
         this.resetItemInfoPanel();
         itemInfo_pnl.Visible = true;
      }

      private void new_btn_Click(object sender, EventArgs e)
      {
         this.resetItemInfoPanel();
         itemInfo_pnl.Visible = true;
      }

      private void newOption_btn_Click(object sender, EventArgs e)
      {
         options_lstBx.Items.Add(newName_txtBx.Text);
      }

      private void resetItemInfoPanel()
      {
         itemInfo_pnl.Visible = false;
         name_txtBx.Clear();
         price_tbtBx.Clear();
         description_rchTxtBx.Clear();
         newName_txtBx.Clear();
         newPrice_txtBx.Clear();
         if (options_lstBx.Items.Count > 1)
         {
            int x = options_lstBx.Items.Count;
            for (int i = x - 1; i > 0; i--)
            {
               options_lstBx.Items.RemoveAt(i);
            }
         }
         pickCat_cmbBx.Text = "<Select Category>";
         newOption_pnl.Visible = false;
         if (update_btn.Visible)
         {
            update_btn.Visible = false;
         }
      }

      private void options_lstBx_DoubleClick(object sender, EventArgs e)
      {
         if (options_lstBx.SelectedItem.ToString() == "<New Option>")
         {
            newOption_pnl.Visible = true;
         }
      }
   }
}
