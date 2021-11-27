
namespace DataView
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(419, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label2.Location = new System.Drawing.Point(423, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textUser.Location = new System.Drawing.Point(317, 159);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(345, 32);
            this.textUser.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textPassword.Location = new System.Drawing.Point(317, 261);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(345, 32);
            this.textPassword.TabIndex = 4;
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.BtnLogin.Location = new System.Drawing.Point(403, 356);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(177, 42);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 72);
            this.label3.TabIndex = 6;
            this.label3.Text = "Software de Hotelaria";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(919, 451);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 486);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelaria Pim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
    }
}

