using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESmartHealthCard
{
    public partial class managers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                Server.Transfer("patients.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            {
                Server.Transfer("branchs.aspx");
            }
        }

        protected void btndoc_Click(object sender, EventArgs e)
        {
            Server.Transfer("doctores.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("GenerateBills.aspx");
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }

        protected void Btnreception_Click(object sender, EventArgs e)
        {
            Server.Transfer("receptions.aspx");
        }
    }
}