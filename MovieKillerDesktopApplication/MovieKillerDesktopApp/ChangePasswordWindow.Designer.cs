namespace MovieKillerDesktopApp
{
    partial class ChangePasswordWindow
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
            if(disposing && (components != null))
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_newPassword = new System.Windows.Forms.Label();
            this.lb_oldPassword = new System.Windows.Forms.Label();
            this.tb_enterNewPassword = new System.Windows.Forms.TextBox();
            this.tb_enterOldPassword = new System.Windows.Forms.TextBox();
            this.btn_acceptChangePassword = new System.Windows.Forms.Button();
            this.btn_cancelChangePassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_newPassword);
            this.groupBox1.Controls.Add(this.lb_oldPassword);
            this.groupBox1.Controls.Add(this.tb_enterNewPassword);
            this.groupBox1.Controls.Add(this.tb_enterOldPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmień hasło";
            // 
            // lb_newPassword
            // 
            this.lb_newPassword.AutoSize = true;
            this.lb_newPassword.Location = new System.Drawing.Point(10, 65);
            this.lb_newPassword.Name = "lb_newPassword";
            this.lb_newPassword.Size = new System.Drawing.Size(203, 17);
            this.lb_newPassword.TabIndex = 6;
            this.lb_newPassword.Text = "Proszę wprowadzić nowe hasło";
            // 
            // lb_oldPassword
            // 
            this.lb_oldPassword.AutoSize = true;
            this.lb_oldPassword.Location = new System.Drawing.Point(10, 20);
            this.lb_oldPassword.Name = "lb_oldPassword";
            this.lb_oldPassword.Size = new System.Drawing.Size(202, 17);
            this.lb_oldPassword.TabIndex = 4;
            this.lb_oldPassword.Text = "Proszę wprowadzić stare hasło";
            // 
            // tb_enterNewPassword
            // 
            this.tb_enterNewPassword.Location = new System.Drawing.Point(13, 91);
            this.tb_enterNewPassword.MaxLength = 8;
            this.tb_enterNewPassword.Name = "tb_enterNewPassword";
            this.tb_enterNewPassword.PasswordChar = '*';
            this.tb_enterNewPassword.Size = new System.Drawing.Size(235, 22);
            this.tb_enterNewPassword.TabIndex = 5;
            // 
            // tb_enterOldPassword
            // 
            this.tb_enterOldPassword.Location = new System.Drawing.Point(13, 40);
            this.tb_enterOldPassword.MaxLength = 8;
            this.tb_enterOldPassword.Name = "tb_enterOldPassword";
            this.tb_enterOldPassword.PasswordChar = '*';
            this.tb_enterOldPassword.Size = new System.Drawing.Size(235, 22);
            this.tb_enterOldPassword.TabIndex = 3;
            // 
            // btn_acceptChangePassword
            // 
            this.btn_acceptChangePassword.Location = new System.Drawing.Point(12, 150);
            this.btn_acceptChangePassword.Name = "btn_acceptChangePassword";
            this.btn_acceptChangePassword.Size = new System.Drawing.Size(115, 47);
            this.btn_acceptChangePassword.TabIndex = 1;
            this.btn_acceptChangePassword.Text = "Zmień hasło";
            this.btn_acceptChangePassword.UseVisualStyleBackColor = true;
            this.btn_acceptChangePassword.Click += new System.EventHandler(this.btn_acceptChangePassword_Click);
            // 
            // btn_cancelChangePassword
            // 
            this.btn_cancelChangePassword.Location = new System.Drawing.Point(155, 150);
            this.btn_cancelChangePassword.Name = "btn_cancelChangePassword";
            this.btn_cancelChangePassword.Size = new System.Drawing.Size(115, 47);
            this.btn_cancelChangePassword.TabIndex = 2;
            this.btn_cancelChangePassword.Text = "Anuluj";
            this.btn_cancelChangePassword.UseVisualStyleBackColor = true;
            this.btn_cancelChangePassword.Click += new System.EventHandler(this.btn_cancelChangePassword_Click);
            // 
            // ChangePasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 215);
            this.Controls.Add(this.btn_cancelChangePassword);
            this.Controls.Add(this.btn_acceptChangePassword);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChangePasswordWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_newPassword;
        private System.Windows.Forms.Label lb_oldPassword;
        private System.Windows.Forms.TextBox tb_enterNewPassword;
        private System.Windows.Forms.TextBox tb_enterOldPassword;
        private System.Windows.Forms.Button btn_acceptChangePassword;
        private System.Windows.Forms.Button btn_cancelChangePassword;
    }
}