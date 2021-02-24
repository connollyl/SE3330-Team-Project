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
            this.lbl_title.Location = new System.Drawing.Point(162, 45);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(173, 42);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Welcome";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightBlue;
            this.btn_login.Location = new System.Drawing.Point(136, 177);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(212, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Sign In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtbx_passoword
            // 
            this.txtbx_passoword.Location = new System.Drawing.Point(192, 139);
            this.txtbx_passoword.Name = "txtbx_passoword";
            this.txtbx_passoword.PasswordChar = '*';
            this.txtbx_passoword.Size = new System.Drawing.Size(169, 20);
            this.txtbx_passoword.TabIndex = 3;
            // 
            // txtbx_userName
            // 
            this.txtbx_userName.Location = new System.Drawing.Point(192, 104);
            this.txtbx_userName.Name = "txtbx_userName";
            this.txtbx_userName.Size = new System.Drawing.Size(169, 20);
            this.txtbx_userName.TabIndex = 2;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.lbl_title);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.txtbx_passoword);
            this.panel_login.Controls.Add(this.txtbx_userName);
            this.panel_login.Controls.Add(this.pwLabel);
            this.panel_login.Controls.Add(this.unLabel);
            this.panel_login.Location = new System.Drawing.Point(86, 58);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(500, 350);
            this.panel_login.TabIndex = 1;
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(123, 139);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(56, 13);
            this.pwLabel.TabIndex = 1;
            this.pwLabel.Text = "Password:";
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(123, 104);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(63, 13);
            this.unLabel.TabIndex = 0;
            this.unLabel.Text = "User Name:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(723, 492);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}