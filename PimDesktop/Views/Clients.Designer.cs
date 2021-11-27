
namespace PimDesktop
{
    partial class Clients
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
            this.textNrDocumentSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.TypesBox = new System.Windows.Forms.ComboBox();
            this.labelTypeDocument = new System.Windows.Forms.Label();
            this.labelDocument = new System.Windows.Forms.Label();
            this.textDocument = new System.Windows.Forms.TextBox();
            this.labelExpeditor = new System.Windows.Forms.Label();
            this.textExpeditor = new System.Windows.Forms.TextBox();
            this.textFunction = new System.Windows.Forms.TextBox();
            this.labelFunction = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textZipCode = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelComplement = new System.Windows.Forms.Label();
            this.textComplement = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textSecondContact = new System.Windows.Forms.TextBox();
            this.labelSecondContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(679, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textNrDocumentSearch
            // 
            this.textNrDocumentSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textNrDocumentSearch.Location = new System.Drawing.Point(322, 38);
            this.textNrDocumentSearch.MaxLength = 70;
            this.textNrDocumentSearch.Name = "textNrDocumentSearch";
            this.textNrDocumentSearch.Size = new System.Drawing.Size(345, 32);
            this.textNrDocumentSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Documento";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textId.Location = new System.Drawing.Point(323, 84);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(50, 32);
            this.textId.TabIndex = 9999;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label2.Location = new System.Drawing.Point(228, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // textCPF
            // 
            this.textCPF.Enabled = false;
            this.textCPF.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textCPF.Location = new System.Drawing.Point(153, 226);
            this.textCPF.MaxLength = 11;
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(345, 32);
            this.textCPF.TabIndex = 6;
            this.textCPF.Visible = false;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelCPF.Location = new System.Drawing.Point(34, 212);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(77, 46);
            this.labelCPF.TabIndex = 9;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Visible = false;
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textName.HideSelection = false;
            this.textName.Location = new System.Drawing.Point(150, 171);
            this.textName.MaxLength = 60;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(345, 32);
            this.textName.TabIndex = 4;
            this.textName.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelName.Location = new System.Drawing.Point(32, 157);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 46);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Nome";
            this.labelName.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(325, 578);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 43);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(530, 577);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 43);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "Salvar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(905, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClient.Location = new System.Drawing.Point(839, 39);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(140, 32);
            this.btnCreateClient.TabIndex = 3;
            this.btnCreateClient.Text = "Novo";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // TypesBox
            // 
            this.TypesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypesBox.Enabled = false;
            this.TypesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypesBox.FormattingEnabled = true;
            this.TypesBox.Location = new System.Drawing.Point(153, 280);
            this.TypesBox.Name = "TypesBox";
            this.TypesBox.Size = new System.Drawing.Size(146, 32);
            this.TypesBox.TabIndex = 8;
            this.TypesBox.Visible = false;
            // 
            // labelTypeDocument
            // 
            this.labelTypeDocument.AutoSize = true;
            this.labelTypeDocument.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelTypeDocument.Location = new System.Drawing.Point(34, 266);
            this.labelTypeDocument.Name = "labelTypeDocument";
            this.labelTypeDocument.Size = new System.Drawing.Size(86, 46);
            this.labelTypeDocument.TabIndex = 23;
            this.labelTypeDocument.Text = "Tipo";
            this.labelTypeDocument.Visible = false;
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelDocument.Location = new System.Drawing.Point(314, 271);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(243, 46);
            this.labelDocument.TabIndex = 24;
            this.labelDocument.Text = "Nr Documento";
            this.labelDocument.Visible = false;
            // 
            // textDocument
            // 
            this.textDocument.Enabled = false;
            this.textDocument.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textDocument.Location = new System.Drawing.Point(563, 279);
            this.textDocument.MaxLength = 24;
            this.textDocument.Name = "textDocument";
            this.textDocument.Size = new System.Drawing.Size(226, 32);
            this.textDocument.TabIndex = 9;
            this.textDocument.Visible = false;
            // 
            // labelExpeditor
            // 
            this.labelExpeditor.AutoSize = true;
            this.labelExpeditor.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelExpeditor.Location = new System.Drawing.Point(34, 324);
            this.labelExpeditor.Name = "labelExpeditor";
            this.labelExpeditor.Size = new System.Drawing.Size(275, 46);
            this.labelExpeditor.TabIndex = 27;
            this.labelExpeditor.Text = "Órgão Expedidor";
            this.labelExpeditor.Visible = false;
            // 
            // textExpeditor
            // 
            this.textExpeditor.Enabled = false;
            this.textExpeditor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textExpeditor.Location = new System.Drawing.Point(309, 337);
            this.textExpeditor.MaxLength = 70;
            this.textExpeditor.Name = "textExpeditor";
            this.textExpeditor.Size = new System.Drawing.Size(71, 32);
            this.textExpeditor.TabIndex = 10;
            this.textExpeditor.Visible = false;
            // 
            // textFunction
            // 
            this.textFunction.Enabled = false;
            this.textFunction.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textFunction.Location = new System.Drawing.Point(530, 338);
            this.textFunction.MaxLength = 70;
            this.textFunction.Name = "textFunction";
            this.textFunction.Size = new System.Drawing.Size(259, 32);
            this.textFunction.TabIndex = 11;
            this.textFunction.Visible = false;
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelFunction.Location = new System.Drawing.Point(401, 325);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(128, 46);
            this.labelFunction.TabIndex = 30;
            this.labelFunction.Text = "Função";
            this.labelFunction.Visible = false;
            // 
            // dateBirth
            // 
            this.dateBirth.Enabled = false;
            this.dateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateBirth.Location = new System.Drawing.Point(726, 171);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(137, 29);
            this.dateBirth.TabIndex = 5;
            this.dateBirth.Visible = false;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelBirth.Location = new System.Drawing.Point(524, 158);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(198, 46);
            this.labelBirth.TabIndex = 31;
            this.labelBirth.Text = "Nascimento";
            this.labelBirth.Visible = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelCountry.Location = new System.Drawing.Point(34, 381);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(77, 46);
            this.labelCountry.TabIndex = 35;
            this.labelCountry.Text = "País";
            this.labelCountry.Visible = false;
            // 
            // textCountry
            // 
            this.textCountry.Enabled = false;
            this.textCountry.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textCountry.Location = new System.Drawing.Point(152, 394);
            this.textCountry.MaxLength = 70;
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(147, 32);
            this.textCountry.TabIndex = 12;
            this.textCountry.Visible = false;
            // 
            // textState
            // 
            this.textState.Enabled = false;
            this.textState.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textState.Location = new System.Drawing.Point(440, 394);
            this.textState.MaxLength = 70;
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(147, 32);
            this.textState.TabIndex = 12;
            this.textState.Visible = false;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelState.Location = new System.Drawing.Point(314, 382);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(120, 46);
            this.labelState.TabIndex = 38;
            this.labelState.Text = "Estado";
            this.labelState.Visible = false;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelCity.Location = new System.Drawing.Point(622, 382);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(124, 46);
            this.labelCity.TabIndex = 39;
            this.labelCity.Text = "Cidade";
            this.labelCity.Visible = false;
            // 
            // textCity
            // 
            this.textCity.Enabled = false;
            this.textCity.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textCity.Location = new System.Drawing.Point(752, 394);
            this.textCity.MaxLength = 70;
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(147, 32);
            this.textCity.TabIndex = 13;
            this.textCity.Visible = false;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelZipCode.Location = new System.Drawing.Point(38, 436);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(77, 46);
            this.labelZipCode.TabIndex = 41;
            this.labelZipCode.Text = "CEP";
            this.labelZipCode.Visible = false;
            // 
            // textZipCode
            // 
            this.textZipCode.Enabled = false;
            this.textZipCode.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textZipCode.Location = new System.Drawing.Point(134, 449);
            this.textZipCode.MaxLength = 12;
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.Size = new System.Drawing.Size(147, 32);
            this.textZipCode.TabIndex = 14;
            this.textZipCode.Visible = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelAddress.Location = new System.Drawing.Point(301, 436);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(160, 46);
            this.labelAddress.TabIndex = 43;
            this.labelAddress.Text = "Endereço";
            this.labelAddress.Visible = false;
            // 
            // textAddress
            // 
            this.textAddress.Enabled = false;
            this.textAddress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textAddress.Location = new System.Drawing.Point(467, 449);
            this.textAddress.MaxLength = 70;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(369, 32);
            this.textAddress.TabIndex = 15;
            this.textAddress.Visible = false;
            // 
            // labelComplement
            // 
            this.labelComplement.AutoSize = true;
            this.labelComplement.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelComplement.Location = new System.Drawing.Point(38, 491);
            this.labelComplement.Name = "labelComplement";
            this.labelComplement.Size = new System.Drawing.Size(234, 46);
            this.labelComplement.TabIndex = 45;
            this.labelComplement.Text = "Complemento";
            this.labelComplement.Visible = false;
            // 
            // textComplement
            // 
            this.textComplement.Enabled = false;
            this.textComplement.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textComplement.Location = new System.Drawing.Point(278, 504);
            this.textComplement.MaxLength = 70;
            this.textComplement.Name = "textComplement";
            this.textComplement.Size = new System.Drawing.Size(147, 32);
            this.textComplement.TabIndex = 16;
            this.textComplement.Visible = false;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelContact.Location = new System.Drawing.Point(526, 212);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(141, 46);
            this.labelContact.TabIndex = 47;
            this.labelContact.Text = "Contato";
            this.labelContact.Visible = false;
            // 
            // textContact
            // 
            this.textContact.Enabled = false;
            this.textContact.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textContact.Location = new System.Drawing.Point(679, 225);
            this.textContact.MaxLength = 15;
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(134, 32);
            this.textContact.TabIndex = 7;
            this.textContact.Visible = false;
            // 
            // textSecondContact
            // 
            this.textSecondContact.Enabled = false;
            this.textSecondContact.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textSecondContact.Location = new System.Drawing.Point(765, 504);
            this.textSecondContact.MaxLength = 15;
            this.textSecondContact.Name = "textSecondContact";
            this.textSecondContact.Size = new System.Drawing.Size(134, 32);
            this.textSecondContact.TabIndex = 17;
            this.textSecondContact.Visible = false;
            // 
            // labelSecondContact
            // 
            this.labelSecondContact.AutoSize = true;
            this.labelSecondContact.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelSecondContact.Location = new System.Drawing.Point(462, 491);
            this.labelSecondContact.Name = "labelSecondContact";
            this.labelSecondContact.Size = new System.Drawing.Size(284, 46);
            this.labelSecondContact.TabIndex = 49;
            this.labelSecondContact.Text = "Segundo Contato";
            this.labelSecondContact.Visible = false;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.textSecondContact);
            this.Controls.Add(this.labelSecondContact);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.textComplement);
            this.Controls.Add(this.labelComplement);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textZipCode);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelFunction);
            this.Controls.Add(this.textFunction);
            this.Controls.Add(this.textExpeditor);
            this.Controls.Add(this.labelExpeditor);
            this.Controls.Add(this.textDocument);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.labelTypeDocument);
            this.Controls.Add(this.TypesBox);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNrDocumentSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospede";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clients_FormClosing);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textNrDocumentSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.ComboBox TypesBox;
        private System.Windows.Forms.Label labelTypeDocument;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.TextBox textDocument;
        private System.Windows.Forms.Label labelExpeditor;
        private System.Windows.Forms.TextBox textExpeditor;
        private System.Windows.Forms.TextBox textFunction;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textZipCode;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelComplement;
        private System.Windows.Forms.TextBox textComplement;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textSecondContact;
        private System.Windows.Forms.Label labelSecondContact;
    }
}