using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using PimWebsite.Models.Main;
using PimWebsite.Controllers;
using PimWebsite.Utils.Alert;
using PimWebsite.Models.Client;
using PimWebsite.Models.Reservation;


namespace PimWebsite
{
    public partial class Default : Page
    {
        static clientData clientHold = new clientData();

        static roomData roomHold = new roomData();

        public int idLoggedUser = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.AsyncMode = true;

        }

        #region Login/Logout Handlers
        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            LoginData sendLogin = new LoginData();


            sendLogin.email = email_login.Value.ToString();
            sendLogin.password = password_login.Value.ToString();


            var clientRetrieve = await clientController.LoginHandler(sendLogin);

            if (clientRetrieve.clientId == 0)
            {
                Alert.MessageBox(this, "E-mail e/ou Senha Inválidos", ".bd-example-modal-lg");
            }
            else
            {
                clientHold = clientRetrieve;
                this.Master.LoggedOptionVisible();
                FillLoggedFields();
            }
        }
        public void LogoutHandler()
        {
            clientHold = new clientData();
            roomHold = new roomData();
            //tableReservations.Rows.Clear();
        }

        #endregion

        #region Client Handlers

        #region Creating Client

        /* Descontinuado
        protected async void btnSearchClient_Click(object sender, EventArgs e)
        {
            string resultFromValidation = ValidateFields("search client");

            if (resultFromValidation == "OK")
            {
                var resultResponse = await clientController.getClientByDocument(searchDocument.Value, searchTypeDocument.Value);

                if (resultResponse != null)
                {
                    if (resultResponse.id_UserClient == null)
                    {
                        clientHold = resultResponse;

                        FillCreateFields();

                    }
                    else
                    {
                        Alert.MessageBox(this, "Já existe um cadastro de usuário vinculado a esse documento",");
                    }
                }
            }
            else
            {
                Alert.MessageBox(this, resultFromValidation);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('#cadastro').modal('show');</script>", false);

            }
        }

        */
        protected async void btnCreateClient_Click(object sender, EventArgs e)
        {
            string resultFromValidation = ValidateFields("create client");


            if (resultFromValidation == "OK")
            {
                clientData sendClientData = new clientData()
                {
                    clientId = clientHold.clientId,
                    clientName = createUserName.Value,
                    typeDocument = createUserDocumentType.Value,
                    clientDocument = createUserDocument.Value,
                    clientCPF = createUserCPF.Value.Replace(".", "").Replace("-", ""),
                    expeditor = createUserExpeditor.Value,
                    function = createUserFunction.Value,
                    dt_birth = Convert.ToDateTime(createUserBirth.Value),
                    country = createUserCountry.Value,
                    state = createUserState.Value,
                    city = createUserCity.Value,
                    zipCode = createUserZipCode.Value,
                    firstAdress = createUserAddress.Value,
                    secondAdress = createUserSecondAddress.Value,
                    firstPhone = createUserFirstPhone.Value,
                    secondPhone = createUserSecondPhone.Value
                };

                string resultResponse = string.Empty;

                if (sendClientData.clientId != 0)
                    resultResponse = await clientController.clientUpdate(sendClientData);
                else
                    resultResponse = await clientController.clientCreate(sendClientData);

                if (!resultResponse.Contains("êxito"))
                {
                    Alert.MessageBox(this, resultResponse, ".create-client-modal");
                }
                else
                {
                    var updateClientHolder = await clientController.getClientByDocument(clientHold.clientDocument, clientHold.typeDocument);

                    clientHold = new clientData();

                    clientHold = updateClientHolder;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('.create-user-modal').modal('show');</script>", false);

                }

            }
            else
            {
                Alert.MessageBox(this, resultFromValidation, ".create-client-modal");
            }
        }
        protected async void btnCreateUserClient_Click(object sender, EventArgs e)
        {
            string resultFromValidation = ValidateFields("create user");

            if (resultFromValidation == "OK")
            {
                clientData sendClientData = new clientData()
                {
                    clientId = clientHold.clientId,
                    updatePassword = createEmail.Value,
                    emailUser = createPassword.Value
                };

                string resultResponse = await clientController.clientUserCreate(sendClientData);


                if (!resultResponse.Contains("êxito"))
                {
                    Alert.MessageBox(this, resultResponse, ".create-user-modal");
                }
                else
                {
                    //var updateClientHolder = await clientController.getClientByDocument(clientHold.clientDocument, clientHold.typeDocument);

                    //clientHold = new clientData();

                    //clientHold = updateClientHolder;

                    Alert.MessageBox(this, resultResponse, "");

                    this.Master.LoggedOptionVisible();
                    FillLoggedFields();

                }

            }
            else
            {
                Alert.MessageBox(this, resultFromValidation, ".create-user-modal");
            }
        }

        #endregion

        #region Updating Client
        protected async void btnSaveClientChanges_Click(object sender, EventArgs e)
        {
            string resultFromValidation = ValidateFields("update client");


            if (resultFromValidation == "OK")
            {
                clientData sendUpdateClient = new clientData()
                {
                    clientId = clientHold.clientId,
                    clientName = loggedUserName.Value,
                    typeDocument = loggedUserDocumentType.Value,
                    clientDocument = loggedUserDocument.Value,
                    clientCPF = loggedUserCPF.Value.Replace(".", "").Replace("-", ""),
                    expeditor = loggedUserExpeditor.Value,
                    function = loggedUserFunction.Value,
                    dt_birth = Convert.ToDateTime(loggedUserBirth.Value),
                    country = loggedUserCountry.Value,
                    state = loggedUserState.Value,
                    city = loggedUserCity.Value,
                    zipCode = loggedUserZipCode.Value,
                    firstAdress = loggedUserAddress.Value,
                    secondAdress = loggedUserSecondAddress.Value,
                    firstPhone = loggedUserFirstPhone.Value,
                    secondPhone = loggedUserSecondPhone.Value
                };

                string resultResponse = await clientController.clientUpdate(sendUpdateClient);

                Alert.MessageBox(this, resultResponse, "");

                var updateClientHolder = await clientController.getClient(clientHold);

                clientHold = new clientData();

                clientHold = updateClientHolder;

            }
            else
            {
                Alert.MessageBox(this, resultFromValidation, ".updateData");
            }
            FillLoggedFields();
        }

        protected async void btnSaveUserChanges_Click(object sender, EventArgs e)
        {
            string resultFromValidation = ValidateFields("update user");

            if (resultFromValidation == "OK")
            {
                if (!string.IsNullOrEmpty(updateEmail.Value))
                    clientHold.emailUser = updateEmail.Value;

                if (!string.IsNullOrEmpty(updatePassword.Value))
                    clientHold.updatePassword = updatePassword.Value;

                string resultResponse = await clientController.clientUpdate(clientHold);

                Alert.MessageBox(this, resultResponse, "");

                var updateClientHolder = await clientController.getClient(clientHold);

                clientHold = new clientData();

                clientHold = updateClientHolder;
            }
            else
            {
                Alert.MessageBox(this, resultFromValidation, ".updateUserData");
            }

            FillLoggedFields();
        }

        #endregion

        #region Fields Handlers
        protected string ValidateFields(string modalType)
        {
            string response = string.Empty;

            switch (modalType)
            {
                case "create user":

                    if (string.IsNullOrEmpty(createEmail.Value))
                    {
                        response = "Necessário preencher o E-mail para prosseguir";
                        break;
                    }

                    if (createEmail.Value != confirmCreateEmail.Value)
                    {
                        response = "Os E-mails não coincidem";
                        break;
                    }

                    if (string.IsNullOrEmpty(createPassword.Value))
                    {
                        response = "Necessário preencher a senha para prosseguir";
                        break;
                    }

                    if (createPassword.Value != confirmCreatePassword.Value)
                    {
                        response = "As Senhas não coincidem";
                        break;
                    }

                    response = "OK";
                    break;


                case "search client":
                    if (searchTypeDocument.Value == "Selecione...")
                    {
                        response = "Necessário preencher o tipo de documento para prosseguir";
                        break;
                    }

                    if (string.IsNullOrEmpty(searchDocument.Value))
                    {
                        response = "Necessário preencher o tipo de documento para prosseguir";
                        break;
                    }

                    response = "OK";
                    break;

                case "create client":
                    if (string.IsNullOrEmpty(createUserName.Value))
                    {
                        response = "Necessário Preencher o Campo de Nome";
                        break;
                    }

                    if (createUserDocumentType.Value == "Selecione...")
                    {
                        response = "Necessário Escolher o Tipo de Documento";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserDocument.Value))
                    {
                        response = "Necessário Preencher o Número de Documento";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserExpeditor.Value))
                    {
                        response = "Necessário Preencher o Orgão Expedidor";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserCountry.Value))
                    {
                        response = "Necessário Preencher o País";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserState.Value))
                    {
                        response = "Necessário Preencher o Estado";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserCity.Value))
                    {
                        response = "Necessário Preencher a Cidade";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserZipCode.Value))
                    {
                        response = "Necessário Preencher o CEP";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserAddress.Value))
                    {
                        response = "Necessário Preencher o Primeiro Endereço";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserSecondAddress.Value))
                    {
                        response = "Necessário Preencher o Complemento";
                        break;
                    }

                    if (string.IsNullOrEmpty(createUserFirstPhone.Value))
                    {
                        response = "Necessário Preencher o Primeiro Número para contato";
                        break;
                    }

                    response = "OK";
                    break;

                case "update client":
                    if (string.IsNullOrEmpty(loggedUserName.Value))
                    {
                        response = "Necessário Preencher o Campo de Nome";
                        break;
                    }

                    if (loggedUserDocumentType.Value == "Selecione...")
                    {
                        response = "Necessário Escolher o Tipo de Documento";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserDocument.Value))
                    {
                        response = "Necessário Preencher o Número de Documento";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserExpeditor.Value))
                    {
                        response = "Necessário Preencher o Orgão Expedidor";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserCountry.Value))
                    {
                        response = "Necessário Preencher o País";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserState.Value))
                    {
                        response = "Necessário Preencher o Estado";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserCity.Value))
                    {
                        response = "Necessário Preencher a Cidade";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserZipCode.Value))
                    {
                        response = "Necessário Preencher o CEP";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserAddress.Value))
                    {
                        response = "Necessário Preencher o Primeiro Endereço";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserSecondAddress.Value))
                    {
                        response = "Necessário Preencher o Complemento";
                        break;
                    }

                    if (string.IsNullOrEmpty(loggedUserFirstPhone.Value))
                    {
                        response = "Necessário Preencher o Primeiro Número para contato";
                        break;
                    }

                    response = "OK";
                    break;

                case "update user":

                    if (updateEmail.Value != confirmEmail.Value)
                    {
                        response = "Os E-mails digitados não coincidem";
                        break;
                    }

                    if (updatePassword.Value != confirmPassword.Value)
                    {
                        response = "As Senhas digitadas não coincidem";
                        break;
                    }

                    response = "OK";
                    break;

                default:
                    return "Erro Inesperado";
            }

            return response;
        }
        protected private void FillLoggedFields()
        {
            loggedUserName.Value = clientHold.clientName;
            loggedUserCPF.Value = clientHold.clientCPF;
            loggedUserDocumentType.Value = clientHold.typeDocument;
            loggedUserDocument.Value = clientHold.clientDocument;
            loggedUserExpeditor.Value = clientHold.expeditor;
            loggedUserFunction.Value = clientHold.function;
            loggedUserBirth.Value = clientHold.dt_birth.Value.ToString("yyyy-MM-dd");
            loggedUserCountry.Value = clientHold.country;
            loggedUserState.Value = clientHold.state;
            loggedUserCity.Value = clientHold.city;
            loggedUserZipCode.Value = clientHold.zipCode;
            loggedUserAddress.Value = clientHold.firstAdress;
            loggedUserSecondAddress.Value = clientHold.secondAdress;
            loggedUserFirstPhone.Value = clientHold.firstPhone;
            loggedUserSecondPhone.Value = clientHold.secondPhone;
            loggedUserEmail.Value = clientHold.emailUser;
        }
        protected private void FillCreateFields()
        {
            createUserName.Value = clientHold.clientName;
            createUserCPF.Value = clientHold.clientCPF;
            createUserDocumentType.Value = clientHold.typeDocument;
            createUserDocument.Value = clientHold.clientDocument;
            createUserExpeditor.Value = clientHold.expeditor;
            createUserFunction.Value = clientHold.function;
            createUserBirth.Value = clientHold.dt_birth.Value.ToString("yyyy-MM-dd");
            createUserCountry.Value = clientHold.country;
            createUserState.Value = clientHold.state;
            createUserCity.Value = clientHold.city;
            createUserZipCode.Value = clientHold.zipCode;
            createUserAddress.Value = clientHold.firstAdress;
            createUserSecondAddress.Value = clientHold.secondAdress;
            createUserFirstPhone.Value = clientHold.firstPhone;
            createUserSecondPhone.Value = clientHold.secondPhone;
        }

        #endregion

        #endregion

        #region Reservation

        protected async void btnVerifyRooom_Click(object sender, EventArgs e)
        {
            string responseFromValidation = validateReservationFields("verifyRoom");

            if (responseFromValidation == "OK")
            {
                reservationData preReservation = new reservationData()
                {
                    startDate = Convert.ToDateTime(inputDateStart.Value),
                    endDate = Convert.ToDateTime(inputDateEnd.Value),
                    qtyCoupleBeds = Convert.ToInt32(coupleBeds.Value),
                    qtySingleBeds = Convert.ToInt32(singleBeds.Value)
                };


                roomHold = await reservationController.getAvailableRoom(preReservation);

                if (roomHold.idRoom != 0)
                {
                    if (clientHold.clientId != 0)
                    {
                        if (clientHold.id_UserClient != null)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('.criar_reserva').modal('show');</script>", false);
                            dateStartReservation.Value = inputDateStart.Value;
                            dateEndReservation.Value = inputDateEnd.Value;
                            paymentPrice.Value = "1 x de R$" + roomHold.payValue.ToString().Replace(".", ",");
                            periodReview.Value = roomHold.dateStart.ToString("dd/MM/yyyy") + " até " + roomHold.dateEnd.ToString("dd/MM/yyyy");

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('.create-user-modal').modal('show');</script>", false);

                        }
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('.bd-example-modal-lg').modal('show');</script>", false);
                }
                else
                {
                    Alert.MessageBox(this, "Nenhum quarto disponível encontrado para os filtros inseridos, tente novamente atualizando os filtros", "");
                }

            }
            else
            {
                Alert.MessageBox(this, responseFromValidation, "");
            }
        }

        protected async void btnCreateReservation_Click(object sender, EventArgs e)
        {
            string responseFromValidation = validateReservationFields("create reservation");

            if (responseFromValidation == "OK")
            {
                reservationData sendReservation = new reservationData()
                {
                    reservationClientId = clientHold.clientId,
                    reasonTravel = travelReason.Value,
                    startDate = Convert.ToDateTime(dateStartReservation.Value),
                    endDate = Convert.ToDateTime(dateEndReservation.Value),
                    lastDestination = lastDestination.Value,
                    qtySingleBeds = Convert.ToInt32(singleBeds.Value),
                    qtyCoupleBeds = Convert.ToInt32(coupleBeds.Value),
                    paymentTimes = Convert.ToInt32(paymentTimes.Value),
                    reservationRoomId = roomHold.idRoom,
                    nextDestination = nextDestinantion.Value,
                    typePayment = paymentType.Value,
                    transport = travelTransport.Value
                };

                string responseResult = await reservationController.createReservation(sendReservation);

                Alert.MessageBox(this, responseResult, ".criar_reserva");

            }
            else
            {
                Alert.MessageBox(this, responseFromValidation, ".criar_reserva");
            }
        }

        protected async void btnGetReservations_Click(object sender, EventArgs e)
        {
            string responseFromValidation = validateReservationFields("search reservations");

            if (responseFromValidation == "OK")
            {
                //tableReservations.Rows.Clear();

                UserData sendFilters = new UserData()
                {
                    clientId = clientHold.clientId,
                    clientUserId = (int)clientHold.id_UserClient,
                    dateStart = Convert.ToDateTime(inputDateStartSearch.Value),
                    dateEnd = Convert.ToDateTime(inputDateEndSearch.Value)
                };

                List<reservationRpt> result = await reservationController.getReservations(sendFilters);

                if (result.Count() > 0)
                {
                    foreach (var item in result)
                    {
                        HtmlTableRow tbRow = new HtmlTableRow();
                        HtmlTableCell tbCellIdReservation = new HtmlTableCell();
                        HtmlTableCell tbCellDtStart = new HtmlTableCell();
                        HtmlTableCell tbCellDtEnd = new HtmlTableCell();
                        HtmlTableCell tbCellDtCheckin = new HtmlTableCell();
                        HtmlTableCell tbCellDtCheckOut = new HtmlTableCell();
                        HtmlTableCell tbCellDtCancelation = new HtmlTableCell();
                        tbCellIdReservation.Controls.Add(new LiteralControl(item.idReservation.ToString()));
                        tbCellDtStart.Controls.Add(new LiteralControl(item.dateStart));
                        tbCellDtEnd.Controls.Add(new LiteralControl(item.dateEnd));
                        tbCellDtCheckin.Controls.Add(new LiteralControl(item.dateCheckIn));
                        tbCellDtCheckOut.Controls.Add(new LiteralControl(item.dateCheckOut));
                        tbCellDtCancelation.Controls.Add(new LiteralControl(item.dateCancelation));

                        tbRow.Cells.Add(tbCellIdReservation);
                        tbRow.Cells.Add(tbCellDtStart);
                        tbRow.Cells.Add(tbCellDtEnd);
                        tbRow.Cells.Add(tbCellDtCheckin);
                        tbRow.Cells.Add(tbCellDtCheckOut);
                        tbRow.Cells.Add(tbCellDtCancelation);

                        tableReservations.Rows.Add(tbRow);


                    }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('.minhas_reservas').modal('show');</script>", false);
                }
                else
                {
                    HtmlTableRow tbRow = new HtmlTableRow();
                    HtmlTableCell tbCell = new HtmlTableCell();
                    tbCell.Controls.Add(new LiteralControl());
                    tbRow.Cells.Add(tbCell);
                    tableReservations.Rows.Add(tbRow);

                    Alert.MessageBox(this, "Sem Reservas no período informado", ".minhas_reservas");
                }


            }
            else
            {
                Alert.MessageBox(this, responseFromValidation, ".minhas_reservas");
            }
        }

        protected void paymentTimes_IndexChange(object sender, EventArgs e)
        {
            string dividedPrice = (roomHold.payValue / Convert.ToInt32(paymentPrice.Value)).ToString().Replace(".", ",");

            paymentPrice.Value = paymentTimes.Value + " X de R$ " + dividedPrice;
        }

        #region Fields Handlers

        protected string validateReservationFields(string modalType)
        {
            string response = string.Empty;

            switch (modalType)
            {
                case "verifyRoom":

                    if (string.IsNullOrEmpty(inputDateStart.Value))
                    {
                        response = "Necessário preencher a data de início";
                        break;
                    }

                    if (string.IsNullOrEmpty(inputDateEnd.Value))
                    {
                        response = "Necessário preencher a data de fim";
                        break;
                    }

                    if (Convert.ToDateTime(inputDateStart.Value).Date < DateTime.Now.Date)
                    {
                        response = "A data de início deve ser maior/ igual a data de hoje";
                        break;
                    }

                    if (Convert.ToDateTime(inputDateStart.Value) >= Convert.ToDateTime(inputDateEnd.Value))
                    {
                        response = "A data de fim não pode ser menor/igual que a data de início";
                        break;
                    }

                    if (string.IsNullOrEmpty(singleBeds.Value))
                    {
                        response = "Necessário informar a quantidade de camas de solteiro";
                        break;
                    }

                    if (string.IsNullOrEmpty(coupleBeds.Value))
                    {
                        response = "Necessário informar a quantidade de camas de casal";
                        break;
                    }

                    if (Convert.ToInt32(coupleBeds.Value) == 0 && Convert.ToInt32(singleBeds.Value) == 0)
                    {
                        response = "Necessário informar ao menos um tipo de cama desejado";
                        break;
                    }

                    response = "OK";
                    break;

                case "search reservations":
                    if (string.IsNullOrEmpty(inputDateStartSearch.Value))
                    {
                        response = "Necessário preencher a data de início";
                        break;
                    }

                    if (string.IsNullOrEmpty(inputDateEndSearch.Value))
                    {
                        response = "Necessário preencher a data de fim";
                        break;
                    }

                    if (Convert.ToDateTime(inputDateStartSearch.Value) > Convert.ToDateTime(inputDateEndSearch.Value))
                    {
                        response = "A data de fim não pode ser menor que a data de início";
                        break;
                    }

                    response = "OK";
                    break;

                case "create reservation":

                    if (string.IsNullOrEmpty(travelReason.Value))
                    {
                        response = "O campo de motivo viagem deve ser preenchido";
                        break;
                    }
                    if (string.IsNullOrEmpty(lastDestination.Value))
                    {
                        response = "O campo de último destino deve ser preenchido";
                        break;
                    }
                    if (string.IsNullOrEmpty(nextDestinantion.Value))
                    {
                        response = "O campo de próximo destino deve ser preenchido";
                        break;
                    }
                    if (string.IsNullOrEmpty(travelTransport.Value))
                    {
                        response = "O campo de tranasporte deve ser preenchido";
                        break;
                    }
                    if (paymentType.Value == "Selecione...")
                    {
                        response = "O campo de tipo de pagamento deve ser preenchido";
                        break;
                    }

                    response = "OK";
                    break;

                default:
                    break;
            }

            return response;
        }


        #endregion

        #endregion
    }
}