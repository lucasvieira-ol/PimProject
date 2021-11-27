
namespace PimDesktop.Views
{
    partial class Menu
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Enabled = false;
            this.btnUsers.Location = new System.Drawing.Point(377, 109);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(233, 46);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Usuário";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Enabled = false;
            this.btnEmployees.Location = new System.Drawing.Point(377, 196);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(233, 46);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Funcionário";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Enabled = false;
            this.btnRooms.Location = new System.Drawing.Point(377, 283);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(233, 46);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "Quarto";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.label3.Location = new System.Drawing.Point(223, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 72);
            this.label3.TabIndex = 7;
            this.label3.Text = "Software de Hotelaria";
            // 
            // btnClients
            // 
            this.btnClients.Enabled = false;
            this.btnClients.Location = new System.Drawing.Point(377, 374);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(233, 46);
            this.btnClients.TabIndex = 8;
            this.btnClients.Text = "Hospede";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Enabled = false;
            this.btnReservations.Location = new System.Drawing.Point(377, 466);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(233, 46);
            this.btnReservations.TabIndex = 9;
            this.btnReservations.Text = "Reserva";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(928, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Enabled = false;
            this.btnReports.Location = new System.Drawing.Point(377, 543);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(233, 46);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "Relatórios";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
    }
}