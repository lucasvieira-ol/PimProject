using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using RoomData = PimDesktop.Business.Utils.Rooms.RoomData;
using RoomFunctions = PimDesktop.Business.Utils.Rooms.RoomFunctions;
using System.Diagnostics;

namespace PimDesktop
{
    public partial class Rooms : Form
    {
        public static int userStorage { get; set; }
        public static int id_profile { get; set; }

        public Rooms(UserData user)
        {
            InitializeComponent();

            userStorage = user.userId;
            id_profile = user.id_profile;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
                MessageBox.Show("O campo de Busca não pode estar vazio");

            else
            {
                RoomFunctions roomHandler = new RoomFunctions();

                var RoomFound = roomHandler.getRoom(textSearch.Text);

                if (RoomFound.roomId != 0)
                {
                    FillRoomFound(RoomFound);
                }
                else
                {
                    MessageBox.Show("Quarto não localizado");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            turnFieldsEnabled();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId.Text))
            {
                InsertRoom(sender, e);
            }
            else
            {
                UpdateRoom(sender, e);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            PimDesktop.Views.Menu menu = new PimDesktop.Views.Menu(getUserLoged());
            this.Close();
            menu.Show();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            turnFieldsEnabled();
        }
        private void UpdateRoom(object sender, EventArgs e)
        {

            Rooms reopen = new Rooms(getUserLoged());
            RoomData RoomData = new RoomData();
            RoomFunctions sendRoom = new RoomFunctions();


            RoomData = validateFilledFields("update");

            if (RoomData != null)
            {
                if (sendRoom.putRoom(RoomData))
                {
                    MessageBox.Show("Informações alteradas com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show("O nome do quarto inserido já está em uso, preencha com outro nome.");
                }
            }

        }

        private void InsertRoom(object sender, EventArgs e)
        {

            Rooms reopen = new Rooms(getUserLoged());
            RoomData RoomData = new RoomData();
            RoomFunctions sendRoom = new RoomFunctions();

            RoomData = validateFilledFields("create");

            if (RoomData != null)
            {
                if (sendRoom.setRoom(RoomData))
                {
                    MessageBox.Show("Quarto cadastrado com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show("O nome do quarto inserido já está em uso, preencha com outro nome.");
                }
            }
            else
            {
                MessageBox.Show("Todas as informações precisam ser preenchidas.");
            }

        }

        private RoomData returnValidateCreate()
        {
            RoomData RoomData = new RoomData();

            if (!string.IsNullOrEmpty(textName.Text))
                RoomData.roomName = textName.Text;
            else
            {
                MessageBox.Show("Necessário preencher o nome");
                return null;
            }

            if (numericFloor.Value > 0)
                RoomData.roomFloor = Convert.ToInt32(numericFloor.Value);
            else
            {
                MessageBox.Show("Necessário preencher o andar com um valor válido");
                return null;
            }

            if (!string.IsNullOrEmpty(textFullPrice.Text))
            {
                try
                {
                    RoomData.roomFullPrice = decimal.Parse(textFullPrice.Text.Replace(",", "."), CultureInfo.InvariantCulture);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("O do valor da diária está em um formato inválido");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Necessário preencher o valor da diária");
                return null;
            }

            if (!string.IsNullOrEmpty(textHalfPrice.Text))
            {
                try
                {
                    RoomData.roomHalfPrice = decimal.Parse(textHalfPrice.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O do valor da meia diária está em um formato inválido");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Necessário preencher o valor da meia diária");
                return null;
            }

            if (checkRoomEnabled.Checked)
                RoomData.roomEnabled = checkRoomEnabled.Checked;
            else
            {
                MessageBox.Show("Necessário checar o campo de ativo");
                return null;
            }

            if (numericSingleBed.Value == 0 && numericCoupleBed.Value == 0)
            {
                MessageBox.Show("Insira ao menos uma quantidade de cama");
                return null;
            }

            return RoomData;
        }

        private RoomData returnValidateUpdate()
        {
            RoomData RoomData = new RoomData();

            if (!string.IsNullOrEmpty(textName.Text))
                RoomData.roomName = textName.Text;

            RoomData.roomEnabled = checkRoomEnabled.Checked;
            RoomData.roomId = Convert.ToInt32(textId.Text);
            RoomData.roomFloor = Convert.ToInt32(numericFloor.Value);
            RoomData.roomCoupleBeds = Convert.ToInt32(numericCoupleBed.Value);
            RoomData.roomSingleBeds = Convert.ToInt32(numericSingleBed.Value);

            try
            {
                RoomData.roomFullPrice = decimal.Parse(textFullPrice.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                RoomData.roomHalfPrice = decimal.Parse(textHalfPrice.Text.Replace(",", "."), CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique a formatação dos campos de valor das diárias");
                return null;
            }

            if (RoomData.roomCoupleBeds == 0 && RoomData.roomSingleBeds == 0)
            {
                MessageBox.Show("Insira ao menos uma quantidade de cama");
                return null;
            }
            return RoomData;
        }
        private RoomData validateFilledFields(string type)
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

        private void FillRoomFound(RoomData RoomFound)
        {
            textId.Text = RoomFound.roomId.ToString();
            textName.Text = RoomFound.roomName;
            numericFloor.Value = RoomFound.roomFloor;
            numericSingleBed.Value = RoomFound.roomSingleBeds;
            numericCoupleBed.Value = RoomFound.roomCoupleBeds;
            checkRoomEnabled.Checked = RoomFound.roomEnabled;
            textFullPrice.Text = RoomFound.roomFullPrice.ToString();
            textHalfPrice.Text = RoomFound.roomHalfPrice.ToString();

            btnUpdate.Visible = true;

        }

        private void turnFieldsEnabled()
        {
            textName.Enabled = true;
            numericFloor.Enabled = true;
            numericSingleBed.Enabled = true;
            numericCoupleBed.Enabled = true;
            checkRoomEnabled.Enabled = true;
            textFullPrice.Enabled = true;
            textHalfPrice.Enabled = true;
            checkRoomEnabled.Checked = true;
            btnUpdate.Enabled = false;
            btnSaveChanges.Visible = true;

        }
        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = userStorage;

            return sendUser;
        }

        private void Rooms_FormClosing(object sender, FormClosingEventArgs e)
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
