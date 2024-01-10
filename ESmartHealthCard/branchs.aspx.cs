using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ESmartHealthCard
{
    public partial class branchs : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");
            con.Open();

            if (!Page.IsPostBack)
            {
                txtbranchid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                DataShow();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from branch ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand commandtocheck = new SqlCommand("select branchid from branch where branchid='" + txtbranchid.Text + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(commandtocheck);
            DataTable dtt = new DataTable();
            sd.Fill(dtt);

            if (dtt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Branch Already Exists');", true);
            }
            else
            {

                dt = new DataTable();
                cmd.CommandText = "Insert into branch (branchid,name,address)values('" + txtbranchid.Text.ToString() + "','" + txtname.Text.ToString() + "','" + txtaddress.Text.ToString() + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                txtbranchid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                DataShow();
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update branch set name='" + txtname.Text.ToString() + "',address='" + txtaddress.Text.ToString() + "' where branchid='" + txtbranchid.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            txtbranchid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            DataShow();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from branch where branchid='" + txtbranchid.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            txtbranchid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            DataShow();
        }

        protected void txtsearch_Click(object sender, EventArgs e)
        {
            int branchid = int.Parse(txtbranchid.Text);
            SqlCommand command = new SqlCommand("Select * from branch where branchid='" + branchid + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            foreach (DataRow row in dt.Rows)
            {
                txtname.Text = row["name"].ToString();
                txtaddress.Text = row["address"].ToString();
            }
        }

        protected void txthome_Click(object sender, EventArgs e)
        {
            Response.Redirect("managers.aspx");
        }

    }
}