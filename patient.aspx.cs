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
    public partial class patient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetPatient();
            }
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(txtpatientid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, email = txtemail.Text, cardtype = DropDownList1.SelectedValue, cardno = txtcardno.Text, cardvalidity = DropDownList2.SelectedValue, address = txtaddress.Text;
            connection.Open();

            SqlCommand commandtocheck = new SqlCommand("select patientid from patient where patientid='" + patientid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(commandtocheck);
            DataTable dtt = new DataTable();
            sd.Fill(dtt);

            if (dtt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Patient Already Exists');", true);
            }
            else
            {
                SqlCommand command = new SqlCommand("Insert into patient values ('" + patientid + "','" + name + "','" + mobile + "','" + email + "','" + cardtype + "','" + cardno + "','" + cardvalidity + "','" + address + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
                GetPatient();
            }
        }
        void GetPatient()
        {
            SqlCommand command = new SqlCommand("Select * from patient", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(txtpatientid.Text);
            string name = txtname.Text, mobile = txtmobile.Text, email = txtemail.Text, cardtype = DropDownList1.SelectedValue, cardno = txtcardno.Text, cardvalidity = DropDownList2.SelectedValue, address = txtaddress.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Update patient set name = '" + name + "', mobile = '" + mobile + "', email= '" + email + "', cardtype = '" + cardtype + "', cardno = '" + cardno + "', cardvalidity = '" + cardvalidity + "', address = '" + address + "' where patientid ='" + patientid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully edited');", true);
            GetPatient();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(txtpatientid.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete patient where patientid ='" + patientid + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
            GetPatient();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(txtpatientid.Text);
            SqlCommand command = new SqlCommand("Select * from patient where patientid='" + patientid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            foreach (DataRow row in dt.Rows)
            {
                txtname.Text = row["name"].ToString();
                txtmobile.Text = row["mobile"].ToString();
                txtemail.Text = row["email"].ToString();
                DropDownList1.Text = row["cardtype"].ToString();
                txtcardno.Text = row["cardno"].ToString();
                DropDownList2.Text = row["cardvalidity"].ToString();
                txtaddress.Text = row["address"].ToString();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GetPatient();
        }

        protected void txthome_Click(object sender, EventArgs e)
        {
            Response.Redirect("chairman.aspx");
        }


        protected void btncard(object sender, EventArgs e)
        {
            Server.Transfer("patientregistration.aspx");
        }


    }
}