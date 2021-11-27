using System;
using System.Windows.Forms;
using PimDesktop.Business.Utils.Reports;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using UserSystemRptData = PimDesktop.Business.Utils.Reports.UserSystemRptData;
using EmployeeRptData = PimDesktop.Business.Utils.Reports.EmployeeRptData;
using ClientRptData = PimDesktop.Business.Utils.Reports.ClientRptData;
using RoomsRptData = PimDesktop.Business.Utils.Reports.RoomsRptData;
using CSV = PimDesktop.Business.Utils.CSV;
using System.Diagnostics;
using System.Linq;

namespace PimDesktop
{
    public partial class Reports : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }

        public Reports(UserData user)
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PimDesktop.Views.Menu menu = new PimDesktop.Views.Menu(getUserLoged());
            this.Close();
            menu.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeRptData Employees = new EmployeeRptData();
            CSV.EmployeesCSV generateFile = new CSV.EmployeesCSV();

            var sendEmployees = Employees.getEmployeeRptData(dateFirst.Value, dateLast.Value);


            string message = generateFile.EmployeesGenerateFile(sendEmployees, dateFirst.Value, dateLast.Value);

            MessageBox.Show(message);

        }

        private void btnSystemUsers_Click(object sender, EventArgs e)
        {
            UserSystemRptData Users = new UserSystemRptData();
            CSV.UsersCSV generateFile = new CSV.UsersCSV();

            var sendUsers = Users.getUserSystemRptData(dateFirst.Value, dateLast.Value);


            string message = generateFile.UsersGenerateFile(sendUsers, dateFirst.Value, dateLast.Value);

            MessageBox.Show(message);


        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientRptData Clients = new ClientRptData();
            CSV.ClientsCSV generateFile = new CSV.ClientsCSV();

            var sendClients = Clients.getClientRptData(dateFirst.Value, dateLast.Value);


            string message = generateFile.ClientsGenerateFile(sendClients, dateFirst.Value, dateLast.Value);

            MessageBox.Show(message);


        }

        private void btnAllReservations_Click(object sender, EventArgs e)
        {
            ReservationRptData reservations = new ReservationRptData();
            CSV.ReservationsCSV generateFile = new CSV.ReservationsCSV();

            var sendReservations = reservations.getReservationRpt(0, dateFirst.Value, dateLast.Value);


            string message = generateFile.ReservationsGenerateFile(sendReservations, dateFirst.Value, dateLast.Value);

            MessageBox.Show(message);


        }

        private void btnAvgReservations_Click(object sender, EventArgs e)
        {
            ReservationRptData reservations = new ReservationRptData();
            CSV.ReservationsCSV generateFile = new CSV.ReservationsCSV();

            var sendReservations = reservations.getAvgReservationRpt(dateFirst.Value, dateLast.Value);


            string message = generateFile.ReservationsAvgGenerateFile(sendReservations, dateFirst.Value, dateLast.Value);

            MessageBox.Show(message);


        }
        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsRptData rooms = new RoomsRptData();
            CSV.RoomsCSV generateFile = new CSV.RoomsCSV();

            var sendRooms = rooms.getRoomsRpt(dateFirst.Value, dateLast.Value);

            string message = generateFile.RoomsGenerateFile(sendRooms, dateFirst.Value, dateLast.Value);

            MessageBox.Show(message);

        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
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
