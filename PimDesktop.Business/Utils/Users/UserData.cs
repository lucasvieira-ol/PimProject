using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Users
{
	public class UserData
	{
		public string user { get; set; }
		public int userId { get; set; }
		public string password { get; set; }
		public int id_profile { get; set; }
		public string emailUser { get; set; }
        public bool enabled { get; set; }
        public string nameProfile { get; set; }
        public int? qtyReservationCreated { get; set; }
        public int? qtyReservationCheckIn { get; set; }
        public int? qtyReservationCheckOut { get; set; }

    }

}