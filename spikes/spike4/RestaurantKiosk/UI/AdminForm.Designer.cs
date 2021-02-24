namespace RestaurantKiosk
{
    partial class AdminForm
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
         System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cheese",
            "$0.50"}, -1);
         System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lettuce",
            "$0.15"}, -1);
         System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tomato",
            "$0.25"}, -1);
         System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Onion",
            "$0.25"}, -1);
         System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pickle",
            "$0.15"}, -1);
         System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mustard",
            "$0.00"}, -1);
         System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ketchup",
            "$0.00"}, -1);
         this.panel3 = new System.Windows.Forms.Panel();
         this.lbl_customOptions = new System.Windows.Forms.Label();
         this.lbl_priceIndex = new System.Windows.Forms.Label();
         this.lBx_customOptions = new System.Windows.Forms.ListBox();
         this.listView1 = new System.Windows.Forms.ListView();
         this.cHdr_item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.cHdr_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.btn_addOption = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.btn_exit = new System.Windows.Forms.Button();
         this.lbl_description = new System.Windows.Forms.Label();
         this.rTxtBx_description = new System.Windows.Forms.RichTextBox();
         this.btn_done = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btn_addItem = new System.Windows.Forms.Button();
         this.cmbBx_items = new System.Windows.Forms.ComboBox();
         this.cmbBx_category = new System.Windows.Forms.ComboBox();
         this.txtBx_itemName = new System.Windows.Forms.TextBox();
         this.lbl_items = new System.Windows.Forms.Label();
         this.lbl_category = new System.Windows.Forms.Label();
         this.lbl_itemName = new System.Windows.Forms.Label();
         this.panel3.SuspendLayout();
         this.panel2.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel3
         // 
         this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.panel3.Controls.Add(this.lbl_customOptions);
         this.panel3.Controls.Add(this.lbl_priceIndex);
         this.panel3.Controls.Add(this.lBx_customOptions);
         this.panel3.Controls.Add(this.listView1);
         this.panel3.Controls.Add(this.btn_addOption);
         this.panel3.Location = new System.Drawing.Point(474, 86);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(392, 244);
         this.panel3.TabIndex = 22;
         // 
         // lbl_customOptions
         // 
         this.lbl_customOptions.AutoSize = true;
         this.lbl_customOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_customOptions.Location = new System.Drawing.Point(19, 23);
         this.lbl_customOptions.Name = "lbl_customOptions";
         this.lbl_customOptions.Size = new System.Drawing.Size(95, 13);
         this.lbl_customOptions.TabIndex = 4;
         this.lbl_customOptions.Text = "Custom Options";
         // 
         // lbl_priceIndex
         // 
         this.lbl_priceIndex.AutoSize = true;
         this.lbl_priceIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_priceIndex.Location = new System.Drawing.Point(199, 23);
         this.lbl_priceIndex.Name = "lbl_priceIndex";
         this.lbl_priceIndex.Size = new System.Drawing.Size(46, 13);
         this.lbl_priceIndex.TabIndex = 18;
         this.lbl_priceIndex.Text = "Pricing";
         // 
         // lBx_customOptions
         // 
         this.lBx_customOptions.FormattingEnabled = true;
         this.lBx_customOptions.Items.AddRange(new object[] {
            "<New Item>"});
         this.lBx_customOptions.Location = new System.Drawing.Point(18, 53);
         this.lBx_customOptions.Name = "lBx_customOptions";
         this.lBx_customOptions.Size = new System.Drawing.Size(120, 134);
         this.lBx_customOptions.TabIndex = 8;
         // 
         // listView1
         // 
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHdr_item,
            this.cHdr_price});
         this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
         this.listView1.Location = new System.Drawing.Point(202, 53);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(154, 169);
         this.listView1.TabIndex = 9;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         // 
         // cHdr_item
         // 
         this.cHdr_item.Text = "Item";
         this.cHdr_item.Width = 89;
         // 
         // cHdr_price
         // 
         this.cHdr_price.Text = "Price";
         // 
         // btn_addOption
         // 
         this.btn_addOption.Location = new System.Drawing.Point(18, 199);
         this.btn_addOption.Name = "btn_addOption";
         this.btn_addOption.Size = new System.Drawing.Size(75, 23);
         this.btn_addOption.TabIndex = 14;
         this.btn_addOption.Text = "Add Option";
         this.btn_addOption.UseVisualStyleBackColor = true;
         this.btn_addOption.Click += new System.EventHandler(this.btn_addOption_Click);
         // 
         // panel2
         // 
         this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.panel2.Controls.Add(this.btn_exit);
         this.panel2.Controls.Add(this.lbl_description);
         this.panel2.Controls.Add(this.rTxtBx_description);
         this.panel2.Controls.Add(this.btn_done);
         this.panel2.Location = new System.Drawing.Point(82, 362);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(321, 171);
         this.panel2.TabIndex = 21;
         // 
         // btn_exit
         // 
         this.btn_exit.Location = new System.Drawing.Point(8, 117);
         this.btn_exit.Name = "btn_exit";
         this.btn_exit.Size = new System.Drawing.Size(75, 23);
         this.btn_exit.TabIndex = 11;
         this.btn_exit.Text = "Exit";
         this.btn_exit.UseVisualStyleBackColor = true;
         this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
         // 
         // lbl_description
         // 
         this.lbl_description.AutoSize = true;
         this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_description.Location = new System.Drawing.Point(5, 0);
         this.lbl_description.Name = "lbl_description";
         this.lbl_description.Size = new System.Drawing.Size(71, 13);
         this.lbl_description.TabIndex = 3;
         this.lbl_description.Text = "Description";
         // 
         // rTxtBx_description
         // 
         this.rTxtBx_description.Enabled = false;
         this.rTxtBx_description.Location = new System.Drawing.Point(8, 17);
         this.rTxtBx_description.Name = "rTxtBx_description";
         this.rTxtBx_description.Size = new System.Drawing.Size(291, 94);
         this.rTxtBx_description.TabIndex = 15;
         this.rTxtBx_description.Text = "";
         // 
         // btn_done
         // 
         this.btn_done.Location = new System.Drawing.Point(224, 117);
         this.btn_done.Name = "btn_done";
         this.btn_done.Size = new System.Drawing.Size(75, 23);
         this.btn_done.TabIndex = 12;
         this.btn_done.Text = "Done";
         this.btn_done.UseVisualStyleBackColor = true;
         // 
         // panel1
         // 
         this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.panel1.Controls.Add(this.btn_addItem);
         this.panel1.Controls.Add(this.cmbBx_items);
         this.panel1.Controls.Add(this.cmbBx_category);
         this.panel1.Controls.Add(this.txtBx_itemName);
         this.panel1.Controls.Add(this.lbl_items);
         this.panel1.Controls.Add(this.lbl_category);
         this.panel1.Controls.Add(this.lbl_itemName);
         this.panel1.Location = new System.Drawing.Point(82, 86);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(321, 244);
         this.panel1.TabIndex = 20;
         // 
         // btn_addItem
         // 
         this.btn_addItem.Location = new System.Drawing.Point(224, 6);
         this.btn_addItem.Name = "btn_addItem";
         this.btn_addItem.Size = new System.Drawing.Size(75, 23);
         this.btn_addItem.TabIndex = 13;
         this.btn_addItem.Text = "Add Item";
         this.btn_addItem.UseVisualStyleBackColor = true;
         this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
         // 
         // cmbBx_items
         // 
         this.cmbBx_items.FormattingEnabled = true;
         this.cmbBx_items.Items.AddRange(new object[] {
            "<New Item>"});
         this.cmbBx_items.Location = new System.Drawing.Point(178, 100);
         this.cmbBx_items.Name = "cmbBx_items";
         this.cmbBx_items.Size = new System.Drawing.Size(121, 21);
         this.cmbBx_items.TabIndex = 7;
         this.cmbBx_items.Text = "<Select Item>";
         this.cmbBx_items.SelectedIndexChanged += new System.EventHandler(this.cmbBx_items_SelectedIndexChanged);
         // 
         // cmbBx_category
         // 
         this.cmbBx_category.FormattingEnabled = true;
         this.cmbBx_category.Location = new System.Drawing.Point(8, 100);
         this.cmbBx_category.Name = "cmbBx_category";
         this.cmbBx_category.Size = new System.Drawing.Size(121, 21);
         this.cmbBx_category.TabIndex = 6;
         this.cmbBx_category.Text = "<Select Category>";
         // 
         // txtBx_itemName
         // 
         this.txtBx_itemName.Enabled = false;
         this.txtBx_itemName.Location = new System.Drawing.Point(78, 8);
         this.txtBx_itemName.Name = "txtBx_itemName";
         this.txtBx_itemName.Size = new System.Drawing.Size(134, 20);
         this.txtBx_itemName.TabIndex = 5;
         // 
         // lbl_items
         // 
         this.lbl_items.AutoSize = true;
         this.lbl_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_items.Location = new System.Drawing.Point(175, 67);
         this.lbl_items.Name = "lbl_items";
         this.lbl_items.Size = new System.Drawing.Size(37, 13);
         this.lbl_items.TabIndex = 2;
         this.lbl_items.Text = "Items";
         // 
         // lbl_category
         // 
         this.lbl_category.AutoSize = true;
         this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_category.Location = new System.Drawing.Point(5, 67);
         this.lbl_category.Name = "lbl_category";
         this.lbl_category.Size = new System.Drawing.Size(57, 13);
         this.lbl_category.TabIndex = 1;
         this.lbl_category.Text = "Category";
         // 
         // lbl_itemName
         // 
         this.lbl_itemName.AutoSize = true;
         this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_itemName.Location = new System.Drawing.Point(5, 11);
         this.lbl_itemName.Name = "lbl_itemName";
         this.lbl_itemName.Size = new System.Drawing.Size(67, 13);
         this.lbl_itemName.TabIndex = 0;
         this.lbl_itemName.Text = "Item Name";
         // 
         // AdminForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSlateGray;
         this.ClientSize = new System.Drawing.Size(949, 599);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "AdminForm";
         this.Text = "AdminForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.AdminForm_Load);
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_customOptions;
        private System.Windows.Forms.Label lbl_priceIndex;
        private System.Windows.Forms.ListBox lBx_customOptions;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cHdr_item;
        private System.Windows.Forms.ColumnHeader cHdr_price;
        private System.Windows.Forms.Button btn_addOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.RichTextBox rTxtBx_description;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.ComboBox cmbBx_items;
        private System.Windows.Forms.ComboBox cmbBx_category;
        private System.Windows.Forms.TextBox txtBx_itemName;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_itemName;
    }
}