using PimWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PimWebApi.Models.Main;
using PimWebApi.Models.Client;

namespace PimWebApi.Controllers
{
    public class MainController : ApiController
    {

        #region login

        [HttpPost]
        [Route("api/login")]

        public clientData loginHandler(LoginData body)
        {
            clientData result = new clientData();
            mainFunctions function = new mainFunctions();

            result = function.verifyUser(body);

            return result;
        }

        #endregion

    }
}
