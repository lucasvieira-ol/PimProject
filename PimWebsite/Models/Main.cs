using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebsite.Models.Main
{
    public class LoginData
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class UserData
    {
        public int clientId { get; set; }
        public int clientUserId { get; set; }
        public DateTime? dateStart { get; set; }
        public DateTime? dateEnd { get; set; }
    }

}