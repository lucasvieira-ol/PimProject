
namespace PimDesktop
{
    partial class Rooms
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
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAdmission = new System.Windows.Forms.Label();
            this.checkRoomEnabled = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.labelDemission = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericSingleBed = new System.Windows.Forms.NumericUpDown();
            this.numericCoupleBed = new System.Windows.Forms.NumericUpDown();
            this.textFullPrice = new System.Windows.Forms.TextBox();
            this.textHalfPrice = new System.Windows.Forms.TextBox();
            this.numericFloor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericSingleBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCoupleBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFloor)).BeginInit();
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
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textSearch.Location = new System.Drawing.Point(195, 38);
            this.textSearch.MaxLength = 70;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(345, 32);
            this.textSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quarto";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label3.Location = new System.Drawing.Point(199, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Andar";
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
            this.label4.Location = new System.Drawing.Point(188, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // labelAdmission
            // 
            this.labelAdmission.AutoSize = true;
            this.labelAdmission.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelAdmission.Location = new System.Drawing.Point(383, 276);
            this.labelAdmission.Name = "labelAdmission";
            this.labelAdmission.Size = new System.Drawing.Size(136, 46);
            this.labelAdmission.TabIndex = 13;
            this.labelAdmission.Text = "Solteiro";
            // 
            // checkRoomEnabled
            // 
            this.checkRoomEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkRoomEnabled.AutoSize = true;
            this.checkRoomEnabled.Enabled = false;
            this.checkRoomEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F);
            this.checkRoomEnabled.Location = new System.Drawing.Point(575, 145);
            this.checkRoomEnabled.Name = "checkRoomEnabled";
            this.checkRoomEnabled.Size = new System.Drawing.Size(94, 35);
            this.checkRoomEnabled.TabIndex = 4;
            this.checkRoomEnabled.Text = "Ativo";
            this.checkRoomEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkRoomEnabled.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(325, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 43);
            this.btnUpdate.TabIndex = 11;
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
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Salvar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // labelDemission
            // 
            this.labelDemission.AutoSize = true;
            this.labelDemission.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelDemission.Location = new System.Drawing.Point(201, 332);
            this.labelDemission.Name = "labelDemission";
            this.labelDemission.Size = new System.Drawing.Size(106, 46);
            this.labelDemission.TabIndex = 19;
            this.labelDemission.Text = "Diária";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(905, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(740, 39);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(140, 32);
            this.btnCreateRoom.TabIndex = 3;
            this.btnCreateRoom.Text = "Novo";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelProfile.Location = new System.Drawing.Point(570, 278);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(97, 46);
            this.labelProfile.TabIndex = 23;
            this.labelProfile.Text = "Casal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label5.Location = new System.Drawing.Point(457, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 46);
            this.label5.TabIndex = 27;
            this.label5.Text = "Meia";
            // 
            // numericSingleBed
            // 
            this.numericSingleBed.Enabled = false;
            this.numericSingleBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSingleBed.Location = new System.Drawing.Point(518, 291);
            this.numericSingleBed.Name = "numericSingleBed";
            this.numericSingleBed.Size = new System.Drawing.Size(49, 29);
            this.numericSingleBed.TabIndex = 7;
            // 
            // numericCoupleBed
            // 
            this.numericCoupleBed.Enabled = false;
            this.numericCoupleBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCoupleBed.Location = new System.Drawing.Point(679, 292);
            this.numericCoupleBed.Name = "numericCoupleBed";
            this.numericCoupleBed.Size = new System.Drawing.Size(49, 29);
            this.numericCoupleBed.TabIndex = 8;
            // 
            // textFullPrice
            // 
            this.textFullPrice.Enabled = false;
            this.textFullPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textFullPrice.Location = new System.Drawing.Point(329, 344);
            this.textFullPrice.MaxLength = 7;
            this.textFullPrice.Name = "textFullPrice";
            this.textFullPrice.Size = new System.Drawing.Size(113, 32);
            this.textFullPrice.TabIndex = 9;
            // 
            // textHalfPrice
            // 
            this.textHalfPrice.Enabled = false;
            this.textHalfPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textHalfPrice.Location = new System.Drawing.Point(562, 344);
            this.textHalfPrice.MaxLength = 7;
            this.textHalfPrice.Name = "textHalfPrice";
            this.textHalfPrice.Size = new System.Drawing.Size(114, 32);
            this.textHalfPrice.TabIndex = 10;
            // 
            // numericFloor
            // 
            this.numericFloor.Enabled = false;
            this.numericFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFloor.Location = new System.Drawing.Point(325, 289);
            this.numericFloor.Name = "numericFloor";
            this.numericFloor.Size = new System.Drawing.Size(49, 29);
            this.numericFloor.TabIndex = 6;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.numericFloor);
            this.Controls.Add(this.textHalfPrice);
            this.Controls.Add(this.textFullPrice);
            this.Controls.Add(this.numericCoupleBed);
            this.Controls.Add(this.numericSingleBed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelDemission);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkRoomEnabled);
            this.Controls.Add(this.labelAdmission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quartos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rooms_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericSingleBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCoupleBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFloor)).EndInit();
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
        private System.Windows.Forms.CheckBox checkRoomEnabled;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label labelDemission;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericSingleBed;
        private System.Windows.Forms.NumericUpDown numericCoupleBed;
        private System.Windows.Forms.TextBox textFullPrice;
        private System.Windows.Forms.TextBox textHalfPrice;
        private System.Windows.Forms.NumericUpDown numericFloor;
    }
}