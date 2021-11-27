using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebsite.Models.Reservation
{

    public class reservationData
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
        public int qtyCoupleBeds { get; set; }
        public int qtySingleBeds { get; set; }
        public string typePayment { get; set; }
        public int paymentTimes { get; set; }

    }
    public class reservationRpt
    {
        public int idReservation { get; set; }
        public string registerDate { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string dateCheckIn { get; set; }
        public string dateCheckOut { get; set; }
        public string dateCancelation { get; set; }
        public string roomName { get; set; }
        public int clientsCompQty { get; set; }
    }
    public class roomData
    {
        public int idRoom { get; set; }
        public decimal payValue { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
    }

}
