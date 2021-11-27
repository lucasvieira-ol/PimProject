using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using UserFunctions = PimDesktop.Business.Utils.Users.UserFunctions;

namespace PimDesktop.Business.Utils.Reports
{
    public class UserSystemRptData
    {
        public List<UserData> getUserSystemRptData(DateTime firstDate, DateTime lastDate)
        {
            UserFunctions userFunctions = new UserFunctions();

            List<UserData> lstUsersResult = userFunctions.getUserRpt(firstDate, lastDate);

            return lstUsersResult;
        }

    }
}
