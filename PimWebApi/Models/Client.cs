using PimDesktop.Data.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebApi.Models.Client
{

    public class clientData
    {
        public int clientId { get; set; }
        public string clientName { get; set; }
        public string clientCPF { get; set; }
        public string typeDocument { get; set; }
        public string clientDocument { get; set; }
        public string expeditor { get; set; }
        public string function { get; set; }
        public DateTime? dt_birth { get; set; }
        public DateTime dt_createdAt { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string firstAdress { get; set; }
        public string secondAdress { get; set; }
        public string firstPhone { get; set; }
        public string secondPhone { get; set; }
        public int? id_UserClient { get; set; }
        public string emailUser { get; set; }
        public DateTime? dt_userCreatedAt { get; set; }
        public DateTime? dt_firstAccess { get; set; }
        public DateTime? dt_lastAccess { get; set; }
        public string updatePassword { get; set; }
    }

    public class clientFunctions
    {
        #region client

        public clientData getClientData(int idClient)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                clientData result = new clientData();

                try
                {
                    result = (from h in context.hospede
                              from uh in context.usuario_hospede.Where(i => i.id_hospede == h.id_hospede).DefaultIfEmpty()
                              select new clientData()
                              {
                                  clientId = h.id_hospede,
                                  clientCPF = h.CPF,
                                  clientName = h.nome,
                                  typeDocument = h.tipo_documento,
                                  clientDocument = h.numero_identidade,
                                  expeditor = h.orgao_expedidor,
                                  function = h.funcao,
                                  dt_birth = h.data_nascimento,
                                  dt_createdAt = h.data_cadastro,
                                  country = h.pais,
                                  state = h.estado,
                                  city = h.cidade,
                                  zipCode = h.CEP,
                                  firstAdress = h.primeiro_endereco,
                                  secondAdress = h.segundo_endereco,
                                  firstPhone = h.primeiro_telefone,
                                  secondPhone = h.segundo_telefone,
                                  id_UserClient = uh.id_usuarioHospede,
                                  emailUser = uh.email ?? "",
                                  dt_userCreatedAt = uh.data_cadastro,
                                  dt_firstAccess = uh.primeiro_acesso,
                                  dt_lastAccess = uh.ultimo_acesso
                              }).Where(i => i.clientId == idClient)
                              .FirstOrDefault();

                    return result;
                }
                catch
                {
                    return result;
                }
            }
        }

        public clientData getClientDataByDocument(string nrDocument, string typeDocument)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                clientData result = new clientData();

                try
                {
                    result = (from h in context.hospede
                              from uh in context.usuario_hospede.Where(i => i.id_hospede == h.id_hospede).DefaultIfEmpty()
                              select new clientData()
                              {
                                  clientId = h.id_hospede,
                                  clientCPF = h.CPF,
                                  clientName = h.nome,
                                  typeDocument = h.tipo_documento,
                                  clientDocument = h.numero_identidade,
                                  expeditor = h.orgao_expedidor,
                                  function = h.funcao,
                                  dt_birth = h.data_nascimento,
                                  dt_createdAt = h.data_cadastro,
                                  country = h.pais,
                                  state = h.estado,
                                  city = h.cidade,
                                  zipCode = h.CEP,
                                  firstAdress = h.primeiro_endereco,
                                  secondAdress = h.segundo_endereco,
                                  firstPhone = h.primeiro_telefone,
                                  secondPhone = h.segundo_telefone,
                                  id_UserClient = uh.id_usuarioHospede,
                                  emailUser = uh.email ?? "",
                                  dt_userCreatedAt = uh.data_cadastro,
                                  dt_firstAccess = uh.primeiro_acesso,
                                  dt_lastAccess = uh.ultimo_acesso
                              }).Where(i => i.clientDocument == nrDocument && i.typeDocument == typeDocument)
                              .FirstOrDefault();

                    return result;
                }
                catch
                {
                    return result;
                }
            }
        }

        public string putClient(clientData currentClient)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var updateClient = context.hospede.Where(i => i.id_hospede == currentClient.clientId).FirstOrDefault();

                var updateUserClient = context.usuario_hospede.Where(i => i.id_usuarioHospede == currentClient.id_UserClient).FirstOrDefault();

                if (!string.IsNullOrEmpty(currentClient.updatePassword))
                {
                    updateUserClient.senha = currentClient.updatePassword;

                    if (!string.IsNullOrEmpty(currentClient.emailUser))
                        if (context.usuario_hospede.Where(i => i.email == currentClient.emailUser && i.id_usuarioHospede != currentClient.id_UserClient).Count() > 0)
                            return "Já existe um usuário com esse e-mail";
                        else
                            updateUserClient.email = currentClient.emailUser;

                    context.SaveChanges();

                    return "Informações alteradas com êxito";
                }

                if (context.hospede.AsEnumerable().Where(i => i.numero_identidade == currentClient.clientDocument && i.id_hospede != currentClient.clientId).Count() == 0)
                {
                    if (!string.IsNullOrEmpty(currentClient.clientCPF))
                    {
                        if (context.hospede.Where(i => i.CPF == currentClient.clientCPF && i.id_hospede != currentClient.clientId).Count() == 0)
                        {
                            updateClient.nome = currentClient.clientName;
                            updateClient.CPF = currentClient.clientCPF;
                            updateClient.tipo_documento = currentClient.typeDocument;
                            updateClient.numero_identidade = currentClient.clientDocument;
                            updateClient.orgao_expedidor = currentClient.expeditor;

                            if (!string.IsNullOrEmpty(currentClient.function))
                                updateClient.funcao = currentClient.function;

                            if (currentClient.dt_birth != null)
                                updateClient.data_nascimento = currentClient.dt_birth;

                            updateClient.pais = currentClient.country;
                            updateClient.estado = currentClient.state;
                            updateClient.cidade = currentClient.city;
                            updateClient.primeiro_endereco = currentClient.firstAdress;
                            updateClient.segundo_endereco = currentClient.secondAdress;
                            updateClient.primeiro_telefone = currentClient.firstPhone;

                            if (!string.IsNullOrEmpty(currentClient.secondPhone))
                                updateClient.segundo_telefone = currentClient.secondPhone;

                            if (!string.IsNullOrEmpty(currentClient.emailUser))
                                if (context.usuario_hospede.Where(i => i.email == currentClient.emailUser && i.id_usuarioHospede != currentClient.id_UserClient).Count() > 0)
                                    return "Já existe um usuário com esse e-mail";
                                else
                                    updateUserClient.email = currentClient.emailUser;

                            context.SaveChanges();

                            return "Informações alteradas com êxito";
                        }
                        else
                        {
                            return "Já existe um hospede cadastrado com esse CPF de documento";
                        }
                    }
                    else
                    {
                        updateClient.nome = currentClient.clientName;
                        updateClient.tipo_documento = currentClient.typeDocument;
                        updateClient.numero_identidade = currentClient.clientDocument;
                        updateClient.orgao_expedidor = currentClient.expeditor;

                        if (!string.IsNullOrEmpty(currentClient.function))
                            updateClient.funcao = currentClient.function;

                        if (currentClient.dt_birth != null)
                            updateClient.data_nascimento = currentClient.dt_birth;

                        updateClient.pais = currentClient.country;
                        updateClient.estado = currentClient.state;
                        updateClient.cidade = currentClient.city;
                        updateClient.primeiro_endereco = currentClient.firstAdress;
                        updateClient.segundo_endereco = currentClient.secondAdress;
                        updateClient.primeiro_telefone = currentClient.firstPhone;

                        if (!string.IsNullOrEmpty(currentClient.secondPhone))
                            updateClient.segundo_telefone = currentClient.secondPhone;

                        if (!string.IsNullOrEmpty(currentClient.emailUser))
                            if (context.usuario_hospede.Where(i => i.email == currentClient.emailUser && i.id_usuarioHospede != currentClient.id_UserClient).Count() > 0)
                                return "Já existe um usuário com esse e-mail";
                            else
                                updateUserClient.email = currentClient.emailUser;

                        context.SaveChanges();

                        return "Informações alteradas com êxito";
                    }
                }
                else
                {
                    return "Já existe um hospede cadastrado com esse número de documento";
                }
            }
        }

        public string setClient(clientData currentClient)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {

                if (context.hospede.Where(i => i.numero_identidade == currentClient.clientDocument).Count() == 0)
                {
                    if (!string.IsNullOrEmpty(currentClient.clientCPF))
                    {
                        if (context.hospede.Where(i => i.CPF == currentClient.clientCPF).Count() == 0)
                        {
                            PimDesktop.Data.Server.hospede createClient = new hospede()
                            {
                                nome = currentClient.clientName,
                                CPF = !string.IsNullOrEmpty(currentClient.clientCPF) ? currentClient.clientCPF : null,
                                tipo_documento = currentClient.typeDocument,
                                numero_identidade = currentClient.clientDocument,
                                orgao_expedidor = currentClient.expeditor,
                                funcao = !string.IsNullOrEmpty(currentClient.function) ? currentClient.function : null,
                                data_nascimento = currentClient.dt_birth,
                                data_cadastro = DateTime.Now,
                                pais = currentClient.country,
                                cidade = currentClient.city,
                                estado = currentClient.state,
                                CEP = currentClient.zipCode,
                                primeiro_endereco = currentClient.firstAdress,
                                segundo_endereco = currentClient.secondAdress,
                                primeiro_telefone = currentClient.firstPhone,
                                segundo_telefone = !string.IsNullOrEmpty(currentClient.secondPhone) ? currentClient.secondPhone : null
                            };

                            context.hospede.Add(createClient);

                            context.SaveChanges();

                            return "êxito";
                        }
                        else
                        {
                            return "Já existe um hospede cadastrado com esse mesmo CPF";
                        }
                    }
                    else
                    {
                        PimDesktop.Data.Server.hospede createClient = new hospede()
                        {
                            nome = currentClient.clientName,
                            CPF = !string.IsNullOrEmpty(currentClient.clientCPF) ? currentClient.clientCPF : null,
                            tipo_documento = currentClient.typeDocument,
                            numero_identidade = currentClient.clientDocument,
                            orgao_expedidor = currentClient.expeditor,
                            funcao = !string.IsNullOrEmpty(currentClient.function) ? currentClient.function : null,
                            data_nascimento = currentClient.dt_birth,
                            data_cadastro = DateTime.Now,
                            pais = currentClient.country,
                            cidade = currentClient.city,
                            estado = currentClient.state,
                            CEP = currentClient.zipCode,
                            primeiro_endereco = currentClient.firstAdress,
                            segundo_endereco = currentClient.secondAdress,
                            primeiro_telefone = currentClient.firstPhone,
                            segundo_telefone = !string.IsNullOrEmpty(currentClient.secondPhone) ? currentClient.secondPhone : null
                        };

                        context.hospede.Add(createClient);

                        context.SaveChanges();

                        return "êxito";
                    }
                }
                else
                {
                    return "Já existe um hospede cadastrado com esse mesmo número de documento";
                }
            }
        }
        public string setClientUser(string email, string password, int clientID)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                if (context.usuario_hospede.Where(i => i.email == email && i.id_hospede == clientID).Count() == 0)
                {
                    usuario_hospede newUser = new usuario_hospede()
                    {
                        id_hospede = clientID,
                        email = email,
                        senha = password,
                        data_cadastro = DateTime.Now
                    };

                    context.usuario_hospede.Add(newUser);

                    context.SaveChanges();

                    return "Dados cadastrados com êxito";

                }
                else
                {
                    return "E-mail já está em uso";
                }
            }
        }

        #endregion
    }

}