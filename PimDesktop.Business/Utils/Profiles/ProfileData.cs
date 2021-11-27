using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Profiles
{
	public class ProfileData
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool Create_reservation { get; set; }
		public bool Create_Employee { get; set; }
		public bool Create_Client { get; set; }
		public bool Admin { get; set; }
		public bool Reports { get; set; }
		public bool Enabled { get; set; } 
	}

}