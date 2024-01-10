using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESmartHealthCard
{
    public partial class Director : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                Server.Transfer("patient.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            {
                Server.Transfer("manager.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            {
                Server.Transfer("branch.aspx");
            }
        }
        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }

        protected void btndoc_Click(object sender, EventArgs e)
        {
            Server.Transfer("doctors.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("GenerateBill.aspx");
        }

        protected void Btnreception_Click(object sender, EventArgs e)
        {
            Server.Transfer("reception.aspx");
        }

       
        
    }
}