
namespace PimDesktop
{
    partial class Employees
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAdmission = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.labelDemission = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.textFunction = new System.Windows.Forms.TextBox();
            this.dateAdmission = new System.Windows.Forms.DateTimePicker();
            this.dateDemission = new System.Windows.Forms.DateTimePicker();
            this.checkUserEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(579, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textSearch.Location = new System.Drawing.Point(195, 38);
            this.textSearch.MaxLength = 70;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(345, 32);
            this.textSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matricula";
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
            // textRN
            // 
            this.textRN.Enabled = false;
            this.textRN.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textRN.Location = new System.Drawing.Point(324, 290);
            this.textRN.MaxLength = 70;
            this.textRN.Name = "textRN";
            this.textRN.Size = new System.Drawing.Size(345, 32);
            this.textRN.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label3.Location = new System.Drawing.Point(158, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Matricula";
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textName.Location = new System.Drawing.Point(324, 219);
            this.textName.MaxLength = 20;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(345, 32);
            this.textName.TabIndex = 7;
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
            // labelAdmission
            // 
            this.labelAdmission.AutoSize = true;
            this.labelAdmission.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelAdmission.Location = new System.Drawing.Point(158, 415);
            this.labelAdmission.Name = "labelAdmission";
            this.labelAdmission.Size = new System.Drawing.Size(164, 46);
            this.labelAdmission.TabIndex = 13;
            this.labelAdmission.Text = "Admissao";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(325, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 43);
            this.btnUpdate.TabIndex = 14;
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
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Salvar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // labelDemission
            // 
            this.labelDemission.AutoSize = true;
            this.labelDemission.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelDemission.Location = new System.Drawing.Point(159, 474);
            this.labelDemission.Name = "labelDemission";
            this.labelDemission.Size = new System.Drawing.Size(164, 46);
            this.labelDemission.TabIndex = 19;
            this.labelDemission.Text = "Demissao";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(905, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmployee.Location = new System.Drawing.Point(740, 39);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(140, 32);
            this.btnCreateEmployee.TabIndex = 6;
            this.btnCreateEmployee.Text = "Novo";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelProfile.Location = new System.Drawing.Point(182, 347);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(128, 46);
            this.labelProfile.TabIndex = 23;
            this.labelProfile.Text = "Funcao";
            // 
            // textFunction
            // 
            this.textFunction.Enabled = false;
            this.textFunction.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textFunction.Location = new System.Drawing.Point(325, 361);
            this.textFunction.MaxLength = 70;
            this.textFunction.Name = "textFunction";
            this.textFunction.Size = new System.Drawing.Size(345, 32);
            this.textFunction.TabIndex = 9;
            // 
            // dateAdmission
            // 
            this.dateAdmission.Enabled = false;
            this.dateAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAdmission.Location = new System.Drawing.Point(328, 430);
            this.dateAdmission.Name = "dateAdmission";
            this.dateAdmission.Size = new System.Drawing.Size(137, 29);
            this.dateAdmission.TabIndex = 10;
            // 
            // dateDemission
            // 
            this.dateDemission.Enabled = false;
            this.dateDemission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDemission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDemission.Location = new System.Drawing.Point(328, 489);
            this.dateDemission.Name = "dateDemission";
            this.dateDemission.Size = new System.Drawing.Size(137, 29);
            this.dateDemission.TabIndex = 11;
            this.dateDemission.ValueChanged += new System.EventHandler(this.dateDemission_ValueChanged);
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
            this.checkUserEnabled.TabIndex = 12;
            this.checkUserEnabled.Text = "Ativo";
            this.checkUserEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkUserEnabled.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.dateDemission);
            this.Controls.Add(this.dateAdmission);
            this.Controls.Add(this.textFunction);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelDemission);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkUserEnabled);
            this.Controls.Add(this.labelAdmission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employees_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAdmission;
        private System.Windows.Forms.TextBox textRN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label labelDemission;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.TextBox textFunction;
        private System.Windows.Forms.DateTimePicker dateAdmission;
        private System.Windows.Forms.DateTimePicker dateDemission;
        private System.Windows.Forms.CheckBox checkUserEnabled;
    }
}