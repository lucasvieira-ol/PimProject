using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PimWebsite.Utils.Alert
{
    public class Alert
    {
        public static void MessageBox(System.Web.UI.Page page, string strMsg, string modal)
        {
            //+ character added after strMsg "')"

            if (!string.IsNullOrEmpty(modal))
                ScriptManager.RegisterStartupScript(page, page.GetType(), "ModalView", "<script>$('.Alert').modal('show'); $('#txt_alert').html('" + strMsg + "'); $('" + modal + "').modal('show'); </script>", false);
            else
                ScriptManager.RegisterStartupScript(page, page.GetType(), "ModalView", "<script>$('.Alert').modal('show'); $('#txt_alert').html('" + strMsg + "'); </script>", false);

        }
    }
}