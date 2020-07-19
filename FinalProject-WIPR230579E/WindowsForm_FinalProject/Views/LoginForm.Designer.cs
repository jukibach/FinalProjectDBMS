namespace WindowsForm_FinalProject.Views
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
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.panelMatKhau = new System.Windows.Forms.Panel();
            this.panelTenDangNhap = new System.Windows.Forms.Panel();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelBack.SuspendLayout();
            this.panelMatKhau.SuspendLayout();
            this.panelTenDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMinimize.Location = new System.Drawing.Point(429, 13);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(53, 49);
            this.buttonMinimize.TabIndex = 17;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelBack.Controls.Add(this.labelLogin);
            this.panelBack.Location = new System.Drawing.Point(22, 13);
            this.panelBack.Margin = new System.Windows.Forms.Padding(4);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(179, 62);
            this.panelBack.TabIndex = 16;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogin.Location = new System.Drawing.Point(59, 14);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 29);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(490, 13);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(53, 49);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "×";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.AccessibleDescription = "";
            this.textBoxTenDangNhap.AllowDrop = true;
            this.textBoxTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(1, 9);
            this.textBoxTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(299, 25);
            this.textBoxTenDangNhap.TabIndex = 2;
            this.textBoxTenDangNhap.Text = "Username";
            this.textBoxTenDangNhap.Click += new System.EventHandler(this.textBoxTenDangNhap_Click);
            this.textBoxTenDangNhap.Leave += new System.EventHandler(this.textBoxTenDangNhap_Leave);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxMatKhau.Location = new System.Drawing.Point(4, 10);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(296, 25);
            this.textBoxMatKhau.TabIndex = 2;
            this.textBoxMatKhau.Text = "Password";
            this.textBoxMatKhau.Click += new System.EventHandler(this.textBoxMatKhau_Click);
            this.textBoxMatKhau.Leave += new System.EventHandler(this.textBoxMatKhau_Leave);
            // 
            // panelMatKhau
            // 
            this.panelMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.panelMatKhau.Controls.Add(this.textBoxMatKhau);
            this.panelMatKhau.Location = new System.Drawing.Point(244, 138);
            this.panelMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.panelMatKhau.Name = "panelMatKhau";
            this.panelMatKhau.Size = new System.Drawing.Size(300, 43);
            this.panelMatKhau.TabIndex = 22;
            // 
            // panelTenDangNhap
            // 
            this.panelTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.panelTenDangNhap.Controls.Add(this.textBoxTenDangNhap);
            this.panelTenDangNhap.Location = new System.Drawing.Point(244, 88);
            this.panelTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.panelTenDangNhap.Name = "panelTenDangNhap";
            this.panelTenDangNhap.Size = new System.Drawing.Size(300, 43);
            this.panelTenDangNhap.TabIndex = 21;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackgroundImage = global::WindowsForm_FinalProject.Properties.Resources.buttonExit;
            this.buttonDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDangNhap.FlatAppearance.BorderSize = 0;
            this.buttonDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.Location = new System.Drawing.Point(476, 189);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(67, 62);
            this.buttonDangNhap.TabIndex = 20;
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImage = global::WindowsForm_FinalProject.Properties.Resources.Student;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUser.Location = new System.Drawing.Point(69, 88);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(167, 154);
            this.pictureBoxUser.TabIndex = 19;
            this.pictureBoxUser.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 420);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelMatKhau);
            this.Controls.Add(this.panelTenDangNhap);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.pictureBoxUser);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelMatKhau.ResumeLayout(false);
            this.panelMatKhau.PerformLayout();
            this.panelTenDangNhap.ResumeLayout(false);
            this.panelTenDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Panel panelMatKhau;
        private System.Windows.Forms.Panel panelTenDangNhap;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.PictureBox pictureBoxUser;
    }
}