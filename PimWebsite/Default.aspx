<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PimWebsite.Default" Async="true" %>

<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        * {
            margin: 0;
            padding: 0
        }

        html {
            height: 100%
        }



        #msform {
            text-align: center;
            position: relative;
            margin-top: 20px
        }

            #msform fieldset .form-card {
                background: white;
                border: 0 none;
                border-radius: 0px;
                box-shadow: 0 2px 2px 2px rgba(0, 0, 0, 0.2);
                padding: 20px 40px 30px 40px;
                box-sizing: border-box;
                width: 94%;
                margin: 0 3% 20px 3%;
                position: relative
            }

            #msform fieldset {
                background: white;
                border: 0 none;
                border-radius: 0.5rem;
                box-sizing: border-box;
                width: 100%;
                margin: 0;
                padding-bottom: 20px;
                position: relative
            }

                #msform fieldset:not(:first-of-type) {
                    display: none
                }

                #msform fieldset .form-card {
                    text-align: left;
                    color: #9E9E9E
                }

            #msform input,
            #msform textarea {
                padding: 0px 8px 4px 8px;
                border: none;
                border-bottom: 1px solid #ccc;
                border-radius: 0px;
                margin-bottom: 25px;
                margin-top: 2px;
                width: 100%;
                box-sizing: border-box;
                font-family: montserrat;
                color: #2C3E50;
                font-size: 16px;
                letter-spacing: 1px
            }

                #msform input:focus,
                #msform textarea:focus {
                    -moz-box-shadow: none !important;
                    -webkit-box-shadow: none !important;
                    box-shadow: none !important;
                    border: none;
                    font-weight: bold;
                    border-bottom: 2px solid skyblue;
                    outline-width: 0
                }

            #msform .action-button {
                width: 100px;
                background: skyblue;
                font-weight: bold;
                color: white;
                border: 0 none;
                border-radius: 0px;
                cursor: pointer;
                padding: 10px 5px;
                margin: 10px 5px
            }

                #msform .action-button:hover,
                #msform .action-button:focus {
                    box-shadow: 0 0 0 2px white, 0 0 0 3px skyblue
                }

            #msform .action-button-previous {
                width: 100px;
                background: #616161;
                font-weight: bold;
                color: white;
                border: 0 none;
                border-radius: 0px;
                cursor: pointer;
                padding: 10px 5px;
                margin: 10px 5px
            }

                #msform .action-button-previous:hover,
                #msform .action-button-previous:focus {
                    box-shadow: 0 0 0 2px white, 0 0 0 3px #616161
                }

        select.list-dt {
            border: none;
            outline: 0;
            border-bottom: 1px solid #ccc;
            padding: 2px 5px 3px 5px;
            margin: 2px
        }

            select.list-dt:focus {
                border-bottom: 2px solid skyblue
            }

        .card {
            z-index: 0;
            border: none;
            border-radius: 0.5rem;
            position: relative
        }

        .fs-title {
            font-size: 25px;
            color: #2C3E50;
            margin-bottom: 10px;
            font-weight: bold;
            text-align: left
        }

        #progressbar {
            margin-bottom: 30px;
            overflow: hidden;
            color: lightgrey
        }

            #progressbar .active {
                color: #000000
            }

            #progressbar li {
                list-style-type: none;
                font-size: 12px;
                width: 25%;
                float: left;
                position: relative
            }

            #progressbar #account:before {
                font-family: FontAwesome;
                content: "\f023"
            }

            #progressbar #personal:before {
                font-family: FontAwesome;
                content: "\f007"
            }

            #progressbar #payment:before {
                font-family: FontAwesome;
                content: "\f09d"
            }

            #progressbar #confirm:before {
                font-family: FontAwesome;
                content: "\f00c"
            }

            #progressbar li:before {
                width: 50px;
                height: 50px;
                line-height: 45px;
                display: block;
                font-size: 18px;
                color: #ffffff;
                background: lightgray;
                border-radius: 50%;
                margin: 0 auto 10px auto;
                padding: 2px
            }

            #progressbar li:after {
                content: '';
                width: 100%;
                height: 2px;
                background: lightgray;
                position: absolute;
                left: 0;
                top: 25px;
                z-index: -1
            }

            #progressbar li.active:before,
            #progressbar li.active:after {
                background: skyblue
            }

        .radio-group {
            position: relative;
            margin-bottom: 25px
        }

        .radio {
            display: inline-block;
            width: 204px;
            height: 104px;
            border-radius: 0;
            background: lightblue;
            box-shadow: 0 2px 2px 2px rgba(0, 0, 0, 0.2);
            box-sizing: border-box;
            cursor: pointer;
            margin: 8px 2px
        }

            .radio:hover {
                box-shadow: 2px 2px 2px 2px rgba(0, 0, 0, 0.3)
            }

            .radio.selected {
                box-shadow: 1px 1px 2px 2px rgba(0, 0, 0, 0.1)
            }

        .fit-image {
            width: 100%;
            object-fit: cover
        }
    </style>
    <div class="tm-main-content" id="top">
        <div class="tm-section tm-bg-img" id="tm-section-1">
            <div class="tm-bg-white ie-container-width-fix-2" style="border: 2px solid #ee5057; border-radius: 11px;">
                <div class="container ie-h-align-center-fix">
                    <div class="row">

                        <div class="col-xs-12 ml-auto mr-auto ie-container-width-fix">

                            <div class="form-row tm-search-form-row" style="position: relative; left: 63px;">
                                <div class="form-group tm-form-element tm-form-element-30" style="padding: 5px;">
                                    <input name="check-in" type="date" class="form-control" id="inputDateStart" placeholder="Check In" runat="server">
                                </div>
                                <div class="form-group tm-form-element tm-form-element-30" style="padding: 5px;">
                                    <input name="check-out" type="date" class="form-control" id="inputDateEnd" placeholder="Check Out" runat="server">
                                </div>

                                <div class="form-group tm-form-element tm-form-element-2" style="padding: 5px;">
                                    <select name="children" class="form-control tm-select" id="singleBeds" runat="server">
                                        <option value="">Camas de Solteiro</option>
                                        <option value="0">0</option>
                                        <option value="1">1</option>
                                        <option value="2">2</option>
                                        <option value="3">3</option>
                                    </select>
                                </div>
                                <div class="form-group tm-form-element tm-form-element-2" style="padding: 5px;">
                                    <select name="room" class="form-control tm-select" id="coupleBeds" runat="server">
                                        <option value="">Camas de Casal </option>
                                        <option value="0">0</option>
                                        <option value="1">1</option>
                                        <option value="2">2</option>
                                    </select>
                                </div>
                                <div class="form-group tm-form-element tm-form-element-2">
                                    <asp:Button Style="position: relative; left: 287px;" Text="Verificar Disponibilidade" CssClass="btn btn-primary" data-toggle="modal" runat="server" OnClick="btnVerifyRooom_Click" ID="btnVerifyRoom" />
                                </div>
                            </div>
                            <div class="form-row clearfix pl-2 pr-2 tm-fx-col-xs">
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>


        <!-- modal -->
        <!-- modal Login -->
        <div class="modal fade bd-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true" id="loginModal" runat="server">
            <div class="modal-dialog modal-md" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">LOGIN </h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row" runat="server">

                            <div class="form-group col-md-12" runat="server">
                                <label>E-mail</label>
                                <input type="text" class="form-control" id="email_login" runat="server">
                            </div>
                            <div class="form-group col-md-12">
                                <label>Senha</label>
                                <input type="password" class="form-control" id="password_login" runat="server">
                            </div>
                            <div class="form-group col-md-12">
                                <a class="nav-link" href="#tm-section-5" data-toggle="modal" data-target="#cadastro">Fazer cadastro</a>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer" runat="server">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        <asp:Button Text="Acessar" CssClass="btn btn-success" ID="btnLogin" OnClick="btnLogin_Click" runat="server" ClientIDMode="Static" />
                    </div>

                </div>
            </div>
        </div>

        <!-- Modal usuario -->
        <div class="modal fade" id="cadastro_de_reserva" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <!-- MultiStep Form -->
                    </div>
                    <div class="modal-footer">
                        <div class="form-group col-md-6">
                            <a href="#" data-toggle="modal" data-dismiss="modal" data-target="#busca_cadastro">Fazer cadastro</a>
                        </div>
                        <div class="form-group col-md-4">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        </div>

                    </div>

                </div>
            </div>
        </div>


        <!-- Modal busca usuario -->
        <div class="modal fade" id="busca_cadastro" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">VERIFICAR CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label>Tipo Documento</label>
                                <select id="searchTypeDocument" class="form-control" runat="server">
                                    <option selected>Selecione...</option>
                                    <option>RG</option>
                                    <option>Passaporte</option>
                                </select>
                            </div>

                            <div class="row">
                                <div class="form-group col-md-6">
                                    <label>Documento</label>
                                    <input type="text" class="form-control" id="searchDocument" placeholder="" runat="server">
                                </div>

                                <div class="form-group col-md-6" style="margin-top: 30px;">
                                    <button type="button" class="btn btn-success" data-toggle="modal" data-dismiss="modal" data-target="#cadastro">Pesquisar</button>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <!-- Modal Cadastro -->
        <div class="modal fade create-client-modal" id="cadastro" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label>Nome Completo</label>
                                <input type="text" class="form-control" id="createUserName" placeholder="João Alves" runat="server" maxlength="70">
                            </div>


                            <div class="form-group col-md-6">
                                <label>CPF</label>
                                <input type="text" class="form-control" id="createUserCPF" runat="server" clientidmode="Static" maxlength="11" />
                            </div>

                            <div class="form-group col-md-6">
                                <label>Tipo de Documento</label>
                                <select id="createUserDocumentType" class="form-control" runat="server">
                                    <option selected>Selecione...</option>
                                    <option>RG</option>
                                    <option>Passaporte</option>
                                </select>
                            </div>

                            <div class="form-group col-md-6">
                                <label>Documento</label>
                                <input type="text" class="form-control" id="createUserDocument" runat="server" maxlength="24">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Orgão Expedidor</label>
                                <input type="text" class="form-control" id="createUserExpeditor" runat="server" maxlength="10">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Cargo</label>
                                <input type="text" class="form-control" id="createUserFunction" runat="server" maxlength="50">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Data de Nascimento</label>
                                <input type="date" class="form-control" id="createUserBirth" runat="server">
                            </div>

                            <div class="form-group col-md-6">
                                <label>CEP</label>
                                <input name="cep" type="text" id="createUserZipCode" class="form-control" value="" size="10" maxlength="12" runat="server" />
                            </div>

                            <div class="form-group col-md-6">
                                <label>País</label>
                                <input name="País" type="text" class="form-control" id="createUserCountry" size="2" runat="server" maxlength="30">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Estado</label>
                                <input name="Estado" type="text" class="form-control" id="createUserState" size="40" runat="server" maxlength="30">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Cidade</label>
                                <input name="cidade" type="text" class="form-control" id="createUserCity" size="40" runat="server" maxlength="30">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Endereço</label>
                                <input name="rua" type="text" class="form-control" id="createUserAddress" size="60" runat="server" maxlength="70">
                            </div>
                            <div class="form-group col-md-6">
                                <label>Complemento</label>
                                <input name="bairro" class="form-control" type="text" id="createUserSecondAddress" size="40" runat="server" maxlength="30">
                            </div>

                            <hr />

                            <div class="form-group col-md-6">
                                <label>Contato</label>
                                <input type="text" class="form-control" id="createUserFirstPhone" placeholder="(11) 0000-0000" runat="server" maxlength="15">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Segundo Contato</label>
                                <input type="text" class="form-control" id="createUserSecondPhone" placeholder="(11)9 0000-0000" runat="server" maxlength="15">
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        <asp:Button Text="Próximo" CssClass="btn btn-info" runat="server" ID="btnSearchClient" OnClick="btnCreateClient_Click" ClientIDMode="Static" data-target="#cadastro_login" />
                    </div>

                </div>
            </div>
        </div>

        <!-- Modal usuario -->
        <div class="modal fade create-user-modal" id="cadastro_login" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row" runat="server">
                            <div class="form-group col-md-6">
                                <label>E-mail</label>
                                <input type="text" class="form-control" id="createEmail" placeholder="" runat="server" maxlength="70">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Confirma E-mail</label>
                                <input type="text" class="form-control" id="confirmCreateEmail" placeholder="" runat="server" maxlength="70">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Senha</label>
                                <input type="password" class="form-control" id="createPassword" runat="server" maxlength="20">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Confirma senha </label>
                                <input type="password" class="form-control" id="confirmCreatePassword" runat="server" maxlength="20">
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        <asp:Button Text="Cadastrar" CssClass="btn btn-info" runat="server" ID="btnCreateUserClient" OnClick="btnCreateUserClient_Click" ClientIDMode="Static" />
                    </div>

                </div>
            </div>
        </div>

        <!--MODAL ATUALIZAR CADSTRO -->
        <div class="modal fade updateData" id="atualizar_cadstro" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label>Nome Completo</label>
                                <input type="text" class="form-control" id="loggedUserName" placeholder="João Alves" runat="server" maxlength="70">
                            </div>

                            <div class="form-group col-md-6">
                                <label>CPF</label>
                                <input type="text" class="form-control" id="loggedUserCPF" placeholder="999.999.999-99" runat="server" maxlength="11">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Tipo de Documento</label>
                                <select id="loggedUserDocumentType" class="form-control" runat="server">
                                    <option selected>Selecione...</option>
                                    <option>RG</option>
                                    <option>Passaporte</option>
                                </select>
                            </div>

                            <div class="form-group col-md-6">
                                <label>Documento</label>
                                <input type="text" class="form-control" id="loggedUserDocument" runat="server" maxlength="24">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Orgão Expedidor</label>
                                <input type="text" class="form-control" id="loggedUserExpeditor" runat="server" maxlength="10">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Cargo</label>
                                <input type="text" class="form-control" id="loggedUserFunction" runat="server" maxlength="50">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Data de Nascimento</label>
                                <input type="date" class="form-control" id="loggedUserBirth" runat="server">
                            </div>

                            <div class="form-group col-md-6">
                                <label>CEP</label>
                                <input name="cep" type="text" id="loggedUserZipCode" class="form-control" value="" size="10" maxlength="9" runat="server" />
                            </div>

                            <div class="form-group col-md-6">
                                <label>País</label>
                                <input name="País" type="text" class="form-control" id="loggedUserCountry" size="2" runat="server" maxlength="30">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Estado</label>
                                <input name="Estado" type="text" class="form-control" id="loggedUserState" size="40" runat="server" maxlength="30">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Cidade</label>
                                <input name="cidade" type="text" class="form-control" id="loggedUserCity" size="40" runat="server" maxlength="30">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Endereço</label>
                                <input name="rua" type="text" class="form-control" id="loggedUserAddress" size="60" runat="server" maxlength="70">
                            </div>
                            <div class="form-group col-md-6">
                                <label>Complemento</label>
                                <input name="bairro" class="form-control" type="text" id="loggedUserSecondAddress" size="40" runat="server" maxlength="30">
                            </div>

                            <hr />

                            <div class="form-group col-md-6">
                                <label>Contato</label>
                                <input type="text" class="form-control" id="loggedUserFirstPhone" placeholder="(11) 0000-0000" runat="server" maxlength="15">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Segundo Contato</label>
                                <input type="text" class="form-control" id="loggedUserSecondPhone" placeholder="(11)9 0000-0000" runat="server" maxlength="15">
                            </div>

                            <div class="form-group col-md-6">
                                <label>E-mail</label>
                                <input type="email" class="form-control" id="loggedUserEmail" placeholder="joao@hotelpim.com" runat="server" readonly="readonly">
                            </div>


                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        <button type="button" class="btn btn-info" data-dismiss="modal" data-toggle="modal" data-target="#alterar_senha">Atualizar Senha</button>
                        <asp:Button Text="Atualizar Dados" CssClass="btn btn-info" runat="server" ID="btnSaveClientChanges" OnClick="btnSaveClientChanges_Click" ClientIDMode="Static" />
                    </div>

                </div>
            </div>
        </div>

        <!-- Modal Criar Reserva -->

        <div class="modal fade criar_reserva" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true" runat="server">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label>Data Inicio</label>
                                <input type="date" class="form-control" id="dateStartReservation" runat="server" readonly="readonly">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Data Fim</label>
                                <input type="date" class="form-control" id="dateEndReservation" runat="server" readonly="readonly">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Último Destino</label>
                                <input type="text" class="form-control" id="lastDestination" runat="server">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Próximo Destino</label>
                                <input type="text" class="form-control" id="nextDestinantion" runat="server">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Motivo Viagem</label>
                                <input type="text" class="form-control" id="travelReason" runat="server">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Meio de Transporte</label>
                                <input type="text" class="form-control" id="travelTransport" runat="server">
                            </div>

                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        <button type="button" class="btn btn-info" data-dismiss="modal" data-toggle="modal" data-target="#checkPayment">Revisão e Pagamento</button>
                    </div>

                </div>
            </div>
        </div>

        <!-- Registrar Pagamento -->
        <div class="modal fade" id="checkPayment" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #ee5057">
                        <h5 class="modal-title" id="" style="text-align: center">CADASTRO </h5>

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">

                            <div class="form-group col-md-6">
                                <label>Total a pagar</label>
                                <input type="text" class="form-control" id="paymentPrice" runat="server" readonly="readonly">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Período</label>
                                <input type="text" class="form-control" id="periodReview" runat="server" readonly="readonly">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Nome do Titular</label>
                                <input type="text" class="form-control" id="paymentName" runat="server">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Número do cartão</label>
                                <input type="text" class="form-control" id="paymentCard" runat="server" maxlength="16">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Data de vencimento</label>
                                <input type="text" class="form-control" id="paymentExpireDate" runat="server" maxlength="5">
                            </div>

                            <div class="form-group col-md-6">
                                <label>CVC</label>
                                <input type="text" class="form-control" id="paymentCVC" runat="server" maxlength="3">
                            </div>

                            <div class="form-group col-md-6">
                                <label>Forma de pagamento</label>
                                <select id="paymentType" class="form-control" runat="server">
                                    <option selected>Selecione...</option>
                                    <option>Débito</option>
                                    <option>Crédito</option>
                                </select>
                            </div>

                            <div class="form-group col-md-6">
                                <label>Quantidade de parcelas</label>
                                <select id="paymentTimes" class="form-control" runat="server" onchange="paymentTimes_IndexChange" onselect="paymentTimes_IndexChange">
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                </select>
                            </div>

                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal" data-toggle="modal" data-target="#createReservation">Voltar</button>
                        <asp:Button Text="Confirmar Reserva" CssClass="btn btn-info" runat="server" ID="btnCreateReservation" OnClick="btnCreateReservation_Click" ClientIDMode="Static" />
                    </div>

                </div>
            </div>
        </div>


        <!--Modal alterar senha  -->
        <div class="modal updateUserData" id="alterar_senha" tabindex="-1" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Alerta</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group col-md-6">
                            <label>E-mail</label>
                            <input type="text" class="form-control" id="updateEmail" placeholder="" runat="server">
                        </div>

                        <div class="form-group col-md-6">
                            <label>Confirmar E-mail</label>
                            <input type="text" class="form-control" placeholder="" id="confirmEmail" runat="server">
                        </div>

                        <div class="form-group col-md-6">
                            <label>Senha</label>
                            <input type="password" class="form-control" id="updatePassword" runat="server">
                        </div>

                        <div class="form-group col-md-6">
                            <label>Confirmar senha </label>
                            <input type="password" class="form-control" id="confirmPassword" runat="server">
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                        <asp:Button Text="Atualizar Dados" CssClass="btn btn-info" runat="server" ID="btnSaveUserChanges" OnClick="btnSaveUserChanges_Click" ClientIDMode="Static" />
                    </div>
                </div>
            </div>
        </div>


        <!--modal minhas reservas -->

        <div class="modal minhas_reservas" id="minhas_reservas" tabindex="-1" role="dialog" runat="server">
            <div class="modal-dialog  modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Minhas Reservas</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <div class="row">
                            <div class="form-group col-md-4">
                                <input name="Start" type="date" class="form-control" id="inputDateStartSearch" placeholder="Inicio " runat="server">
                            </div>

                            <div class="form-group col-md-4">

                                <input name="End" type="date" class="form-control" id="inputDateEndSearch" placeholder="Fim" runat="server">
                            </div>

                            <div class="form-group col-md-4">
                                <asp:Button Text="Pesquisar" CssClass="btn btn-info" runat="server" ID="Button1" OnClick="btnGetReservations_Click" ClientIDMode="Static" />
                            </div>

                        </div>



                        <table class="table table-bordered" id="tableReservations" runat="server">
                            <thead>
                                <tr>
                                    <th scope="col">#Id</th>
                                    <th scope="col">Data Inicio</th>
                                    <th scope="col">Data Fim</th>
                                    <th scope="col">Data Check In</th>
                                    <th scope="col">Data Check Out</th>
                                    <th scope="col">Data Cancelamento</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>





                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>


        <!--Modal Alert -->
        <div class="modal Alert" tabindex="10" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Alerta</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <p id="txt_alert"></p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>

        <!--footer-->
        <footer class="tm-bg-dark-blue">
            <div class="container">
                <div class="row">
                    <p class="col-sm-12 text-center tm-font-light tm-color-white p-4 tm-margin-b-0">
                        Copyright &copy; <span class="tm-current-year">2021</span> Hotel Pim
                        
                        - FrontEnd: Leonardo Alves, BackEnd: Lucas Oliveira, Documentação: Heron Duarte, Vinicius Fernandes
                    </p>
                </div>
            </div>
        </footer>
    </div>


    <script>


        $(document).ready(function () {
            $('#paymentExpireDate').mask('00/00');
            $('#paymentCVC').mask('000');
            $('#loggedUserSecondPhone').mask('(00) 00000-0000');
            $('#loggedUserFirstPhone').mask('(00) 00000-0000');
            $('#createUserCPF').mask("000.000.000-00", { reverse: true });
            $('#loggedUserCPF').mask('000.000.000-00', { reverse: true });
        });

    </script>

</asp:Content>
