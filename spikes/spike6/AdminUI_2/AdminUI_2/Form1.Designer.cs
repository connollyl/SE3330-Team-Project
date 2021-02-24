namespace AdminUI_2
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
         this.itemInfo_pnl = new System.Windows.Forms.Panel();
         this.pickCat_cmbBx = new System.Windows.Forms.ComboBox();
         this.name_txtBx = new System.Windows.Forms.TextBox();
         this.options_lbl = new System.Windows.Forms.Label();
         this.desciption_lbl = new System.Windows.Forms.Label();
         this.category_lbl = new System.Windows.Forms.Label();
         this.name_lbl = new System.Windows.Forms.Label();
         this.submit_btn = new System.Windows.Forms.Button();
         this.new_btn = new System.Windows.Forms.Button();
         this.update_btn = new System.Windows.Forms.Button();
         this.cmi_lbl = new System.Windows.Forms.Label();
         this.item_cmbBx = new System.Windows.Forms.ComboBox();
         this.description_rchTxtBx = new System.Windows.Forms.RichTextBox();
         this.options_lstBx = new System.Windows.Forms.ListBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.menuItems_cmbBx = new System.Windows.Forms.ListBox();
         this.newName_txtBx = new System.Windows.Forms.TextBox();
         this.newPrice_txtBx = new System.Windows.Forms.TextBox();
         this.basePrice_lbl = new System.Windows.Forms.Label();
         this.price_tbtBx = new System.Windows.Forms.TextBox();
         this.optionName_lbl = new System.Windows.Forms.Label();
         this.optionPrice_lbl = new System.Windows.Forms.Label();
         this.newOption_btn = new System.Windows.Forms.Button();
         this.newOption_pnl = new System.Windows.Forms.Panel();
         this.itemInfo_pnl.SuspendLayout();
         this.panel1.SuspendLayout();
         this.newOption_pnl.SuspendLayout();
         this.SuspendLayout();
         // 
         // itemInfo_pnl
         // 
         this.itemInfo_pnl.Controls.Add(this.newOption_pnl);
         this.itemInfo_pnl.Controls.Add(this.submit_btn);
         this.itemInfo_pnl.Controls.Add(this.price_tbtBx);
         this.itemInfo_pnl.Controls.Add(this.basePrice_lbl);
         this.itemInfo_pnl.Controls.Add(this.options_lstBx);
         this.itemInfo_pnl.Controls.Add(this.description_rchTxtBx);
         this.itemInfo_pnl.Controls.Add(this.pickCat_cmbBx);
         this.itemInfo_pnl.Controls.Add(this.name_txtBx);
         this.itemInfo_pnl.Controls.Add(this.options_lbl);
         this.itemInfo_pnl.Controls.Add(this.desciption_lbl);
         this.itemInfo_pnl.Controls.Add(this.category_lbl);
         this.itemInfo_pnl.Controls.Add(this.name_lbl);
         this.itemInfo_pnl.Location = new System.Drawing.Point(361, 12);
         this.itemInfo_pnl.Name = "itemInfo_pnl";
         this.itemInfo_pnl.Size = new System.Drawing.Size(476, 484);
         this.itemInfo_pnl.TabIndex = 0;
         // 
         // pickCat_cmbBx
         // 
         this.pickCat_cmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickCat_cmbBx.FormattingEnabled = true;
         this.pickCat_cmbBx.Items.AddRange(new object[] {
            "Meals",
            "Appetizers",
            "Drinks"});
         this.pickCat_cmbBx.Location = new System.Drawing.Point(95, 62);
         this.pickCat_cmbBx.Name = "pickCat_cmbBx";
         this.pickCat_cmbBx.Size = new System.Drawing.Size(159, 24);
         this.pickCat_cmbBx.TabIndex = 5;
         this.pickCat_cmbBx.Text = "<Select Category>";
         // 
         // name_txtBx
         // 
         this.name_txtBx.Location = new System.Drawing.Point(73, 22);
         this.name_txtBx.Name = "name_txtBx";
         this.name_txtBx.Size = new System.Drawing.Size(100, 20);
         this.name_txtBx.TabIndex = 4;
         // 
         // options_lbl
         // 
         this.options_lbl.AutoSize = true;
         this.options_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.options_lbl.Location = new System.Drawing.Point(259, 107);
         this.options_lbl.Name = "options_lbl";
         this.options_lbl.Size = new System.Drawing.Size(61, 16);
         this.options_lbl.TabIndex = 3;
         this.options_lbl.Text = "Options";
         // 
         // desciption_lbl
         // 
         this.desciption_lbl.AutoSize = true;
         this.desciption_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.desciption_lbl.Location = new System.Drawing.Point(18, 107);
         this.desciption_lbl.Name = "desciption_lbl";
         this.desciption_lbl.Size = new System.Drawing.Size(87, 16);
         this.desciption_lbl.TabIndex = 2;
         this.desciption_lbl.Text = "Description";
         // 
         // category_lbl
         // 
         this.category_lbl.AutoSize = true;
         this.category_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.category_lbl.Location = new System.Drawing.Point(18, 63);
         this.category_lbl.Name = "category_lbl";
         this.category_lbl.Size = new System.Drawing.Size(71, 16);
         this.category_lbl.TabIndex = 1;
         this.category_lbl.Text = "Category";
         // 
         // name_lbl
         // 
         this.name_lbl.AutoSize = true;
         this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.name_lbl.Location = new System.Drawing.Point(18, 23);
         this.name_lbl.Name = "name_lbl";
         this.name_lbl.Size = new System.Drawing.Size(49, 16);
         this.name_lbl.TabIndex = 0;
         this.name_lbl.Text = "Name";
         // 
         // submit_btn
         // 
         this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.submit_btn.Location = new System.Drawing.Point(21, 288);
         this.submit_btn.Name = "submit_btn";
         this.submit_btn.Size = new System.Drawing.Size(152, 54);
         this.submit_btn.TabIndex = 1;
         this.submit_btn.Text = "Submit";
         this.submit_btn.UseVisualStyleBackColor = true;
         this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
         // 
         // new_btn
         // 
         this.new_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.new_btn.Location = new System.Drawing.Point(37, 22);
         this.new_btn.Name = "new_btn";
         this.new_btn.Size = new System.Drawing.Size(120, 45);
         this.new_btn.TabIndex = 2;
         this.new_btn.Text = "New";
         this.new_btn.UseVisualStyleBackColor = true;
         this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
         // 
         // update_btn
         // 
         this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.update_btn.Location = new System.Drawing.Point(204, 98);
         this.update_btn.Name = "update_btn";
         this.update_btn.Size = new System.Drawing.Size(120, 45);
         this.update_btn.TabIndex = 3;
         this.update_btn.Text = "Update";
         this.update_btn.UseVisualStyleBackColor = true;
         this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
         // 
         // cmi_lbl
         // 
         this.cmi_lbl.AutoSize = true;
         this.cmi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmi_lbl.Location = new System.Drawing.Point(34, 182);
         this.cmi_lbl.Name = "cmi_lbl";
         this.cmi_lbl.Size = new System.Drawing.Size(139, 16);
         this.cmi_lbl.TabIndex = 5;
         this.cmi_lbl.Text = "Current Menu Items";
         // 
         // item_cmbBx
         // 
         this.item_cmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.item_cmbBx.FormattingEnabled = true;
         this.item_cmbBx.Items.AddRange(new object[] {
            "Burger",
            "Fries",
            "Live Zebra"});
         this.item_cmbBx.Location = new System.Drawing.Point(36, 109);
         this.item_cmbBx.Name = "item_cmbBx";
         this.item_cmbBx.Size = new System.Drawing.Size(162, 24);
         this.item_cmbBx.TabIndex = 6;
         this.item_cmbBx.Text = "<Select Menu Item>";
         this.item_cmbBx.SelectedIndexChanged += new System.EventHandler(this.item_cmbBx_SelectedIndexChanged);
         // 
         // description_rchTxtBx
         // 
         this.description_rchTxtBx.Location = new System.Drawing.Point(21, 123);
         this.description_rchTxtBx.Name = "description_rchTxtBx";
         this.description_rchTxtBx.Size = new System.Drawing.Size(205, 136);
         this.description_rchTxtBx.TabIndex = 6;
         this.description_rchTxtBx.Text = "";
         // 
         // options_lstBx
         // 
         this.options_lstBx.FormattingEnabled = true;
         this.options_lstBx.Items.AddRange(new object[] {
            "<New Option>"});
         this.options_lstBx.Location = new System.Drawing.Point(262, 126);
         this.options_lstBx.Name = "options_lstBx";
         this.options_lstBx.Size = new System.Drawing.Size(200, 134);
         this.options_lstBx.Sorted = true;
         this.options_lstBx.TabIndex = 7;
         this.options_lstBx.DoubleClick += new System.EventHandler(this.options_lstBx_DoubleClick);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.menuItems_cmbBx);
         this.panel1.Controls.Add(this.new_btn);
         this.panel1.Controls.Add(this.item_cmbBx);
         this.panel1.Controls.Add(this.cmi_lbl);
         this.panel1.Controls.Add(this.update_btn);
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(343, 484);
         this.panel1.TabIndex = 7;
         // 
         // menuItems_cmbBx
         // 
         this.menuItems_cmbBx.ColumnWidth = 90;
         this.menuItems_cmbBx.FormattingEnabled = true;
         this.menuItems_cmbBx.Location = new System.Drawing.Point(37, 219);
         this.menuItems_cmbBx.Name = "menuItems_cmbBx";
         this.menuItems_cmbBx.Size = new System.Drawing.Size(287, 225);
         this.menuItems_cmbBx.Sorted = true;
         this.menuItems_cmbBx.TabIndex = 7;
         // 
         // newName_txtBx
         // 
         this.newName_txtBx.Location = new System.Drawing.Point(58, 12);
         this.newName_txtBx.Name = "newName_txtBx";
         this.newName_txtBx.Size = new System.Drawing.Size(100, 20);
         this.newName_txtBx.TabIndex = 8;
         // 
         // newPrice_txtBx
         // 
         this.newPrice_txtBx.Location = new System.Drawing.Point(63, 43);
         this.newPrice_txtBx.Name = "newPrice_txtBx";
         this.newPrice_txtBx.Size = new System.Drawing.Size(95, 20);
         this.newPrice_txtBx.TabIndex = 9;
         // 
         // basePrice_lbl
         // 
         this.basePrice_lbl.AutoSize = true;
         this.basePrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.basePrice_lbl.Location = new System.Drawing.Point(194, 23);
         this.basePrice_lbl.Name = "basePrice_lbl";
         this.basePrice_lbl.Size = new System.Drawing.Size(100, 16);
         this.basePrice_lbl.TabIndex = 10;
         this.basePrice_lbl.Text = "Base Price: $";
         // 
         // price_tbtBx
         // 
         this.price_tbtBx.Location = new System.Drawing.Point(300, 23);
         this.price_tbtBx.Name = "price_tbtBx";
         this.price_tbtBx.Size = new System.Drawing.Size(48, 20);
         this.price_tbtBx.TabIndex = 11;
         this.price_tbtBx.Text = "<price>";
         // 
         // optionName_lbl
         // 
         this.optionName_lbl.AutoSize = true;
         this.optionName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionName_lbl.Location = new System.Drawing.Point(3, 13);
         this.optionName_lbl.Name = "optionName_lbl";
         this.optionName_lbl.Size = new System.Drawing.Size(53, 16);
         this.optionName_lbl.TabIndex = 12;
         this.optionName_lbl.Text = "Name:";
         // 
         // optionPrice_lbl
         // 
         this.optionPrice_lbl.AutoSize = true;
         this.optionPrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionPrice_lbl.Location = new System.Drawing.Point(3, 44);
         this.optionPrice_lbl.Name = "optionPrice_lbl";
         this.optionPrice_lbl.Size = new System.Drawing.Size(60, 16);
         this.optionPrice_lbl.TabIndex = 13;
         this.optionPrice_lbl.Text = "Price: $";
         // 
         // newOption_btn
         // 
         this.newOption_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.newOption_btn.Location = new System.Drawing.Point(174, 19);
         this.newOption_btn.Name = "newOption_btn";
         this.newOption_btn.Size = new System.Drawing.Size(35, 35);
         this.newOption_btn.TabIndex = 14;
         this.newOption_btn.Text = "+";
         this.newOption_btn.UseVisualStyleBackColor = true;
         this.newOption_btn.Click += new System.EventHandler(this.newOption_btn_Click);
         // 
         // newOption_pnl
         // 
         this.newOption_pnl.Controls.Add(this.optionName_lbl);
         this.newOption_pnl.Controls.Add(this.newOption_btn);
         this.newOption_pnl.Controls.Add(this.optionPrice_lbl);
         this.newOption_pnl.Controls.Add(this.newName_txtBx);
         this.newOption_pnl.Controls.Add(this.newPrice_txtBx);
         this.newOption_pnl.Location = new System.Drawing.Point(237, 278);
         this.newOption_pnl.Name = "newOption_pnl";
         this.newOption_pnl.Size = new System.Drawing.Size(225, 74);
         this.newOption_pnl.TabIndex = 15;
         // 
         // AdminForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSlateGray;
         this.ClientSize = new System.Drawing.Size(888, 646);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.itemInfo_pnl);
         this.Name = "AdminForm";
         this.Text = "AdminForm";
         this.Load += new System.EventHandler(this.AdminForm_Load);
         this.itemInfo_pnl.ResumeLayout(false);
         this.itemInfo_pnl.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.newOption_pnl.ResumeLayout(false);
         this.newOption_pnl.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel itemInfo_pnl;
      private System.Windows.Forms.Button submit_btn;
      private System.Windows.Forms.Button new_btn;
      private System.Windows.Forms.Button update_btn;
      private System.Windows.Forms.Label cmi_lbl;
      private System.Windows.Forms.ComboBox item_cmbBx;
      private System.Windows.Forms.ComboBox pickCat_cmbBx;
      private System.Windows.Forms.TextBox name_txtBx;
      private System.Windows.Forms.Label options_lbl;
      private System.Windows.Forms.Label desciption_lbl;
      private System.Windows.Forms.Label category_lbl;
      private System.Windows.Forms.Label name_lbl;
      private System.Windows.Forms.ListBox options_lstBx;
      private System.Windows.Forms.RichTextBox description_rchTxtBx;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.ListBox menuItems_cmbBx;
      private System.Windows.Forms.TextBox price_tbtBx;
      private System.Windows.Forms.Label basePrice_lbl;
      private System.Windows.Forms.TextBox newPrice_txtBx;
      private System.Windows.Forms.TextBox newName_txtBx;
      private System.Windows.Forms.Button newOption_btn;
      private System.Windows.Forms.Label optionPrice_lbl;
      private System.Windows.Forms.Label optionName_lbl;
      private System.Windows.Forms.Panel newOption_pnl;
   }
}

