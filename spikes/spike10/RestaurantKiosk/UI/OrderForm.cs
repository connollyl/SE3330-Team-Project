﻿using System;
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
      
      const int CORRECTION = 10;
      const int PRECISION = 2;
      const int PER_ROW = 3;
      const int TABLE_Y= 447;
      const int TABLE_X = 234;
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
      private int spacingY = 0;
      private int spacingX = 0;
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
      GroupBox lastBox = new GroupBox();
      GroupBox currentBox = new GroupBox();
      public OrderForm()
      {
         InitializeComponent();
         Rectangle screen = Screen.PrimaryScreen.WorkingArea;
         int w =  screen.Width;
         int h = screen.Height;
         this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
         this.Size = new Size(w, h);
         centerY = this.Height / 2;
         centerX = this.Width / 2;
         buttonX = (int)(this.Width * .15);
         buttonY = (int)(this.Height * .15);
         smallX = (int)(this.Width * .10);
         smallY = (int)(this.Height * .10);
         spacingY = (int)(this.Height * .05);
         spacingX = (int)(this.Width * .05);
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
         txtbox_description.Location = new Point(categoryGrpBxList[0].Right - txtbox_description.Width, pnl_summary.Top - txtbox_description.Height);
         updateSubTotal(0.0f);
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
       * Loads the category buttons onto the screen.
       */
      private void load_categories()
      {
         centerY = this.Height / 2;
         centerX = this.Width / 2;
         List<string> categories = orderController.loadCategoryButtons();

         categoryBtnBox.Width = (int)(lstVw_cartSummary.Width * 1.618);
         categoryBtnBox.Height = btn_checkout.Height + btn_checkout.Location.Y;
         categoryBtnBox.Location = new Point(centerX - categoryBtnBox.Width, 0);
         //centerY += cats.Height / 2;
         for (int i = 0; i < categories.Count; i++)
         {
            //GroupBox(category)
            GroupBox categoryBox = new GroupBox();
            categoryBox.Name = "grpBox_" + categories[i];
            //visibility and movement
            categoryBox.Width = categoryBtnBox.Width;
            categoryBox.Height = categoryBtnBox.Height;
            categoryBox.Location = categoryBtnBox.Location;
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
         int x = 0;
         for (int i = 0; i < itemList.Count; i++)
         {
               
             string name = "btn_" + itemList[i];
             GroupBox itemGrp = findBox(categoryGrpBxList, orderController.getCategoryOfMenuItem(itemList[i]));
             Button itemBtn = (new CustomButton(name, itemList[i], findPosition(itemGrp), Color.White, smallX, smallY)).toButton();
             itemBtn.Click += new EventHandler(CustomItem_Click);

             this.Controls.Add(itemBtn);
             itemGrp.Controls.Add(itemBtn);
             if (i == 0)
               x = itemBtn.Location.X;

         }
         for (int i = 0; i < categoryGrpBxList.Count; i++)
         {

            int row = (categoryGrpBxList[i].Controls.Count / PER_ROW) + 1;
            if (categoryGrpBxList[i].Controls.Count % PER_ROW == 0)
               row--;
            int y = (row) * (spacingY + smallY);
            Point posBack = new Point(x, y);
            Button backButton = (new CustomButton("btn_back", "Back", posBack, Color.White, smallX, smallY)).toButton();
            backButton.Click += new EventHandler(CustomBack_Click);
            categoryGrpBxList[i].Controls.Add(backButton);
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
           

            //visibility and movement
            optionBox.Width = categoryBtnBox.Width;
            optionBox.Height = categoryBtnBox.Height;
            optionBox.Location = new Point(centerX - optionBox.Width, 0);
            itemGrpBxList.Add(optionBox);
            this.Controls.Add(optionBox);
            optionBox.Visible = false;

            List<string> options = new List<string>();
            options = orderController.getMenuItemOptions(itemList[i]);
            int x = 0;
            for (int j = 0; j < options.Count; j++)
            {
               Point position = findPosition(optionBox);

               string name = "btn_" + options[j];
               Button optionButton = (new CustomButton(name, options[j], position, Color.White, smallX, smallY)).toButton();
               if (j == 0 && orderController.getCategoryOfMenuItem(itemList[i]).Equals("Drinks"))
               {
                  optionButton = removePrefix(optionButton, "No");
               }
               else if (orderController.getCategoryOfMenuItem(itemList[i]).Equals("Drinks"))
               {
                  optionButton.Text = "No " + optionButton.Text;
               }
               else
               {
                  optionButton = removePrefix(optionButton, "No");
               }
               optionButton.Click += new EventHandler(CustomOption_Click);
               optionBox.Controls.Add(optionButton);
               if (j == 0)
                  x = optionButton.Location.X;
            }
            int row = (optionBox.Controls.Count / PER_ROW) + 1;
            if (optionBox.Controls.Count % PER_ROW == 0)
               row--;
            int y = (row) * (spacingY + smallY);
            
            Point posBack = new Point(x, y);
            Button backButton = (new CustomButton("btn_back", "Back", posBack, Color.White, smallX, smallY)).toButton();
            backButton.Click += new EventHandler(CustomBack_Click);
            
            this.Controls.Add(backButton);
            optionBox.Controls.Add(backButton);
            Point posAdd = new Point(optionBox.Width - x - smallX, backButton.Location.Y);
            Button addToOrder = (new CustomButton("btn_addToOrder", "Add to Order", posAdd, Color.White, smallX, smallY)).toButton();
            addToOrder.Click += new EventHandler(CustomAddToOrder_Click);
            this.Controls.Add(addToOrder);
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
            List<string> words = item.Text.Split(' ').ToList();
            if (words.First().Equals("No"))
            {
               words.RemoveAt(0);
               string temp2 = "";


               foreach (string word in words)
                  temp2 += word + " ";
               temp2 = temp2.Trim();
               optionsToRemove.Add(temp2);
            }
         }
         txtbox_description.Text = "";
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
               if (!con.Name.Equals("txtbox_description"))
               {
                  Button temp2 = new Button();
                  temp2 = (Button)con;
                  if (!temp2.Text.Split(' ').ToList().First().Equals("No") && !temp2.Name.Equals(temp.Name) && !temp2.Text.Equals("Back") && !temp2.Text.Equals("Add to Order"))
                     temp2.Text = "No " + temp2.Text;
               }
            }
            temp = removePrefix(temp, "No");
         }
         else
         {
            if(temp.Text.Split(' ').ToList().First().Equals("No"))
               temp = removePrefix(temp, "No");
            else
               temp.Text = "No " + temp.Text;
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
         //txtbox_Item.Text = getName(grp.Name);

         grp.Controls.Add(txtbox_description);
         txtbox_description.BringToFront();
        // txtbox_description.Location = findPosition(grp);
         //txtbox_description.Location = new Point(txtbox_description.Location.X, txtbox_description.Location.Y + spacingY);
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

      private Button removePrefix(Button temp, string prefix)
      {
         List<string> stringStatement = temp.Text.Split(' ').ToList();
         if(stringStatement.First().Equals(prefix))
         {
            stringStatement.RemoveAt(0);
            temp.Text = "";
            foreach(string word in stringStatement)
            {
               temp.Text += word + " ";
            }
            temp.Text = temp.Text.Trim();
         }
         return temp;
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
         //if (lstVw_cartSummary.Items.Count == 0)
            //btn_checkout.Visible = false;
      }

      private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         formController.showLoginForm();
      }

      private void btn_checkout_Click(object sender, EventArgs e)
      {
         pnl_payment.Visible = true;
         pnl_summary.Visible = false;
         btn_editCart.Visible = false;
         btn_removeCart.Visible = false;
         txt_subTotal.Visible = false;
         txtbox_description.Visible = false;
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

         lbl_prc_subtotal.Text = "$" + subTotal.ToString("0.00");
         lbl_prc_tax.Text = "$" + taxAddition.ToString("0.00");
         lbl_prc_total.Text = "$" + taxTotal.ToString("0.00");
         rchTxtBx_Comments.Text = "";

         adjustCheckoutSummary();
         btnPercentZero.FlatStyle = FlatStyle.Standard;
         btn_checkout.Visible = false;
         pnl_payment.BringToFront();
      }

      private void adjustCheckoutSummary()
      {
         pnl_summary.Width = (int)(this.Width);
         pnl_summary.Location = new Point(0, 0);
         pnl_payment.Location = new Point(centerX - pnl_payment.Width, pnl_summary.Location.Y);
         lstVw_cartSummary.Height = pnl_summary.Height;
         lstVw_cartSummary.Location = new Point(pnl_payment.Location.X + pnl_payment.Width, orderLabel.Location.Y);
         lstVw_cartSummary.Height = lbl_Total.Location.Y - orderLabel.Location.Y + lbl_Total.Height;
         lbl_cartSummary.Visible = false;
         pnl_summary.Visible = true;
         btn_ArrowDown.Visible = false;
         btn_ArrowUp.Visible = false;
      }

      private void btnPay_Click(object sender, EventArgs e)
      {
         if (ConfirmCard())
         {
            List<string> order = lstVw_cartSummary.Items.Cast<ListViewItem>()
               .Select(item => item.Text).ToList();
            foreach (string s in order)
            {
               if (!s.Contains('+'))
                  orderController.ProcessOrder(s);
            }

            OrderController.SaveOrder(orderController.getCurrentOrder());

            orderController.createNewOrder();
            refreshCartSummary();
            categoryBtnBox.Visible = true;
            foreach (Control con in pnl_summary.Controls)
               con.Visible = true;
            pnl_payment.Visible = false;
            pnl_summary.Location = new Point(categoryBtnBox.Location.X + categoryBtnBox.Width, categoryBtnBox.Location.Y);



            lstVw_cartSummary.Width = (int)(this.Width * .30);
            lstVw_cartSummary.Height = (int)(this.Height * .60) - CORRECTION * 3;
            lstVw_cartSummary.Location = new Point(0, btn_ArrowUp.Height + btn_ArrowUp.Location.Y + CORRECTION);
            btn_checkout.Visible = true;
            updateSubTotal(0.0f);
            ClearCard();
         }
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

         lbl_prc_subtotal.Text = "$" + subTotal.ToString("0.00");
         lbl_prc_tip.Text = "$" + tipTotal.ToString("0.00");
         lbl_prc_total.Text = "$" + endTotal.ToString("0.00");
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

         lstVw_cartSummary.Height = (int)(this.Height * .60) - CORRECTION * 3;
         lstVw_cartSummary.Location = new Point(0, btn_ArrowUp.Height + btn_ArrowUp.Location.Y + CORRECTION);
         lstVw_cartSummary.Width = (int)(this.Width * .30);
      }

      /*
       * Clears the credit card information in the checkout window.
       */
      private void ClearCard()
      {
         maskedTextBox1.Clear();
         mTB_cvc.Clear();
         lbl_prc_tip.Text = "$0.00";
      }

      /*
       * Comfirms that the credit card and cvc are valid.
       */
      private bool ConfirmCard()
      {
         return maskedTextBox1.Text.Length == 19 && mTB_cvc.Text.Length == 3 && !maskedTextBox1.Text.Contains(" ");
      }
      

      private void scaling()
      {
         
         lstVw_cartSummary.Width = (int)(this.Width * .30);
         lstVw_cartSummary.Columns[0].Width = (int)(lstVw_cartSummary.Width * .618);
         lstVw_cartSummary.Columns[1].Width = (int)(lstVw_cartSummary.Columns[0].Width * .33);
         
         foreach (Control con in pnl_summary.Controls)
         {
            try
            {
               Button b = (Button)con;
               b.Height = (int)(this.Height * .05);
               if (b.Text == "Checkout")
                  b.Height += b.Height;
               b.Font = new Font(b.Font.FontFamily, (int)(b.Height * .40), b.Font.Style);
               b.Width = lstVw_cartSummary.Width;
            }
            catch (Exception e){}
         }
         btn_checkout.Font = new Font("Ariel", (int)(btn_checkout.Height * .60), FontStyle.Regular);
         btn_ArrowUp.Font = btn_ArrowDown.Font;
         lstVw_cartSummary.Font = new Font("Ariel", (int)(this.Height * .022), FontStyle.Regular);
         txt_subTotal.Font = btn_editCart.Font;
         txt_subTotal.Width = lstVw_cartSummary.Width;
         int spacingY = (int)(this.Height * .01);
         int centerX = (int)(this.Width * .5);
         btn_editCart.Width = (int)(btn_editCart.Width * .309);
         btn_removeCart.Width = btn_editCart.Width;
         pnl_summary.Location = new Point(centerX, 0);
         btn_checkout.Height =(int) (this.Height * .10);
         btn_ArrowUp.Location = new Point(0, spacingY);
         lstVw_cartSummary.Height = (int)(this.Height * .60);
         lstVw_cartSummary.Location = new Point(0, btn_ArrowUp.Location.Y + btn_ArrowUp.Height + spacingY);
         btn_ArrowDown.Location = new Point(0, lstVw_cartSummary.Location.Y +lstVw_cartSummary.Height + spacingY);
         btn_editCart.Location = new Point(lstVw_cartSummary.Width - btn_editCart.Width, btn_ArrowDown.Location.Y + btn_ArrowDown.Height + spacingY);
         btn_removeCart.Location = new Point(0, btn_ArrowDown.Location.Y + btn_ArrowDown.Height + spacingY);
         txt_subTotal.Location = new Point(0, btn_removeCart.Location.Y + btn_removeCart.Height + spacingY);
         btn_checkout.Location = new Point(0, txt_subTotal.Location.Y + txt_subTotal.Height + spacingY);
         categoryBtnBox.Height = (int)(this.Height * .60);
         categoryBtnBox.Width = (int)(this.Width * .30);
         categoryBtnBox.Location = new Point(centerX - categoryBtnBox.Width, btn_ArrowUp.Location.Y + CORRECTION);
         pnl_summary.Width = lstVw_cartSummary.Width;
         
      }

      /*
       * Refreshes the cart summary everytime the order is updated.
       */
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
                  newItem.Font = new Font("Ariel", (int)(this.Height * .018), FontStyle.Regular); 
                  foreach (string option in orderController.getOptionsAndPricesByID(item))
                  {
                     string optionName = option.Split('_')[0];
                     string optionPrice = option.Split('_')[1];

                     newItem = new ListViewItem();
                     newItem.Name = optionName;
                     newItem.Group = group;
                     newItem.Text = "   +" + optionName;

                     newItem.Font = new Font("Ariel",(int)(this.Height * .018), FontStyle.Regular);
                     newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, optionPrice));
                     lstVw_cartSummary.Items.Add(newItem);
                  }
               }
            }
         }
      }
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
            cButton.Font = new Font("Ariel", (int)(height * .15), FontStyle.Regular);
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

         p.X += (categoryBtnBox.Width / 2 - buttonX / 2);
         p.Y = (spacingY + buttonY) * index + CORRECTION;

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
         p.Y = (index / PER_ROW) * (spacingY + smallY) + CORRECTION;
         return p;
      }
      private void txtbox_Item_TextChanged(object sender, EventArgs e)
      {

      }
   }

}