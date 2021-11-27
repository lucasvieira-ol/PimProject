using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Clients
{
    public class ClientFunctions
    {
        public ClientData getClient(string document)
        {
            ClientData client = new ClientData();

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                client = (from h in context.hospede
                          where h.numero_identidade == document
                          select new ClientData()
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
                              secondPhone = h.segundo_telefone
                          }).FirstOrDefault();
            }
            return client;
        }
        public List<ClientData> getClients()
        {
            List<ClientData> client = new List<ClientData>();

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                client = (from h in context.hospede
                          select new ClientData()
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
                              secondPhone = h.segundo_telefone
                          }).ToList();
            }
            return client;
        }
        public List<ClientData> getClientsRpt(DateTime firstDate, DateTime lastDate)
        {
            List<ClientData> client = new List<ClientData>();

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                client = (from h in context.hospede
                          from uh in context.usuario_hospede.Where(i => i.id_hospede == h.id_hospede).DefaultIfEmpty()
                          where h.data_cadastro >=  firstDate.Date && h.data_cadastro <= lastDate.Date
                          select new ClientData()
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
                              emailUser = uh.email?? "",
                              dt_userCreatedAt = uh.data_cadastro,
                              dt_firstAccess = uh.primeiro_acesso,
                              dt_lastAccess = uh.ultimo_acesso
                          }).ToList();
            }
            return client;
        }

        public string putClient(ClientData currentClient)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var updateClient = context.hospede.Where(i => i.numero_identidade == currentClient.clientDocument).FirstOrDefault();

                if (context.hospede.AsEnumerable().Where(i => i.numero_identidade == currentClient.clientDocument && i.id_hospede != currentClient.clientId).Count() == 0)
                {
                    if (!string.IsNullOrEmpty(currentClient.clientCPF))
                    {
                        if (context.hospede.AsEnumerable().Where(i => i.CPF == currentClient.clientCPF && i.id_hospede != currentClient.clientId).Count() == 0)
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

                            context.SaveChanges();

                            return "OK";
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

                        context.SaveChanges();

                        return "OK";
                    }
                }
                else
                {
                    return "Já existe um hospede cadastrado com esse número de documento";
                }
            }
        }

        public string setClient(ClientData currentClient)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {

                if (context.hospede.Where(i => i.numero_identidade == currentClient.clientDocument).Count() == 0)
                {
                    if (!string.IsNullOrEmpty(currentClient.clientCPF))
                    {
                        if (context.hospede.Where(i => i.CPF == currentClient.clientCPF).Count() == 0)
                        {
                            PimDesktop.Data.Server.hospede createClient = new Data.Server.hospede()
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

                            return "OK";
                        }
                        else
                        {
                            return "Já existe um hospede cadastrado com esse mesmo CPF";
                        }
                    }
                    else
                    {
                        PimDesktop.Data.Server.hospede createClient = new Data.Server.hospede()
                        {
                            nome = currentClient.clientName,
                            CPF = !string.IsNullOrEmpty(currentClient.clientCPF) ? currentClient.clientCPF : null,
                            tipo_documento = currentClient.typeDocument,
                            numero_identidade = currentClient.clientDocument,
                            orgao_expedidor = currentClient.expeditor,
                            funcao = !string.IsNullOrEmpty(currentClient.function) ? currentClient.function : null,
                            data_nascimento = currentClient.dt_birth,
                            data_cadastro = currentClient.dt_createdAt,
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

                        return "OK";
                    }
                }
                else
                {
                    return "Já existe um hospede cadastrado com esse mesmo número de documento";
                }
            }
        }
    }
}
