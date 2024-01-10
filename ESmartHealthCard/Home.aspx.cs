using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ESmartHealthCard
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from PortalUser where emailid = '" + txtUser.Text + "' and password = '" + txtPass.Text + "' and role= '" + DropDownList1.SelectedItem.ToString() + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               // Response.Write("<h1 align=right> Welcome " + dt.Rows[0][7] + "</h1>");
                if (DropDownList1.SelectedIndex == 0)
                {
                    Response.Write("<h1 align=right> Welcome " + dt.Rows[0][7] + "</h1>");
                    Server.Transfer("chairman.aspx");
                }
                else if (DropDownList1.SelectedIndex == 1)
                {
                    Response.Write("<h1 align=right> Welcome " + dt.Rows[0][1] + "</h1>");
                    Server.Transfer("managers.aspx");
                }
                else if (DropDownList1.SelectedIndex == 2)
                {
                    Response.Write("<h1 align=right> Welcome " + dt.Rows[0][1] + "</h1>");
                    //int id = dt.Rows[0][0];
                    Response.Redirect("doctorpatient.aspx?id=" + dt.Rows[0][0]);
                    //Server.Transfer("doctorpatient.aspx");
                }
                else if (DropDownList1.SelectedIndex == 3)
                {
                    Response.Write("<h1 align=right> Welcome " + dt.Rows[0][1] + "</h1>");
                    Server.Transfer("Generate.aspx");
                }
            }
            else
            {
                Response.Write("<h1>Login Failed !!!</h1>");
            }


        }
    }
}