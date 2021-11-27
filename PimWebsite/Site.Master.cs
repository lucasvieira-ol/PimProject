using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PimWebsite
{
    public partial class SiteMaster : MasterPage
    {
        static bool userLogged = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            profileOption.Visible = userLogged;
            loginOption.Visible = !userLogged;
        }
        public void LoggedOptionVisible()
        {
            userLogged = true;
            profileOption.Visible = true;
            loginOption.Visible = false;
        }

        public void btnHandleLogout_Click(object sender, EventArgs e)
        {
            userLogged = !userLogged;

            Default pageDefault = new Default();

            pageDefault.LogoutHandler();

            Response.Redirect("/Default.aspx");
        }
    }
}