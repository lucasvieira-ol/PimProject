using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientData = PimDesktop.Business.Utils.Clients.ClientData;
using ClientFunctions = PimDesktop.Business.Utils.Clients.ClientFunctions;

namespace PimDesktop.Business.Utils.Reports
{
   public class ClientRptData
    {
        public List<ClientData> getClientRptData(DateTime firstDate, DateTime lastDate)
        {
            ClientFunctions clientFunctions = new ClientFunctions();

            List<ClientData> lstClientsResult = clientFunctions.getClientsRpt(firstDate, lastDate);

            return lstClientsResult;
        }
    }
}
