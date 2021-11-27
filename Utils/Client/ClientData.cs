using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Utils.Client
{
    public class ClientData
    {
        public int clientId { get; set; }
        public string clientName { get; set; }
        public string clientDocument { get; set; }
        public int? clientUserId { get; set; }
        public string clientCPF { get; set; }

        public List<ClientData> getClient(string document)
        {
            List<ClientData> client = new List<ClientData>();

            using (PimDesktop.Server.db_pim_hmlEntities1 context = new PimDesktop.Server.db_pim_hmlEntities1())
            {
                client = (from h in context.hospede
                          from u in context.usuario_hospede.Where(x => x.id_hospede == h.id_hospede).DefaultIfEmpty()
                          where h.numero_identidade == document
                          select new ClientData()
                          {
                              clientId = h.id_hospede,
                              clientName = h.nome,
                              clientDocument = h.numero_identidade,
                              clientUserId = u.id_usuarioHospede,
                              clientCPF = h.CPF
                          }).ToList();
            }
            return client;
        }

    }
}
