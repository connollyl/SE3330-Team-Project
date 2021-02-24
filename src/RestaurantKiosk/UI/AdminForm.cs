//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Admin form allows the admin to add, modify, and delete
//          items from the menu.
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
   public partial class AdminForm : Form
   {
      protected AdminController controller = new AdminController();
      protected FormController formController;
      private List<Option> tempOps = new List<Option>();

      // ----------------------------------------------------------
      // Constructs the admin form
      // ----------------------------------------------------------
      public AdminForm()
      {
         InitializeComponent();
         if (controller.CheckDone())
            btn_undo.Visible = false;
         if (controller.CheckUnDone())
            btn_redo.Visible = false;
      }

      // ----------------------------------------------------------
      // Saves current menu data to XML
      // ----------------------------------------------------------
      private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         controller.onAdminClose();
         Application.Exit();
      }

      // ----------------------------------------------------------
      // Assigns a form controller object
      // ----------------------------------------------------------
      public void addController(FormController controller)
      {
         formController = controller;
      }

      // ----------------------------------------------------------
      // Adds the item to the menu if the item doesn't exist.
      // ----------------------------------------------------------
      private void addItem()
      {
         if (!controller.loadCategories().Contains(pickCat_cmbBx.Text))
            controller.addNewCategory(pickCat_cmbBx.Text);
         if (fullItemFields())
         {
            controller.addMenuItem(int.Parse(txtBx_calories.Text), description_rchTxtBx.Text,
               name_txtBx.Text, float.Parse(price_txtBx.Text),
               3.0f, pickCat_cmbBx.Text);
         }
      }

      // ----------------------------------------------------------
      // Displays default administrator form
      // ----------------------------------------------------------
      private void AdminForm_Load(object sender, EventArgs e)
      {
         submit_btn.Location = new Point(submit_btn.Location.X, logout_btn.Location.Y);
         remove_btn.Location = new Point(remove_btn.Location.X, logout_btn.Location.Y);
         btn_remOp.Location = new Point(btn_remOp.Location.X, logout_btn.Location.Y);
         newOption_pnl.Location = new Point(newOption_pnl.Location.X, logout_btn.Location.Y - 10);
         menuItems_lstBx.Height = logout_btn.Location.Y - menuItems_lstBx.Location.Y;
         description_rchTxtBx.Height = logout_btn.Location.Y - description_rchTxtBx.Location.Y - 15;
         options_lstBx.Height = logout_btn.Location.Y - options_lstBx.Location.Y;

         controller.sortRestaurantMenu();
         loadMenuItems();
         loadCategories();
         this.resetItemInfoPanel();
         remove_btn.Hide();
         options_lstBx.BringToFront();
      }

      // ----------------------------------------------------------
      // Sets label colors
      // ----------------------------------------------------------
      private void setLabelColors()
      {
         name_lbl.ForeColor = Color.White;
         category_lbl.ForeColor = Color.White;
         basePrice_lbl.ForeColor = Color.White;
         optionPrice_lbl.ForeColor = Color.White;
         optionName_lbl.ForeColor = Color.White;
         lbl_calories.ForeColor = Color.White;
      }

      // ----------------------------------------------------------
      // Removes all items besides "<New Option>" item
      // in options listbox.
      // ----------------------------------------------------------
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

      // ----------------------------------------------------------
      // Populates the menu items list box from the 
      // restaraunt menu list.
      // ----------------------------------------------------------
      private void loadMenuItems()
      {
         menuItems_lstBx.Items.Clear();
         menuItems_lstBx.Items.Add("<New Item>");
         for (int i = 1; i < controller.menuSize(); i++)
            menuItems_lstBx.Items.Add(controller.loadMenuItem(i - 1).nameAtt);
      }

      // ----------------------------------------------------------
      // Populates the pick category list box with
      // current menu categories.
      // ----------------------------------------------------------
      private void loadCategories()
      {
         pickCat_cmbBx.Items.Clear();
         for (int i = 0; i < controller.loadCategories().Count(); i++)
            pickCat_cmbBx.Items.Add(controller.loadCategories()[i]);
      }

      // ----------------------------------------------------------
      // Returns user to the login window
      // ----------------------------------------------------------
      private void logout_btn_Click(object sender, EventArgs e)
      {
         formController.showLoginForm();
         controller.onAdminClose();
      }

      // ----------------------------------------------------------
      // Attempts to add a new option to a menu 
      // item through AdminController
      // ----------------------------------------------------------
      private void newOption_btn_Click(object sender, EventArgs e)
      {
         if (options_lstBx.SelectedIndex == 0)
         {
            if (!string.IsNullOrEmpty(newName_txtBx.Text))
            {
               if (controller.checkPrice(newPrice_txtBx.Text) && !string.IsNullOrEmpty(newPrice_txtBx.Text))
               {
                  if (controller.verifyNewMenuItem(name_txtBx.Text) == -1)
                  {
                     Option op = new Option(newName_txtBx.Text, float.Parse(newPrice_txtBx.Text), 0);
                     tempOps.Add(op);
                     options_lstBx.Items.Add(newName_txtBx.Text);
                  }
                  else if (controller.verifyItemOption(menuItems_lstBx.SelectedIndex, newName_txtBx.Text) == -1)
                  {
                     controller.addOptionToItem(controller.verifyNewMenuItem(name_txtBx.Text),
                         newName_txtBx.Text, float.Parse(newPrice_txtBx.Text));
                     options_lstBx.Items.Add(newName_txtBx.Text);
                  }
                  controller.sortRestaurantMenu();
                  loadMenuItems();
                  menuItems_lstBx.SelectedIndex = controller.verifyNewMenuItem(name_txtBx.Text);
                  newName_txtBx.Clear();
                  newPrice_txtBx.Clear();
               }
               else
               {
                  optionPrice_lbl.ForeColor = Color.Red;
                  newPrice_txtBx.Clear();
               }
            }
            else
            {
               optionName_lbl.ForeColor = Color.Red;
               newName_txtBx.Clear();
            }
         }
      }

      // ----------------------------------------------------------
      // Removes a menu item from the menu and
      // reloads the form.
      // ----------------------------------------------------------
      private void remove_btn_Click(object sender, EventArgs e)
      {
         controller.removeMenuItem(menuItems_lstBx.SelectedIndex - 1);
         this.AdminForm_Load(this, e);
         if (!controller.CheckDone())
            btn_undo.Visible = true;
         controller.history.undone_commands.Clear();
      }

      // ---------------------------------------------------------- 
      // Clears information in text fields in itemInfo_pnl 
      // and resets all displays to default values
      // ----------------------------------------------------------
      private void resetItemInfoPanel()
      {
         newOption_pnl.Hide();
         btn_remOp.Hide();
         name_txtBx.Text = "<name>";
         price_txtBx.Text = "<price>";
         pickCat_cmbBx.Text = "<select category>";
         txtBx_calories.Text = "<calories>";
         description_rchTxtBx.Clear();
         newName_txtBx.Clear();
         newPrice_txtBx.Clear();
         clearOptionsBox();
         submit_btn.Hide();
         setLabelColors();
      }

      // ----------------------------------------------------------
      // Adds a menu item to the menu through AdminController
      // ----------------------------------------------------------
      private void submit_btn_Click(object sender, EventArgs e)
      {
         KeyEventArgs temp = new KeyEventArgs(Keys.Return);
         updateMenuItem(temp);
         if (!controller.CheckDone())
            btn_undo.Visible = true;
         controller.history.undone_commands.Clear();
      }

      // ----------------------------------------------------------
      // Checks if all required item information fields
      // are populated
      // ----------------------------------------------------------
      public bool fullItemFields()
      {
         bool allFull = true;

         if (name_txtBx.Text.Equals("") || name_txtBx.Text.Equals("<name>"))
         {
            name_lbl.ForeColor = Color.Red;
            allFull = false;
         }

         if (price_txtBx.Text.Equals("") || price_txtBx.Text.Equals("<price>"))
         {
            basePrice_lbl.ForeColor = Color.Red;
            allFull = false;
         }

         if (pickCat_cmbBx.Text.Equals("")
            || pickCat_cmbBx.Text.Equals("<select category>"))
         {
            category_lbl.ForeColor = Color.Red;
            allFull = false;
         }

         if (txtBx_calories.Text.Equals("")
            || txtBx_calories.Text.Equals("<calories>"))
         {
            lbl_calories.ForeColor = Color.Red;
            allFull = false;
         }
         return allFull;
      }

      // ---------------------------------------------------------- 
      // Populates item information panel fields with information
      // for the selected menu item
      // ----------------------------------------------------------
      private void menuItems_lstBx_MouseClick(object sender, MouseEventArgs e)
      {
         setLabelColors();
         clearOptionsBox();
         enableFields();
         if (menuItems_lstBx.SelectedIndex == 0)
         {
            this.resetItemInfoPanel();
            submit_btn.Show();
            remove_btn.Hide();
         }
         else if (menuItems_lstBx.SelectedIndex != -1)
         {
            name_txtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex - 1).nameAtt;
            price_txtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex - 1).priceAtt.ToString("0.00");
            pickCat_cmbBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex - 1).categoryAtt;
            description_rchTxtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex - 1).descriptionAtt;
            txtBx_calories.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex - 1).caloriesAtt.ToString();
            for (int i = 0; i < controller.loadItemOptions(menuItems_lstBx.SelectedIndex - 1).Count; i++)
               options_lstBx.Items.Add(controller.loadItemOptions(menuItems_lstBx.SelectedIndex - 1)[i].nameAtt);
            itemInfo_pnl.Enabled = true;
            submit_btn.Show();
            remove_btn.Show();
         }
      }

      // ----------------------------------------------------------
      // Enables the elements in the item info panel
      // ----------------------------------------------------------
      private void enableFields()
      {
         name_txtBx.Enabled = true;
         price_txtBx.Enabled = true;
         txtBx_calories.Enabled = true;
         description_rchTxtBx.Enabled = true;
         options_lstBx.Enabled = true;
         pickCat_cmbBx.Enabled = true;
      }

      // ----------------------------------------------------------
      // Opens the new option panel if <New Option> is selected
      // ----------------------------------------------------------
      private void options_lstBx_MouseClick(object sender, MouseEventArgs e)
      {
         if (options_lstBx.SelectedItem != null)
         {
            if (options_lstBx.SelectedItem.ToString().Equals("<New Option>"))
            {
               btn_remOp.Hide();
               newOption_pnl.Show();
               newOption_pnl.BringToFront();
            }
            else
            {
               newOption_pnl.Hide();
               btn_remOp.Show();
               btn_remOp.BringToFront();
            }
         }
      }

      // ----------------------------------------------------------
      // Removes a specified option from the selected menu item 
      // ----------------------------------------------------------
      private void btn_remOp_Click(object sender, EventArgs e)
      {
         if (options_lstBx.SelectedIndex > 0 && menuItems_lstBx.SelectedIndex > 0)
         {
            controller.removeItemOption(menuItems_lstBx.SelectedIndex, options_lstBx.SelectedIndex - 1);
            options_lstBx.Items.RemoveAt(options_lstBx.SelectedIndex);
            btn_remOp.Hide();
         }
         else
         {
            tempOps.RemoveAt(options_lstBx.SelectedIndex - 1);
            options_lstBx.Items.RemoveAt(options_lstBx.SelectedIndex);
            btn_remOp.Hide();
         }
      }

      // ----------------------------------------------------------
      // Takes the info from the form and updates the specific menu item
      // whe called
      // ----------------------------------------------------------
      private int updateMenuItem(KeyEventArgs e)
      {
         setLabelColors();
         if (this.fullItemFields())
         {
            if (!controller.loadCategories().Contains(pickCat_cmbBx.Text))
               controller.addNewCategory(pickCat_cmbBx.Text);

            if (controller.checkPrice(price_txtBx.Text) && controller.verifyCalories(txtBx_calories.Text))
            {
               string name = name_txtBx.Text;
               controller.updateMenuItem(controller.verifyNewMenuItem(name),
                  description_rchTxtBx.Text, name_txtBx.Text,
                  float.Parse(price_txtBx.Text), pickCat_cmbBx.Text, int.Parse(txtBx_calories.Text));
               if (tempOps.Count != 0)
               {
                  foreach (Option o in tempOps)
                     controller.addOptionToItem(controller.verifyNewMenuItem(name), o.nameAtt, o.priceAtt);
                  tempOps.Clear();
               }
               this.AdminForm_Load(this, e);
               return 0;
            }
            else
            {
               if (!controller.checkPrice(price_txtBx.Text))
               {
                  this.basePrice_lbl.ForeColor = Color.Red;
                  this.price_txtBx.Clear();
                  this.price_txtBx.Focus();
               }
               else
               {
                  this.lbl_calories.ForeColor = Color.Red;
                  this.txtBx_calories.Clear();
                  this.txtBx_calories.Focus();
               }
               return -1;
            }
         }
         return -1;
      }

      // ----------------------------------------------------------
      // Updates the menu item if return is pressed while in the
      // name textbox
      // ----------------------------------------------------------
      private void name_txtBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      // ----------------------------------------------------------
      // Updates the menu item if return is pressed while in the
      // price textbox
      // ----------------------------------------------------------
      private void price_txtBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      // ----------------------------------------------------------
      // Updates the menu item if return is pressed while in the
      // category combobox
      // ----------------------------------------------------------
      private void pickCat_cmbBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      // ----------------------------------------------------------
      // Updates the menu item if return is pressed while in the
      // description rich textbox
      // ----------------------------------------------------------
      private void description_rchTxtBx_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      // ----------------------------------------------------------
      // Updates the menu item if return is pressed while in the
      // calories textbox
      // ----------------------------------------------------------
      private void txtBx_calories_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Return)
         {
            updateMenuItem(e);
         }
      }

      // ----------------------------------------------------------
      // Redoes the action on the top stack of undone commads
      // ----------------------------------------------------------
      private void btn_redo_Click(object sender, EventArgs e)
      {
         controller.getHistory().redo(controller.loadRestaurantMenu());

         if (!controller.CheckDone())
            btn_undo.Visible = true;
         else
            btn_undo.Visible = false;
         if (controller.CheckUnDone())
            btn_redo.Visible = false;
         else
            btn_redo.Visible = true;
         loadMenuItems();

         controller.restaurantMenu = controller.history.getMenu();
         controller.sortRestaurantMenu();
      }

      // ----------------------------------------------------------
      // Undoes the last commmand inputted
      // ----------------------------------------------------------
      private void btn_undo_Click(object sender, EventArgs e)
      {
         controller.getHistory().undo(controller.loadRestaurantMenu());
         if (controller.CheckDone())
            btn_undo.Visible = false;
         if (!controller.CheckUnDone())
            btn_redo.Visible = true;
         controller.sortRestaurantMenu();
         loadMenuItems();
      }

      // ----------------------------------------------------------
      // Shifts button locations upon form resize
      // ----------------------------------------------------------
      private void AdminForm_SizeChanged(object sender, EventArgs e)
      {
         submit_btn.Location = new Point(submit_btn.Location.X, logout_btn.Location.Y);
         remove_btn.Location = new Point(remove_btn.Location.X, logout_btn.Location.Y);
         btn_remOp.Location = new Point(btn_remOp.Location.X, logout_btn.Location.Y);
      }

      // ----------------------------------------------------------
      // Shows the command to be undone when hovering over the undo button
      // ----------------------------------------------------------
      private void btn_undo_MouseHover(object sender, EventArgs e)
      {
         String info = controller.getHistory().done_commands.Peek().see_details();
         this.toolTipCommand.SetToolTip(this.btn_undo, info);
      }

      // ----------------------------------------------------------
      // Shows the command to be redone when hovering over the redo button
      // ----------------------------------------------------------
      private void btn_redo_MouseHover(object sender, EventArgs e)
      {
         String info = controller.getHistory().undone_commands.Peek().see_details();
         this.toolTipCommand.SetToolTip(this.btn_redo, info);
      }
   }
}
