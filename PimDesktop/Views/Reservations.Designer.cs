
namespace PimDesktop
{
    partial class Reservations
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
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNrDocumentSearch = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.RoomsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLastPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNextPlace = new System.Windows.Forms.TextBox();
            this.textTravelReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textTransport = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnVerifyRooms = new System.Windows.Forms.Button();
            this.textClientId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textName.HideSelection = false;
            this.textName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textName.Location = new System.Drawing.Point(250, 110);
            this.textName.MaxLength = 20;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(366, 32);
            this.textName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelName.Location = new System.Drawing.Point(121, 102);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 46);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Nome";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(439, 508);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 43);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Salvar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(751, 522);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(722, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Documento";
            // 
            // textNrDocumentSearch
            // 
            this.textNrDocumentSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textNrDocumentSearch.Location = new System.Drawing.Point(310, 38);
            this.textNrDocumentSearch.MaxLength = 70;
            this.textNrDocumentSearch.Name = "textNrDocumentSearch";
            this.textNrDocumentSearch.Size = new System.Drawing.Size(392, 32);
            this.textNrDocumentSearch.TabIndex = 1;
            // 
            // textCPF
            // 
            this.textCPF.Enabled = false;
            this.textCPF.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textCPF.Location = new System.Drawing.Point(705, 110);
            this.textCPF.MaxLength = 70;
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(207, 32);
            this.textCPF.TabIndex = 5;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelCPF.Location = new System.Drawing.Point(622, 102);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(77, 46);
            this.labelCPF.TabIndex = 9;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Visible = false;
            // 
            // RoomsBox
            // 
            this.RoomsBox.Enabled = false;
            this.RoomsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsBox.FormattingEnabled = true;
            this.RoomsBox.Location = new System.Drawing.Point(749, 168);
            this.RoomsBox.Name = "RoomsBox";
            this.RoomsBox.Size = new System.Drawing.Size(146, 32);
            this.RoomsBox.TabIndex = 8;
            this.RoomsBox.Text = "-- Selecione --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label2.Location = new System.Drawing.Point(617, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quarto";
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd/mm/yyyy";
            this.dtEnd.Enabled = false;
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(477, 166);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(128, 38);
            this.dtEnd.TabIndex = 7;
            this.dtEnd.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "";
            this.dtStart.Enabled = false;
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(250, 166);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(134, 38);
            this.dtStart.TabIndex = 6;
            this.dtStart.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 45);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 45);
            this.label4.TabIndex = 27;
            this.label4.Text = "Inicio";
            // 
            // textLastPlace
            // 
            this.textLastPlace.Enabled = false;
            this.textLastPlace.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textLastPlace.HideSelection = false;
            this.textLastPlace.Location = new System.Drawing.Point(371, 233);
            this.textLastPlace.MaxLength = 20;
            this.textLastPlace.Name = "textLastPlace";
            this.textLastPlace.Size = new System.Drawing.Size(364, 32);
            this.textLastPlace.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label5.Location = new System.Drawing.Point(121, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 46);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ultimo Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label6.Location = new System.Drawing.Point(121, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 46);
            this.label6.TabIndex = 34;
            this.label6.Text = "Próximo Destino";
            // 
            // textNextPlace
            // 
            this.textNextPlace.Enabled = false;
            this.textNextPlace.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textNextPlace.HideSelection = false;
            this.textNextPlace.Location = new System.Drawing.Point(396, 303);
            this.textNextPlace.MaxLength = 20;
            this.textNextPlace.Name = "textNextPlace";
            this.textNextPlace.Size = new System.Drawing.Size(331, 32);
            this.textNextPlace.TabIndex = 11;
            // 
            // textTravelReason
            // 
            this.textTravelReason.Enabled = false;
            this.textTravelReason.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textTravelReason.HideSelection = false;
            this.textTravelReason.Location = new System.Drawing.Point(375, 369);
            this.textTravelReason.MaxLength = 20;
            this.textTravelReason.Name = "textTravelReason";
            this.textTravelReason.Size = new System.Drawing.Size(364, 32);
            this.textTravelReason.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label7.Location = new System.Drawing.Point(121, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 46);
            this.label7.TabIndex = 36;
            this.label7.Text = "Motivo Viagem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label8.Location = new System.Drawing.Point(121, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 46);
            this.label8.TabIndex = 37;
            this.label8.Text = "Transporte";
            // 
            // textTransport
            // 
            this.textTransport.Enabled = false;
            this.textTransport.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textTransport.HideSelection = false;
            this.textTransport.Location = new System.Drawing.Point(296, 445);
            this.textTransport.MaxLength = 20;
            this.textTransport.Name = "textTransport";
            this.textTransport.Size = new System.Drawing.Size(431, 32);
            this.textTransport.TabIndex = 13;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(879, 38);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 32);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnVerifyRooms
            // 
            this.btnVerifyRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyRooms.Location = new System.Drawing.Point(907, 168);
            this.btnVerifyRooms.Name = "btnVerifyRooms";
            this.btnVerifyRooms.Size = new System.Drawing.Size(92, 32);
            this.btnVerifyRooms.TabIndex = 9;
            this.btnVerifyRooms.Text = "Carregar";
            this.btnVerifyRooms.UseVisualStyleBackColor = true;
            this.btnVerifyRooms.Visible = false;
            this.btnVerifyRooms.Click += new System.EventHandler(this.btnVerifyRooms_Click);
            // 
            // textClientId
            // 
            this.textClientId.Enabled = false;
            this.textClientId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textClientId.Location = new System.Drawing.Point(769, 445);
            this.textClientId.MaxLength = 70;
            this.textClientId.Name = "textClientId";
            this.textClientId.Size = new System.Drawing.Size(57, 32);
            this.textClientId.TabIndex = 99999;
            this.textClientId.Visible = false;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 585);
            this.Controls.Add(this.textClientId);
            this.Controls.Add(this.btnVerifyRooms);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textTransport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTravelReason);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNextPlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textLastPlace);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomsBox);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNrDocumentSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reservations_FormClosing);
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNrDocumentSearch;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.ComboBox RoomsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLastPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNextPlace;
        private System.Windows.Forms.TextBox textTravelReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTransport;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnVerifyRooms;
        private System.Windows.Forms.TextBox textClientId;
    }
}