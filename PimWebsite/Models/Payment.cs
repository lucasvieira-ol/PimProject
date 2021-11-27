using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebsite.Models.Payment
{

    public class paymentLog
    {
        public int reservationId { get; set; }
        public string description { get; set; }
        public decimal value { get; set; }
        public string typePayment { get; set; }
        public int payTimes { get; set; }
        public bool refund { get; set; }
        public bool registerPaid { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime? paymentDate { get; set; }

    }

    public class paymentData
    {

        public int idCard { get; set; }
        public int idUserclient { get; set; }
        public string nameCard { get; set; }
        public string numberCard { get; set; }
        public DateTime validationDate { get; set; }
        public string validationConverted { get; set; }

    }


}