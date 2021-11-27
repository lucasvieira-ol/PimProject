using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimDesktop.Business.Utils.Users;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using ClientData = PimDesktop.Business.Utils.Clients.ClientData;
using ClientFunctions = PimDesktop.Business.Utils.Clients.ClientFunctions;
using System.Diagnostics;

namespace PimDesktop
{
    public partial class Clients : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }
        public string nrDocumentClient { get; set; }

        public Clients(UserData user, string nrDocument = "")
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;
            nrDocumentClient = nrDocument;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textNrDocumentSearch.Text == "")
                MessageBox.Show("O campo de Nr Documento não pode ser vazio");

            else 
            {
                ClientFunctions clientHandler = new ClientFunctions();
                ClientData ClientFound = new ClientData();

                FillProfiles(sender, e);

                ClientFound = clientHandler.getClient(textNrDocumentSearch.Text);

                if (ClientFound != null)
                {
                    FillClientFields(ClientFound);
                    TurnFieldsVisible();
                }
                else
                {
                    MessageBox.Show("Hospede não localizado");
                }
            }
        }

        private void FillClientFields(ClientData ClientFound)
        {
            textId.Text = ClientFound.clientId.ToString();
            textName.Text = ClientFound.clientName;
            textCPF.Text = ClientFound.clientCPF;
            TypesBox.Text = ClientFound.typeDocument;
            textDocument.Text = ClientFound.clientDocument;
            textExpeditor.Text = ClientFound.expeditor;
            textFunction.Text = ClientFound.function;

            if (ClientFound.dt_birth != null)
                dateBirth.Value = (DateTime)ClientFound.dt_birth;
            else
                dateBirth.CustomFormat = " ";

            textCountry.Text = ClientFound.country;
            textState.Text = ClientFound.state;
            textCity.Text = ClientFound.city;
            textZipCode.Text = ClientFound.zipCode;
            textAddress.Text = ClientFound.firstAdress;
            textComplement.Text = ClientFound.secondAdress;
            textContact.Text = ClientFound.firstPhone;
            textSecondContact.Text = ClientFound.secondPhone;


        }

        private void TurnFieldsVisible()
        {

            labelName.Visible = true;
            textName.Visible = true;

            labelBirth.Visible = true;
            dateBirth.Visible = true;

            labelCPF.Visible = true;
            textCPF.Visible = true;

            labelContact.Visible = true;
            textContact.Visible = true;

            labelTypeDocument.Visible = true;
            TypesBox.Visible = true;

            labelDocument.Visible = true;
            textDocument.Visible = true;

            labelExpeditor.Visible = true;
            textExpeditor.Visible = true;

            labelFunction.Visible = true;
            textFunction.Visible = true;

            labelCountry.Visible = true;
            textCountry.Visible = true;

            labelState.Visible = true;
            textState.Visible = true;

            labelCity.Visible = true;
            textCity.Visible = true;

            labelZipCode.Visible = true;
            textZipCode.Visible = true;

            labelComplement.Visible = true;
            textComplement.Visible = true;

            labelSecondContact.Visible = true;
            textSecondContact.Visible = true;

            labelAddress.Visible = true;
            textAddress.Visible = true;


            btnUpdate.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            textName.Enabled = true;
            dateBirth.Enabled = true;
            textCPF.Enabled = true;
            textContact.Enabled = true;
            TypesBox.Enabled = true;
            textDocument.Enabled = true;
            textExpeditor.Enabled = true;
            textFunction.Enabled = true;
            textCountry.Enabled = true;
            textState.Enabled = true;
            textCity.Enabled = true;
            textZipCode.Enabled = true;
            textComplement.Enabled = true;
            textSecondContact.Enabled = true;
            textAddress.Enabled = true;
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

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            FillProfiles(sender, e);
            TurnFieldsVisible();

            if (!string.IsNullOrEmpty(nrDocumentClient))
                textDocument.Text = this.nrDocumentClient;

            textName.Enabled = true;
            dateBirth.Enabled = true;
            textCPF.Enabled = true;
            textContact.Enabled = true;
            TypesBox.Enabled = true;
            textDocument.Enabled = true;
            textExpeditor.Enabled = true;
            textFunction.Enabled = true;
            textCountry.Enabled = true;
            textState.Enabled = true;
            textCity.Enabled = true;
            textZipCode.Enabled = true;
            textComplement.Enabled = true;
            textSecondContact.Enabled = true;
            textAddress.Enabled = true;
            btnUpdate.Visible = false;
            btnSaveChanges.Visible = true;

        }
        private void UpdateUser(object sender, EventArgs e)
        {

            Clients reopen = new Clients(getUserLoged());
            ClientData updateClient = new ClientData();
            ClientFunctions clientHandler = new ClientFunctions();

            if (verifyFilledFields())
            {
                updateClient = clientDataHolder();

                string status = clientHandler.putClient(updateClient);

                if (status == "OK")
                {
                    MessageBox.Show("Informações alteradas com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show(status);
                }
            }
        }

        private ClientData clientDataHolder()
        {
            var convertID = !string.IsNullOrEmpty(textId.Text) ? Convert.ToInt32(textId.Text) : 0;

            DateTime? convertDate = null;

            if (dateBirth.CustomFormat != "")
                convertDate = dateBirth.Value;

            ClientData clientData = new ClientData()
            {
                clientId = convertID,
                clientName = textName.Text,
                clientCPF = !string.IsNullOrEmpty(textCPF.Text) ? textCPF.Text : null,
                typeDocument = TypesBox.SelectedValue.ToString(),
                clientDocument = textDocument.Text,
                expeditor = textExpeditor.Text,
                function = !string.IsNullOrEmpty(textFunction.Text) ? textFunction.Text : null,
                dt_birth = convertDate,
                country = textCountry.Text,
                state = textState.Text,
                city = textCity.Text,
                zipCode = textZipCode.Text,
                firstAdress = textAddress.Text,
                secondAdress = textSecondContact.Text,
                firstPhone = textContact.Text,
                secondPhone = !string.IsNullOrEmpty(textSecondContact.Text) ? textSecondContact.Text : null
            };

            return clientData;
        }

        private bool verifyFilledFields()
        {
            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Necessário preencher o nome");
                return false;
            }

            if (TypesBox.SelectedValue == "0")
            {
                MessageBox.Show("Necessário preencher o tipo do documento");
                return false;
            }

            if (string.IsNullOrEmpty(textDocument.Text))
            {
                MessageBox.Show("Necessário preencher o número de documento");
                return false;
            }

            if (string.IsNullOrEmpty(textExpeditor.Text))
            {
                MessageBox.Show("Necessário preencher o orgão expeditor");
                return false;
            }

            if (string.IsNullOrEmpty(textCountry.Text))
            {
                MessageBox.Show("Necessário preencher o pais de nascimento");
                return false;
            }

            if (string.IsNullOrEmpty(textState.Text))
            {
                MessageBox.Show("Necessário preencher o estado de nascimento");
                return false;
            }

            if (string.IsNullOrEmpty(textCity.Text))
            {
                MessageBox.Show("Necessário preencher a cidade de nascimento");
                return false;
            }

            if (string.IsNullOrEmpty(textZipCode.Text))
            {
                MessageBox.Show("Necessário preencher o CEP para cobrança");
                return false;
            }

            if (string.IsNullOrEmpty(textAddress.Text))
            {
                MessageBox.Show("Necessário preencher o endereço de cobrança");
                return false;
            }

            if (string.IsNullOrEmpty(textComplement.Text))
            {
                MessageBox.Show("Necessário preencher o complemento");
                return false;
            }

            if (string.IsNullOrEmpty(textContact.Text))
            {
                MessageBox.Show("Necessário preencher o primeiro número para contato");
                return false;
            }

            return true;
        }

        private void InsertUser(object sender, EventArgs e)
        {

            Clients reopen = new Clients(getUserLoged());
            ClientData createClient = new ClientData();
            ClientFunctions clientHandler = new ClientFunctions();

            if (verifyFilledFields())
            {
                createClient = clientDataHolder();

                string status = clientHandler.setClient(createClient);

                if (status == "OK")
                {
                    MessageBox.Show("Hospede cadastrado com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show(status);
                }
            }
        }

        private void FillProfiles(object sender, EventArgs e)
        {
            Dictionary<string, string> documentsTypes = new Dictionary<string, string>();

            documentsTypes.Add("0", "Selecione");
            documentsTypes.Add("1", "RG");
            documentsTypes.Add("2", "Passaporte");


            TypesBox.DataSource = new BindingSource(documentsTypes, null);
            TypesBox.DisplayMember = "Value";
            TypesBox.ValueMember = "Key";
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.nrDocumentClient))
                btnCreateClient_Click(sender, e);
        }

        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
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
