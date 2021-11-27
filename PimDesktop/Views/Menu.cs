using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimDesktop.Business;
using UserData = PimDesktop.Business.Utils.Users.UserData;

namespace PimDesktop.Views
{
    public partial class Menu : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }

        public Menu(UserData user)
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;

            PimDesktop.Business.Utils.Profiles.ProfileFunctions profile = new Business.Utils.Profiles.ProfileFunctions();

            var VerifyPermissions = profile.getPermissions(id_profile);

            if (VerifyPermissions.Admin)
            {
                btnReservations.Enabled = true;
                btnClients.Enabled = true;
                btnEmployees.Enabled = true;
                btnUsers.Enabled = true;
                btnRooms.Enabled = true;
                btnReports.Enabled = true;
            }
            else
            {

                if (VerifyPermissions.Create_Employee)
                    btnEmployees.Enabled = true;

                if (VerifyPermissions.Create_Client)
                    btnClients.Enabled = true;

                if (VerifyPermissions.Create_reservation)
                    btnReservations.Enabled = true;

                if (VerifyPermissions.Reports)
                    btnReports.Enabled = true;
            }

        }

        private void btnUsers_click(object sender, EventArgs e)
        {

            PimDesktop.Users Users = new Users(getUserLoged());
            this.Close();
            Users.Show();

        }

        private void btnClients_Click(object sender, EventArgs e)
        {

            PimDesktop.Clients Clients = new PimDesktop.Clients(getUserLoged());
            this.Close();
            Clients.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DataView.Login login = new DataView.Login();
            this.Close();
            login.Show();

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

            PimDesktop.Employees Employees = new Employees(getUserLoged());
            this.Close();
            Employees.Show();

        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            PimDesktop.Rooms Rooms = new Rooms(getUserLoged());
            this.Close();
            Rooms.Show();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            PimDesktop.Reports reports = new Reports(getUserLoged());
            this.Close();
            reports.Show();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {

            PimDesktop.ReservationsList reservation = new ReservationsList(getUserLoged());
            this.Close();
            reservation.Show();
        }
        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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
