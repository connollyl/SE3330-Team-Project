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
         *
         */
        public void addController(FormController controller)
        {
            formController = controller;
        }

        /*
         * Adds a menu item to the menu through AdminController
         * NOT DONE
         */
        private void submit_btn_Click(object sender, EventArgs e)
        {
            controller.addMenuItem(0, description_rchTxtBx.Text,
                name_txtBx.Text, float.Parse(price_tbtBx.Text),
                3.0f, pickCat_cmbBx.Text);
            this.AdminForm_Load(this, e);
            itemInfo_pnl.Visible = false;
            this.resetItemInfoPanel();
        }

        /*
         * Displays default administrator form
         * "DONE"
         */
        private void AdminForm_Load(object sender, EventArgs e)
        {
            menuItems_lstBx.Items.Clear();
            for (int i = 0; i < controller.menuSize(); i++)
                //menuItems_lstBx.Items.Add(controller.loadMenuItem(i).getName());
            this.resetItemInfoPanel();
            update_btn.Visible = false;
        }

        /*
         * Updates menu item attributes through AdminController
         * NOT DONE
         */
        private void update_btn_Click(object sender, EventArgs e)
        {
            this.resetItemInfoPanel();
            itemInfo_pnl.Visible = true;
        }

        /*
         * Enables the item information panel to allow
         * user to enter new item information
         * "DONE"
         */
        private void new_btn_Click(object sender, EventArgs e)
        {
            this.resetItemInfoPanel();
            submit_btn.Visible = true;
            update_btn.Visible = false;
            itemInfo_pnl.Enabled = true;
        }


        /*
         * Attempts to add a new option to a menu 
         * item through AdminController
         * "DONE"
         */
        private void newOption_btn_Click(object sender, EventArgs e)
        {
            controller.addOptionToItem(menuItems_lstBx.SelectedIndex, 
                newName_txtBx.Text, float.Parse(newPrice_txtBx.Text));
            options_lstBx.Items.Add(newName_txtBx.Text);
        }

        /* 
         * Clears information in text fields in itemInfo_pnl 
         * and resets all displays to default values
         * "DONE"
         */
        private void resetItemInfoPanel()
        {
            itemInfo_pnl.Enabled = false;
            newOption_pnl.Visible = false;
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
            if (update_btn.Visible)
            {
                update_btn.Visible = false;
            }
        }

        /*
         * Opens the new option panel if <New Option> is selected
         * "DONE"
         */
        private void options_lstBx_DoubleClick(object sender, EventArgs e)
        {
            if (options_lstBx.SelectedItem.ToString() == "<New Option>")
            {
                newOption_pnl.Visible = true;
            }
        }

        /*
         * Returns user to the login window
         * DONE
         */
        private void logout_btn_Click(object sender, EventArgs e)
        {
            formController.showLoginForm();
        }

        /* 
         * Populates item information panel fields with information
         * for the selected menu item
         * "DONE"
         */
        private void menuItems_lstBx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //name_txtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).getName();
            //price_tbtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).getPrice().ToString();
            //pickCat_cmbBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).getCategory();
            //description_rchTxtBx.Text = controller.loadMenuItem(menuItems_lstBx.SelectedIndex).getDescription();
            itemInfo_pnl.Enabled = true;
            submit_btn.Hide();
            update_btn.Show();
        }
    }
}
