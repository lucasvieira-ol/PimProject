using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Reservations
{
    public class ReservationData
    {
        public int reservationId { get; set; }
        public int reservationClientId { get; set; }
        public int reservationRoomId { get; set; }
        public int? reservationUserCreateId { get; set; }
        public int? reservationUserIdCheckIn { get; set; }
        public int? reservationUserIdCheckOut { get; set; }
        public int? reservationIdEmployee { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime? checkInDate { get; set; }
        public DateTime? checkOutDate { get; set; }
        public DateTime? cancelationDate { get; set; }
        public string lastDestination { get; set; }
        public string nextDestination { get; set; }
        public string reasonTravel { get; set; }
        public string transport { get; set; }
    }

}

