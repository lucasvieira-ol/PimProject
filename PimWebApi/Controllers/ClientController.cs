using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using PimWebApi.Models.Main;
using PimWebApi.Models.Client;

namespace PimWebApi.Controllers
{
    public class ClientController : ApiController
    {
        #region client

        [HttpPost]
        [Route("api/clientInfo")]
        public clientData getClient(UserData body)
        {
            clientData result = new clientData();
            clientFunctions function = new clientFunctions();

            result = function.getClientData(body.clientId);

            return result;
        }
        [HttpPost]
        [Route("api/clientInfoByDocument")]
        public clientData getClientByDocument(clientData body)
        {
            clientData result = new clientData();
            clientFunctions function = new clientFunctions();

            result = function.getClientDataByDocument(body.clientDocument, body.typeDocument);

            return result;
        }

        [HttpPut]
        [Route("api/clientUpdate")]
        public string updateClient(clientData body)
        {
            string result = "";
            clientFunctions function = new clientFunctions();

            result = function.putClient(body);

            return result;
        }

        [HttpPost]
        [Route("api/clientCreate")]

        public string createClient(clientData body)
        {
            clientFunctions function = new clientFunctions();

            string result = function.setClient(body);

            return result;
        }

        [HttpPost]
        [Route("api/clientUserCreate")]

        public string createClientUser(clientData body)
        {
            clientFunctions function = new clientFunctions();

            string result = function.setClientUser(body.emailUser, body.updatePassword, body.clientId);

            return result;
        }

        #endregion

    }
}