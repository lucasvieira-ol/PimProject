
namespace PimDesktop
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dateFirst = new System.Windows.Forms.DateTimePicker();
            this.dateLast = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAllReservations = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnAvgReservations = new System.Windows.Forms.Button();
            this.btnSystemUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio";
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
            // dateFirst
            // 
            this.dateFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFirst.Location = new System.Drawing.Point(160, 38);
            this.dateFirst.Name = "dateFirst";
            this.dateFirst.Size = new System.Drawing.Size(155, 33);
            this.dateFirst.TabIndex = 21;
            this.dateFirst.Value = new System.DateTime(2021, 10, 17, 0, 0, 0, 0);
            // 
            // dateLast
            // 
            this.dateLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLast.Location = new System.Drawing.Point(458, 38);
            this.dateLast.Name = "dateLast";
            this.dateLast.Size = new System.Drawing.Size(155, 33);
            this.dateLast.TabIndex = 23;
            this.dateLast.Value = new System.DateTime(2021, 10, 17, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label2.Location = new System.Drawing.Point(365, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 54);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fim";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(364, 135);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(167, 47);
            this.btnEmployees.TabIndex = 24;
            this.btnEmployees.Text = "Funcionários";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnClients
            // 
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(364, 337);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(167, 47);
            this.btnClients.TabIndex = 25;
            this.btnClients.Text = "Clientes";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAllReservations
            // 
            this.btnAllReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReservations.Location = new System.Drawing.Point(364, 405);
            this.btnAllReservations.Name = "btnAllReservations";
            this.btnAllReservations.Size = new System.Drawing.Size(167, 47);
            this.btnAllReservations.TabIndex = 26;
            this.btnAllReservations.Text = "Total Reservas";
            this.btnAllReservations.UseVisualStyleBackColor = true;
            this.btnAllReservations.Click += new System.EventHandler(this.btnAllReservations_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(364, 272);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(167, 47);
            this.btnRooms.TabIndex = 27;
            this.btnRooms.Text = "Quartos";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnAvgReservations
            // 
            this.btnAvgReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgReservations.Location = new System.Drawing.Point(364, 472);
            this.btnAvgReservations.Name = "btnAvgReservations";
            this.btnAvgReservations.Size = new System.Drawing.Size(167, 47);
            this.btnAvgReservations.TabIndex = 28;
            this.btnAvgReservations.Text = "Médias Reservas";
            this.btnAvgReservations.UseVisualStyleBackColor = true;
            this.btnAvgReservations.Click += new System.EventHandler(this.btnAvgReservations_Click);
            // 
            // btnSystemUsers
            // 
            this.btnSystemUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemUsers.Location = new System.Drawing.Point(364, 202);
            this.btnSystemUsers.Name = "btnSystemUsers";
            this.btnSystemUsers.Size = new System.Drawing.Size(167, 47);
            this.btnSystemUsers.TabIndex = 29;
            this.btnSystemUsers.Text = "Usuários";
            this.btnSystemUsers.UseVisualStyleBackColor = true;
            this.btnSystemUsers.Click += new System.EventHandler(this.btnSystemUsers_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.btnSystemUsers);
            this.Controls.Add(this.btnAvgReservations);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnAllReservations);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.dateLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFirst);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DateTimePicker dateFirst;
        private System.Windows.Forms.DateTimePicker dateLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAllReservations;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnAvgReservations;
        private System.Windows.Forms.Button btnSystemUsers;
    }
}