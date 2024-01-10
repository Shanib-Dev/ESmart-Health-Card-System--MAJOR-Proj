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
    public partial class manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetManager();
            }
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");

        protected void btnsave_Click(object sender, EventArgs e)
        {
            int managerid = int.Parse(txtmanagerid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, address = txtaddress.Text, branch = DropDownList1.SelectedValue, emailid = txtemail.Text, password = txtpassword.Text, role="Manager";
            connection.Open();

            SqlCommand commandtocheck = new SqlCommand("select managerid from PortalUser where managerid='" + managerid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(commandtocheck);
            DataTable dtt = new DataTable();
            sd.Fill(dtt);

            if (dtt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Manager Already Exists');", true);
            }
            else
            {

                SqlCommand command = new SqlCommand("Insert into PortalUser values ('" + managerid + "','" + name + "','" + mobile + "','" + address + "','" + branch + "','" + emailid + "','" + password + "','" + role + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
                GetManager();
            }
        }
        void GetManager() 
    {
        SqlCommand command = new SqlCommand("Select * from PortalUser where role='Manager'", connection);
        SqlDataAdapter sd = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        sd.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
 

    }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            int managerid = int.Parse(txtmanagerid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, address = txtaddress.Text, branch = DropDownList1.SelectedValue, emailid = txtemail.Text, password = txtpassword.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Update PortalUser set name = '" + name + "', mobile = '" + mobile + "', address = '" + address + "', branch = '" + branch + "' , emailid = '" + emailid + "', password = '" + password + "' where managerid ='" + managerid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully edited');", true);
            GetManager();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int managerid = int.Parse(txtmanagerid.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete PortalUser where managerid ='" + managerid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
            GetManager();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            int managerid = int.Parse(txtmanagerid.Text);
            SqlCommand command = new SqlCommand("Select * from PortalUser where role='Manager' and managerid='" + managerid + "'", connection);
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

        protected void btnload_Click(object sender, EventArgs e)
        {
            GetManager();
        }

        protected void txthome_Click(object sender, EventArgs e)
        {
            Response.Redirect("chairman.aspx");
        }
    }
}