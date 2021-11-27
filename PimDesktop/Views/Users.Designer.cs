
namespace PimDesktop
{
    partial class Users
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkUserEnabled = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.profilesBox = new System.Windows.Forms.ComboBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(579, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textUser.Location = new System.Drawing.Point(195, 38);
            this.textUser.MaxLength = 70;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(345, 32);
            this.textUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textId.Location = new System.Drawing.Point(322, 146);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(51, 32);
            this.textId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label2.Location = new System.Drawing.Point(227, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textEmail.Location = new System.Drawing.Point(324, 290);
            this.textEmail.MaxLength = 70;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(345, 32);
            this.textEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label3.Location = new System.Drawing.Point(185, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textName.Location = new System.Drawing.Point(324, 219);
            this.textName.MaxLength = 20;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(345, 32);
            this.textName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label4.Location = new System.Drawing.Point(187, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // textPassword
            // 
            this.textPassword.Enabled = false;
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textPassword.Location = new System.Drawing.Point(325, 428);
            this.textPassword.MaxLength = 20;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(345, 32);
            this.textPassword.TabIndex = 8;
            this.textPassword.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelPassword.Location = new System.Drawing.Point(188, 415);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(111, 46);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Senha";
            this.labelPassword.Visible = false;
            // 
            // checkUserEnabled
            // 
            this.checkUserEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUserEnabled.AutoSize = true;
            this.checkUserEnabled.Enabled = false;
            this.checkUserEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F);
            this.checkUserEnabled.Location = new System.Drawing.Point(575, 145);
            this.checkUserEnabled.Name = "checkUserEnabled";
            this.checkUserEnabled.Size = new System.Drawing.Size(94, 35);
            this.checkUserEnabled.TabIndex = 4;
            this.checkUserEnabled.Text = "Ativo";
            this.checkUserEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkUserEnabled.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(325, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 43);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(530, 543);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 43);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Salvar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Enabled = false;
            this.textConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textConfirmPassword.Location = new System.Drawing.Point(324, 484);
            this.textConfirmPassword.MaxLength = 20;
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.PasswordChar = '*';
            this.textConfirmPassword.Size = new System.Drawing.Size(345, 32);
            this.textConfirmPassword.TabIndex = 9;
            this.textConfirmPassword.Visible = false;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(34, 474);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(284, 46);
            this.labelConfirmPassword.TabIndex = 19;
            this.labelConfirmPassword.Text = "Confirme a Senha";
            this.labelConfirmPassword.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(905, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(740, 39);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(140, 32);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Novo";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // profilesBox
            // 
            this.profilesBox.Enabled = false;
            this.profilesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilesBox.FormattingEnabled = true;
            this.profilesBox.Location = new System.Drawing.Point(322, 356);
            this.profilesBox.Name = "profilesBox";
            this.profilesBox.Size = new System.Drawing.Size(347, 32);
            this.profilesBox.TabIndex = 7;
            this.profilesBox.Text = "-- Selecione --";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelProfile.Location = new System.Drawing.Point(204, 347);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(95, 46);
            this.labelProfile.TabIndex = 23;
            this.labelProfile.Text = "Perfil";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.profilesBox);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkUserEnabled);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkUserEnabled;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ComboBox profilesBox;
        private System.Windows.Forms.Label labelProfile;
    }
}