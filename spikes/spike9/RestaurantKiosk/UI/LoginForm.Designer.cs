namespace RestaurantKiosk
{
    partial class LoginForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
         this.lbl_title = new System.Windows.Forms.Label();
         this.pnl_inner = new System.Windows.Forms.Panel();
         this.lbl_screen = new System.Windows.Forms.Label();
         this.btn_exit = new System.Windows.Forms.Button();
         this.btn_login = new System.Windows.Forms.Button();
         this.txtbx_password = new System.Windows.Forms.TextBox();
         this.txtbx_userName = new System.Windows.Forms.TextBox();
         this.pwLabel = new System.Windows.Forms.Label();
         this.unLabel = new System.Windows.Forms.Label();
         this.panel_login = new System.Windows.Forms.Panel();
         this.pnl_inner.SuspendLayout();
         this.panel_login.SuspendLayout();
         this.SuspendLayout();
         // 
         // lbl_title
         // 
         this.lbl_title.AutoSize = true;
         this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.lbl_title.Location = new System.Drawing.Point(173, 0);
         this.lbl_title.Name = "lbl_title";
         this.lbl_title.Size = new System.Drawing.Size(303, 42);
         this.lbl_title.TabIndex = 6;
         this.lbl_title.Text = "Restaurant Kiosk";
         this.lbl_title.Visible = false;
         // 
         // pnl_inner
         // 
         this.pnl_inner.Controls.Add(this.lbl_screen);
         this.pnl_inner.Controls.Add(this.btn_exit);
         this.pnl_inner.Controls.Add(this.btn_login);
         this.pnl_inner.Controls.Add(this.txtbx_password);
         this.pnl_inner.Controls.Add(this.txtbx_userName);
         this.pnl_inner.Controls.Add(this.pwLabel);
         this.pnl_inner.Controls.Add(this.unLabel);
         this.pnl_inner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pnl_inner.Location = new System.Drawing.Point(129, 93);
         this.pnl_inner.Name = "pnl_inner";
         this.pnl_inner.Size = new System.Drawing.Size(854, 536);
         this.pnl_inner.TabIndex = 10;
         // 
         // lbl_screen
         // 
         this.lbl_screen.AutoSize = true;
         this.lbl_screen.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_screen.Location = new System.Drawing.Point(318, 75);
         this.lbl_screen.Name = "lbl_screen";
         this.lbl_screen.Size = new System.Drawing.Size(230, 57);
         this.lbl_screen.TabIndex = 10;
         this.lbl_screen.Text = "Kiosk Login";
         // 
         // btn_exit
         // 
         this.btn_exit.BackColor = System.Drawing.Color.White;
         this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_exit.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_exit.Location = new System.Drawing.Point(569, 365);
         this.btn_exit.Name = "btn_exit";
         this.btn_exit.Size = new System.Drawing.Size(159, 82);
         this.btn_exit.TabIndex = 3;
         this.btn_exit.Text = "E&xit";
         this.btn_exit.UseVisualStyleBackColor = false;
         this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
         // 
         // btn_login
         // 
         this.btn_login.BackColor = System.Drawing.Color.White;
         this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btn_login.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_login.ForeColor = System.Drawing.Color.Black;
         this.btn_login.Location = new System.Drawing.Point(143, 365);
         this.btn_login.Name = "btn_login";
         this.btn_login.Size = new System.Drawing.Size(159, 82);
         this.btn_login.TabIndex = 2;
         this.btn_login.Text = "Sign In";
         this.btn_login.UseVisualStyleBackColor = false;
         this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
         // 
         // txtbx_password
         // 
         this.txtbx_password.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtbx_password.Location = new System.Drawing.Point(285, 248);
         this.txtbx_password.Name = "txtbx_password";
         this.txtbx_password.PasswordChar = '*';
         this.txtbx_password.Size = new System.Drawing.Size(443, 41);
         this.txtbx_password.TabIndex = 1;
         this.txtbx_password.Text = "guest";
         this.txtbx_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_password_KeyDown);
         // 
         // txtbx_userName
         // 
         this.txtbx_userName.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtbx_userName.Location = new System.Drawing.Point(285, 179);
         this.txtbx_userName.Name = "txtbx_userName";
         this.txtbx_userName.Size = new System.Drawing.Size(443, 41);
         this.txtbx_userName.TabIndex = 0;
         this.txtbx_userName.Text = "guest";
         this.txtbx_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_userName_KeyDown);
         // 
         // pwLabel
         // 
         this.pwLabel.AutoSize = true;
         this.pwLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pwLabel.Location = new System.Drawing.Point(152, 251);
         this.pwLabel.Name = "pwLabel";
         this.pwLabel.Size = new System.Drawing.Size(127, 33);
         this.pwLabel.TabIndex = 9;
         this.pwLabel.Text = "Password:";
         // 
         // unLabel
         // 
         this.unLabel.AutoSize = true;
         this.unLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.unLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.unLabel.Location = new System.Drawing.Point(137, 179);
         this.unLabel.Name = "unLabel";
         this.unLabel.Size = new System.Drawing.Size(142, 33);
         this.unLabel.TabIndex = 9;
         this.unLabel.Text = "User Name:";
         // 
         // panel_login
         // 
         this.panel_login.BackColor = System.Drawing.Color.Transparent;
         this.panel_login.Controls.Add(this.pnl_inner);
         this.panel_login.Controls.Add(this.lbl_title);
         this.panel_login.Location = new System.Drawing.Point(12, 12);
         this.panel_login.Name = "panel_login";
         this.panel_login.Size = new System.Drawing.Size(1093, 667);
         this.panel_login.TabIndex = 5;
         this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.BackgroundImage = global::RestaurantKiosk.Properties.Resources.background;
         this.ClientSize = new System.Drawing.Size(1129, 691);
         this.ControlBox = false;
         this.Controls.Add(this.panel_login);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "LoginForm";
         this.Text = "LoginForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
         this.Load += new System.EventHandler(this.LoginForm_Load);
         this.Shown += new System.EventHandler(this.LoginForm_Shown);
         this.pnl_inner.ResumeLayout(false);
         this.pnl_inner.PerformLayout();
         this.panel_login.ResumeLayout(false);
         this.panel_login.PerformLayout();
         this.ResumeLayout(false);

        }

      #endregion

      private System.Windows.Forms.Label lbl_title;
      private System.Windows.Forms.Panel pnl_inner;
      private System.Windows.Forms.Label lbl_screen;
      private System.Windows.Forms.Button btn_exit;
      private System.Windows.Forms.Button btn_login;
      private System.Windows.Forms.TextBox txtbx_password;
      private System.Windows.Forms.TextBox txtbx_userName;
      private System.Windows.Forms.Label pwLabel;
      private System.Windows.Forms.Label unLabel;
      private System.Windows.Forms.Panel panel_login;
   }
}