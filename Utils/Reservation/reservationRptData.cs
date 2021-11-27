using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Utils.Reservation
{
   public class reservationRptData
    {
        public int idReservation { get; set; }
        public string clientName { get; set; }
        public string clientDocument { get; set; }
        public string roomName { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string dateCheckIn { get; set; }
        public string dateCheckOut { get; set; }
        public string dateCancelation { get; set; }
    }
}
