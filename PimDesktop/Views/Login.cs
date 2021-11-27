using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using userFunctions = PimDesktop.Business.Utils.Users;


namespace DataView
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {

                UserData userData = new UserData();
                userData.user = textUser.Text;
                userData.password = textPassword.Text;
                postLogin(userData);
            }
            else
            {
                MessageBox.Show("Usuário/Senha não podem estar vazios");
            }
        }

        private void postLogin(UserData userData)
        {
            userFunctions.LoginHandler sendLogin = new userFunctions.LoginHandler();

            var users = sendLogin.HandleLogin(userData);

            if (users != null)
            {
                if (users.userId != null)
                {
                    this.Hide();
                    PimDesktop.Views.Menu redirect = new PimDesktop.Views.Menu(userData);
                    redirect.Show();
                }
                else
                    MessageBox.Show("Usuário e/ou Senha inválidos");
            }
            else
                MessageBox.Show("Sem Conexão");
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool verifyFields()
        {
            if (textPassword.Text != "" && textUser.Text != "")
                return true;
            else
                return false;
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
