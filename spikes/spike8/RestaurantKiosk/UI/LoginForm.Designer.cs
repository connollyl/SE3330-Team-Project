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
         this.lbl_title = new System.Windows.Forms.Label();
         this.btn_login = new System.Windows.Forms.Button();
         this.txtbx_passoword = new System.Windows.Forms.TextBox();
         this.txtbx_userName = new System.Windows.Forms.TextBox();
         this.panel_login = new System.Windows.Forms.Panel();
         this.btn_exit = new System.Windows.Forms.Button();
         this.pwLabel = new System.Windows.Forms.Label();
         this.unLabel = new System.Windows.Forms.Label();
         this.panel_login.SuspendLayout();
         this.SuspendLayout();
         // 
         // lbl_title
         // 
         this.lbl_title.AutoSize = true;
         this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_title.ForeColor = System.Drawing.Color.LightBlue;
         this.lbl_title.Location = new System.Drawing.Point(326, 139);
         this.lbl_title.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
         this.lbl_title.Name = "lbl_title";
         this.lbl_title.Size = new System.Drawing.Size(899, 126);
         this.lbl_title.TabIndex = 5;
         this.lbl_title.Text = "Restaurant Kiosk";
         // 
         // btn_login
         // 
         this.btn_login.BackColor = System.Drawing.Color.LightBlue;
         this.btn_login.Location = new System.Drawing.Point(934, 478);
         this.btn_login.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_login.Name = "btn_login";
         this.btn_login.Size = new System.Drawing.Size(209, 65);
         this.btn_login.TabIndex = 4;
         this.btn_login.Text = "Sign In";
         this.btn_login.UseVisualStyleBackColor = false;
         this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
         // 
         // txtbx_passoword
         // 
         this.txtbx_passoword.Location = new System.Drawing.Point(608, 404);
         this.txtbx_passoword.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.txtbx_passoword.Name = "txtbx_passoword";
         this.txtbx_passoword.PasswordChar = '*';
         this.txtbx_passoword.Size = new System.Drawing.Size(527, 44);
         this.txtbx_passoword.TabIndex = 3;
         // 
         // txtbx_userName
         // 
         this.txtbx_userName.Location = new System.Drawing.Point(608, 305);
         this.txtbx_userName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.txtbx_userName.Name = "txtbx_userName";
         this.txtbx_userName.Size = new System.Drawing.Size(527, 44);
         this.txtbx_userName.TabIndex = 2;
         // 
         // panel_login
         // 
         this.panel_login.Controls.Add(this.btn_exit);
         this.panel_login.Controls.Add(this.lbl_title);
         this.panel_login.Controls.Add(this.btn_login);
         this.panel_login.Controls.Add(this.txtbx_passoword);
         this.panel_login.Controls.Add(this.txtbx_userName);
         this.panel_login.Controls.Add(this.pwLabel);
         this.panel_login.Controls.Add(this.unLabel);
         this.panel_login.Location = new System.Drawing.Point(272, 165);
         this.panel_login.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.panel_login.Name = "panel_login";
         this.panel_login.Size = new System.Drawing.Size(1583, 996);
         this.panel_login.TabIndex = 1;
         // 
         // btn_exit
         // 
         this.btn_exit.Location = new System.Drawing.Point(1409, 922);
         this.btn_exit.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.btn_exit.Name = "btn_exit";
         this.btn_exit.Size = new System.Drawing.Size(165, 65);
         this.btn_exit.TabIndex = 6;
         this.btn_exit.Text = "Exit";
         this.btn_exit.UseVisualStyleBackColor = true;
         this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
         // 
         // pwLabel
         // 
         this.pwLabel.AutoSize = true;
         this.pwLabel.Location = new System.Drawing.Point(390, 404);
         this.pwLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
         this.pwLabel.Name = "pwLabel";
         this.pwLabel.Size = new System.Drawing.Size(167, 37);
         this.pwLabel.TabIndex = 1;
         this.pwLabel.Text = "Password:";
         // 
         // unLabel
         // 
         this.unLabel.AutoSize = true;
         this.unLabel.Location = new System.Drawing.Point(390, 305);
         this.unLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
         this.unLabel.Name = "unLabel";
         this.unLabel.Size = new System.Drawing.Size(188, 37);
         this.unLabel.TabIndex = 0;
         this.unLabel.Text = "User Name:";
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSlateGray;
         this.ClientSize = new System.Drawing.Size(2290, 1400);
         this.Controls.Add(this.panel_login);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
         this.Name = "LoginForm";
         this.Text = "LoginForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
         this.Load += new System.EventHandler(this.LoginForm_Load);
         this.SizeChanged += new System.EventHandler(this.LoginForm_SizeChanged);
         this.panel_login.ResumeLayout(false);
         this.panel_login.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbx_passoword;
        private System.Windows.Forms.TextBox txtbx_userName;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label unLabel;
      private System.Windows.Forms.Button btn_exit;
   }
}