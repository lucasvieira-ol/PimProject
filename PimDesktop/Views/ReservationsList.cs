using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using ClientFunctions = PimDesktop.Business.Utils.Clients.ClientFunctions;
using ReservationData = PimDesktop.Business.Utils.Reservations.ReservationData;
using ReservationFunctions = PimDesktop.Business.Utils.Reservations.ReservationFunctions;
using ReportReservationTotalData = PimDesktop.Business.Utils.Reservations.ReportReservationTotalData;
using ReservationRptData = PimDesktop.Business.Utils.Reports.ReservationRptData;
using RoomFunctions = PimDesktop.Business.Utils.Rooms.RoomFunctions;
using System.Diagnostics;

namespace PimDesktop
{
    public partial class ReservationsList : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }

        public ReservationsList(UserData user)
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "dd/MM/yyyy";

            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "dd/MM/yyyy";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PimDesktop.Views.Menu menu = new PimDesktop.Views.Menu(getUserLoged());
            this.Close();
            menu.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClientFunctions client = new ClientFunctions();
            ReservationRptData reservation = new ReservationRptData();

            if (dtStart.Value != null && dtEnd.Value != null)
            {

                int clientId = 0;
                if (!string.IsNullOrEmpty(textNrDocumentSearch.Text))
                {
                    var verifyClient = client.getClient(textNrDocumentSearch.Text).clientId;

                    if (verifyClient != null)
                        clientId = (int)verifyClient;
                    else
                    {
                        var result = MessageBox.Show("Hospede não localizado, Deseja cadastrar?", "", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            PimDesktop.Clients Clients = new PimDesktop.Clients(getUserLoged(), textNrDocumentSearch.Text);
                            this.Close();
                            Clients.Show();
                        }
                    }
                }
                else
                {
                    var lstReservations = reservation.getReservationRpt(clientId, dtStart.Value, dtEnd.Value);

                    if (lstReservations.Count > 0)
                    {
                        dataGridLoad(sender, e, lstReservations);
                    }
                    else
                        MessageBox.Show("Nenhuma reserva localizada no periodo informado");
                }
            }
            else
            {
                MessageBox.Show("Preencha o período desejado");
            }

        }

        private void dataGridLoad(object sender, EventArgs e, List<ReportReservationTotalData> lstReservations)
        {

            dataGridView1.Rows.Clear();

            foreach (var item in lstReservations)
            {
                dataGridView1.Rows.Add
                    (
                    item.idReservation,
                    item.clientName,
                    item.clientDocument,
                    item.roomName,
                    item.dateStart,
                    item.dateEnd,
                    item.dateCheckIn,
                    item.dateCheckOut,
                    item.dateCancelation
                    );
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[4].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[3].ReadOnly = true;

                }

                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[7].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[4].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[3].ReadOnly = true;
                }


                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[4].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[3].ReadOnly = true;

                }
            }

            btnSaveChanges.Visible = true;
            btnSaveChanges.Enabled = true;
            btnCreateReservation.Visible = false;
            btnCreateReservation.Enabled = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Deseja Salvar as Alterações?", "Salvando", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                updateChanges(sender, e);
            }

        }

        private void updateChanges(object sender, EventArgs e)
        {
            List<ReservationData> lstReservation = new List<ReservationData>();
            ReservationFunctions updateReservation = new ReservationFunctions();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    ReservationData reservation = new ReservationData();
                    RoomFunctions room = new RoomFunctions();

                    reservation.reservationId = Convert.ToInt32(row.Cells[0].Value.ToString());

                    if (row.Cells[4].Value != null)
                        if (!string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                            reservation.startDate = Convert.ToDateTime(row.Cells[4].Value.ToString());

                    if (row.Cells[5].Value != null)
                        if (!string.IsNullOrEmpty(row.Cells[5].Value.ToString()))
                            reservation.endDate = Convert.ToDateTime(row.Cells[5].Value.ToString());


                    if (row.Cells[8].Value != null)
                        if (!string.IsNullOrEmpty(row.Cells[8].Value.ToString()))
                            reservation.cancelationDate = Convert.ToDateTime(row.Cells[8].Value.ToString());

                    if (row.Cells[3].Value != null)
                    {
                        try
                        {
                            reservation.reservationRoomId = room.getRoom(row.Cells[3].Value.ToString().Trim()).roomId;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Quarto Não Localizado");
                        }
                    }
                    lstReservation.Add(reservation);
                }

                try
                {
                    if (updateReservation.updateReservation(lstReservation))
                    {

                        MessageBox.Show("Dados Alterados Com êxito!");

                        btnSearch_Click(sender, e);

                    }
                }
                catch
                {

                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de data inserido inválido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro.");
            }


        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            PimDesktop.Reservations reservation = new Reservations(getUserLoged());
            this.Close();
            reservation.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textReservationId.Text))
            {
                var result = MessageBox.Show("Deseja Fazer o CheckIn?", "CheckIn", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ReservationFunctions updateReservation = new ReservationFunctions();
                        int idReservation = Convert.ToInt32(textReservationId.Text);

                        if (updateReservation.CheckInReservation(idReservation, UserStorage))
                        {
                            MessageBox.Show("Data CheckIn Inserida com êxito");
                        }
                        else
                        {
                            MessageBox.Show("Essa reserva já possui data de CheckIn");
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Formato de id Reserva inserido Inválido");
                    }
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textReservationId.Text))
            {
                try
                {
                    ReservationFunctions reservationHandler = new ReservationFunctions();
                    int idReservation = Convert.ToInt32(textReservationId.Text);

                    var verifyReservation = reservationHandler.getReservationById(idReservation);

                    if (verifyReservation.checkOutDate == null)
                    {
                        if (verifyReservation.checkInDate != null)
                        {
                            var result = MessageBox.Show("Deseja Fazer o CheckOut?", "CheckOut", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                lblPayTimes.Visible = true;
                                btnPay.Visible = true;
                                numPayTimes.Visible = true;
                                TypesBox.Visible = true;
                                lbPaymentTypes.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Essa reserva não possui data de CheckIn");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Essa reserva já possui data de CheckOut");
                    }


                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato de id Reserva inserido Inválido");
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                ReservationFunctions updateReservation = new ReservationFunctions();
                int idReservation = Convert.ToInt32(textReservationId.Text);
                int payTimes = Convert.ToInt32(numPayTimes.Value);
                string paymentType = TypesBox.SelectedValue.ToString();

                if (paymentType == "Selecione")
                {
                    MessageBox.Show("Selecione um tipo de pagamento");
                }
                else if (paymentType == "Dinheiro" && payTimes > 1)
                {
                    MessageBox.Show("Não é possível realizar o parcelamento do pagamento em dinheiro");
                }
                else
                {
                    var resultPayment = MessageBox.Show("O Cliente realizou o pagamento?", "Confirmação", MessageBoxButtons.YesNo);

                    if (resultPayment == DialogResult.Yes)
                    {
                        try
                        {
                            updateReservation.CheckOutReservation(idReservation, UserStorage, payTimes, paymentType);
                            MessageBox.Show("CheckOut Cadastrado com êxito!");

                            PimDesktop.ReservationsList reopen = new ReservationsList(getUserLoged());
                            this.Close();
                            reopen.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro");
                        }
                    }
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Formato de id Reserva inserido Inválido");
            }

        }

        private void FillPaymentTypes(object sender, EventArgs e)
        {
            Dictionary<string, string> documentsTypes = new Dictionary<string, string>();

            documentsTypes.Add("Selecione", "Selecione");
            documentsTypes.Add("Dinheiro", "Dinheiro");
            documentsTypes.Add("Crédito", "Crédito");
            documentsTypes.Add("Débito", "Débito");


            TypesBox.DataSource = new BindingSource(documentsTypes, null);
            TypesBox.DisplayMember = "Value";
            TypesBox.ValueMember = "Key";
        }

        private void ReservationsList_Load(object sender, EventArgs e)
        {
            FillPaymentTypes(sender, e);
        }

        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void ReservationsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {

            }
            else
            {
                btnLogout_Click(sender, e);

            }
        }
    }
}
