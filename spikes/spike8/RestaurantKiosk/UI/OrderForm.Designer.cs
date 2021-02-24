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
         System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Meals", System.Windows.Forms.HorizontalAlignment.Left);
         System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Drinks", System.Windows.Forms.HorizontalAlignment.Left);
         System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Sides", System.Windows.Forms.HorizontalAlignment.Left);
         System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Burger",
            "$6.99"}, -1);
         System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "  +Lettuce",
            "$0.00"}, -1);
         System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lemonade",
            "$0.99"}, -1);
         this.pnl_ingredients = new System.Windows.Forms.Panel();
         this.grpBx_ingredients = new System.Windows.Forms.GroupBox();
         this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
         this.pnl_summary = new System.Windows.Forms.Panel();
         this.btn_removeCart = new System.Windows.Forms.Button();
         this.btn_editCart = new System.Windows.Forms.Button();
         this.txt_subTotal = new System.Windows.Forms.TextBox();
         this.btn_checkout = new System.Windows.Forms.Button();
         this.lstVw_cartSummary = new System.Windows.Forms.ListView();
         this.cHdr_menuItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.cHdr_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.lbl_cartSummary = new System.Windows.Forms.Label();
         this.btn_logout = new System.Windows.Forms.Button();
         this.txtbox_description = new System.Windows.Forms.RichTextBox();
         this.payment_pnl = new System.Windows.Forms.Panel();
         this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
         this.btn_tip20 = new System.Windows.Forms.Button();
         this.btn_tip15 = new System.Windows.Forms.Button();
         this.btn_tip10 = new System.Windows.Forms.Button();
         this.btn_tip5 = new System.Windows.Forms.Button();
         this.btn_tip0 = new System.Windows.Forms.Button();
         this.lbl_subtotal = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.btn_processPay = new System.Windows.Forms.Button();
         this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
         this.pnl_ingredients.SuspendLayout();
         this.grpBx_ingredients.SuspendLayout();
         this.pnl_summary.SuspendLayout();
         this.payment_pnl.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnl_ingredients
         // 
         this.pnl_ingredients.Controls.Add(this.grpBx_ingredients);
         this.pnl_ingredients.Location = new System.Drawing.Point(529, 44);
         this.pnl_ingredients.Name = "pnl_ingredients";
         this.pnl_ingredients.Size = new System.Drawing.Size(347, 425);
         this.pnl_ingredients.TabIndex = 7;
         this.pnl_ingredients.Visible = false;
         // 
         // grpBx_ingredients
         // 
         this.grpBx_ingredients.Controls.Add(this.checkedListBox1);
         this.grpBx_ingredients.Location = new System.Drawing.Point(3, 7);
         this.grpBx_ingredients.Name = "grpBx_ingredients";
         this.grpBx_ingredients.Size = new System.Drawing.Size(340, 415);
         this.grpBx_ingredients.TabIndex = 1;
         this.grpBx_ingredients.TabStop = false;
         this.grpBx_ingredients.Text = "Custom Group Box";
         this.grpBx_ingredients.Visible = false;
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
         this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
         this.checkedListBox1.Name = "checkedListBox1";
         this.checkedListBox1.Size = new System.Drawing.Size(328, 349);
         this.checkedListBox1.TabIndex = 0;
         // 
         // pnl_summary
         // 
         this.pnl_summary.Controls.Add(this.btn_removeCart);
         this.pnl_summary.Controls.Add(this.btn_editCart);
         this.pnl_summary.Controls.Add(this.txt_subTotal);
         this.pnl_summary.Controls.Add(this.btn_checkout);
         this.pnl_summary.Controls.Add(this.lstVw_cartSummary);
         this.pnl_summary.Controls.Add(this.lbl_cartSummary);
         this.pnl_summary.Location = new System.Drawing.Point(882, 17);
         this.pnl_summary.Name = "pnl_summary";
         this.pnl_summary.Size = new System.Drawing.Size(240, 473);
         this.pnl_summary.TabIndex = 5;
         // 
         // btn_removeCart
         // 
         this.btn_removeCart.Location = new System.Drawing.Point(162, 365);
         this.btn_removeCart.Name = "btn_removeCart";
         this.btn_removeCart.Size = new System.Drawing.Size(75, 27);
         this.btn_removeCart.TabIndex = 5;
         this.btn_removeCart.Text = "Remove";
         this.btn_removeCart.UseVisualStyleBackColor = true;
         this.btn_removeCart.Click += new System.EventHandler(this.btn_removeCart_Click);
         // 
         // btn_editCart
         // 
         this.btn_editCart.Location = new System.Drawing.Point(3, 365);
         this.btn_editCart.Name = "btn_editCart";
         this.btn_editCart.Size = new System.Drawing.Size(75, 27);
         this.btn_editCart.TabIndex = 4;
         this.btn_editCart.Text = "Edit";
         this.btn_editCart.UseVisualStyleBackColor = true;
         // 
         // txt_subTotal
         // 
         this.txt_subTotal.Location = new System.Drawing.Point(3, 399);
         this.txt_subTotal.Name = "txt_subTotal";
         this.txt_subTotal.ReadOnly = true;
         this.txt_subTotal.Size = new System.Drawing.Size(234, 20);
         this.txt_subTotal.TabIndex = 3;
         this.txt_subTotal.Text = "Sub-Total: To Be Calculated";
         // 
         // btn_checkout
         // 
         this.btn_checkout.Location = new System.Drawing.Point(3, 422);
         this.btn_checkout.Name = "btn_checkout";
         this.btn_checkout.Size = new System.Drawing.Size(235, 47);
         this.btn_checkout.TabIndex = 2;
         this.btn_checkout.Text = "Checkout";
         this.btn_checkout.UseVisualStyleBackColor = true;
         this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
         // 
         // lstVw_cartSummary
         // 
         this.lstVw_cartSummary.BackColor = System.Drawing.Color.White;
         this.lstVw_cartSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHdr_menuItem,
            this.cHdr_price});
         listViewGroup4.Header = "Meals";
         listViewGroup4.Name = "Meals";
         listViewGroup5.Header = "Drinks";
         listViewGroup5.Name = "Drinks";
         listViewGroup6.Header = "Sides";
         listViewGroup6.Name = "Sides";
         this.lstVw_cartSummary.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
         listViewItem4.UseItemStyleForSubItems = false;
         listViewItem5.StateImageIndex = 0;
         this.lstVw_cartSummary.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
         this.lstVw_cartSummary.Location = new System.Drawing.Point(3, 36);
         this.lstVw_cartSummary.Name = "lstVw_cartSummary";
         this.lstVw_cartSummary.Size = new System.Drawing.Size(234, 328);
         this.lstVw_cartSummary.TabIndex = 1;
         this.lstVw_cartSummary.UseCompatibleStateImageBehavior = false;
         this.lstVw_cartSummary.View = System.Windows.Forms.View.Details;
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
         this.lbl_cartSummary.Location = new System.Drawing.Point(18, 0);
         this.lbl_cartSummary.Name = "lbl_cartSummary";
         this.lbl_cartSummary.Size = new System.Drawing.Size(204, 33);
         this.lbl_cartSummary.TabIndex = 0;
         this.lbl_cartSummary.Text = "Cart Summary";
         // 
         // btn_logout
         // 
         this.btn_logout.Location = new System.Drawing.Point(12, 35);
         this.btn_logout.Name = "btn_logout";
         this.btn_logout.Size = new System.Drawing.Size(57, 26);
         this.btn_logout.TabIndex = 8;
         this.btn_logout.Text = "Logout";
         this.btn_logout.UseVisualStyleBackColor = true;
         this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
         // 
         // txtbox_description
         // 
         this.txtbox_description.Location = new System.Drawing.Point(386, 593);
         this.txtbox_description.Name = "txtbox_description";
         this.txtbox_description.ReadOnly = true;
         this.txtbox_description.Size = new System.Drawing.Size(240, 128);
         this.txtbox_description.TabIndex = 0;
         this.txtbox_description.Text = "";
         // 
         // payment_pnl
         // 
         this.payment_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.payment_pnl.BackColor = System.Drawing.Color.Teal;
         this.payment_pnl.Controls.Add(this.maskedTextBox2);
         this.payment_pnl.Controls.Add(this.maskedTextBox1);
         this.payment_pnl.Controls.Add(this.btn_tip20);
         this.payment_pnl.Controls.Add(this.btn_tip15);
         this.payment_pnl.Controls.Add(this.btn_tip10);
         this.payment_pnl.Controls.Add(this.btn_tip5);
         this.payment_pnl.Controls.Add(this.btn_tip0);
         this.payment_pnl.Controls.Add(this.lbl_subtotal);
         this.payment_pnl.Controls.Add(this.label1);
         this.payment_pnl.Controls.Add(this.btn_processPay);
         this.payment_pnl.Location = new System.Drawing.Point(75, 35);
         this.payment_pnl.Name = "payment_pnl";
         this.payment_pnl.Size = new System.Drawing.Size(392, 653);
         this.payment_pnl.TabIndex = 9;
         // 
         // maskedTextBox1
         // 
         this.maskedTextBox1.Location = new System.Drawing.Point(30, 326);
         this.maskedTextBox1.Mask = "0000-0000-0000-0000";
         this.maskedTextBox1.Name = "maskedTextBox1";
         this.maskedTextBox1.Size = new System.Drawing.Size(116, 20);
         this.maskedTextBox1.TabIndex = 13;
         this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // btn_tip20
         // 
         this.btn_tip20.Location = new System.Drawing.Point(299, 81);
         this.btn_tip20.Name = "btn_tip20";
         this.btn_tip20.Size = new System.Drawing.Size(64, 57);
         this.btn_tip20.TabIndex = 12;
         this.btn_tip20.Text = "20%";
         this.btn_tip20.UseVisualStyleBackColor = true;
         this.btn_tip20.Click += new System.EventHandler(this.btn_tip20_Click);
         // 
         // btn_tip15
         // 
         this.btn_tip15.Location = new System.Drawing.Point(229, 81);
         this.btn_tip15.Name = "btn_tip15";
         this.btn_tip15.Size = new System.Drawing.Size(64, 57);
         this.btn_tip15.TabIndex = 11;
         this.btn_tip15.Text = "15%";
         this.btn_tip15.UseVisualStyleBackColor = true;
         this.btn_tip15.Click += new System.EventHandler(this.btn_tip15_Click);
         // 
         // btn_tip10
         // 
         this.btn_tip10.Location = new System.Drawing.Point(159, 81);
         this.btn_tip10.Name = "btn_tip10";
         this.btn_tip10.Size = new System.Drawing.Size(64, 57);
         this.btn_tip10.TabIndex = 10;
         this.btn_tip10.Text = "10%";
         this.btn_tip10.UseVisualStyleBackColor = true;
         this.btn_tip10.Click += new System.EventHandler(this.btn_tip10_Click);
         // 
         // btn_tip5
         // 
         this.btn_tip5.Location = new System.Drawing.Point(89, 81);
         this.btn_tip5.Name = "btn_tip5";
         this.btn_tip5.Size = new System.Drawing.Size(64, 57);
         this.btn_tip5.TabIndex = 7;
         this.btn_tip5.Text = "5%";
         this.btn_tip5.UseVisualStyleBackColor = true;
         this.btn_tip5.Click += new System.EventHandler(this.btn_tip5_Click);
         // 
         // btn_tip0
         // 
         this.btn_tip0.Location = new System.Drawing.Point(19, 81);
         this.btn_tip0.Name = "btn_tip0";
         this.btn_tip0.Size = new System.Drawing.Size(64, 57);
         this.btn_tip0.TabIndex = 6;
         this.btn_tip0.Text = "0%";
         this.btn_tip0.UseVisualStyleBackColor = true;
         this.btn_tip0.Click += new System.EventHandler(this.btn_tip0_Click);
         // 
         // lbl_subtotal
         // 
         this.lbl_subtotal.AutoSize = true;
         this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_subtotal.ForeColor = System.Drawing.Color.White;
         this.lbl_subtotal.Location = new System.Drawing.Point(245, 49);
         this.lbl_subtotal.Name = "lbl_subtotal";
         this.lbl_subtotal.Size = new System.Drawing.Size(65, 29);
         this.lbl_subtotal.TabIndex = 5;
         this.lbl_subtotal.Text = "1111";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(109, 49);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(143, 29);
         this.label1.TabIndex = 1;
         this.label1.Text = "Order Total:";
         // 
         // btn_processPay
         // 
         this.btn_processPay.BackColor = System.Drawing.Color.DarkSlateGray;
         this.btn_processPay.FlatAppearance.BorderSize = 0;
         this.btn_processPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn_processPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_processPay.ForeColor = System.Drawing.Color.White;
         this.btn_processPay.Location = new System.Drawing.Point(19, 404);
         this.btn_processPay.Name = "btn_processPay";
         this.btn_processPay.Size = new System.Drawing.Size(223, 51);
         this.btn_processPay.TabIndex = 0;
         this.btn_processPay.Text = "Process Payment";
         this.btn_processPay.UseVisualStyleBackColor = false;
         this.btn_processPay.Click += new System.EventHandler(this.btn_processPay_Click);
         // 
         // maskedTextBox2
         // 
         this.maskedTextBox2.Location = new System.Drawing.Point(153, 325);
         this.maskedTextBox2.Mask = "000";
         this.maskedTextBox2.Name = "maskedTextBox2";
         this.maskedTextBox2.Size = new System.Drawing.Size(25, 20);
         this.maskedTextBox2.TabIndex = 14;
         this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // OrderForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSlateGray;
         this.ClientSize = new System.Drawing.Size(1134, 733);
         this.Controls.Add(this.payment_pnl);
         this.Controls.Add(this.txtbox_description);
         this.Controls.Add(this.btn_logout);
         this.Controls.Add(this.pnl_ingredients);
         this.Controls.Add(this.pnl_summary);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "OrderForm";
         this.Text = "OrderForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
         this.Load += new System.EventHandler(this.OrderForm_Load);
         this.Resize += new System.EventHandler(this.OrderForm_Resize);
         this.pnl_ingredients.ResumeLayout(false);
         this.grpBx_ingredients.ResumeLayout(false);
         this.pnl_summary.ResumeLayout(false);
         this.pnl_summary.PerformLayout();
         this.payment_pnl.ResumeLayout(false);
         this.payment_pnl.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ingredients;
        private System.Windows.Forms.GroupBox grpBx_ingredients;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel pnl_summary;
        private System.Windows.Forms.Button btn_removeCart;
        private System.Windows.Forms.Button btn_editCart;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ListView lstVw_cartSummary;
        private System.Windows.Forms.ColumnHeader cHdr_menuItem;
        private System.Windows.Forms.ColumnHeader cHdr_price;
        private System.Windows.Forms.Label lbl_cartSummary;
      private System.Windows.Forms.Button btn_logout;
      private System.Windows.Forms.RichTextBox txtbox_description;
      private System.Windows.Forms.Panel payment_pnl;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btn_processPay;
      private System.Windows.Forms.Label lbl_subtotal;
      private System.Windows.Forms.Button btn_tip20;
      private System.Windows.Forms.Button btn_tip15;
      private System.Windows.Forms.Button btn_tip10;
      private System.Windows.Forms.Button btn_tip5;
      private System.Windows.Forms.Button btn_tip0;
      private System.Windows.Forms.MaskedTextBox maskedTextBox1;
      private System.Windows.Forms.MaskedTextBox maskedTextBox2;
   }
}