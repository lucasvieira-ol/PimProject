using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Reservations
{
    public class ReportReservationAvgData
    {
        public string dt_period { get; set; }
        public string roomName { get; set; }
        public int qtyMonth { get; set; }
        public string totalByMonth { get; set; }
    }
}
