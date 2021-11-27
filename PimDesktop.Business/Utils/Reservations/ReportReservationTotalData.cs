using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Reservations
{
    public class ReportReservationTotalData
    {
        public int idReservation { get; set; }
        public string clientName { get; set; }
        public string clientTypeDocument { get; set; }
        public string clientDocument { get; set; }
        public string roomName { get; set; }
        public decimal roomFullPrice { get; set; }
        public decimal roomHalfPrice { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string dateCheckIn { get; set; }
        public string userCheckIn { get; set; }
        public string dateCheckOut { get; set; }
        public string userCheckOut { get; set; }
        public string dateCancelation { get; set; }
        public string totalpaid { get; set; }
        public string dateCreated { get; set; }
        public string userCreated { get; set; }


    }
}
