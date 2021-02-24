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
      struct CustomButton
      {
         public Button cButton;
         public CustomButton(string name, string text, Point point, Color col, int width, int height)
         {
            cButton = new Button();
            cButton.Name = name;
            cButton.Text = text;
            cButton.Location = point;
            cButton.BackColor = col;
            cButton.Width = width;
            cButton.Height = height;
            cButton.FlatStyle = FlatStyle.Popup;
         }
         public Button toButton()
         {
            return cButton;
         }
      }
      /*
      * Find the position for a category button using the point class to anchor
      * the x and y coordinates according to button spacing.
      */
      private Point findPosition(int index)
      {
         Point p = new Point(0, 0);
         int x = (int)(this.Width * .30);
         p.X = x - (int)(this.Width * .30);
         p.Y = (SPACING_Y + buttonY) * index + CORRECTION; 

         return p;
      }
      private Point findPosition(GroupBox box)
      {
         Point p = new Point(0, 0);
         int index = box.Controls.Count;
         foreach (Control item in box.Controls)
         {
            Type test = item.GetType();
            if (test.Name.Equals("Button"))
            {
               Button temp = new Button();
               temp = (Button)item;
               if (temp.Name.Equals("btn_back"))
                  index--;
               if (temp.Name.Equals("btn_addToOrder"))
                  index--;
            }
         }
         int x = (categoryGrpBxList[0].Width - (smallX * PER_ROW)) / (PER_ROW + 1);
         int num = index % PER_ROW + 1;
         p.X = num * x + (num - 1) * smallX;
         p.Y = (index / PER_ROW) * (SPACING_Y + smallY) + smallY;
         return p;
      }
      const int CORRECTION = 8;
      const int PRECISION = 2;
      const int PER_ROW = 3;
      const int TABLE_Y= 447;
      const int TABLE_X = 234;
      const int SPACING_Y = 50;
      const int SPACING_X = 50;
      const int CUSHION = 20;
      const int CENTER_X = 347;
      const float TEN_PERCENT = 0.10f;
      const float FIFTEEN_PERCENT = 0.15f;
      const float TWENTY_PERCENT = 0.20f;
      const float WISC_TAX = .05f;
      float subTotal = 0.0f;
      float taxTotal = 0.0f;
      private int lastIndex = 0;
      private int centerY = 0;
      private int centerX = 0;
      private int buttonX = 0;
      private int buttonY = 0;
      private int smallX = 0;
      private int smallY = 0;
      FormController formController;
      OrderController orderController;
      List<string> itemList;
      List<GroupBox> categoryGrpBxList = new List<GroupBox>();
      List<GroupBox> itemGrpBxList = new List<GroupBox>();
      List<ListViewGroup> categoryViews = new List<ListViewGroup>();
      GroupBox categoryBtnBox = new GroupBox();
      Button backButton = new Button();
      Button addToOrder = new Button();
      ListViewItem lastItem = new ListViewItem();
      //Button backButton = new Button();
      GroupBox lastBox = new GroupBox();
      GroupBox currentBox = new GroupBox();
      public OrderForm()
      {
         InitializeComponent();
         centerY = this.Height / 2;
         centerX = this.Width / 2;
         buttonX = (int)(this.Width * .20);
         buttonY = (int)(this.Height * .15);
         smallX = (int)(this.Width * .10);
         smallY = (int)(this.Height * .10);
         scaling();
         itemList = new List<string>();
         orderController = new OrderController();
         itemList = orderController.getMenuItemNames();
         orderController.createNewOrder();
         load_views();
         load_categories();
         load_items();
         load_options();
         lstVw_cartSummary.Items.Clear();
         txtbox_Item.Location = new Point(categoryGrpBxList[0].Left, pnl_summary.Top - txtbox_Item.Height);
         txtbox_description.Location = new Point(categoryGrpBxList[0].Right - txtbox_description.Width, pnl_summary.Top - txtbox_description.Height);
         updateSubTotal(0.0f);
        // categoryBtnBox.FlatStyle = FlatStyle.Popup;
         
      }

      /*
       * Adds subsections to the cart display. 
       */
      public void load_views()
      {
         pnl_payment.Hide();
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
       * Refreshes the cart summary everytime the order is updated.
       */
      

      /*
       * Loads the category buttons onto the screen.
       */
      private void load_categories()
      {
         centerY = this.Height / 2;
         centerX = this.Width / 2;
         List<string> categories = orderController.loadCategoryButtons();

         categoryBtnBox.Width = lstVw_cartSummary.Width;
         categoryBtnBox.Height = this.Height;
         //centerY += cats.Height / 2;
         for (int i = 0; i < categories.Count; i++)
         {
            //GroupBox(category)
            GroupBox categoryBox = new GroupBox();
            categoryBox.Name = "grpBox_" + categories[i];
            //tempBox.Text = categories[i];

            

            //visibility and movement
            categoryBox.Width = categoryBtnBox.Width;
            categoryBox.Height = lstVw_cartSummary.Height;
            categoryBox.Location = new Point(centerX - categoryBox.Width / 2, btn_ArrowUp.Location.Y);
            categoryGrpBxList.Add(categoryBox);
            //Button()
            string name = "btn_c_" + categories[i];
            Button categoryButton = (new CustomButton(name, categories[i], findPosition(i),  Color.White, buttonX,buttonY)).toButton();
            categoryButton.Click += new EventHandler(CustomCategory_Click);
            this.Controls.Add(categoryButton);
            categoryBtnBox.Controls.Add(categoryButton);
            this.Controls.Add(categoryBox);
            categoryBox.Visible = false;
         }

         this.Controls.Add(categoryBtnBox);
      }

      /*
       * Dynamically generates all of the menu items in a category. All category
       * items are generated at once. 
       */
      private void load_items()
      {
         for (int i = 0; i < itemList.Count; i++)
         {
             string name = "btn_" + itemList[i];
             GroupBox itemGrp = findBox(categoryGrpBxList, orderController.getCategoryOfMenuItem(itemList[i]));
             Button itemBtn = (new CustomButton(name, itemList[i], findPosition(itemGrp), Color.White, smallX, smallY)).toButton();
             itemBtn.Click += new EventHandler(CustomItem_Click);
             this.Controls.Add(itemBtn);
             itemGrp.Controls.Add(itemBtn);
         }
      }

      /*
       * Loads the various group boxes for each item and fills them 
       * with the corresponding options.
       */
      private void load_options()
      {
         for (int i = 0; i < itemList.Count; i++)
         {
            //GroupBox(itemOptions)
            GroupBox optionBox = new GroupBox();
            optionBox.Name = "grpBox_" + itemList[i];
            optionBox.Location = new Point(CENTER_X, 0);

            //visibility and movement
            optionBox.Width = categoryBtnBox.Width;
            optionBox.Height = categoryBtnBox.Height;
            itemGrpBxList.Add(optionBox);
            this.Controls.Add(optionBox);
            optionBox.Visible = false;

            List<string> options = new List<string>();
            options = orderController.getMenuItemOptions(itemList[i]);

            for (int j = 0; j < options.Count; j++)
            {
               Button optionButton = new Button();

               optionButton.Name = "btn_" + options[j];
               optionButton.Text = options[j];

               if (j == 0 && orderController.getCategoryOfMenuItem(itemList[i]).Equals("Drinks"))
                  optionButton.BackColor = Color.LightGreen;
               else if(orderController.getCategoryOfMenuItem(itemList[i]).Equals("Drinks"))
                  optionButton.BackColor = Color.Red;
               else
                  optionButton.BackColor = Color.LightGreen;

               optionButton.FlatStyle = FlatStyle.Popup;
               optionButton.Width = smallX;
               optionButton.Height = smallY;
               optionButton.Click += new EventHandler(CustomOption_Click);
               this.Controls.Add(optionButton);
               optionButton.Location = findPosition(optionBox);
               optionBox.Controls.Add(optionButton);
            }
            Button backButton = (new CustomButton("btn_back", "Back", findPosition(optionBox), Color.White, smallX, smallY)).toButton();
            backButton.Click += new EventHandler(CustomBack_Click);
            
            this.Controls.Add(backButton);
           // backButton.Location = new Point(25, optionBox.Height - optionBox.Location.Y);
            optionBox.Controls.Add(backButton);

            addToOrder = new Button();
            addToOrder.Name = "btn_addToOrder";
            addToOrder.Text = "Add To Order";
            addToOrder.BackColor = Color.White;
            addToOrder.FlatStyle = FlatStyle.Popup;
            addToOrder.Width = smallX;
            addToOrder.Height = smallY;
            addToOrder.Click += new EventHandler(CustomAddToOrder_Click);

            this.Controls.Add(addToOrder);
            addToOrder.Location = new Point(optionBox.Width - smallX - SPACING_X, backButton.Location.Y);
            optionBox.Controls.Add(addToOrder);
         }
      }
      /*
       * Adds the custom order item to the cart and order.
       */
      private void CustomAddToOrder_Click(object sender, EventArgs e)
      {
         List<string> optionsToRemove = new List<string>();
         Button temp = new Button();
         temp = (Button)sender;
         GroupBox parentBox = (GroupBox)temp.Parent;
         foreach (Control item in parentBox.Controls)
         {
            if (item.BackColor.Equals(Color.Red))
            {
               optionsToRemove.Add(item.Text);
            }
         }
         txtbox_description.Text = "";
         txtbox_Item.Text = "";
         enableBack(parentBox);
         temp.Text = "Add to Order";
         categoryBtnBox.Visible = true;
         orderController.updateOrder(getName(parentBox.Name), optionsToRemove);
         refreshCartSummary();
         updateSubTotal(orderController.getSubTotal());
         parentBox.SendToBack();
      }

      /*
       * Goes back to the previous group box.
       */
      private void CustomBack_Click(object sender, EventArgs e)
      {
         txtbox_description.Text = "";
         txtbox_Item.Text = "";
         Button temp = new Button();
         temp = (Button)sender;
         GroupBox currentGrpBx = new GroupBox();
         currentGrpBx = (GroupBox)temp.Parent;

         foreach (Control control in currentGrpBx.Controls)
         {
            Type type = control.GetType();
            if (type.Name.Equals("Button"))
            {
               Button tempBtn = new Button();
               tempBtn = (Button)control;
               if (tempBtn.BackColor.Equals(Color.Red)  && !orderController.getCategoryOfMenuItem(getName(currentGrpBx.Name)).Equals("Drinks"))
                  tempBtn.BackColor = Color.LightGreen;
            }
         }

         GroupBox newGrpBx = new GroupBox();
         foreach (GroupBox item in categoryGrpBxList)
         {
            foreach (Control cont in item.Controls)
            {
               if (getName(cont.Name).Equals(getName(currentGrpBx.Name)))
               {
                  newGrpBx = item;
               }
            }
         }

         if (newGrpBx.Name.Equals(""))
         {
            newGrpBx = categoryBtnBox;
         }

         currentGrpBx.Visible = false;
         newGrpBx.Visible = true;
      }
      /*
       * Selecting an option changes the backcolor of the button
       * to demonstrate to the user that their click was recognized.
       */
      private void CustomOption_Click(object sender, EventArgs e)
      {
         Button temp = new Button();
         temp = (Button)sender;
         if(checkCategorySide(temp.Parent))
         {
            foreach (Control con in temp.Parent.Controls)
            {
               Button temp2 = new Button();
               temp2 = (Button)con;
               if (temp2.BackColor == Color.LightGreen && !temp2.Name.Equals(temp.Name))
               {
                  temp2.BackColor = Color.Red;
               }
            }

            temp.BackColor = Color.LightGreen;
         }
         else
         {
            if (temp.BackColor == Color.LightGreen)
               temp.BackColor = Color.Red;
            else
               temp.BackColor = Color.LightGreen;
         }
      }

      private bool checkCategorySide(Control parent)
      {
         if(orderController.getCategoryOfMenuItem(getName(parent.Name)).Equals("Drinks"))
         {
            return true;
         }
         return false;
      }

      /*
       * Handles a click on one of the menu item buttons. For now it adds it to the cart view
       * without any options. Calls addItemToCheckout to handle cart actions.
       */
      private void CustomItem_Click(object sender, EventArgs e)
      {
         foreach (GroupBox boxes in categoryGrpBxList)
            boxes.Visible = false;
         foreach (GroupBox boxes in itemGrpBxList)
            boxes.Visible = false;
         Button temp = new Button();
         temp = (Button)sender;
         GroupBox grp = findBox(itemGrpBxList, temp.Text);
         grp.Visible = true;
         txtbox_Item.Text = getName(grp.Name);
         displayDescription(temp.Text);
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
         categoryBtnBox.Visible = false;
         foreach (GroupBox boxes in categoryGrpBxList)
            boxes.Visible = false;
         Button currentButton = (Button)sender;
         GroupBox grp = findBox(categoryGrpBxList, currentButton.Text);
         grp.Visible = true;
      }

      /*
       * Updates the sub total price in the cart view. Prices are to 2 decimal points.
       */
      private void updateSubTotal(float price)
      {
         subTotal = price;
         subTotal = (float)Math.Round(subTotal, PRECISION);
         txt_subTotal.Text = "Sub-Total: $" + subTotal.ToString();
      }

      /*
       * Finds a menu item button based on the menu item's name.
       */
      private GroupBox findBox(List<GroupBox> genericList, string s)
      {
         return genericList.Find(group => getName(group.Name).Equals(s));
      }

     
      

      
      

      /*
       * I removed the text from the group boxes, so now this splits the group box name
       * and removes the grpBx_ part.
       */
      public string getName(string text)
      {
         string result = "";
         List<string> temp = text.Split('_').ToList();
         temp.RemoveAt(0);
         foreach (string item in temp)
            result += item;
         return result;
      }

      /*
       * Handles the remove operation by removing the selected index from the cart.
       */
      private void btn_removeCart_Click(object sender, EventArgs e)
      {
         if (lstVw_cartSummary.SelectedItems.Count > 0)
         {
            ListViewItem item = lstVw_cartSummary.SelectedItems[0];

            if (item.Text.Contains("+"))
            {
               traverseListUp(lastIndex);
            }
         }
         foreach (ListViewItem clicked in lstVw_cartSummary.SelectedItems)
         {
            orderController.removeItem(clicked.Name);
            updateSubTotal(orderController.getSubTotal());
         }
         refreshCartSummary();
         lastIndex = 0;
      }

      private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         formController.showLoginForm();
      }

      private void btn_checkout_Click(object sender, EventArgs e)
      {
         pnl_payment.Visible = true;
         pnl_summary.Visible = false;
         btn_checkout.Visible = false;
         btn_editCart.Visible = false;
         btn_removeCart.Visible = false;
         txt_subTotal.Visible = false;
         txtbox_description.Visible = false;
         txtbox_Item.Visible = false;
         categoryBtnBox.Visible = false;
         foreach (GroupBox boxes in categoryGrpBxList)
            boxes.Visible = false;
         foreach (GroupBox boxes in itemGrpBxList)
            boxes.Visible = false;

         for (int i = 0; i < categoryGrpBxList.Count; i++)
         {
            categoryGrpBxList[i].Hide();
         }
         float taxAddition = subTotal * WISC_TAX;
         taxTotal = subTotal + taxAddition;
         totalLabel.Text = "$" + taxTotal.ToString("0.00");
         adjustCheckoutSummary();
         btnPercentZero.FlatStyle = FlatStyle.Standard;
      }

      private void adjustCheckoutSummary()
      {
         pnl_summary.Location = new Point(this.Width / 2, 0);
         pnl_payment.Location = new Point(this.Width / 2 - pnl_payment.Width, 0);
         pnl_payment.Height = btnPay.Location.Y + CUSHION + btnPay.Height;
         lbl_cartSummary.Visible = false;
         pnl_summary.Visible = true;
         btn_ArrowDown.Visible = false;
         btn_ArrowUp.Visible = false;
      }

      private void btnPay_Click(object sender, EventArgs e)
      {
         List<string> order = lstVw_cartSummary.Items.Cast<ListViewItem>()
            .Select(item => item.Text).ToList();
         foreach (string s in order)
         {
            if (!s.Contains('+'))
               orderController.ProcessOrder(s);
         }

         orderController.createNewOrder();
         refreshCartSummary();
         categoryBtnBox.Visible = true;
         foreach (Control con in pnl_summary.Controls)
            con.Visible = true;
         pnl_payment.Visible = false;
         pnl_summary.Location = new Point(categoryBtnBox.Location.X + categoryBtnBox.Width, categoryBtnBox.Location.Y);
         lstVw_cartSummary.Height = TABLE_Y;
         lstVw_cartSummary.Width = TABLE_X;
      }

      private void percentage_Click(object sender, EventArgs e)
      {
         Button btn = (Button)sender;//Assumes only buttons have this event.
         String percentage = btn.Text.ToString();
         float rate = 0.0f;

         btnPercentZero.FlatStyle = FlatStyle.Flat;
         btnPercentTen.FlatStyle = FlatStyle.Flat;
         btnPercentFifteen.FlatStyle = FlatStyle.Flat;
         btnPercentTwenty.FlatStyle = FlatStyle.Flat;

         if (percentage.Contains("10"))
         {
            rate = TEN_PERCENT;
            btnPercentTen.FlatStyle = FlatStyle.Standard;
         }
         else if (percentage.Contains("15"))
         {
            rate = FIFTEEN_PERCENT;
            btnPercentFifteen.FlatStyle = FlatStyle.Standard;
         }
         else if (percentage.Contains("20"))
         {
            rate = TWENTY_PERCENT;
            btnPercentTwenty.FlatStyle = FlatStyle.Standard;
         }
         else
         {
            rate = 0.0f;
            btnPercentZero.FlatStyle = FlatStyle.Standard;
         }

         float tipTotal = subTotal * rate;
         float endTotal = taxTotal + tipTotal;
         totalLabel.Text = "$" + endTotal.ToString("0.00");
      }

      private void OrderForm_Resize(object sender, EventArgs e)
      {
         pnl_payment.Height = this.Height;
         pnl_payment.Location = new Point(0, 0);
         pnl_payment.Visible = false;
      }

      private void btn_editCart_Click(object sender, EventArgs e)
      {
         if (lstVw_cartSummary.Items.Count == 0 || lstVw_cartSummary.Items[lastIndex].Selected == false)
            return;
         if (lstVw_cartSummary.Items[lastIndex].Text.Contains("+"))
            traverseListUp(lastIndex);
         int current = lstVw_cartSummary.SelectedIndices[0];
         string uniqueID = lstVw_cartSummary.Items[current].Name;
         string itemName = lstVw_cartSummary.Items[current].Text;
         foreach (GroupBox box in itemGrpBxList)
         {

            if (box.Name == ("grpBox_" + itemName))
            {
               box.Visible = true;
               txtbox_description.Text = orderController.getDescription(itemName);
               txtbox_Item.Text = itemName;
               disableBack(box);
               orderController.removeItem(uniqueID);
               box.BringToFront();
            }
         }
      }
      private void disableBack(GroupBox currentBox)
      {
         foreach (Control con in currentBox.Controls)
            if (con.Name == "btn_back")
               con.Visible = false;

      }
      private void enableBack(GroupBox currentBox)
      {
         foreach (Control con in currentBox.Controls)
            if (con.Name == "btn_back")
               con.Visible = true;

      }
      private void btn_ArrowUp_Click(object sender, EventArgs e)
      {
         traverseListUp(lastIndex);
      }

      private void btn_ArrowDown_Click(object sender, EventArgs e)
      {
         traverseListDown(lastIndex);
      }

      /*
       * Traverses up the list of items in the cart summary.
       */
      private void traverseListUp(int currentIndex)
      {

         if (lstVw_cartSummary.Items.Count == 0)
            return;
         if (currentIndex == 0 && lstVw_cartSummary.Items.Count != 0)
         {
            lstVw_cartSummary.Items[0].Selected = true;
            return;
         }
         lstVw_cartSummary.Items[currentIndex].Selected = false;
         for (int i = currentIndex - 1; i >= 0; i--)
         {
            if (!lstVw_cartSummary.Items[i].Text.Contains("+"))
            {
               lstVw_cartSummary.Items[i].Selected = true;
               return;
            }
         }

         return;
      }

      /*
       * Traverses down the list of items in the cart summary.
       */
      private void traverseListDown(int currentIndex)
      {
         if (lstVw_cartSummary.Items.Count == 0)
            return;
         if (currentIndex == 0 && lstVw_cartSummary.Items.Count != 0 && lstVw_cartSummary.Items[0].Selected == false)
         {
            lstVw_cartSummary.Items[0].Selected = true;
            return;
         }

         // lstVw_cartSummary.Items[currentIndex].Selected = false;
         for (int i = currentIndex + 1; i < lstVw_cartSummary.Items.Count; i++)
         {
            if (!lstVw_cartSummary.Items[i].Text.Contains("+"))
            {
               lstVw_cartSummary.Items[currentIndex].Selected = false;
               lstVw_cartSummary.Items[i].Selected = true;
               return;
            }
         }
         return;
      }

      /*
       * Stores the index when an item is selected.
       */
      private void lstVw_cartSummary_SelectedIndexChanged(object sender, EventArgs e)
      {
         int store = lastIndex;
         try
         {
            lastIndex = lstVw_cartSummary.SelectedIndices[0];
         }
         catch (Exception ex)
         {
            lastIndex = store;
         }
      }
      /*
       * Takes the user back to the ordering screen
       */
      private void btn_cancel_Click(object sender, EventArgs e)
      {
         categoryBtnBox.Visible = true;
         foreach (Control con in pnl_summary.Controls)
            con.Visible = true;
         pnl_payment.Visible = false;
         pnl_summary.Location = new Point(categoryBtnBox.Location.X + categoryBtnBox.Width, categoryBtnBox.Location.Y);
         lstVw_cartSummary.Height = TABLE_Y;
         lstVw_cartSummary.Width = TABLE_X;
      }

      private void txt_subTotal_TextChanged(object sender, EventArgs e)
      {

      }

      private void pnl_summary_Paint(object sender, PaintEventArgs e)
      {

      }

      private void OrderForm_Load(object sender, EventArgs e)
      {
         
        
         scaling();
      }
      private void scaling()
      {
         foreach (Control con in pnl_summary.Controls)
         {
            try
            {
               Button b = (Button)con;
               b.Height = (int)(this.Height * .05);
               if (b.Text == "Checkout")
                  b.Height += b.Height;
            }
            catch (Exception e){}
         }
         int spacingY = (int)(this.Height * .01);
         int centerX = (int)(this.Width * .5);
         pnl_summary.Location = new Point(centerX, 0);
         
         btn_ArrowUp.Location = new Point(0, spacingY);
         lstVw_cartSummary.Height = (int)(this.Height * .60);
         lstVw_cartSummary.Location = new Point(0, btn_ArrowUp.Location.Y + btn_ArrowUp.Height + spacingY);
         btn_ArrowDown.Location = new Point(0, lstVw_cartSummary.Location.Y +lstVw_cartSummary.Height + spacingY);
         btn_editCart.Location = new Point(lstVw_cartSummary.Width - btn_editCart.Width, btn_ArrowDown.Location.Y + btn_ArrowDown.Height + spacingY);
         btn_removeCart.Location = new Point(0, btn_ArrowDown.Location.Y + btn_ArrowDown.Height + spacingY);
         txt_subTotal.Location = new Point(0, btn_removeCart.Location.Y + btn_removeCart.Height + spacingY);
         btn_checkout.Location = new Point(0, txt_subTotal.Location.Y + txt_subTotal.Height + spacingY);
         categoryBtnBox.Height = (int)(this.Height * .80);
         categoryBtnBox.Width = (int)(this.Width * .30);

         categoryBtnBox.Location = new Point(centerX - categoryBtnBox.Width, btn_ArrowUp.Location.Y + CORRECTION);
         pnl_summary.Width = lstVw_cartSummary.Width;
      }
      public void refreshCartSummary()
      {
         List<string> uniqueIDs = new List<string>();
         uniqueIDs = orderController.getOrderMenuItemUniqueIDs();
         lstVw_cartSummary.Items.Clear();
         foreach (ListViewGroup group in categoryViews)
         {
            foreach (string item in uniqueIDs)
            {
               string itemName = orderController.getOrderMenuItemNameByID(item);
               string category = orderController.getCategoryOfMenuItem(itemName);
               float price = orderController.getOrderMenuItemPriceByID(item);
               if (group.Name.Equals(category))
               {
                  ListViewItem newItem = new ListViewItem();
                  newItem.Name = item;
                  newItem.Group = group;
                  newItem.Text = itemName;
                  newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, price.ToString("$0.00")));
                  lstVw_cartSummary.Items.Add(newItem);

                  foreach (string option in orderController.getOptionsAndPricesByID(item))
                  {
                     string optionName = option.Split('_')[0];
                     string optionPrice = option.Split('_')[1];

                     newItem = new ListViewItem();
                     newItem.Name = optionName;
                     newItem.Group = group;
                     newItem.Text = "   +" + optionName;
                     newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, optionPrice));
                     lstVw_cartSummary.Items.Add(newItem);
                  }
               }
            }
         }
      }
   }

}
