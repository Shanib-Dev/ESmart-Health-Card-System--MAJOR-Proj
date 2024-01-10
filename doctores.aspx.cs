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
    public partial class doctores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDoctor();
            }
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");


        protected void btnsave_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(txtdoctorid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, address = txtaddress.Text, branch = DropDownList1.SelectedValue, emailid = txtemail.Text, password = txtpassword.Text, role = "Doctor";
            connection.Open();

            SqlCommand commandtocheck = new SqlCommand("select managerid from PortalUser where role='Doctor' and managerid='" + doctorid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(commandtocheck);
            DataTable dtt = new DataTable();
            sd.Fill(dtt);

            if (dtt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Doctor Already Exists');", true);
            }
            else
            {

                SqlCommand command = new SqlCommand("Insert into PortalUser values ('" + doctorid + "','" + name + "','" + mobile + "','" + address + "','" + branch + "','" + emailid + "','" + password + "','" + role + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
                GetDoctor();
            }

        }
        void GetDoctor()
        {
            SqlCommand command = new SqlCommand("Select * from PortalUser where role='Doctor'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(txtdoctorid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, address = txtaddress.Text, branch = DropDownList1.SelectedValue, emailid = txtemail.Text, password = txtpassword.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Update PortalUser set name = '" + name + "', mobile = '" + mobile + "', address = '" + address + "', branch = '" + branch + "' , emailid = '" + emailid + "', password = '" + password + "' where managerid ='" + doctorid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully edited');", true);
            GetDoctor();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(txtdoctorid.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete PortalUser where managerid ='" + doctorid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
            GetDoctor();
        }

        protected void btnload_Click(object sender, EventArgs e)
        {
            GetDoctor();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(txtdoctorid.Text);
            SqlCommand command = new SqlCommand("Select * from PortalUser where role='Doctor' and managerid='" + doctorid + "'", connection);
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

        protected void txthome_Click(object sender, EventArgs e)
        {
            Response.Redirect("managers.aspx");
        }
    }
}