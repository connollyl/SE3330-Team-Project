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
      protected AdminController controller = new AdminController();
      protected FormController formController;

      public AdminForm()
      {
         InitializeComponent();
      }

      /*
       * Saves current menu data to XML
       */
      private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         controller.onAdminClose();
         Application.Exit();
      }

      /*
       * Assigns a form controller object
       */
      public void addController(FormController controller)
      {
         formController = controller;
      }

      /*
       * Adds the item to the menu if the item doesn't exist.
       */
      private void addItem()
      {
         if (!controller.loadCategories().Contains(pickCat_cmbBx.Text))
            controller.addNewCategory(pickCat_cmbBx.Text);

         controller.addMenuItem(0, description_rchTxtBx.Text,
            name_txtBx.Text, float.Parse(price_txtBx.Text),
            3.0f, pickCat_cmbBx.Text);
      }

      /*
       * Displays default administrator form
       * "DONE"
       */
      private void AdminForm_Load(object sender, EventArgs e)
      {
         setLabelColors();
         controller.sortRestaurantMenu();
         loadMenuItems();
         loadCategories();
         this.resetItemInfoPanel();
         remove_btn.Hide();
         options_lstBx.BringToFront();
         itemInfo_pnl.Controls.Add(pnl_remOp);
         pnl_remOp.Location = new Point(newOption_pnl.Location.X,
            newOption_pnl.Location.Y);
      }

      /*
       * Sets label colors
       */
      private void setLabelColors()
      {
         name_lbl.ForeColor = Color.Black;
         category_lbl.ForeColor = Color.Black;
         basePrice_lbl.ForeColor = Color.Black;
         optionPrice_lbl.ForeColor = Color.Black;
      }

      /*
       * Removes all items besides "<New Option>" item
       * in options listbox.
       */ 
      public void clearOptionsBox()
      {
         if (options_lstBx.Items.Count > 1)
         {
            int x = options_lstBx.Items.Count;
            for (int i = x - 1; i > 0; i--)
            {
               options_lstBx.Items.RemoveAt(i);
            }
         }
      }

      /*
       * Populates the menu items list box from the 
       * restaraunt menu list.
       * "DONE"
       */
      private void loadMenuItems()
      {
         menuItems_lstBx.Items.Clear();
         for (int i = 0; i < controller.menuSize(); i++)
            menuItems_lstBx.Items.Add(controller.loadMenuItem(i).nameAtt);
      }

      /*
       * Populates the pick category list box with
       * current menu categories.
       * "DONE"
       */
      private void loadCategories()
      {
         pickCat_cmbBx.Items.Clear();
         for (int i = 0; i < controller.loadCategories().Count(); i++)
            pickCat_cmbBx.Items.Add(controller.loadCategories()[i]);
      }

      /*
       * Returns user to the login window
       * DONE
       */
      private void logout_btn_Click(object sender, EventArgs e)
      {
         formController.showLoginForm();
         controller.onAdminClose();
      }

      /*
       * Enables the item information panel to allow
       * user to enter new item information
       * "DONE"
       */
      private void new_btn_Click(object sender, EventArgs e)
      {
         this.resetItemInfoPanel();
         submit_btn.Show();
         itemInfo_pnl.Enabled = true;
      }

      /*
       * Attempts to add a new option to a menu 
       * item through AdminController
       * "DONE"
       */
      private void newOption_btn_Click(object sender, EventArgs e)
      {
         if (options_lstBx.SelectedIndex == 0)
         {
            if (controller.checkPrice(newPrice_txtBx.Text))
            {
               if (controller.verifyItemOption(menuItems_lstBx.SelectedIndex, newName_txtBx.Text) == -1)
               {
                  controller.addOptionToItem(controller.verifyNewMenuItem(name_txtBx.Text),
                      newName_txtBx.Text, float.Parse(newPrice_txtBx.Text));
                  options_lstBx.Items.Add(newName_txtBx.Text);
                  this.AdminForm_Load(this, e);
               }
            }
            else
            {
               optionPrice_lbl.ForeColor = Color.Red;
               newPrice_txtBx.Clear();
            }
         }
      }

      /*
       * Removes a menu item from the menu and
       * reloads the form.  "DONE"
       */
      private void remove_btn_Click(object sender, EventArgs e)
      {
         controller.removeMenuItem(menuItems_lstBx.SelectedIndex);
         this.AdminForm_Load(this, e);
      }

      /* 
       * Clears information in text fields in itemInfo_pnl 
       * and resets all displays to default values
       * "DONE"
       */
      private void resetItemInfoPanel()
      {
         //itemInfo_pnl.Enabled = false;
         newOption_pnl.Hide();
         pnl_remOp.Hide();
         name_txtBx.Clear();
         price_txtBx.Clear();
         description_rchTxtBx.Clear();
         newName_txtBx.Clear();
         newPrice_txtBx.Clear();
         clearOptionsBox();
         pickCat_cmbBx.Text = "<Select Category>";
         submit_btn.Hide();
      }

      /*
       * Adds a menu item to the menu through AdminController
       * "DONE"
       */
      private void submit_btn_Click(object sender, EventArgs e)
      {
         KeyEventArgs temp = new KeyEventArgs(Keys.Return);
         updateMenuItem(temp);
      }

      /*
       * Checks if all required item information fields
       * are populated
       * "DONE"
       */
      public bool fullItemFields()
      {
         bool allFull = true;

         if(name_txtBx.Text.Equals("")) {
            name_lbl.ForeColor = Color.Red;
            allFull = false;
         }

         if (price_txtBx.Text.Equals("")) {
            basePrice_lbl.ForeColor = Color.Red;
            allFull = false;
         }

         if(pickCat_cmbBx.Text.Equals("") 
            || pickCat_cmbBx.Text.Equals("<Select Category>")){
            category_lbl.ForeColor = Color.Red;
            allFull = false;
         }

         return allFull; 
      }

      /* 
       * Populates item information panel fields with information
       * for the selected menu item
       * "DONE"
       */
      private void menuItems_lstBx_MouseClick(object sender, MouseEventArgs e)
      {
         clearOptionsBox();
         name_txtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).nameAtt;
         price_txtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).priceAtt.ToString("0.00");
         pickCat_cmbBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).categoryAtt;
         description_rchTxtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).descriptionAtt;
         for (int i = 0; i < controller.loadItemOptions(menuItems_lstBx.SelectedIndex).Count; i++)
            options_lstBx.Items.Add(controller.loadItemOptions(menuItems_lstBx.SelectedIndex)[i].nameAtt);
         itemInfo_pnl.Enabled = true;
         submit_btn.Show();
         remove_btn.Show();
      }

      /*
       * Opens the new option panel if <New Option> is selected
       * "DONE"
       */
      private void options_lstBx_MouseClick(object sender, MouseEventArgs e)
      {
         if (options_lstBx.SelectedItem != null)
         {
            if (options_lstBx.SelectedItem.ToString().Equals("<New Option>"))
            {
               pnl_remOp.Hide();
               newOption_pnl.Show();
               newOption_pnl.BringToFront();
            }
            else
            {
               newOption_pnl.Hide();
               pnl_remOp.Show();
               pnl_remOp.BringToFront();
            }
         }
      }

      /*
       * Removes a specified option from the selected menu item 
       * "DONE"
       */
      private void btn_remOp_Click(object sender, EventArgs e)
      {
         if (options_lstBx.SelectedIndex > 0)
         {
            controller.removeItemOption(menuItems_lstBx.SelectedIndex, options_lstBx.SelectedIndex - 1);
            resetItemInfoPanel();
         }
      }

      /*
       * Takes the info from the form and updates the specific menu item
       * whe called
       */ 
      private void updateMenuItem(KeyEventArgs e)
      {
         if (this.fullItemFields())
         {
            if (!controller.loadCategories().Contains(pickCat_cmbBx.Text))
               controller.addNewCategory(pickCat_cmbBx.Text);

            if (controller.checkPrice(price_txtBx.Text))
            {
               controller.updateMenuItem(menuItems_lstBx.SelectedIndex,
                  description_rchTxtBx.Text, name_txtBx.Text,
                  float.Parse(price_txtBx.Text), pickCat_cmbBx.Text);
               this.AdminForm_Load(this, e);
            }
            else
            {
               this.basePrice_lbl.ForeColor = Color.Red;
               this.price_txtBx.Clear();
               this.price_txtBx.Focus();
            }
         }
      }

      /*
       * Updates the menu item if return is pressed while in the
       * name textbox
       */ 
      private void name_txtBx_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      /*
       * Updates the menu item if return is pressed while in the
       * price textbox
       */
      private void price_txtBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      /*
       * Updates the menu item if return is pressed while in the
       * category combobox
       */
      private void pickCat_cmbBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      /*
       * Updates the menu item if return is pressed while in the
       * description rich textbox
       */
      private void description_rchTxtBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }
   }
}
