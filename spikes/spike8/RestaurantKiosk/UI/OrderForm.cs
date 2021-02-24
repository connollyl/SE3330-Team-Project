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
   public partial class OrderForm : Form
   {
      const int LEFT_ANCHOR = 100;
      const int TOP_ANCHOR = 100;
      const int PRECISION = 2;
      const int PER_ROW = 3;
      const int BUTTON_SIZE_X = 200;
      const int BUTTON_SIZE_Y = 100;
      const int SMALL_SIZE_X = 125;
      const int SMALL_SIZE_Y = 80;
      const int SPACING_Y = 50;
      const int SPACING_X = 50;
      const int CUSHION = 20;
      const int CENTER_X = 347;
      const int CENTER_Y = 100;
      float subTotal = 0.0f;

      FormController formController;
      OrderController orderController;
      List<string> itemList;
      List<GroupBox> categoryList = new List<GroupBox>();
      List<ListViewGroup> categoryViews = new List<ListViewGroup>();
      GroupBox cats = new GroupBox();

      public OrderForm()
      {
         InitializeComponent();
         itemList = new List<string>();
         orderController = new OrderController();
         itemList = orderController.getMenuItemNames();
         orderController.createNewOrder();
         load_views();
         load_categories();
         load_items();
         lstVw_cartSummary.Items.Clear();
         txtbox_description.Location = new Point(categoryList[0].Right, pnl_summary.Bottom);
         updateSubTotal(0.0f);
      }

      /*
       * Adds subsections to the cart display. 
       */
      public void load_views()
      {
         foreach (string cat in orderController.loadCategoryButtons())
         {
            ListViewGroup group = new ListViewGroup(cat, cat);
            group.Name = cat;
            categoryViews.Add(group);
            lstVw_cartSummary.Groups.Add(group);
         }

      }

      /*
       * Allows the form contoller to hide and create the order form
       */
      public void addController(FormController controller)
      {
         formController = controller;
      }

      /*
       * Handles the logout button click. Redirects user to login screen.
       */
      private void btn_logout_Click(object sender, EventArgs e)
      {
         formController.showLoginForm();
      }

      /*
       * Loads the category buttons onto the screen.
       */
      private void load_categories()
      {
         List<string> categories = orderController.loadCategoryButtons();
         cats.Location = new Point(CENTER_X, CENTER_Y);
         cats.Width = categories.Count * BUTTON_SIZE_X;
         cats.Height = categories.Count * BUTTON_SIZE_X;
       
         for (int i = 0; i < categories.Count; i++)
         {
            //GroupBox(category)
            GroupBox tempBox = new GroupBox();
            tempBox.Name = "grpBox_" + categories[i];
            tempBox.Text = categories[i];
            tempBox.Location = new Point(CENTER_X, CENTER_Y);
            
            //visibility and movement
            tempBox.Width = cats.Width;
            pnl_summary.Location = new Point(cats.Width + cats.Location.X, CENTER_Y);
            tempBox.Height = cats.Height;
            categoryList.Add(tempBox);
            this.Controls.Add(tempBox);
            tempBox.Visible = false;

            //Button()
            Button tempButton = new Button();
            tempButton.Name = "btn_c_" + categories[i];
            tempButton.Text = categories[i];
            tempButton.Location = findPosition(i);
            tempButton.Height = BUTTON_SIZE_Y;
            tempButton.Width = BUTTON_SIZE_X;
            tempButton.BackColor = Color.White;
            tempButton.Click += new EventHandler(CustomCategory_Click);
            this.Controls.Add(tempButton);
            cats.Controls.Add(tempButton);
            
         }
         this.Controls.Add(cats);
      }

      /*
       * Dynamically generates all of the menu items in a category. All category
       * items are generated at once. 
       */
      private void load_items()
      {
         for (int i = 0; i < itemList.Count; i++)
         {
            Button tempButton = new Button();

            tempButton.Name = "btn_" + itemList[i];
            tempButton.Text = itemList[i];
            
            tempButton.BackColor = Color.White;
            tempButton.Width = SMALL_SIZE_X;
            tempButton.Height = SMALL_SIZE_Y;
            tempButton.Click += new EventHandler(CustomItem_Click);
            this.Controls.Add(tempButton);
            GroupBox tempGrp = findBox(orderController.getCategoryOfMenuItem(itemList[i]));
            tempButton.Location = findPosition(tempGrp);
            tempGrp.Controls.Add(tempButton);
         }
      }
      /*
       * Handles a click on one of the menu item buttons. For now it adds it to the cart view
       * without any options. Calls addItemToCheckout to handle cart actions.
       */
      private void CustomItem_Click(object sender, EventArgs e)
      {
         ListViewItem newItem = new ListViewItem();
         Button temp = new Button();
         temp = (Button)sender;
         newItem.Text = temp.Text;
         displayDescription(temp.Text); 
         addItemToCheckout(temp.Text, newItem);
      }
      /*
       * Gets the descriptions of an item and displays it in a textbox
       */
      private void displayDescription(string name)
      {
         txtbox_description.Text = orderController.getDescription(name);
      }
      
      /*
       * Event for clicking a category button. Hides the all of the groups
       * then makes the group associated with the click visible.
       */
      private void CustomCategory_Click(object sender, EventArgs e)
      {
         cats.Visible = false;
         foreach (GroupBox boxes in categoryList)
            boxes.Visible = false;
         Button temp = (Button)sender;
         GroupBox grp = findBox(temp.Text);
         grp.Visible = true;

      }

      /*
       * Adds an item to the cart based on its name to the cart listview.
       */
      private void addItemToCheckout(string item, ListViewItem newItem)
      {
         foreach (ListViewGroup group in categoryViews)
         {
            if (group.Name.Equals(orderController.getCategoryOfMenuItem(item)))
               newItem.Group = group;
         }
         float price = orderController.getPrice(item);

         newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, price.ToString()));
         lstVw_cartSummary.Items.Add(newItem);
         updateSubTotal(price);
      }

      /*
       * Updates the sub total price in the cart view. Prices are to 2 decimal points.
       */
      private void updateSubTotal(float price)
      {
         subTotal += price;
         subTotal = (float)Math.Round(subTotal, PRECISION);
         txt_subTotal.Text = "Sub-Total: $" + subTotal.ToString();
      }

      /*
       * Finds a menu item button based on the menu item's name.
       */
      private GroupBox findBox(string s)
      {
         return categoryList.Find(group => group.Text.Equals(s));
      }

      /*
       * Find the position for a category button using the point class to anchor
       * the x and y coordinates according to button spacing.
       */
      private Point findPosition(int index)
      {
         Point p = new Point(0, 0);
       
         p.X = (cats.Width / 2) - BUTTON_SIZE_X / 2;
         p.Y = CENTER_Y + (SPACING_Y + BUTTON_SIZE_Y) * index;
       
         return p;
      }

      /*
       * Find the position for the category group boxes using the point class to anchor
       * the x and y coordinates according to button spacing.
       */
      private Point findPosition(GroupBox box)
      {
         Point p = new Point(0, 0);
         int index = box.Controls.Count;
         int x = (categoryList[0].Width - (SMALL_SIZE_X * PER_ROW)) / (PER_ROW + 1);
         int num = index % PER_ROW + 1;
         p.X = num * x + (num - 1)*SMALL_SIZE_X;
         p.Y = (index / PER_ROW) * (SPACING_Y + SMALL_SIZE_Y) + CUSHION;
     
         return p;
      }

      /*
       * Handles the remove operation by removing the selected index from the cart.
       */
      private void btn_removeCart_Click(object sender, EventArgs e)
      {
         foreach(ListViewItem clicked in lstVw_cartSummary.SelectedItems)
         {
            int count = 0;
            foreach(ListViewItem.ListViewSubItem subitem in clicked.SubItems)
            {
               if(count == 1)
               {
                  string price = subitem.Text.TrimStart('$');
                  updateSubTotal(-1 * float.Parse(price));
               }
               count++;
            }
            clicked.Remove();
         }
      }

      private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         formController.showLoginForm();
      }

      private void OrderForm_Load(object sender, EventArgs e)
      {
         
      }

      private void OrderForm_Resize(object sender, EventArgs e)
      {
         payment_pnl.Width = this.Width / 4;
         payment_pnl.Height = this.Height;
         payment_pnl.Location = new Point(0, 0);
         payment_pnl.Visible = false;
      }

      private void btn_checkout_Click(object sender, EventArgs e)
      {
         payment_pnl.Visible = true;
         btn_checkout.Visible = false;
         btn_editCart.Visible = false;
         btn_removeCart.Visible = false;
         txt_subTotal.Visible = false;
         txtbox_description.Visible = false;
         for(int i = 0; i < categoryList.Count; i ++)
         {
            categoryList[i].Hide();
         }
         lbl_subtotal.Text = "$" + subTotal.ToString();
         cats.Visible = false;
         adjustCheckoutSummary();
         
      }

      private void adjustCheckoutSummary()
      {
         pnl_summary.Location = new Point(this.Width * 3 / 4, 50);
         pnl_summary.Height = this.Height;
         pnl_summary.Width = this.Width / 4;

         lstVw_cartSummary.Height = pnl_summary.Height * 9 / 10;
         lstVw_cartSummary.Width = pnl_summary.Width * 9 / 10;
         lstVw_cartSummary.Font = new Font("Windows Sans Serif", 12);
         lstVw_cartSummary.Columns[0].Width = lstVw_cartSummary.Width * 6 / 10;
         lstVw_cartSummary.Columns[1].Width = lstVw_cartSummary.Width * 3 / 10;

         lbl_cartSummary.Location = new Point(pnl_summary.Width / 4, this.Height - pnl_summary.Height);
         lbl_cartSummary.BringToFront();
      }

      private void btn_tip0_Click(object sender, EventArgs e)
      {
         lbl_subtotal.Text = "$" + subTotal.ToString("0.00");
      }

      private void btn_tip5_Click(object sender, EventArgs e)
      {
         float tipAmount = subTotal * .05f;
         float tipTotal = subTotal + tipAmount;
         lbl_subtotal.Text = "$" + tipTotal.ToString("0.00");
      }

      private void btn_tip10_Click(object sender, EventArgs e)
      {
         float tipAmount = subTotal * .10f;
         float tipTotal = subTotal + tipAmount;
         lbl_subtotal.Text = "$" + tipTotal.ToString("0.00");
      }

      private void btn_tip15_Click(object sender, EventArgs e)
      {
         float tipAmount = subTotal * .15f;
         float tipTotal = subTotal + tipAmount;
         lbl_subtotal.Text = "$" + tipTotal.ToString("0.00");
      }

      private void btn_tip20_Click(object sender, EventArgs e)
      {
         float tipAmount = subTotal * .20f;
         float tipTotal = subTotal + tipAmount;
         lbl_subtotal.Text = "$" + tipTotal.ToString("0.00");
      }

      private void btn_processPay_Click(object sender, EventArgs e)
      {
         
      }

   }
}
