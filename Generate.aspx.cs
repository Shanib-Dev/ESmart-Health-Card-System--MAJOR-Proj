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
    public partial class Generate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");

        protected void btnDiscount_Click(object sender, EventArgs e)
        {
            if (txtCardType.Text == "Silver")
            {
                txtDiscount.Text = (Convert.ToInt32(txtAmount.Text) * 0.10).ToString();
                txtFinalAmount.Text = (Convert.ToInt32(txtAmount.Text) - (Convert.ToInt32(txtAmount.Text) * 0.10)).ToString();
            }

            if (txtCardType.Text == "Gold")
            {
                txtDiscount.Text = (Convert.ToInt32(txtAmount.Text) * 0.20).ToString();
                txtFinalAmount.Text = (Convert.ToInt32(txtAmount.Text) - (Convert.ToInt32(txtAmount.Text) * 0.20)).ToString();
            }

            if (txtCardType.Text == "Platinum")
            {
                txtDiscount.Text = (Convert.ToInt32(txtAmount.Text) * 0.30).ToString();
                txtFinalAmount.Text = (Convert.ToInt32(txtAmount.Text) - (Convert.ToInt32(txtAmount.Text) * 0.30)).ToString();
            }
        }

        protected void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into PatientPayment (PatientId,Amount,Discount,FinalAmount,PaymentMode) values ('" + txtPatientId.Text + "','" + txtAmount.Text + "','" + txtDiscount.Text + "','" + txtFinalAmount.Text + "','" + dripPaymode.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
        }

        protected void txtsearch_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(txtPatientId.Text);
            SqlCommand command = new SqlCommand("Select * from patient where patientid='" + patientid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txtname.Text = row["name"].ToString();
                txtCardType.Text = row["cardtype"].ToString();
            }
        }

        protected void txthome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}