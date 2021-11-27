using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using PimWebApi.Models.Main;
using PimWebApi.Models.Payment;

namespace PimWebApi.Controllers
{
    public class PaymentController : ApiController
    {
        #region payments

        [HttpGet]
        [Route("api/clientPayments")]
        public List<paymentData> getPayments(UserData body)
        {
            List<paymentData> result = new List<paymentData>();
            paymentFunctions function = new paymentFunctions();

            result = function.getPayments(body.clientUserId);

            return result;
        }

        [HttpPut]
        [Route("api/clientPaymentUpdate")]
        public bool updatePayment(paymentData body)
        {
            paymentFunctions function = new paymentFunctions();

            bool result = function.updatePayment(body);

            return result;
        }

        [HttpPost]
        [Route("api/clientPaymentCreate")]
        public string createPayment(paymentData body)
        {
            paymentFunctions function = new paymentFunctions();

            string result = function.createPayment(body);

            return result;
        }

        [HttpDelete]
        [Route("api/clientPaymentDelete")]
        public bool deletePayment(paymentData body)
        {
            paymentFunctions function = new paymentFunctions();

            bool result = function.deletePayment(body);

            return result;
        }


        #endregion

    }
}