using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESmartHealthCard
{
    public partial class patientuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Server.Transfer("patientregistration.aspx");
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            Server.Transfer("patientregistration.aspx");
        }
    }
}