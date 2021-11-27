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
using UserFunctions = PimDesktop.Business.Utils.Users.UserFunctions;
using ProfilesFunctions = PimDesktop.Business.Utils.Profiles.ProfileFunctions;
using System.Diagnostics;

namespace PimDesktop
{
    public partial class Users : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }

        public Users(UserData user)
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "")
                MessageBox.Show("O campo de e-mail não pode ser vazio");

            else
            {
                UserFunctions userHandler = new UserFunctions();

                var userFound = userHandler.getUser(textUser.Text);

                FillProfiles(sender, e);

                if (userFound != null)
                {
                    FillUserFound(userFound);
                }
                else
                {
                    MessageBox.Show("Usuário não localizado");
                }
            }
        }
        private void FillUserFound(UserData userFound)
        {
            textId.Text = userFound.userId.ToString();
            textName.Text = userFound.user;
            textEmail.Text = userFound.emailUser;
            checkUserEnabled.Checked = userFound.enabled;
            profilesBox.SelectedValue = userFound.id_profile;

            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            textEmail.Enabled = true;
            textName.Enabled = true;
            textPassword.Enabled = true;
            textConfirmPassword.Enabled = true;
            checkUserEnabled.Enabled = true;
            labelPassword.Visible = true;
            labelConfirmPassword.Visible = true;
            textConfirmPassword.Visible = true;
            textPassword.Visible = true;
            btnUpdate.Enabled = false;
            btnSaveChanges.Visible = true;
            profilesBox.Enabled = true;
            btnCreateUser.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId.Text))
            {
                InsertUser(sender, e);
            }
            else
            {
                UpdateUser(sender, e);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PimDesktop.Views.Menu menu = new PimDesktop.Views.Menu(getUserLoged());
            this.Close();
            menu.Show();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FillProfiles(sender, e);
            textId.Text = null;
            textEmail.Text = null;
            textName.Text = null;
            textEmail.Enabled = true;
            textName.Enabled = true;
            textPassword.Enabled = true;
            textConfirmPassword.Enabled = true;
            checkUserEnabled.Enabled = true;
            checkUserEnabled.Checked = true;
            labelPassword.Visible = true;
            labelConfirmPassword.Visible = true;
            textConfirmPassword.Visible = true;
            textPassword.Visible = true;
            btnUpdate.Enabled = false;
            btnSaveChanges.Visible = true;
            profilesBox.Enabled = true;
            profilesBox.SelectedItem = 0;
            profilesBox.SelectedValue = "";
            profilesBox.SelectedText = "-- Selecione --";

        }
        private void UpdateUser(object sender, EventArgs e)
        {

            Users reopen = new Users(getUserLoged());
            UserData UserData = new UserData();
            UserFunctions sendUser = new UserFunctions();

            UserData = validateFilledFields("update");

            if (UserData != null)
            {
                var result = sendUser.putUser(UserData);

                if (result)
                {
                    MessageBox.Show("Informações alteradas com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show("E-mail inserido já está em uso, preencha com outro e-mail.");
                }
            }
        }

        private UserData validateFilledFields(string type)
        {
            switch (type)
            {
                case "create":
                    return returnValidateCreate();
                    break;
                case "update":
                    return returnValidateUpdate();
                    break;
                default:
                    return null;
                    break;
            }
        }

        private UserData returnValidateUpdate()
        {
            UserData UserData = new UserData();

            UserData.emailUser = textEmail.Text;
            UserData.enabled = checkUserEnabled.Checked;
            UserData.id_profile = Convert.ToInt32(profilesBox.SelectedValue);
            UserData.userId = Convert.ToInt32(textId.Text);

            if (!string.IsNullOrEmpty(textPassword.Text))
                if (textPassword.Text == textConfirmPassword.Text)
                    UserData.password = textPassword.Text;
                else
                {
                    MessageBox.Show("As senhas precisam ser iguais");
                    return null;
                }

            UserData.user = textName.Text;

            return UserData;
        }

        private UserData returnValidateCreate()
        {
            UserData UserData = new UserData();

            if (!string.IsNullOrEmpty(textName.Text))
                UserData.user = textName.Text;
            else
            {
                MessageBox.Show("Necessário preencher o nome");
                return null;
            }

            if (!string.IsNullOrEmpty(textEmail.Text))
                UserData.emailUser = textEmail.Text;
            else
            {
                MessageBox.Show("Necessário preencher o e-mail");
                return null;
            }

            if (checkUserEnabled.Checked)
                UserData.enabled = checkUserEnabled.Checked;
            else
            {
                MessageBox.Show("Necessário checar o campo de ativo");
                return null;
            }

            if (profilesBox.SelectedValue != "0")
                UserData.id_profile = Convert.ToInt32(profilesBox.SelectedValue);
            else
            {
                MessageBox.Show("Necessário selecionar um perfil");
                return null;
            }

            if (!string.IsNullOrEmpty(textPassword.Text))
                if (textPassword.Text == textConfirmPassword.Text)
                    UserData.password = textPassword.Text;
                else
                {
                    MessageBox.Show("As senhas precisam ser iguais");
                    return null;
                }

            return UserData;

        }



        private void InsertUser(object sender, EventArgs e)
        {
            Users reopen = new Users(getUserLoged());
            UserData UserData = new UserData();
            UserFunctions sendUser = new UserFunctions();

            UserData = validateFilledFields("create");

            if (UserData != null)
            {
                var result = sendUser.setUser(UserData);

                if (result)
                {
                    MessageBox.Show("Usuário criado com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show("E-mail inserido já está em uso, preencha com outro e-mail.");
                }
            }

        }

        private void FillProfiles(object sender, EventArgs e)
        {
            ProfilesFunctions load = new ProfilesFunctions();

            var profiles = load.getProfiles();

            profilesBox.DataSource = profiles;
            profilesBox.DisplayMember = "Name";
            profilesBox.ValueMember = "Id";
        }

        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
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
