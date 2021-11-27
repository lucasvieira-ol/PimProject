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
using ClientData = PimDesktop.Business.Utils.Clients.ClientData;
using ClientFunctions = PimDesktop.Business.Utils.Clients.ClientFunctions;
using ReservationData = PimDesktop.Business.Utils.Reservations.ReservationData;
using ReservationFunctions = PimDesktop.Business.Utils.Reservations.ReservationFunctions;
using RoomFunctions = PimDesktop.Business.Utils.Rooms.RoomFunctions;
using System.Diagnostics;

namespace PimDesktop
{
    public partial class Reservations : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }
        public string nrDocumentClient { get; set; }

        public Reservations(UserData user, string nrDocument = "")
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;
            nrDocumentClient = nrDocument;

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "dd/MM/yyyy";

            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textNrDocumentSearch.Text == "")
                MessageBox.Show("O campo de Nr Documento não pode ser vazio");

            else
            {
                ClientData client = new ClientData();
                ClientFunctions clientHandler = new ClientFunctions();

                client = clientHandler.getClient(textNrDocumentSearch.Text);

                if (client != null)
                    FillClientFound(client);
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

        }

        private void enableButtons()
        {
            textLastPlace.Enabled = true;
            textNextPlace.Enabled = true;
            textTransport.Enabled = true;
            textTravelReason.Enabled = true;
            dtStart.Enabled = true;
            dtEnd.Enabled = true;
            RoomsBox.Enabled = true;
            btnSaveChanges.Visible = true;
            btnSaveChanges.Enabled = true;
            btnSearch.Enabled = false;
            textNrDocumentSearch.Enabled = false;
            btnNew.Visible = true;
            btnVerifyRooms.Visible = true;
        }

        private void FillClientFound(ClientData resultClient)
        {
            textName.Text = resultClient.clientName;
            textCPF.Text = resultClient.clientCPF;
            textClientId.Text = resultClient.clientId.ToString();
            enableButtons();
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (dtStart.Value >= dtEnd.Value)
                MessageBox.Show("A data fim deve ser maior que a data inicio");
            else
            {
                var reservationData = insertReservation();
                ReservationFunctions sendReservation = new ReservationFunctions();

                if (sendReservation.setReservation(reservationData))
                {
                    var result = MessageBox.Show("Reserva Criada com êxito!, deseja ir para tela de consulta reserva?", "Aviso", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {

                        PimDesktop.ReservationsList redirect = new ReservationsList(getUserLoged());
                        this.Close();
                        redirect.Show();
                    }
                    else
                    {
                        Reservations reopen = new Reservations(getUserLoged());
                        this.Close();
                        reopen.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar a reserva");
                }

            }
        }

        private ReservationData insertReservation()
        {
            ReservationData reservationData = new ReservationData();

            reservationData.reservationRoomId = Convert.ToInt32(RoomsBox.SelectedValue);
            reservationData.reservationUserCreateId = UserStorage;
            reservationData.reservationClientId = Convert.ToInt32(textClientId.Text);
            reservationData.nextDestination = textNextPlace.Text;
            reservationData.lastDestination = textLastPlace.Text;
            reservationData.reasonTravel = textTravelReason.Text;
            reservationData.startDate = dtStart.Value;
            reservationData.endDate = dtEnd.Value;
            reservationData.createdDate = DateTime.Now;
            reservationData.transport = textTransport.Text;

            return reservationData;
        }


        private void FillRooms(object sender, EventArgs e)
        {

            Dictionary<string, string> documentsTypes = new Dictionary<string, string>();

            RoomFunctions Rooms = new RoomFunctions();
            try
            {
                var lstRooms = Rooms.getEmptyRooms(dtStart.Value, dtEnd.Value);

                foreach (var item in lstRooms)
                {
                    documentsTypes.Add(item.roomId.ToString(), item.roomName);
                }

                RoomsBox.DataSource = new BindingSource(documentsTypes, null);
                RoomsBox.DisplayMember = "Value";
                RoomsBox.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar recuperar os quartos cadastrados");
            }
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nrDocumentClient))
            {
                textNrDocumentSearch.Text = nrDocumentClient;
                btnSearch_Click(sender, e);
            }
        }

        private void btnVerifyRooms_Click(object sender, EventArgs e)
        {
            if (dtStart.Value > dtEnd.Value)
            {
                MessageBox.Show("A data de inicio não pode ser maior que a data fim");
            }
            else
                FillRooms(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reservations reopen = new Reservations(getUserLoged());
            this.Close();
            reopen.Show();

        }

        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void Reservations_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {

            }
            else
            {
                btnLogout_Click(sender, e);

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PimDesktop.Views.Menu menu = new PimDesktop.Views.Menu(getUserLoged());
            this.Close();
            menu.Show();
        }
    }
}
