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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
         this.btn_redo = new System.Windows.Forms.Button();
         this.btn_undo = new System.Windows.Forms.Button();
         this.txtBx_calories = new System.Windows.Forms.TextBox();
         this.lbl_calories = new System.Windows.Forms.Label();
         this.required_lbl = new System.Windows.Forms.Label();
         this.submit_btn = new System.Windows.Forms.Button();
         this.newOption_pnl = new System.Windows.Forms.Panel();
         this.optionName_lbl = new System.Windows.Forms.Label();
         this.btn_remOp = new System.Windows.Forms.Button();
         this.newOption_btn = new System.Windows.Forms.Button();
         this.optionPrice_lbl = new System.Windows.Forms.Label();
         this.newName_txtBx = new System.Windows.Forms.TextBox();
         this.newPrice_txtBx = new System.Windows.Forms.TextBox();
         this.price_txtBx = new System.Windows.Forms.TextBox();
         this.basePrice_lbl = new System.Windows.Forms.Label();
         this.options_lstBx = new System.Windows.Forms.ListBox();
         this.description_rchTxtBx = new System.Windows.Forms.RichTextBox();
         this.pickCat_cmbBx = new System.Windows.Forms.ComboBox();
         this.name_txtBx = new System.Windows.Forms.TextBox();
         this.options_lbl = new System.Windows.Forms.Label();
         this.desciption_lbl = new System.Windows.Forms.Label();
         this.category_lbl = new System.Windows.Forms.Label();
         this.name_lbl = new System.Windows.Forms.Label();
         this.cmi_lbl = new System.Windows.Forms.Label();
         this.menuItems_pnl = new System.Windows.Forms.Panel();
         this.remove_btn = new System.Windows.Forms.Button();
         this.menuItems_lstBx = new System.Windows.Forms.ListBox();
         this.logout_btn = new System.Windows.Forms.Button();
         this.pnl_main = new System.Windows.Forms.Panel();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pic_Pioneers = new System.Windows.Forms.PictureBox();
         this.pic_Background = new System.Windows.Forms.PictureBox();
         this.toolTipCommand = new System.Windows.Forms.ToolTip(this.components);
         this.newOption_pnl.SuspendLayout();
         this.menuItems_pnl.SuspendLayout();
         this.pnl_main.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pic_Pioneers)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
         this.SuspendLayout();
         // 
         // btn_redo
         // 
         this.btn_redo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.btn_redo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_redo.Location = new System.Drawing.Point(181, 9);
         this.btn_redo.Margin = new System.Windows.Forms.Padding(1);
         this.btn_redo.Name = "btn_redo";
         this.btn_redo.Size = new System.Drawing.Size(69, 32);
         this.btn_redo.TabIndex = 23;
         this.btn_redo.Text = "Redo";
         this.btn_redo.UseVisualStyleBackColor = false;
         this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
         this.btn_redo.MouseHover += new System.EventHandler(this.btn_redo_MouseHover);
         // 
         // btn_undo
         // 
         this.btn_undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.btn_undo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_undo.Location = new System.Drawing.Point(7, 9);
         this.btn_undo.Margin = new System.Windows.Forms.Padding(1);
         this.btn_undo.Name = "btn_undo";
         this.btn_undo.Size = new System.Drawing.Size(69, 32);
         this.btn_undo.TabIndex = 22;
         this.btn_undo.Text = "Undo";
         this.btn_undo.UseVisualStyleBackColor = false;
         this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
         this.btn_undo.MouseHover += new System.EventHandler(this.btn_undo_MouseHover);
         // 
         // txtBx_calories
         // 
         this.txtBx_calories.BackColor = System.Drawing.Color.White;
         this.txtBx_calories.Enabled = false;
         this.txtBx_calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtBx_calories.Location = new System.Drawing.Point(108, 81);
         this.txtBx_calories.Name = "txtBx_calories";
         this.txtBx_calories.Size = new System.Drawing.Size(147, 26);
         this.txtBx_calories.TabIndex = 20;
         this.txtBx_calories.Text = "<calories>";
         this.txtBx_calories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_calories_KeyDown);
         // 
         // lbl_calories
         // 
         this.lbl_calories.AutoSize = true;
         this.lbl_calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_calories.ForeColor = System.Drawing.Color.White;
         this.lbl_calories.Location = new System.Drawing.Point(3, 81);
         this.lbl_calories.Name = "lbl_calories";
         this.lbl_calories.Size = new System.Drawing.Size(81, 20);
         this.lbl_calories.TabIndex = 19;
         this.lbl_calories.Text = "*Calories";
         // 
         // required_lbl
         // 
         this.required_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.required_lbl.AutoSize = true;
         this.required_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.required_lbl.ForeColor = System.Drawing.Color.White;
         this.required_lbl.Location = new System.Drawing.Point(-5, 0);
         this.required_lbl.Name = "required_lbl";
         this.required_lbl.Size = new System.Drawing.Size(209, 25);
         this.required_lbl.TabIndex = 17;
         this.required_lbl.Text = "* - Required Fields";
         // 
         // submit_btn
         // 
         this.submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.submit_btn.ForeColor = System.Drawing.Color.White;
         this.submit_btn.Location = new System.Drawing.Point(302, 628);
         this.submit_btn.Name = "submit_btn";
         this.submit_btn.Size = new System.Drawing.Size(228, 72);
         this.submit_btn.TabIndex = 1;
         this.submit_btn.Text = "Submit";
         this.submit_btn.UseVisualStyleBackColor = false;
         this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
         // 
         // newOption_pnl
         // 
         this.newOption_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
         this.newOption_pnl.Controls.Add(this.optionName_lbl);
         this.newOption_pnl.Controls.Add(this.btn_remOp);
         this.newOption_pnl.Controls.Add(this.newOption_btn);
         this.newOption_pnl.Controls.Add(this.optionPrice_lbl);
         this.newOption_pnl.Controls.Add(this.newName_txtBx);
         this.newOption_pnl.Controls.Add(this.newPrice_txtBx);
         this.newOption_pnl.Location = new System.Drawing.Point(600, 628);
         this.newOption_pnl.Name = "newOption_pnl";
         this.newOption_pnl.Size = new System.Drawing.Size(211, 72);
         this.newOption_pnl.TabIndex = 15;
         // 
         // optionName_lbl
         // 
         this.optionName_lbl.AutoSize = true;
         this.optionName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionName_lbl.ForeColor = System.Drawing.Color.White;
         this.optionName_lbl.Location = new System.Drawing.Point(0, 0);
         this.optionName_lbl.Name = "optionName_lbl";
         this.optionName_lbl.Size = new System.Drawing.Size(53, 16);
         this.optionName_lbl.TabIndex = 12;
         this.optionName_lbl.Text = "Name:";
         // 
         // btn_remOp
         // 
         this.btn_remOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.btn_remOp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_remOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_remOp.ForeColor = System.Drawing.Color.White;
         this.btn_remOp.Location = new System.Drawing.Point(-3, 7);
         this.btn_remOp.Name = "btn_remOp";
         this.btn_remOp.Size = new System.Drawing.Size(211, 63);
         this.btn_remOp.TabIndex = 24;
         this.btn_remOp.Text = "Remove Option";
         this.btn_remOp.UseVisualStyleBackColor = false;
         this.btn_remOp.Click += new System.EventHandler(this.btn_remOp_Click);
         // 
         // newOption_btn
         // 
         this.newOption_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.newOption_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.newOption_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.newOption_btn.ForeColor = System.Drawing.Color.White;
         this.newOption_btn.Location = new System.Drawing.Point(3, 43);
         this.newOption_btn.Name = "newOption_btn";
         this.newOption_btn.Size = new System.Drawing.Size(186, 27);
         this.newOption_btn.TabIndex = 14;
         this.newOption_btn.Text = "Add Option";
         this.newOption_btn.UseVisualStyleBackColor = false;
         this.newOption_btn.Click += new System.EventHandler(this.newOption_btn_Click);
         // 
         // optionPrice_lbl
         // 
         this.optionPrice_lbl.AutoSize = true;
         this.optionPrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionPrice_lbl.ForeColor = System.Drawing.Color.White;
         this.optionPrice_lbl.Location = new System.Drawing.Point(107, 0);
         this.optionPrice_lbl.Name = "optionPrice_lbl";
         this.optionPrice_lbl.Size = new System.Drawing.Size(60, 16);
         this.optionPrice_lbl.TabIndex = 13;
         this.optionPrice_lbl.Text = "Price: $";
         // 
         // newName_txtBx
         // 
         this.newName_txtBx.Location = new System.Drawing.Point(3, 17);
         this.newName_txtBx.Name = "newName_txtBx";
         this.newName_txtBx.Size = new System.Drawing.Size(76, 20);
         this.newName_txtBx.TabIndex = 8;
         // 
         // newPrice_txtBx
         // 
         this.newPrice_txtBx.Location = new System.Drawing.Point(110, 17);
         this.newPrice_txtBx.Name = "newPrice_txtBx";
         this.newPrice_txtBx.Size = new System.Drawing.Size(76, 20);
         this.newPrice_txtBx.TabIndex = 9;
         // 
         // price_txtBx
         // 
         this.price_txtBx.BackColor = System.Drawing.Color.White;
         this.price_txtBx.Enabled = false;
         this.price_txtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.price_txtBx.Location = new System.Drawing.Point(131, 55);
         this.price_txtBx.Name = "price_txtBx";
         this.price_txtBx.Size = new System.Drawing.Size(147, 26);
         this.price_txtBx.TabIndex = 11;
         this.price_txtBx.Text = "<price>";
         this.price_txtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.price_txtBx_KeyDown);
         // 
         // basePrice_lbl
         // 
         this.basePrice_lbl.AutoSize = true;
         this.basePrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.basePrice_lbl.ForeColor = System.Drawing.Color.White;
         this.basePrice_lbl.Location = new System.Drawing.Point(3, 55);
         this.basePrice_lbl.Name = "basePrice_lbl";
         this.basePrice_lbl.Size = new System.Drawing.Size(122, 20);
         this.basePrice_lbl.TabIndex = 10;
         this.basePrice_lbl.Text = "*Base Price: $";
         // 
         // options_lstBx
         // 
         this.options_lstBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.options_lstBx.BackColor = System.Drawing.Color.White;
         this.options_lstBx.Enabled = false;
         this.options_lstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.options_lstBx.FormattingEnabled = true;
         this.options_lstBx.ItemHeight = 20;
         this.options_lstBx.Items.AddRange(new object[] {
            "<New Option>"});
         this.options_lstBx.Location = new System.Drawing.Point(7, 153);
         this.options_lstBx.Margin = new System.Windows.Forms.Padding(0);
         this.options_lstBx.Name = "options_lstBx";
         this.options_lstBx.Size = new System.Drawing.Size(272, 524);
         this.options_lstBx.TabIndex = 7;
         this.options_lstBx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.options_lstBx_MouseClick);
         // 
         // description_rchTxtBx
         // 
         this.description_rchTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.description_rchTxtBx.BackColor = System.Drawing.Color.White;
         this.description_rchTxtBx.Enabled = false;
         this.description_rchTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.description_rchTxtBx.Location = new System.Drawing.Point(7, 114);
         this.description_rchTxtBx.Name = "description_rchTxtBx";
         this.description_rchTxtBx.Size = new System.Drawing.Size(239, 732);
         this.description_rchTxtBx.TabIndex = 6;
         this.description_rchTxtBx.Text = "";
         this.description_rchTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.description_rchTxtBx_KeyDown);
         // 
         // pickCat_cmbBx
         // 
         this.pickCat_cmbBx.BackColor = System.Drawing.Color.White;
         this.pickCat_cmbBx.Enabled = false;
         this.pickCat_cmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pickCat_cmbBx.FormattingEnabled = true;
         this.pickCat_cmbBx.Location = new System.Drawing.Point(99, 60);
         this.pickCat_cmbBx.Name = "pickCat_cmbBx";
         this.pickCat_cmbBx.Size = new System.Drawing.Size(147, 28);
         this.pickCat_cmbBx.TabIndex = 5;
         this.pickCat_cmbBx.Text = "<select category>";
         this.pickCat_cmbBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickCat_cmbBx_KeyDown);
         // 
         // name_txtBx
         // 
         this.name_txtBx.BackColor = System.Drawing.Color.White;
         this.name_txtBx.Enabled = false;
         this.name_txtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.name_txtBx.Location = new System.Drawing.Point(92, 28);
         this.name_txtBx.Name = "name_txtBx";
         this.name_txtBx.Size = new System.Drawing.Size(147, 26);
         this.name_txtBx.TabIndex = 4;
         this.name_txtBx.Text = "<name>";
         this.name_txtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_txtBx_KeyDown);
         // 
         // options_lbl
         // 
         this.options_lbl.AutoSize = true;
         this.options_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.options_lbl.ForeColor = System.Drawing.Color.White;
         this.options_lbl.Location = new System.Drawing.Point(13, 119);
         this.options_lbl.Name = "options_lbl";
         this.options_lbl.Size = new System.Drawing.Size(71, 20);
         this.options_lbl.TabIndex = 3;
         this.options_lbl.Text = "Options";
         // 
         // desciption_lbl
         // 
         this.desciption_lbl.AutoSize = true;
         this.desciption_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.desciption_lbl.ForeColor = System.Drawing.Color.White;
         this.desciption_lbl.Location = new System.Drawing.Point(3, 91);
         this.desciption_lbl.Name = "desciption_lbl";
         this.desciption_lbl.Size = new System.Drawing.Size(100, 20);
         this.desciption_lbl.TabIndex = 2;
         this.desciption_lbl.Text = "Description";
         // 
         // category_lbl
         // 
         this.category_lbl.AutoSize = true;
         this.category_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.category_lbl.ForeColor = System.Drawing.Color.White;
         this.category_lbl.Location = new System.Drawing.Point(-29, 54);
         this.category_lbl.Name = "category_lbl";
         this.category_lbl.Size = new System.Drawing.Size(88, 20);
         this.category_lbl.TabIndex = 1;
         this.category_lbl.Text = "*Category";
         // 
         // name_lbl
         // 
         this.name_lbl.AutoSize = true;
         this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.name_lbl.ForeColor = System.Drawing.Color.White;
         this.name_lbl.Location = new System.Drawing.Point(3, 31);
         this.name_lbl.Name = "name_lbl";
         this.name_lbl.Size = new System.Drawing.Size(62, 20);
         this.name_lbl.TabIndex = 0;
         this.name_lbl.Text = "*Name";
         // 
         // cmi_lbl
         // 
         this.cmi_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.cmi_lbl.AutoSize = true;
         this.cmi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmi_lbl.ForeColor = System.Drawing.Color.White;
         this.cmi_lbl.Location = new System.Drawing.Point(3, 10);
         this.cmi_lbl.Name = "cmi_lbl";
         this.cmi_lbl.Size = new System.Drawing.Size(218, 25);
         this.cmi_lbl.TabIndex = 5;
         this.cmi_lbl.Text = "Current Menu Items";
         // 
         // menuItems_pnl
         // 
         this.menuItems_pnl.AutoSize = true;
         this.menuItems_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.menuItems_pnl.Controls.Add(this.menuItems_lstBx);
         this.menuItems_pnl.Controls.Add(this.cmi_lbl);
         this.menuItems_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.menuItems_pnl.Location = new System.Drawing.Point(24, 81);
         this.menuItems_pnl.Name = "menuItems_pnl";
         this.menuItems_pnl.Size = new System.Drawing.Size(251, 541);
         this.menuItems_pnl.TabIndex = 7;
         // 
         // remove_btn
         // 
         this.remove_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.remove_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.remove_btn.ForeColor = System.Drawing.Color.White;
         this.remove_btn.Location = new System.Drawing.Point(24, 628);
         this.remove_btn.MaximumSize = new System.Drawing.Size(199, 72);
         this.remove_btn.Name = "remove_btn";
         this.remove_btn.Size = new System.Drawing.Size(199, 72);
         this.remove_btn.TabIndex = 8;
         this.remove_btn.Text = "Remove Item";
         this.remove_btn.UseVisualStyleBackColor = false;
         this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
         // 
         // menuItems_lstBx
         // 
         this.menuItems_lstBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.menuItems_lstBx.BackColor = System.Drawing.Color.White;
         this.menuItems_lstBx.ColumnWidth = 90;
         this.menuItems_lstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.menuItems_lstBx.FormattingEnabled = true;
         this.menuItems_lstBx.ItemHeight = 20;
         this.menuItems_lstBx.Items.AddRange(new object[] {
            "<New Item>"});
         this.menuItems_lstBx.Location = new System.Drawing.Point(0, 38);
         this.menuItems_lstBx.Margin = new System.Windows.Forms.Padding(0);
         this.menuItems_lstBx.Name = "menuItems_lstBx";
         this.menuItems_lstBx.Size = new System.Drawing.Size(221, 404);
         this.menuItems_lstBx.Sorted = true;
         this.menuItems_lstBx.TabIndex = 7;
         this.menuItems_lstBx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuItems_lstBx_MouseClick);
         // 
         // logout_btn
         // 
         this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.logout_btn.ForeColor = System.Drawing.Color.White;
         this.logout_btn.Location = new System.Drawing.Point(12, 712);
         this.logout_btn.Name = "logout_btn";
         this.logout_btn.Size = new System.Drawing.Size(120, 64);
         this.logout_btn.TabIndex = 8;
         this.logout_btn.Text = "Logout";
         this.logout_btn.UseVisualStyleBackColor = false;
         this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
         // 
         // pnl_main
         // 
         this.pnl_main.BackColor = System.Drawing.Color.Transparent;
         this.pnl_main.Controls.Add(this.tableLayoutPanel1);
         this.pnl_main.Controls.Add(this.pic_Pioneers);
         this.pnl_main.Controls.Add(this.logout_btn);
         this.pnl_main.Controls.Add(this.pic_Background);
         this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnl_main.Location = new System.Drawing.Point(0, 0);
         this.pnl_main.Name = "pnl_main";
         this.pnl_main.Size = new System.Drawing.Size(1084, 788);
         this.pnl_main.TabIndex = 9;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
         this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.tableLayoutPanel1.ColumnCount = 7;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
         this.tableLayoutPanel1.Controls.Add(this.newOption_pnl, 5, 2);
         this.tableLayoutPanel1.Controls.Add(this.panel2, 5, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.menuItems_pnl, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.remove_btn, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.submit_btn, 3, 2);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(222, 3);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 782);
         this.tableLayoutPanel1.TabIndex = 9;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.btn_undo);
         this.panel2.Controls.Add(this.txtBx_calories);
         this.panel2.Controls.Add(this.btn_redo);
         this.panel2.Controls.Add(this.lbl_calories);
         this.panel2.Controls.Add(this.basePrice_lbl);
         this.panel2.Controls.Add(this.options_lstBx);
         this.panel2.Controls.Add(this.price_txtBx);
         this.panel2.Controls.Add(this.options_lbl);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(580, 81);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(251, 541);
         this.panel2.TabIndex = 25;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
         this.panel1.Controls.Add(this.required_lbl);
         this.panel1.Controls.Add(this.name_lbl);
         this.panel1.Controls.Add(this.name_txtBx);
         this.panel1.Controls.Add(this.category_lbl);
         this.panel1.Controls.Add(this.pickCat_cmbBx);
         this.panel1.Controls.Add(this.desciption_lbl);
         this.panel1.Controls.Add(this.description_rchTxtBx);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(302, 81);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(251, 541);
         this.panel1.TabIndex = 11;
         // 
         // pic_Pioneers
         // 
         this.pic_Pioneers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
         this.pic_Pioneers.Image = ((System.Drawing.Image)(resources.GetObject("pic_Pioneers.Image")));
         this.pic_Pioneers.InitialImage = null;
         this.pic_Pioneers.Location = new System.Drawing.Point(12, 12);
         this.pic_Pioneers.Name = "pic_Pioneers";
         this.pic_Pioneers.Size = new System.Drawing.Size(204, 61);
         this.pic_Pioneers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pic_Pioneers.TabIndex = 9;
         this.pic_Pioneers.TabStop = false;
         // 
         // pic_Background
         // 
         this.pic_Background.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pic_Background.Image = ((System.Drawing.Image)(resources.GetObject("pic_Background.Image")));
         this.pic_Background.Location = new System.Drawing.Point(0, 0);
         this.pic_Background.Name = "pic_Background";
         this.pic_Background.Size = new System.Drawing.Size(1084, 788);
         this.pic_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pic_Background.TabIndex = 10;
         this.pic_Background.TabStop = false;
         // 
         // AdminForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BackColor = System.Drawing.Color.White;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(1084, 788);
         this.Controls.Add(this.pnl_main);
         this.DoubleBuffered = true;
         this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "AdminForm";
         this.Text = "AdminForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
         this.Load += new System.EventHandler(this.AdminForm_Load);
         this.SizeChanged += new System.EventHandler(this.AdminForm_SizeChanged);
         this.newOption_pnl.ResumeLayout(false);
         this.newOption_pnl.PerformLayout();
         this.menuItems_pnl.ResumeLayout(false);
         this.menuItems_pnl.PerformLayout();
         this.pnl_main.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pic_Pioneers)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button submit_btn;
      private System.Windows.Forms.Label cmi_lbl;
      private System.Windows.Forms.ComboBox pickCat_cmbBx;
      private System.Windows.Forms.TextBox name_txtBx;
      private System.Windows.Forms.Label options_lbl;
      private System.Windows.Forms.Label desciption_lbl;
      private System.Windows.Forms.Label category_lbl;
      private System.Windows.Forms.Label name_lbl;
      private System.Windows.Forms.ListBox options_lstBx;
      private System.Windows.Forms.RichTextBox description_rchTxtBx;
      private System.Windows.Forms.Panel menuItems_pnl;
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
        private System.Windows.Forms.Panel pnl_main;
      private System.Windows.Forms.Button remove_btn;
      private System.Windows.Forms.Label required_lbl;
      private System.Windows.Forms.Label lbl_calories;
      private System.Windows.Forms.TextBox txtBx_calories;
      private System.Windows.Forms.PictureBox pic_Pioneers;
      private System.Windows.Forms.PictureBox pic_Background;
      private System.Windows.Forms.Button btn_redo;
      private System.Windows.Forms.Button btn_undo;
      private System.Windows.Forms.Button btn_remOp;
      private System.Windows.Forms.ToolTip toolTipCommand;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel1;
   }
}

