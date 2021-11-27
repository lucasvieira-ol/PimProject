using PimDesktop.Data.Server;
using PimWebApi.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebApi.Models.Main
{
    public class LoginData
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class UserData
    {
        public int clientId { get; set; }
        public int clientUserId { get; set; }
        public DateTime? dateStart { get; set; }
        public DateTime? dateEnd { get; set; }
    }

    public class mainFunctions
    {
        #region User
        public clientData verifyUser(LoginData client)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                clientData data = new clientData();

                clientFunctions functions = new clientFunctions();

                try
                {
                    var result = context.usuario_hospede.Where(i => i.email == client.email && i.senha == client.password).FirstOrDefault();

                    if (result == null)
                        return data;
                    else
                    {

                        if (result.primeiro_acesso == null)
                            result.primeiro_acesso = DateTime.Now;

                        result.ultimo_acesso = DateTime.Now;

                        context.SaveChanges();

                        data = functions.getClientData(result.id_hospede);

                        return data;
                    }

                }
                catch (Exception ex)
                {
                    return data;
                }
            }
        }
        #endregion

    }

}