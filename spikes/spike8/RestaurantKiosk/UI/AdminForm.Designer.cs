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
         this.itemInfo_pnl = new System.Windows.Forms.Panel();
         this.incomplete_lbl = new System.Windows.Forms.Label();
         this.required_lbl = new System.Windows.Forms.Label();
         this.invalid_lbl = new System.Windows.Forms.Label();
         this.newOption_pnl = new System.Windows.Forms.Panel();
         this.inval_lbl = new System.Windows.Forms.Label();
         this.optionName_lbl = new System.Windows.Forms.Label();
         this.newOption_btn = new System.Windows.Forms.Button();
         this.optionPrice_lbl = new System.Windows.Forms.Label();
         this.newName_txtBx = new System.Windows.Forms.TextBox();
         this.newPrice_txtBx = new System.Windows.Forms.TextBox();
         this.submit_btn = new System.Windows.Forms.Button();
         this.price_txtBx = new System.Windows.Forms.TextBox();
         this.update_btn = new System.Windows.Forms.Button();
         this.basePrice_lbl = new System.Windows.Forms.Label();
         this.options_lstBx = new System.Windows.Forms.ListBox();
         this.description_rchTxtBx = new System.Windows.Forms.RichTextBox();
         this.pickCat_cmbBx = new System.Windows.Forms.ComboBox();
         this.name_txtBx = new System.Windows.Forms.TextBox();
         this.options_lbl = new System.Windows.Forms.Label();
         this.desciption_lbl = new System.Windows.Forms.Label();
         this.category_lbl = new System.Windows.Forms.Label();
         this.name_lbl = new System.Windows.Forms.Label();
         this.new_btn = new System.Windows.Forms.Button();
         this.cmi_lbl = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.remove_btn = new System.Windows.Forms.Button();
         this.menuItems_lstBx = new System.Windows.Forms.ListBox();
         this.logout_btn = new System.Windows.Forms.Button();
         this.parent_pnl = new System.Windows.Forms.Panel();
         this.itemInfo_pnl.SuspendLayout();
         this.newOption_pnl.SuspendLayout();
         this.panel1.SuspendLayout();
         this.parent_pnl.SuspendLayout();
         this.SuspendLayout();
         // 
         // itemInfo_pnl
         // 
         this.itemInfo_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.itemInfo_pnl.Controls.Add(this.incomplete_lbl);
         this.itemInfo_pnl.Controls.Add(this.required_lbl);
         this.itemInfo_pnl.Controls.Add(this.invalid_lbl);
         this.itemInfo_pnl.Controls.Add(this.newOption_pnl);
         this.itemInfo_pnl.Controls.Add(this.submit_btn);
         this.itemInfo_pnl.Controls.Add(this.price_txtBx);
         this.itemInfo_pnl.Controls.Add(this.update_btn);
         this.itemInfo_pnl.Controls.Add(this.basePrice_lbl);
         this.itemInfo_pnl.Controls.Add(this.options_lstBx);
         this.itemInfo_pnl.Controls.Add(this.description_rchTxtBx);
         this.itemInfo_pnl.Controls.Add(this.pickCat_cmbBx);
         this.itemInfo_pnl.Controls.Add(this.name_txtBx);
         this.itemInfo_pnl.Controls.Add(this.options_lbl);
         this.itemInfo_pnl.Controls.Add(this.desciption_lbl);
         this.itemInfo_pnl.Controls.Add(this.category_lbl);
         this.itemInfo_pnl.Controls.Add(this.name_lbl);
         this.itemInfo_pnl.Location = new System.Drawing.Point(341, 3);
         this.itemInfo_pnl.Name = "itemInfo_pnl";
         this.itemInfo_pnl.Size = new System.Drawing.Size(441, 400);
         this.itemInfo_pnl.TabIndex = 0;
         // 
         // incomplete_lbl
         // 
         this.incomplete_lbl.AutoSize = true;
         this.incomplete_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.incomplete_lbl.ForeColor = System.Drawing.Color.Red;
         this.incomplete_lbl.Location = new System.Drawing.Point(18, 108);
         this.incomplete_lbl.Name = "incomplete_lbl";
         this.incomplete_lbl.Size = new System.Drawing.Size(242, 16);
         this.incomplete_lbl.TabIndex = 18;
         this.incomplete_lbl.Text = "Please Complete Required Fields";
         // 
         // required_lbl
         // 
         this.required_lbl.AutoSize = true;
         this.required_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.required_lbl.Location = new System.Drawing.Point(18, 0);
         this.required_lbl.Name = "required_lbl";
         this.required_lbl.Size = new System.Drawing.Size(130, 16);
         this.required_lbl.TabIndex = 17;
         this.required_lbl.Text = "* - Required Field";
         // 
         // invalid_lbl
         // 
         this.invalid_lbl.AutoSize = true;
         this.invalid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.invalid_lbl.ForeColor = System.Drawing.Color.Red;
         this.invalid_lbl.Location = new System.Drawing.Point(347, 40);
         this.invalid_lbl.Name = "invalid_lbl";
         this.invalid_lbl.Size = new System.Drawing.Size(94, 16);
         this.invalid_lbl.TabIndex = 16;
         this.invalid_lbl.Text = "Invalid Price";
         // 
         // newOption_pnl
         // 
         this.newOption_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.newOption_pnl.Controls.Add(this.inval_lbl);
         this.newOption_pnl.Controls.Add(this.optionName_lbl);
         this.newOption_pnl.Controls.Add(this.newOption_btn);
         this.newOption_pnl.Controls.Add(this.optionPrice_lbl);
         this.newOption_pnl.Controls.Add(this.newName_txtBx);
         this.newOption_pnl.Controls.Add(this.newPrice_txtBx);
         this.newOption_pnl.Location = new System.Drawing.Point(236, 278);
         this.newOption_pnl.Name = "newOption_pnl";
         this.newOption_pnl.Size = new System.Drawing.Size(205, 122);
         this.newOption_pnl.TabIndex = 15;
         // 
         // inval_lbl
         // 
         this.inval_lbl.AutoSize = true;
         this.inval_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.inval_lbl.ForeColor = System.Drawing.Color.Red;
         this.inval_lbl.Location = new System.Drawing.Point(98, 53);
         this.inval_lbl.Name = "inval_lbl";
         this.inval_lbl.Size = new System.Drawing.Size(94, 16);
         this.inval_lbl.TabIndex = 17;
         this.inval_lbl.Text = "Invalid Price";
         // 
         // optionName_lbl
         // 
         this.optionName_lbl.AutoSize = true;
         this.optionName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionName_lbl.Location = new System.Drawing.Point(-3, 13);
         this.optionName_lbl.Name = "optionName_lbl";
         this.optionName_lbl.Size = new System.Drawing.Size(53, 16);
         this.optionName_lbl.TabIndex = 12;
         this.optionName_lbl.Text = "Name:";
         // 
         // newOption_btn
         // 
         this.newOption_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.newOption_btn.Location = new System.Drawing.Point(0, 77);
         this.newOption_btn.Name = "newOption_btn";
         this.newOption_btn.Size = new System.Drawing.Size(183, 27);
         this.newOption_btn.TabIndex = 14;
         this.newOption_btn.Text = "Add Option";
         this.newOption_btn.UseVisualStyleBackColor = true;
         this.newOption_btn.Click += new System.EventHandler(this.newOption_btn_Click);
         // 
         // optionPrice_lbl
         // 
         this.optionPrice_lbl.AutoSize = true;
         this.optionPrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionPrice_lbl.Location = new System.Drawing.Point(104, 13);
         this.optionPrice_lbl.Name = "optionPrice_lbl";
         this.optionPrice_lbl.Size = new System.Drawing.Size(60, 16);
         this.optionPrice_lbl.TabIndex = 13;
         this.optionPrice_lbl.Text = "Price: $";
         // 
         // newName_txtBx
         // 
         this.newName_txtBx.Location = new System.Drawing.Point(0, 30);
         this.newName_txtBx.Name = "newName_txtBx";
         this.newName_txtBx.Size = new System.Drawing.Size(76, 20);
         this.newName_txtBx.TabIndex = 8;
         // 
         // newPrice_txtBx
         // 
         this.newPrice_txtBx.Location = new System.Drawing.Point(107, 30);
         this.newPrice_txtBx.Name = "newPrice_txtBx";
         this.newPrice_txtBx.Size = new System.Drawing.Size(76, 20);
         this.newPrice_txtBx.TabIndex = 9;
         // 
         // submit_btn
         // 
         this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.submit_btn.Location = new System.Drawing.Point(21, 301);
         this.submit_btn.Name = "submit_btn";
         this.submit_btn.Size = new System.Drawing.Size(152, 54);
         this.submit_btn.TabIndex = 1;
         this.submit_btn.Text = "Submit";
         this.submit_btn.UseVisualStyleBackColor = true;
         this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
         // 
         // price_txtBx
         // 
         this.price_txtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.price_txtBx.Location = new System.Drawing.Point(297, 37);
         this.price_txtBx.Name = "price_txtBx";
         this.price_txtBx.Size = new System.Drawing.Size(50, 22);
         this.price_txtBx.TabIndex = 11;
         this.price_txtBx.Text = "<price>";
         // 
         // update_btn
         // 
         this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.update_btn.Location = new System.Drawing.Point(21, 301);
         this.update_btn.Name = "update_btn";
         this.update_btn.Size = new System.Drawing.Size(152, 54);
         this.update_btn.TabIndex = 3;
         this.update_btn.Text = "Update";
         this.update_btn.UseVisualStyleBackColor = true;
         this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
         // 
         // basePrice_lbl
         // 
         this.basePrice_lbl.AutoSize = true;
         this.basePrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.basePrice_lbl.Location = new System.Drawing.Point(194, 40);
         this.basePrice_lbl.Name = "basePrice_lbl";
         this.basePrice_lbl.Size = new System.Drawing.Size(106, 16);
         this.basePrice_lbl.TabIndex = 10;
         this.basePrice_lbl.Text = "*Base Price: $";
         // 
         // options_lstBx
         // 
         this.options_lstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.options_lstBx.FormattingEnabled = true;
         this.options_lstBx.ItemHeight = 16;
         this.options_lstBx.Items.AddRange(new object[] {
            "<New Option>"});
         this.options_lstBx.Location = new System.Drawing.Point(233, 156);
         this.options_lstBx.Name = "options_lstBx";
         this.options_lstBx.Size = new System.Drawing.Size(186, 132);
         this.options_lstBx.Sorted = true;
         this.options_lstBx.TabIndex = 7;
         this.options_lstBx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.options_lstBx_MouseClick);
         // 
         // description_rchTxtBx
         // 
         this.description_rchTxtBx.Location = new System.Drawing.Point(21, 153);
         this.description_rchTxtBx.Name = "description_rchTxtBx";
         this.description_rchTxtBx.Size = new System.Drawing.Size(183, 134);
         this.description_rchTxtBx.TabIndex = 6;
         this.description_rchTxtBx.Text = "";
         // 
         // pickCat_cmbBx
         // 
         this.pickCat_cmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickCat_cmbBx.FormattingEnabled = true;
         this.pickCat_cmbBx.Location = new System.Drawing.Point(93, 81);
         this.pickCat_cmbBx.Name = "pickCat_cmbBx";
         this.pickCat_cmbBx.Size = new System.Drawing.Size(159, 24);
         this.pickCat_cmbBx.TabIndex = 5;
         this.pickCat_cmbBx.Text = "<Select Category>";
         // 
         // name_txtBx
         // 
         this.name_txtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.name_txtBx.Location = new System.Drawing.Point(73, 39);
         this.name_txtBx.Name = "name_txtBx";
         this.name_txtBx.Size = new System.Drawing.Size(115, 20);
         this.name_txtBx.TabIndex = 4;
         // 
         // options_lbl
         // 
         this.options_lbl.AutoSize = true;
         this.options_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.options_lbl.Location = new System.Drawing.Point(233, 137);
         this.options_lbl.Name = "options_lbl";
         this.options_lbl.Size = new System.Drawing.Size(61, 16);
         this.options_lbl.TabIndex = 3;
         this.options_lbl.Text = "Options";
         // 
         // desciption_lbl
         // 
         this.desciption_lbl.AutoSize = true;
         this.desciption_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.desciption_lbl.Location = new System.Drawing.Point(18, 134);
         this.desciption_lbl.Name = "desciption_lbl";
         this.desciption_lbl.Size = new System.Drawing.Size(87, 16);
         this.desciption_lbl.TabIndex = 2;
         this.desciption_lbl.Text = "Description";
         // 
         // category_lbl
         // 
         this.category_lbl.AutoSize = true;
         this.category_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.category_lbl.Location = new System.Drawing.Point(18, 84);
         this.category_lbl.Name = "category_lbl";
         this.category_lbl.Size = new System.Drawing.Size(77, 16);
         this.category_lbl.TabIndex = 1;
         this.category_lbl.Text = "*Category";
         // 
         // name_lbl
         // 
         this.name_lbl.AutoSize = true;
         this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.name_lbl.Location = new System.Drawing.Point(18, 40);
         this.name_lbl.Name = "name_lbl";
         this.name_lbl.Size = new System.Drawing.Size(55, 16);
         this.name_lbl.TabIndex = 0;
         this.name_lbl.Text = "*Name";
         // 
         // new_btn
         // 
         this.new_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.new_btn.Location = new System.Drawing.Point(37, 304);
         this.new_btn.Name = "new_btn";
         this.new_btn.Size = new System.Drawing.Size(120, 54);
         this.new_btn.TabIndex = 2;
         this.new_btn.Text = "New Item";
         this.new_btn.UseVisualStyleBackColor = true;
         this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
         // 
         // cmi_lbl
         // 
         this.cmi_lbl.AutoSize = true;
         this.cmi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmi_lbl.Location = new System.Drawing.Point(34, 3);
         this.cmi_lbl.Name = "cmi_lbl";
         this.cmi_lbl.Size = new System.Drawing.Size(139, 16);
         this.cmi_lbl.TabIndex = 5;
         this.cmi_lbl.Text = "Current Menu Items";
         // 
         // panel1
         // 
         this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.panel1.Controls.Add(this.remove_btn);
         this.panel1.Controls.Add(this.menuItems_lstBx);
         this.panel1.Controls.Add(this.new_btn);
         this.panel1.Controls.Add(this.cmi_lbl);
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(343, 403);
         this.panel1.TabIndex = 7;
         // 
         // remove_btn
         // 
         this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.remove_btn.Location = new System.Drawing.Point(204, 304);
         this.remove_btn.Name = "remove_btn";
         this.remove_btn.Size = new System.Drawing.Size(120, 54);
         this.remove_btn.TabIndex = 8;
         this.remove_btn.Text = "Remove Item";
         this.remove_btn.UseVisualStyleBackColor = true;
         this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
         // 
         // menuItems_lstBx
         // 
         this.menuItems_lstBx.ColumnWidth = 90;
         this.menuItems_lstBx.FormattingEnabled = true;
         this.menuItems_lstBx.Location = new System.Drawing.Point(37, 65);
         this.menuItems_lstBx.Name = "menuItems_lstBx";
         this.menuItems_lstBx.Size = new System.Drawing.Size(287, 225);
         this.menuItems_lstBx.Sorted = true;
         this.menuItems_lstBx.TabIndex = 7;
         this.menuItems_lstBx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuItems_lstBx_MouseClick);
         // 
         // logout_btn
         // 
         this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.logout_btn.Location = new System.Drawing.Point(12, 12);
         this.logout_btn.Name = "logout_btn";
         this.logout_btn.Size = new System.Drawing.Size(75, 23);
         this.logout_btn.TabIndex = 8;
         this.logout_btn.Text = "Logout";
         this.logout_btn.UseVisualStyleBackColor = true;
         this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
         // 
         // parent_pnl
         // 
         this.parent_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.parent_pnl.Controls.Add(this.itemInfo_pnl);
         this.parent_pnl.Controls.Add(this.panel1);
         this.parent_pnl.Location = new System.Drawing.Point(44, 64);
         this.parent_pnl.Name = "parent_pnl";
         this.parent_pnl.Size = new System.Drawing.Size(782, 403);
         this.parent_pnl.TabIndex = 9;
         // 
         // AdminForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSlateGray;
         this.ClientSize = new System.Drawing.Size(863, 511);
         this.Controls.Add(this.logout_btn);
         this.Controls.Add(this.parent_pnl);
         this.Name = "AdminForm";
         this.Text = "AdminForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
         this.Load += new System.EventHandler(this.AdminForm_Load);
         this.itemInfo_pnl.ResumeLayout(false);
         this.itemInfo_pnl.PerformLayout();
         this.newOption_pnl.ResumeLayout(false);
         this.newOption_pnl.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.parent_pnl.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel itemInfo_pnl;
      private System.Windows.Forms.Button submit_btn;
      private System.Windows.Forms.Button new_btn;
      private System.Windows.Forms.Button update_btn;
      private System.Windows.Forms.Label cmi_lbl;
      private System.Windows.Forms.ComboBox pickCat_cmbBx;
      private System.Windows.Forms.TextBox name_txtBx;
      private System.Windows.Forms.Label options_lbl;
      private System.Windows.Forms.Label desciption_lbl;
      private System.Windows.Forms.Label category_lbl;
      private System.Windows.Forms.Label name_lbl;
      private System.Windows.Forms.ListBox options_lstBx;
      private System.Windows.Forms.RichTextBox description_rchTxtBx;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.ListBox menuItems_lstBx;
      private System.Windows.Forms.TextBox price_txtBx;
      private System.Windows.Forms.Label basePrice_lbl;
      private System.Windows.Forms.TextBox newPrice_txtBx;
      private System.Windows.Forms.TextBox newName_txtBx;
      private System.Windows.Forms.Button newOption_btn;
      private System.Windows.Forms.Label optionPrice_lbl;
      private System.Windows.Forms.Label optionName_lbl;
      private System.Windows.Forms.Panel newOption_pnl;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel parent_pnl;
      private System.Windows.Forms.Button remove_btn;
      private System.Windows.Forms.Label invalid_lbl;
      private System.Windows.Forms.Label required_lbl;
      private System.Windows.Forms.Label incomplete_lbl;
      private System.Windows.Forms.Label inval_lbl;
   }
}

