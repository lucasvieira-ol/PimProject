
namespace PimDesktop
{
    partial class ReservationsList
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_cancelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.textReservationId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.numPayTimes = new System.Windows.Forms.NumericUpDown();
            this.lblPayTimes = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.TypesBox = new System.Windows.Forms.ComboBox();
            this.lbPaymentTypes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(857, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textNrDocumentSearch
            // 
            this.textNrDocumentSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textNrDocumentSearch.Location = new System.Drawing.Point(272, 38);
            this.textNrDocumentSearch.MaxLength = 70;
            this.textNrDocumentSearch.Name = "textNrDocumentSearch";
            this.textNrDocumentSearch.Size = new System.Drawing.Size(135, 32);
            this.textNrDocumentSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Documento";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1033, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_reservation,
            this.client_name,
            this.clientDocument,
            this.room_name,
            this.dt_start,
            this.dt_end,
            this.dt_checkIn,
            this.dt_checkOut,
            this.dt_cancelation});
            this.dataGridView1.Location = new System.Drawing.Point(67, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1095, 388);
            this.dataGridView1.TabIndex = 21;
            // 
            // id_reservation
            // 
            this.id_reservation.HeaderText = "Id";
            this.id_reservation.Name = "id_reservation";
            this.id_reservation.ReadOnly = true;
            this.id_reservation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // client_name
            // 
            this.client_name.HeaderText = "Hospede";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            this.client_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.client_name.Width = 250;
            // 
            // clientDocument
            // 
            this.clientDocument.HeaderText = "Documento";
            this.clientDocument.Name = "clientDocument";
            this.clientDocument.ReadOnly = true;
            // 
            // room_name
            // 
            this.room_name.HeaderText = "Quarto";
            this.room_name.Name = "room_name";
            this.room_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dt_start
            // 
            this.dt_start.HeaderText = "Inicio";
            this.dt_start.Name = "dt_start";
            this.dt_start.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dt_end
            // 
            this.dt_end.HeaderText = "Fim";
            this.dt_end.Name = "dt_end";
            this.dt_end.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dt_checkIn
            // 
            this.dt_checkIn.HeaderText = "CheckIn";
            this.dt_checkIn.Name = "dt_checkIn";
            this.dt_checkIn.ReadOnly = true;
            this.dt_checkIn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dt_checkOut
            // 
            this.dt_checkOut.HeaderText = "CheckOut";
            this.dt_checkOut.Name = "dt_checkOut";
            this.dt_checkOut.ReadOnly = true;
            this.dt_checkOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dt_cancelation
            // 
            this.dt_cancelation.HeaderText = "Cancelamento";
            this.dt_cancelation.Name = "dt_cancelation";
            this.dt_cancelation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fim";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(521, 41);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(109, 29);
            this.dtStart.TabIndex = 25;
            this.dtStart.Value = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd/mm/yyyy";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(702, 41);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(116, 29);
            this.dtEnd.TabIndex = 26;
            this.dtEnd.Value = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(1003, 38);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 32);
            this.btnSaveChanges.TabIndex = 27;
            this.btnSaveChanges.Text = "Salvar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.Location = new System.Drawing.Point(1003, 39);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(140, 32);
            this.btnCreateReservation.TabIndex = 28;
            this.btnCreateReservation.Text = "Novo";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // textReservationId
            // 
            this.textReservationId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textReservationId.Location = new System.Drawing.Point(250, 506);
            this.textReservationId.MaxLength = 70;
            this.textReservationId.Name = "textReservationId";
            this.textReservationId.Size = new System.Drawing.Size(135, 32);
            this.textReservationId.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "Id Reserva";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(413, 501);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 38);
            this.btnCheckIn.TabIndex = 31;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(582, 501);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(145, 38);
            this.btnCheckOut.TabIndex = 32;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // numPayTimes
            // 
            this.numPayTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPayTimes.Location = new System.Drawing.Point(496, 571);
            this.numPayTimes.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numPayTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPayTimes.Name = "numPayTimes";
            this.numPayTimes.Size = new System.Drawing.Size(68, 35);
            this.numPayTimes.TabIndex = 33;
            this.numPayTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPayTimes.Visible = false;
            // 
            // lblPayTimes
            // 
            this.lblPayTimes.AutoSize = true;
            this.lblPayTimes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayTimes.Location = new System.Drawing.Point(366, 569);
            this.lblPayTimes.Name = "lblPayTimes";
            this.lblPayTimes.Size = new System.Drawing.Size(112, 37);
            this.lblPayTimes.TabIndex = 34;
            this.lblPayTimes.Text = "Parcelas";
            this.lblPayTimes.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(582, 570);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(145, 37);
            this.btnPay.TabIndex = 35;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // TypesBox
            // 
            this.TypesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypesBox.FormattingEnabled = true;
            this.TypesBox.Location = new System.Drawing.Point(179, 574);
            this.TypesBox.Name = "TypesBox";
            this.TypesBox.Size = new System.Drawing.Size(146, 32);
            this.TypesBox.TabIndex = 36;
            this.TypesBox.Visible = false;
            // 
            // lbPaymentTypes
            // 
            this.lbPaymentTypes.AutoSize = true;
            this.lbPaymentTypes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentTypes.Location = new System.Drawing.Point(103, 569);
            this.lbPaymentTypes.Name = "lbPaymentTypes";
            this.lbPaymentTypes.Size = new System.Drawing.Size(70, 37);
            this.lbPaymentTypes.TabIndex = 37;
            this.lbPaymentTypes.Text = "Tipo";
            this.lbPaymentTypes.Visible = false;
            // 
            // ReservationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 651);
            this.Controls.Add(this.lbPaymentTypes);
            this.Controls.Add(this.TypesBox);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblPayTimes);
            this.Controls.Add(this.numPayTimes);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textReservationId);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNrDocumentSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ReservationsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Reservas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservationsList_FormClosing);
            this.Load += new System.EventHandler(this.ReservationsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textNrDocumentSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.TextBox textReservationId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.NumericUpDown numPayTimes;
        private System.Windows.Forms.Label lblPayTimes;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox TypesBox;
        private System.Windows.Forms.Label lbPaymentTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_checkIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_checkOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_cancelation;
    }
}