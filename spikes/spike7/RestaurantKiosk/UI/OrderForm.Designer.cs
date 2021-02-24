namespace RestaurantKiosk
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Meals", System.Windows.Forms.HorizontalAlignment.Left);
         System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Drinks", System.Windows.Forms.HorizontalAlignment.Left);
         System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Sides", System.Windows.Forms.HorizontalAlignment.Left);
         System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Burger",
            "$6.99"}, -1);
         System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "  +Lettuce",
            "$0.00"}, -1);
         System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lemonade",
            "$0.99"}, -1);
         this.pnl_ingredients = new System.Windows.Forms.Panel();
         this.grpBx_ingredients = new System.Windows.Forms.GroupBox();
         this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
         this.btn_add = new System.Windows.Forms.Button();
         this.pnl_actions = new System.Windows.Forms.Panel();
         this.pnl_summary = new System.Windows.Forms.Panel();
         this.btn_removeCart = new System.Windows.Forms.Button();
         this.btn_editCart = new System.Windows.Forms.Button();
         this.txt_subTotal = new System.Windows.Forms.TextBox();
         this.btn_checkout = new System.Windows.Forms.Button();
         this.listView1 = new System.Windows.Forms.ListView();
         this.cHdr_menuItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.cHdr_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.lbl_cartSummary = new System.Windows.Forms.Label();
         this.pnl_menu = new System.Windows.Forms.Panel();
         this.grpBx_drinks = new System.Windows.Forms.GroupBox();
         this.btn_water = new System.Windows.Forms.Button();
         this.btn_lemonade = new System.Windows.Forms.Button();
         this.grpBx_sides = new System.Windows.Forms.GroupBox();
         this.btn_fries = new System.Windows.Forms.Button();
         this.btn_friedPickles = new System.Windows.Forms.Button();
         this.grpBx_meals = new System.Windows.Forms.GroupBox();
         this.btn_pizza = new System.Windows.Forms.Button();
         this.btn_burger = new System.Windows.Forms.Button();
         this.grpBx_categories = new System.Windows.Forms.GroupBox();
         this.btn_drinks = new System.Windows.Forms.Button();
         this.btn_sides = new System.Windows.Forms.Button();
         this.btn_meal = new System.Windows.Forms.Button();
         this.btn_logout = new System.Windows.Forms.Button();
         this.pnl_ingredients.SuspendLayout();
         this.grpBx_ingredients.SuspendLayout();
         this.pnl_summary.SuspendLayout();
         this.pnl_menu.SuspendLayout();
         this.grpBx_drinks.SuspendLayout();
         this.grpBx_sides.SuspendLayout();
         this.grpBx_meals.SuspendLayout();
         this.grpBx_categories.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnl_ingredients
         // 
         this.pnl_ingredients.Controls.Add(this.grpBx_ingredients);
         this.pnl_ingredients.Controls.Add(this.btn_add);
         this.pnl_ingredients.Location = new System.Drawing.Point(2058, 80);
         this.pnl_ingredients.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.pnl_ingredients.Name = "pnl_ingredients";
         this.pnl_ingredients.Size = new System.Drawing.Size(1099, 1346);
         this.pnl_ingredients.TabIndex = 7;
         // 
         // grpBx_ingredients
         // 
         this.grpBx_ingredients.Controls.Add(this.checkedListBox1);
         this.grpBx_ingredients.Location = new System.Drawing.Point(13, 11);
         this.grpBx_ingredients.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_ingredients.Name = "grpBx_ingredients";
         this.grpBx_ingredients.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_ingredients.Size = new System.Drawing.Size(1077, 1181);
         this.grpBx_ingredients.TabIndex = 1;
         this.grpBx_ingredients.TabStop = false;
         this.grpBx_ingredients.Text = "Custom Group Box";
         // 
         // checkedListBox1
         // 
         this.checkedListBox1.BackColor = System.Drawing.Color.LightSlateGray;
         this.checkedListBox1.FormattingEnabled = true;
         this.checkedListBox1.Items.AddRange(new object[] {
            "Lettuce",
            "Tomato",
            "Pickles",
            "Onions",
            "Cheese"});
         this.checkedListBox1.Location = new System.Drawing.Point(19, 54);
         this.checkedListBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.checkedListBox1.Name = "checkedListBox1";
         this.checkedListBox1.Size = new System.Drawing.Size(1030, 1057);
         this.checkedListBox1.TabIndex = 0;
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(614, 1210);
         this.btn_add.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(475, 128);
         this.btn_add.TabIndex = 0;
         this.btn_add.Text = "Add to Order";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // pnl_actions
         // 
         this.pnl_actions.Location = new System.Drawing.Point(263, 1190);
         this.pnl_actions.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.pnl_actions.Name = "pnl_actions";
         this.pnl_actions.Size = new System.Drawing.Size(1773, 236);
         this.pnl_actions.TabIndex = 6;
         this.pnl_actions.Tag = "";
         // 
         // pnl_summary
         // 
         this.pnl_summary.Controls.Add(this.btn_removeCart);
         this.pnl_summary.Controls.Add(this.btn_editCart);
         this.pnl_summary.Controls.Add(this.txt_subTotal);
         this.pnl_summary.Controls.Add(this.btn_checkout);
         this.pnl_summary.Controls.Add(this.listView1);
         this.pnl_summary.Controls.Add(this.lbl_cartSummary);
         this.pnl_summary.Location = new System.Drawing.Point(3176, 80);
         this.pnl_summary.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.pnl_summary.Name = "pnl_summary";
         this.pnl_summary.Size = new System.Drawing.Size(760, 1346);
         this.pnl_summary.TabIndex = 5;
         // 
         // btn_removeCart
         // 
         this.btn_removeCart.Location = new System.Drawing.Point(513, 1053);
         this.btn_removeCart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_removeCart.Name = "btn_removeCart";
         this.btn_removeCart.Size = new System.Drawing.Size(238, 65);
         this.btn_removeCart.TabIndex = 5;
         this.btn_removeCart.Text = "Remove";
         this.btn_removeCart.UseVisualStyleBackColor = true;
         // 
         // btn_editCart
         // 
         this.btn_editCart.Location = new System.Drawing.Point(10, 1053);
         this.btn_editCart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_editCart.Name = "btn_editCart";
         this.btn_editCart.Size = new System.Drawing.Size(238, 65);
         this.btn_editCart.TabIndex = 4;
         this.btn_editCart.Text = "Edit";
         this.btn_editCart.UseVisualStyleBackColor = true;
         // 
         // txt_subTotal
         // 
         this.txt_subTotal.Location = new System.Drawing.Point(10, 1136);
         this.txt_subTotal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.txt_subTotal.Name = "txt_subTotal";
         this.txt_subTotal.Size = new System.Drawing.Size(732, 44);
         this.txt_subTotal.TabIndex = 3;
         this.txt_subTotal.Text = "Sub-Total: To Be Calculated";
         // 
         // btn_checkout
         // 
         this.btn_checkout.Location = new System.Drawing.Point(342, 1235);
         this.btn_checkout.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_checkout.Name = "btn_checkout";
         this.btn_checkout.Size = new System.Drawing.Size(409, 102);
         this.btn_checkout.TabIndex = 2;
         this.btn_checkout.Text = "Checkout";
         this.btn_checkout.UseVisualStyleBackColor = true;
         // 
         // listView1
         // 
         this.listView1.BackColor = System.Drawing.Color.White;
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHdr_menuItem,
            this.cHdr_price});
         listViewGroup1.Header = "Meals";
         listViewGroup1.Name = "Meals";
         listViewGroup2.Header = "Drinks";
         listViewGroup2.Name = "Drinks";
         listViewGroup3.Header = "Sides";
         listViewGroup3.Name = "Sides";
         this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
         listViewItem1.Group = listViewGroup1;
         listViewItem2.Group = listViewGroup1;
         listViewItem3.Group = listViewGroup2;
         this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
         this.listView1.Location = new System.Drawing.Point(10, 102);
         this.listView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(732, 926);
         this.listView1.TabIndex = 1;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         // 
         // cHdr_menuItem
         // 
         this.cHdr_menuItem.Text = "Menu Item";
         this.cHdr_menuItem.Width = 136;
         // 
         // cHdr_price
         // 
         this.cHdr_price.Text = "Price";
         this.cHdr_price.Width = 94;
         // 
         // lbl_cartSummary
         // 
         this.lbl_cartSummary.AutoSize = true;
         this.lbl_cartSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_cartSummary.ForeColor = System.Drawing.Color.LightBlue;
         this.lbl_cartSummary.Location = new System.Drawing.Point(57, 0);
         this.lbl_cartSummary.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
         this.lbl_cartSummary.Name = "lbl_cartSummary";
         this.lbl_cartSummary.Size = new System.Drawing.Size(600, 98);
         this.lbl_cartSummary.TabIndex = 0;
         this.lbl_cartSummary.Text = "Cart Summary";
         // 
         // pnl_menu
         // 
         this.pnl_menu.Controls.Add(this.grpBx_drinks);
         this.pnl_menu.Controls.Add(this.grpBx_sides);
         this.pnl_menu.Controls.Add(this.grpBx_meals);
         this.pnl_menu.Controls.Add(this.grpBx_categories);
         this.pnl_menu.Location = new System.Drawing.Point(263, 80);
         this.pnl_menu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.pnl_menu.Name = "pnl_menu";
         this.pnl_menu.Size = new System.Drawing.Size(1773, 1090);
         this.pnl_menu.TabIndex = 4;
         // 
         // grpBx_drinks
         // 
         this.grpBx_drinks.Controls.Add(this.btn_water);
         this.grpBx_drinks.Controls.Add(this.btn_lemonade);
         this.grpBx_drinks.Location = new System.Drawing.Point(586, 780);
         this.grpBx_drinks.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_drinks.Name = "grpBx_drinks";
         this.grpBx_drinks.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_drinks.Size = new System.Drawing.Size(1178, 302);
         this.grpBx_drinks.TabIndex = 3;
         this.grpBx_drinks.TabStop = false;
         this.grpBx_drinks.Text = "Drinks";
         // 
         // btn_water
         // 
         this.btn_water.Location = new System.Drawing.Point(789, 54);
         this.btn_water.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_water.Name = "btn_water";
         this.btn_water.Size = new System.Drawing.Size(260, 202);
         this.btn_water.TabIndex = 3;
         this.btn_water.Text = "Water";
         this.btn_water.UseVisualStyleBackColor = true;
         // 
         // btn_lemonade
         // 
         this.btn_lemonade.Location = new System.Drawing.Point(158, 54);
         this.btn_lemonade.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_lemonade.Name = "btn_lemonade";
         this.btn_lemonade.Size = new System.Drawing.Size(260, 202);
         this.btn_lemonade.TabIndex = 2;
         this.btn_lemonade.Text = "Lemonade";
         this.btn_lemonade.UseVisualStyleBackColor = true;
         // 
         // grpBx_sides
         // 
         this.grpBx_sides.Controls.Add(this.btn_fries);
         this.grpBx_sides.Controls.Add(this.btn_friedPickles);
         this.grpBx_sides.Location = new System.Drawing.Point(586, 407);
         this.grpBx_sides.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_sides.Name = "grpBx_sides";
         this.grpBx_sides.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_sides.Size = new System.Drawing.Size(1178, 302);
         this.grpBx_sides.TabIndex = 2;
         this.grpBx_sides.TabStop = false;
         this.grpBx_sides.Text = "Sides";
         // 
         // btn_fries
         // 
         this.btn_fries.Location = new System.Drawing.Point(789, 54);
         this.btn_fries.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_fries.Name = "btn_fries";
         this.btn_fries.Size = new System.Drawing.Size(260, 202);
         this.btn_fries.TabIndex = 2;
         this.btn_fries.Text = "Fries";
         this.btn_fries.UseVisualStyleBackColor = true;
         // 
         // btn_friedPickles
         // 
         this.btn_friedPickles.Location = new System.Drawing.Point(158, 51);
         this.btn_friedPickles.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_friedPickles.Name = "btn_friedPickles";
         this.btn_friedPickles.Size = new System.Drawing.Size(260, 202);
         this.btn_friedPickles.TabIndex = 1;
         this.btn_friedPickles.Text = "Fried Pickles";
         this.btn_friedPickles.UseVisualStyleBackColor = true;
         // 
         // grpBx_meals
         // 
         this.grpBx_meals.Controls.Add(this.btn_pizza);
         this.grpBx_meals.Controls.Add(this.btn_burger);
         this.grpBx_meals.Location = new System.Drawing.Point(586, 11);
         this.grpBx_meals.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_meals.Name = "grpBx_meals";
         this.grpBx_meals.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_meals.Size = new System.Drawing.Size(1178, 299);
         this.grpBx_meals.TabIndex = 1;
         this.grpBx_meals.TabStop = false;
         this.grpBx_meals.Text = "Meals";
         // 
         // btn_pizza
         // 
         this.btn_pizza.Location = new System.Drawing.Point(789, 54);
         this.btn_pizza.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_pizza.Name = "btn_pizza";
         this.btn_pizza.Size = new System.Drawing.Size(260, 202);
         this.btn_pizza.TabIndex = 1;
         this.btn_pizza.Text = "Pizza";
         this.btn_pizza.UseVisualStyleBackColor = true;
         // 
         // btn_burger
         // 
         this.btn_burger.Location = new System.Drawing.Point(158, 54);
         this.btn_burger.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_burger.Name = "btn_burger";
         this.btn_burger.Size = new System.Drawing.Size(260, 202);
         this.btn_burger.TabIndex = 0;
         this.btn_burger.Text = "Burger";
         this.btn_burger.UseVisualStyleBackColor = true;
         this.btn_burger.Click += new System.EventHandler(this.btn_burger_Click);
         // 
         // grpBx_categories
         // 
         this.grpBx_categories.Controls.Add(this.btn_drinks);
         this.grpBx_categories.Controls.Add(this.btn_sides);
         this.grpBx_categories.Controls.Add(this.btn_meal);
         this.grpBx_categories.Location = new System.Drawing.Point(13, 11);
         this.grpBx_categories.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_categories.Name = "grpBx_categories";
         this.grpBx_categories.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.grpBx_categories.Size = new System.Drawing.Size(551, 1070);
         this.grpBx_categories.TabIndex = 0;
         this.grpBx_categories.TabStop = false;
         // 
         // btn_drinks
         // 
         this.btn_drinks.Location = new System.Drawing.Point(19, 882);
         this.btn_drinks.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_drinks.Name = "btn_drinks";
         this.btn_drinks.Size = new System.Drawing.Size(513, 171);
         this.btn_drinks.TabIndex = 3;
         this.btn_drinks.Text = "Drinks";
         this.btn_drinks.UseVisualStyleBackColor = true;
         this.btn_drinks.Click += new System.EventHandler(this.btn_drinks_Click);
         // 
         // btn_sides
         // 
         this.btn_sides.Location = new System.Drawing.Point(19, 478);
         this.btn_sides.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_sides.Name = "btn_sides";
         this.btn_sides.Size = new System.Drawing.Size(513, 171);
         this.btn_sides.TabIndex = 2;
         this.btn_sides.Text = "Sides";
         this.btn_sides.UseVisualStyleBackColor = true;
         this.btn_sides.Click += new System.EventHandler(this.btn_sides_Click);
         // 
         // btn_meal
         // 
         this.btn_meal.Location = new System.Drawing.Point(19, 54);
         this.btn_meal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_meal.Name = "btn_meal";
         this.btn_meal.Size = new System.Drawing.Size(513, 171);
         this.btn_meal.TabIndex = 0;
         this.btn_meal.Text = "Meals";
         this.btn_meal.UseVisualStyleBackColor = true;
         this.btn_meal.Click += new System.EventHandler(this.btn_meal_Click);
         // 
         // btn_logout
         // 
         this.btn_logout.Location = new System.Drawing.Point(38, 34);
         this.btn_logout.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_logout.Name = "btn_logout";
         this.btn_logout.Size = new System.Drawing.Size(181, 139);
         this.btn_logout.TabIndex = 8;
         this.btn_logout.Text = "Logout";
         this.btn_logout.UseVisualStyleBackColor = true;
         this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
         // 
         // OrderForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSlateGray;
         this.ClientSize = new System.Drawing.Size(3880, 1543);
         this.Controls.Add(this.btn_logout);
         this.Controls.Add(this.pnl_ingredients);
         this.Controls.Add(this.pnl_actions);
         this.Controls.Add(this.pnl_summary);
         this.Controls.Add(this.pnl_menu);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.Name = "OrderForm";
         this.Text = "OrderForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.OrderForm_Load);
         this.pnl_ingredients.ResumeLayout(false);
         this.grpBx_ingredients.ResumeLayout(false);
         this.pnl_summary.ResumeLayout(false);
         this.pnl_summary.PerformLayout();
         this.pnl_menu.ResumeLayout(false);
         this.grpBx_drinks.ResumeLayout(false);
         this.grpBx_sides.ResumeLayout(false);
         this.grpBx_meals.ResumeLayout(false);
         this.grpBx_categories.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ingredients;
        private System.Windows.Forms.GroupBox grpBx_ingredients;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_actions;
        private System.Windows.Forms.Panel pnl_summary;
        private System.Windows.Forms.Button btn_removeCart;
        private System.Windows.Forms.Button btn_editCart;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cHdr_menuItem;
        private System.Windows.Forms.ColumnHeader cHdr_price;
        private System.Windows.Forms.Label lbl_cartSummary;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.GroupBox grpBx_drinks;
        private System.Windows.Forms.Button btn_water;
        private System.Windows.Forms.Button btn_lemonade;
        private System.Windows.Forms.GroupBox grpBx_sides;
        private System.Windows.Forms.Button btn_fries;
        private System.Windows.Forms.Button btn_friedPickles;
        private System.Windows.Forms.GroupBox grpBx_meals;
        private System.Windows.Forms.Button btn_pizza;
        private System.Windows.Forms.Button btn_burger;
        private System.Windows.Forms.GroupBox grpBx_categories;
        private System.Windows.Forms.Button btn_drinks;
        private System.Windows.Forms.Button btn_sides;
        private System.Windows.Forms.Button btn_meal;
      private System.Windows.Forms.Button btn_logout;
   }
}