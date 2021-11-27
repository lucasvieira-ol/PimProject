using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using PimWebApi.Models.Main;
using PimWebApi.Models.Reservation;

namespace PimWebApi.Controllers
{
    public class ReservationController : ApiController
    {
        #region reservations

        [HttpPost]
        [Route("api/reservationsRpt")]

        public List<reservationRpt> getClientReservations(UserData body)
        {
            List<reservationRpt> result = new List<reservationRpt>();
            reservationFunctions function = new reservationFunctions();

            result = function.GetReservationRpts(body);

            return result;
        }

        [HttpPost]
        [Route("api/reservationCreate")]
        public string createReservation(reservationData body)
        {
            reservationFunctions function = new reservationFunctions();

            string result = function.setReservation(body);

            return result;
        }

        [HttpPut]
        [Route("api/reservationUpdate")]
        public string updateReservation(reservationData body)
        {
            reservationFunctions function = new reservationFunctions();

            string result = function.updateReservation(body);

            return result;
        }

        [HttpPost]
        [Route("api/getAvailableRoom")]

        public roomData getAvailabelRoom(reservationData body)
        {
            reservationFunctions function = new reservationFunctions();

            roomData result = function.getAvailableRoom(body.qtyCoupleBeds, body.qtySingleBeds, body.startDate, body.endDate);

            return result;
        }

        #endregion

    }
}