using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Clients
{
    public class ClientData
    {
        public int? clientId { get; set; }
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

    }
}
