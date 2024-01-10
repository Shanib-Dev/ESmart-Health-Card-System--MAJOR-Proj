using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ESmartHealthCard
{
    public partial class receptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetReception();
            }
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");


        protected void btnsave_Click(object sender, EventArgs e)
        {
            int receptionid = int.Parse(txtreceptionid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, address = txtaddress.Text, branch = DropDownList1.SelectedValue, emailid = txtemail.Text, password = txtpassword.Text, role = "Receptionist";
            connection.Open();

            SqlCommand commandtocheck = new SqlCommand("select managerid from PortalUser where role='Receptionist' and managerid='" + receptionid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(commandtocheck);
            DataTable dtt = new DataTable();
            sd.Fill(dtt);

            if (dtt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Doctor Already Exists');", true);
            }
            else
            {

                SqlCommand command = new SqlCommand("Insert into PortalUser values ('" + receptionid + "','" + name + "','" + mobile + "','" + address + "','" + branch + "','" + emailid + "','" + password + "','" + role + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
                GetReception();
            }
        }
        void GetReception()
        {
            SqlCommand command = new SqlCommand("Select * from PortalUser where role='receptionist'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            int receptionid = int.Parse(txtreceptionid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, address = txtaddress.Text, branch = DropDownList1.SelectedValue, emailid = txtemail.Text, password = txtpassword.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Update PortalUser set name = '" + name + "', mobile = '" + mobile + "', address = '" + address + "', branch = '" + branch + "' , emailid = '" + emailid + "', password = '" + password + "' where managerid ='" + receptionid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully edited');", true);
            GetReception();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int receptionid = int.Parse(txtreceptionid.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete PortalUser where managerid ='" + receptionid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
            GetReception();
        }

        protected void btnload_Click(object sender, EventArgs e)
        {
            GetReception();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            int receptionid = int.Parse(txtreceptionid.Text);
            SqlCommand command = new SqlCommand("Select * from PortalUser where role='Receptionist' and managerid='" + receptionid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            foreach (DataRow row in dt.Rows)
            {
                txtname.Text = row["name"].ToString();
                txtmobile.Text = row["mobile"].ToString();
                txtaddress.Text = row["address"].ToString();
                DropDownList1.Text = row["branch"].ToString();
                txtemail.Text = row["emailid"].ToString();
                txtpassword.Text = row["password"].ToString();
            }
        }

        protected void txtlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("managers.aspx");
        }
    }
}