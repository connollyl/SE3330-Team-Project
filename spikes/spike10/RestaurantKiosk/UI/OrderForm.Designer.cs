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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
         this.pnl_summary = new System.Windows.Forms.Panel();
         this.txtbox_description = new System.Windows.Forms.TextBox();
         this.btn_ArrowDown = new System.Windows.Forms.Button();
         this.btn_removeCart = new System.Windows.Forms.Button();
         this.btn_editCart = new System.Windows.Forms.Button();
         this.btn_ArrowUp = new System.Windows.Forms.Button();
         this.txt_subTotal = new System.Windows.Forms.TextBox();
         this.btn_checkout = new System.Windows.Forms.Button();
         this.lstVw_cartSummary = new System.Windows.Forms.ListView();
         this.cHdr_menuItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.cHdr_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.lbl_cartSummary = new System.Windows.Forms.Label();
         this.pnl_payment = new System.Windows.Forms.Panel();
         this.label11 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.lbl_prc_total = new System.Windows.Forms.Label();
         this.lbl_Total = new System.Windows.Forms.Label();
         this.lbl_prc_tip = new System.Windows.Forms.Label();
         this.lbl_tip = new System.Windows.Forms.Label();
         this.lbl_prc_tax = new System.Windows.Forms.Label();
         this.lbl_tax = new System.Windows.Forms.Label();
         this.lbl_prc_subtotal = new System.Windows.Forms.Label();
         this.lbl_subtotal = new System.Windows.Forms.Label();
         this.btn_cancel = new System.Windows.Forms.Button();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.mTB_cvc = new System.Windows.Forms.MaskedTextBox();
         this.rchTxtBx_Comments = new System.Windows.Forms.RichTextBox();
         this.lbl_comment = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.trckBr_review = new System.Windows.Forms.TrackBar();
         this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
         this.btnPay = new System.Windows.Forms.Button();
         this.btnPercentTwenty = new System.Windows.Forms.Button();
         this.btnPercentFifteen = new System.Windows.Forms.Button();
         this.btnPercentTen = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.btnPercentZero = new System.Windows.Forms.Button();
         this.totalLabel = new System.Windows.Forms.Label();
         this.orderLabel = new System.Windows.Forms.Label();
         this.btn_logout = new System.Windows.Forms.Button();
         this.pnl_summary.SuspendLayout();
         this.pnl_payment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trckBr_review)).BeginInit();
         this.SuspendLayout();
         // 
         // pnl_summary
         // 
         this.pnl_summary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.pnl_summary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.pnl_summary.Controls.Add(this.txtbox_description);
         this.pnl_summary.Controls.Add(this.btn_ArrowDown);
         this.pnl_summary.Controls.Add(this.btn_removeCart);
         this.pnl_summary.Controls.Add(this.btn_editCart);
         this.pnl_summary.Controls.Add(this.btn_ArrowUp);
         this.pnl_summary.Controls.Add(this.txt_subTotal);
         this.pnl_summary.Controls.Add(this.btn_checkout);
         this.pnl_summary.Controls.Add(this.lstVw_cartSummary);
         this.pnl_summary.Controls.Add(this.lbl_cartSummary);
         this.pnl_summary.Location = new System.Drawing.Point(710, 0);
         this.pnl_summary.Name = "pnl_summary";
         this.pnl_summary.Size = new System.Drawing.Size(466, 4000);
         this.pnl_summary.TabIndex = 5;
         // 
         // txtbox_description
         // 
         this.txtbox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.txtbox_description.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.txtbox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtbox_description.ForeColor = System.Drawing.Color.White;
         this.txtbox_description.Location = new System.Drawing.Point(0, 3865);
         this.txtbox_description.Multiline = true;
         this.txtbox_description.Name = "txtbox_description";
         this.txtbox_description.Size = new System.Drawing.Size(466, 135);
         this.txtbox_description.TabIndex = 11;
         this.txtbox_description.Text = "<No Description>";
         // 
         // btn_ArrowDown
         // 
         this.btn_ArrowDown.BackColor = System.Drawing.Color.White;
         this.btn_ArrowDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_ArrowDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_ArrowDown.Location = new System.Drawing.Point(0, 658);
         this.btn_ArrowDown.Name = "btn_ArrowDown";
         this.btn_ArrowDown.Size = new System.Drawing.Size(371, 45);
         this.btn_ArrowDown.TabIndex = 7;
         this.btn_ArrowDown.Text = "Down";
         this.btn_ArrowDown.UseVisualStyleBackColor = false;
         this.btn_ArrowDown.Click += new System.EventHandler(this.btn_ArrowDown_Click);
         // 
         // btn_removeCart
         // 
         this.btn_removeCart.BackColor = System.Drawing.Color.White;
         this.btn_removeCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_removeCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_removeCart.Location = new System.Drawing.Point(234, 709);
         this.btn_removeCart.Name = "btn_removeCart";
         this.btn_removeCart.Size = new System.Drawing.Size(137, 56);
         this.btn_removeCart.TabIndex = 5;
         this.btn_removeCart.Text = "Remove";
         this.btn_removeCart.UseVisualStyleBackColor = false;
         this.btn_removeCart.Click += new System.EventHandler(this.btn_removeCart_Click);
         // 
         // btn_editCart
         // 
         this.btn_editCart.BackColor = System.Drawing.Color.White;
         this.btn_editCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_editCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_editCart.Location = new System.Drawing.Point(0, 709);
         this.btn_editCart.Name = "btn_editCart";
         this.btn_editCart.Size = new System.Drawing.Size(134, 56);
         this.btn_editCart.TabIndex = 4;
         this.btn_editCart.Text = "Edit";
         this.btn_editCart.UseVisualStyleBackColor = false;
         this.btn_editCart.Click += new System.EventHandler(this.btn_editCart_Click);
         // 
         // btn_ArrowUp
         // 
         this.btn_ArrowUp.AutoSize = true;
         this.btn_ArrowUp.BackColor = System.Drawing.Color.White;
         this.btn_ArrowUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_ArrowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_ArrowUp.Location = new System.Drawing.Point(0, 30);
         this.btn_ArrowUp.Name = "btn_ArrowUp";
         this.btn_ArrowUp.Size = new System.Drawing.Size(371, 108);
         this.btn_ArrowUp.TabIndex = 6;
         this.btn_ArrowUp.Text = "Up";
         this.btn_ArrowUp.UseVisualStyleBackColor = false;
         this.btn_ArrowUp.Click += new System.EventHandler(this.btn_ArrowUp_Click);
         // 
         // txt_subTotal
         // 
         this.txt_subTotal.BackColor = System.Drawing.Color.White;
         this.txt_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_subTotal.Location = new System.Drawing.Point(0, 776);
         this.txt_subTotal.Name = "txt_subTotal";
         this.txt_subTotal.ReadOnly = true;
         this.txt_subTotal.Size = new System.Drawing.Size(371, 35);
         this.txt_subTotal.TabIndex = 3;
         this.txt_subTotal.Text = "Sub-Total: To Be Calculated";
         // 
         // btn_checkout
         // 
         this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_checkout.ForeColor = System.Drawing.Color.White;
         this.btn_checkout.Location = new System.Drawing.Point(0, 817);
         this.btn_checkout.Name = "btn_checkout";
         this.btn_checkout.Size = new System.Drawing.Size(371, 102);
         this.btn_checkout.TabIndex = 2;
         this.btn_checkout.Text = " Checkout";
         this.btn_checkout.UseVisualStyleBackColor = false;
         this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
         // 
         // lstVw_cartSummary
         // 
         this.lstVw_cartSummary.BackColor = System.Drawing.Color.White;
         this.lstVw_cartSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHdr_menuItem,
            this.cHdr_price});
         this.lstVw_cartSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lstVw_cartSummary.FullRowSelect = true;
         listViewGroup1.Header = "Meals";
         listViewGroup1.Name = "Meals";
         listViewGroup2.Header = "Drinks";
         listViewGroup2.Name = "Drinks";
         listViewGroup3.Header = "Sides";
         listViewGroup3.Name = "Sides";
         this.lstVw_cartSummary.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
         this.lstVw_cartSummary.HideSelection = false;
         listViewItem1.UseItemStyleForSubItems = false;
         listViewItem2.StateImageIndex = 0;
         this.lstVw_cartSummary.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
         this.lstVw_cartSummary.Location = new System.Drawing.Point(0, 81);
         this.lstVw_cartSummary.Name = "lstVw_cartSummary";
         this.lstVw_cartSummary.Size = new System.Drawing.Size(371, 568);
         this.lstVw_cartSummary.TabIndex = 1;
         this.lstVw_cartSummary.UseCompatibleStateImageBehavior = false;
         this.lstVw_cartSummary.View = System.Windows.Forms.View.Details;
         this.lstVw_cartSummary.SelectedIndexChanged += new System.EventHandler(this.lstVw_cartSummary_SelectedIndexChanged);
         // 
         // cHdr_menuItem
         // 
         this.cHdr_menuItem.Text = "Menu Item";
         this.cHdr_menuItem.Width = 275;
         // 
         // cHdr_price
         // 
         this.cHdr_price.Text = "Price";
         this.cHdr_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.cHdr_price.Width = 89;
         // 
         // lbl_cartSummary
         // 
         this.lbl_cartSummary.AutoSize = true;
         this.lbl_cartSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_cartSummary.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.lbl_cartSummary.Location = new System.Drawing.Point(160, 4);
         this.lbl_cartSummary.Name = "lbl_cartSummary";
         this.lbl_cartSummary.Size = new System.Drawing.Size(204, 33);
         this.lbl_cartSummary.TabIndex = 0;
         this.lbl_cartSummary.Text = "Cart Summary";
         this.lbl_cartSummary.Visible = false;
         // 
         // pnl_payment
         // 
         this.pnl_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.pnl_payment.Controls.Add(this.label11);
         this.pnl_payment.Controls.Add(this.label10);
         this.pnl_payment.Controls.Add(this.label9);
         this.pnl_payment.Controls.Add(this.label6);
         this.pnl_payment.Controls.Add(this.label5);
         this.pnl_payment.Controls.Add(this.label4);
         this.pnl_payment.Controls.Add(this.lbl_prc_total);
         this.pnl_payment.Controls.Add(this.lbl_Total);
         this.pnl_payment.Controls.Add(this.lbl_prc_tip);
         this.pnl_payment.Controls.Add(this.lbl_tip);
         this.pnl_payment.Controls.Add(this.lbl_prc_tax);
         this.pnl_payment.Controls.Add(this.lbl_tax);
         this.pnl_payment.Controls.Add(this.lbl_prc_subtotal);
         this.pnl_payment.Controls.Add(this.lbl_subtotal);
         this.pnl_payment.Controls.Add(this.btn_cancel);
         this.pnl_payment.Controls.Add(this.label8);
         this.pnl_payment.Controls.Add(this.label7);
         this.pnl_payment.Controls.Add(this.mTB_cvc);
         this.pnl_payment.Controls.Add(this.rchTxtBx_Comments);
         this.pnl_payment.Controls.Add(this.lbl_comment);
         this.pnl_payment.Controls.Add(this.label3);
         this.pnl_payment.Controls.Add(this.label2);
         this.pnl_payment.Controls.Add(this.trckBr_review);
         this.pnl_payment.Controls.Add(this.maskedTextBox1);
         this.pnl_payment.Controls.Add(this.btnPay);
         this.pnl_payment.Controls.Add(this.btnPercentTwenty);
         this.pnl_payment.Controls.Add(this.btnPercentFifteen);
         this.pnl_payment.Controls.Add(this.btnPercentTen);
         this.pnl_payment.Controls.Add(this.label1);
         this.pnl_payment.Controls.Add(this.btnPercentZero);
         this.pnl_payment.Controls.Add(this.totalLabel);
         this.pnl_payment.Controls.Add(this.orderLabel);
         this.pnl_payment.Location = new System.Drawing.Point(78, 4);
         this.pnl_payment.Name = "pnl_payment";
         this.pnl_payment.Size = new System.Drawing.Size(473, 952);
         this.pnl_payment.TabIndex = 10;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label11.Location = new System.Drawing.Point(448, 251);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(16, 18);
         this.label11.TabIndex = 35;
         this.label11.Text = "5";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label10.Location = new System.Drawing.Point(379, 251);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(16, 18);
         this.label10.TabIndex = 34;
         this.label10.Text = "4";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label9.Location = new System.Drawing.Point(312, 251);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(16, 18);
         this.label9.TabIndex = 33;
         this.label9.Text = "3";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label6.Location = new System.Drawing.Point(242, 251);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(16, 18);
         this.label6.TabIndex = 32;
         this.label6.Text = "2";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label5.Location = new System.Drawing.Point(173, 251);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(16, 18);
         this.label5.TabIndex = 31;
         this.label5.Text = "1";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label4.Location = new System.Drawing.Point(105, 251);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(16, 18);
         this.label4.TabIndex = 30;
         this.label4.Text = "0";
         // 
         // lbl_prc_total
         // 
         this.lbl_prc_total.AutoSize = true;
         this.lbl_prc_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_prc_total.ForeColor = System.Drawing.Color.White;
         this.lbl_prc_total.Location = new System.Drawing.Point(324, 769);
         this.lbl_prc_total.Name = "lbl_prc_total";
         this.lbl_prc_total.Size = new System.Drawing.Size(66, 25);
         this.lbl_prc_total.TabIndex = 29;
         this.lbl_prc_total.Text = "$0.00";
         // 
         // lbl_Total
         // 
         this.lbl_Total.AutoSize = true;
         this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_Total.ForeColor = System.Drawing.Color.White;
         this.lbl_Total.Location = new System.Drawing.Point(24, 769);
         this.lbl_Total.Name = "lbl_Total";
         this.lbl_Total.Size = new System.Drawing.Size(66, 25);
         this.lbl_Total.TabIndex = 28;
         this.lbl_Total.Text = "Total:";
         // 
         // lbl_prc_tip
         // 
         this.lbl_prc_tip.AutoSize = true;
         this.lbl_prc_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_prc_tip.ForeColor = System.Drawing.Color.White;
         this.lbl_prc_tip.Location = new System.Drawing.Point(324, 728);
         this.lbl_prc_tip.Name = "lbl_prc_tip";
         this.lbl_prc_tip.Size = new System.Drawing.Size(66, 25);
         this.lbl_prc_tip.TabIndex = 27;
         this.lbl_prc_tip.Text = "$0.00";
         // 
         // lbl_tip
         // 
         this.lbl_tip.AutoSize = true;
         this.lbl_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_tip.ForeColor = System.Drawing.Color.White;
         this.lbl_tip.Location = new System.Drawing.Point(24, 728);
         this.lbl_tip.Name = "lbl_tip";
         this.lbl_tip.Size = new System.Drawing.Size(48, 25);
         this.lbl_tip.TabIndex = 26;
         this.lbl_tip.Text = "Tip:";
         // 
         // lbl_prc_tax
         // 
         this.lbl_prc_tax.AutoSize = true;
         this.lbl_prc_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_prc_tax.ForeColor = System.Drawing.Color.White;
         this.lbl_prc_tax.Location = new System.Drawing.Point(324, 691);
         this.lbl_prc_tax.Name = "lbl_prc_tax";
         this.lbl_prc_tax.Size = new System.Drawing.Size(66, 25);
         this.lbl_prc_tax.TabIndex = 25;
         this.lbl_prc_tax.Text = "$0.00";
         // 
         // lbl_tax
         // 
         this.lbl_tax.AutoSize = true;
         this.lbl_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_tax.ForeColor = System.Drawing.Color.White;
         this.lbl_tax.Location = new System.Drawing.Point(24, 691);
         this.lbl_tax.Name = "lbl_tax";
         this.lbl_tax.Size = new System.Drawing.Size(54, 25);
         this.lbl_tax.TabIndex = 24;
         this.lbl_tax.Text = "Tax:";
         // 
         // lbl_prc_subtotal
         // 
         this.lbl_prc_subtotal.AutoSize = true;
         this.lbl_prc_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_prc_subtotal.ForeColor = System.Drawing.Color.White;
         this.lbl_prc_subtotal.Location = new System.Drawing.Point(324, 654);
         this.lbl_prc_subtotal.Name = "lbl_prc_subtotal";
         this.lbl_prc_subtotal.Size = new System.Drawing.Size(66, 25);
         this.lbl_prc_subtotal.TabIndex = 23;
         this.lbl_prc_subtotal.Text = "$0.00";
         // 
         // lbl_subtotal
         // 
         this.lbl_subtotal.AutoSize = true;
         this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_subtotal.ForeColor = System.Drawing.Color.White;
         this.lbl_subtotal.Location = new System.Drawing.Point(24, 654);
         this.lbl_subtotal.Name = "lbl_subtotal";
         this.lbl_subtotal.Size = new System.Drawing.Size(111, 25);
         this.lbl_subtotal.TabIndex = 22;
         this.lbl_subtotal.Text = "Sub-Total:";
         // 
         // btn_cancel
         // 
         this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_cancel.ForeColor = System.Drawing.Color.White;
         this.btn_cancel.Location = new System.Drawing.Point(329, 565);
         this.btn_cancel.Name = "btn_cancel";
         this.btn_cancel.Size = new System.Drawing.Size(140, 69);
         this.btn_cancel.TabIndex = 21;
         this.btn_cancel.Text = "Cancel";
         this.btn_cancel.UseVisualStyleBackColor = false;
         this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label8.Location = new System.Drawing.Point(208, 508);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(49, 24);
         this.label8.TabIndex = 19;
         this.label8.Text = "CVC";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label7.Location = new System.Drawing.Point(25, 507);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(119, 24);
         this.label7.TabIndex = 18;
         this.label7.Text = "Credit Card #";
         // 
         // mTB_cvc
         // 
         this.mTB_cvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mTB_cvc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
         this.mTB_cvc.Location = new System.Drawing.Point(212, 535);
         this.mTB_cvc.Mask = "000";
         this.mTB_cvc.Name = "mTB_cvc";
         this.mTB_cvc.Size = new System.Drawing.Size(37, 24);
         this.mTB_cvc.TabIndex = 17;
         // 
         // rchTxtBx_Comments
         // 
         this.rchTxtBx_Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rchTxtBx_Comments.Location = new System.Drawing.Point(29, 323);
         this.rchTxtBx_Comments.Name = "rchTxtBx_Comments";
         this.rchTxtBx_Comments.Size = new System.Drawing.Size(440, 167);
         this.rchTxtBx_Comments.TabIndex = 16;
         this.rchTxtBx_Comments.Text = "";
         // 
         // lbl_comment
         // 
         this.lbl_comment.AutoSize = true;
         this.lbl_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_comment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lbl_comment.Location = new System.Drawing.Point(24, 295);
         this.lbl_comment.Name = "lbl_comment";
         this.lbl_comment.Size = new System.Drawing.Size(245, 25);
         this.lbl_comment.TabIndex = 15;
         this.lbl_comment.Text = "Any Recommendations?";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label3.Location = new System.Drawing.Point(30, 251);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(32, 18);
         this.label3.TabIndex = 11;
         this.label3.Text = "N/A";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.label2.Location = new System.Drawing.Point(30, 196);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(241, 25);
         this.label2.TabIndex = 10;
         this.label2.Text = "How Did We Do Today?";
         // 
         // trckBr_review
         // 
         this.trckBr_review.LargeChange = 1;
         this.trckBr_review.Location = new System.Drawing.Point(30, 224);
         this.trckBr_review.Maximum = 6;
         this.trckBr_review.Name = "trckBr_review";
         this.trckBr_review.Size = new System.Drawing.Size(439, 45);
         this.trckBr_review.TabIndex = 9;
         // 
         // maskedTextBox1
         // 
         this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.maskedTextBox1.Location = new System.Drawing.Point(29, 535);
         this.maskedTextBox1.Mask = "0000-0000-0000-0000";
         this.maskedTextBox1.Name = "maskedTextBox1";
         this.maskedTextBox1.Size = new System.Drawing.Size(152, 24);
         this.maskedTextBox1.TabIndex = 8;
         this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // btnPay
         // 
         this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPay.ForeColor = System.Drawing.Color.White;
         this.btnPay.Location = new System.Drawing.Point(29, 565);
         this.btnPay.Name = "btnPay";
         this.btnPay.Size = new System.Drawing.Size(220, 69);
         this.btnPay.TabIndex = 7;
         this.btnPay.Text = "Process Payment";
         this.btnPay.UseVisualStyleBackColor = false;
         this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
         // 
         // btnPercentTwenty
         // 
         this.btnPercentTwenty.BackColor = System.Drawing.Color.Lime;
         this.btnPercentTwenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnPercentTwenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPercentTwenty.Location = new System.Drawing.Point(365, 116);
         this.btnPercentTwenty.Name = "btnPercentTwenty";
         this.btnPercentTwenty.Size = new System.Drawing.Size(104, 68);
         this.btnPercentTwenty.TabIndex = 6;
         this.btnPercentTwenty.Text = "20%";
         this.btnPercentTwenty.UseVisualStyleBackColor = false;
         this.btnPercentTwenty.Click += new System.EventHandler(this.percentage_Click);
         // 
         // btnPercentFifteen
         // 
         this.btnPercentFifteen.BackColor = System.Drawing.Color.Yellow;
         this.btnPercentFifteen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnPercentFifteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPercentFifteen.Location = new System.Drawing.Point(255, 116);
         this.btnPercentFifteen.Name = "btnPercentFifteen";
         this.btnPercentFifteen.Size = new System.Drawing.Size(104, 68);
         this.btnPercentFifteen.TabIndex = 5;
         this.btnPercentFifteen.Text = "15%";
         this.btnPercentFifteen.UseVisualStyleBackColor = false;
         this.btnPercentFifteen.Click += new System.EventHandler(this.percentage_Click);
         // 
         // btnPercentTen
         // 
         this.btnPercentTen.BackColor = System.Drawing.Color.OrangeRed;
         this.btnPercentTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnPercentTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPercentTen.Location = new System.Drawing.Point(145, 116);
         this.btnPercentTen.Name = "btnPercentTen";
         this.btnPercentTen.Size = new System.Drawing.Size(104, 68);
         this.btnPercentTen.TabIndex = 20;
         this.btnPercentTen.Text = "10%";
         this.btnPercentTen.UseVisualStyleBackColor = false;
         this.btnPercentTen.Click += new System.EventHandler(this.percentage_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(31, 77);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(187, 25);
         this.label1.TabIndex = 3;
         this.label1.Text = "Select Tip Amount";
         // 
         // btnPercentZero
         // 
         this.btnPercentZero.BackColor = System.Drawing.Color.Firebrick;
         this.btnPercentZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnPercentZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPercentZero.Location = new System.Drawing.Point(35, 116);
         this.btnPercentZero.Name = "btnPercentZero";
         this.btnPercentZero.Size = new System.Drawing.Size(104, 68);
         this.btnPercentZero.TabIndex = 2;
         this.btnPercentZero.Text = "0%";
         this.btnPercentZero.UseVisualStyleBackColor = false;
         this.btnPercentZero.Click += new System.EventHandler(this.percentage_Click);
         // 
         // totalLabel
         // 
         this.totalLabel.AutoSize = true;
         this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.totalLabel.ForeColor = System.Drawing.Color.White;
         this.totalLabel.Location = new System.Drawing.Point(154, 26);
         this.totalLabel.Name = "totalLabel";
         this.totalLabel.Size = new System.Drawing.Size(66, 25);
         this.totalLabel.TabIndex = 1;
         this.totalLabel.Text = "$0.00";
         // 
         // orderLabel
         // 
         this.orderLabel.AutoSize = true;
         this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.orderLabel.ForeColor = System.Drawing.Color.White;
         this.orderLabel.Location = new System.Drawing.Point(29, 26);
         this.orderLabel.Name = "orderLabel";
         this.orderLabel.Size = new System.Drawing.Size(126, 25);
         this.orderLabel.TabIndex = 0;
         this.orderLabel.Text = "Order Total:";
         // 
         // btn_logout
         // 
         this.btn_logout.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.btn_logout.Dock = System.Windows.Forms.DockStyle.Right;
         this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_logout.Location = new System.Drawing.Point(1344, 0);
         this.btn_logout.MaximumSize = new System.Drawing.Size(100, 50);
         this.btn_logout.Name = "btn_logout";
         this.btn_logout.Size = new System.Drawing.Size(100, 50);
         this.btn_logout.TabIndex = 0;
         this.btn_logout.Text = "Logout";
         this.btn_logout.UseVisualStyleBackColor = false;
         this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
         // 
         // OrderForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.ClientSize = new System.Drawing.Size(1444, 904);
         this.Controls.Add(this.btn_logout);
         this.Controls.Add(this.pnl_summary);
         this.Controls.Add(this.pnl_payment);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "OrderForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
         this.Resize += new System.EventHandler(this.OrderForm_Resize);
         this.pnl_summary.ResumeLayout(false);
         this.pnl_summary.PerformLayout();
         this.pnl_payment.ResumeLayout(false);
         this.pnl_payment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trckBr_review)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion
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
      private System.Windows.Forms.Panel pnl_payment;
      private System.Windows.Forms.Button btnPay;
      private System.Windows.Forms.Button btnPercentTwenty;
      private System.Windows.Forms.Button btnPercentFifteen;
      private System.Windows.Forms.Button btnPercentTen;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnPercentZero;
      private System.Windows.Forms.Label totalLabel;
      private System.Windows.Forms.Label orderLabel;
      private System.Windows.Forms.MaskedTextBox maskedTextBox1;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.MaskedTextBox mTB_cvc;
      private System.Windows.Forms.RichTextBox rchTxtBx_Comments;
      private System.Windows.Forms.Label lbl_comment;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TrackBar trckBr_review;
      private System.Windows.Forms.Button btn_ArrowDown;
      private System.Windows.Forms.Button btn_ArrowUp;
      private System.Windows.Forms.Button btn_cancel;
      private System.Windows.Forms.Label lbl_prc_total;
      private System.Windows.Forms.Label lbl_Total;
      private System.Windows.Forms.Label lbl_prc_tip;
      private System.Windows.Forms.Label lbl_tip;
      private System.Windows.Forms.Label lbl_prc_tax;
      private System.Windows.Forms.Label lbl_tax;
      private System.Windows.Forms.Label lbl_prc_subtotal;
      private System.Windows.Forms.Label lbl_subtotal;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtbox_description;
   }
}