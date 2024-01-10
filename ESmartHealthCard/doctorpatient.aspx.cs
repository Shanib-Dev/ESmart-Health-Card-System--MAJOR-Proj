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
    public partial class doctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
               

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");
           
        protected void Button4_Click(object sender, EventArgs e)
        {
           // SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True");
            int patientid = int.Parse(txtpatientid.Text);
            SqlCommand command = new SqlCommand("Select * from patient where patientid='" + patientid + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            SqlCommand command2 = new SqlCommand("SELECT PH.Doctorid,PU.name,PH.PatientId,PH.TreatmentRemark,PH.TreatmentDate FROM PatientHistory PH LEFT JOIN portaluser PU ON PH.Doctorid=PU.managerid WHERE PH.PatientId='" + patientid + "'", connection);
            SqlDataAdapter sd2 = new SqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);
            GridView2.DataSource = dt2;
            GridView2.DataBind();
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string treatmentremarks = TextTrtRmk.Text;
            string id = Request.QueryString["id"];
            int patientid = int.Parse(txtpatientid.Text);
            var treatmentdate = DateTime.Now;
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into patienthistory (Doctorid,PatientId,TreatmentRemark,TreatmentDate) values ('" + id + "','" + patientid + "','" + treatmentremarks + "','" + treatmentdate + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);


            //int patientid = int.Parse(txtpatientid.Text);
            SqlCommand command2 = new SqlCommand("SELECT PH.Doctorid,PU.name,PH.PatientId,PH.TreatmentRemark,PH.TreatmentDate FROM PatientHistory PH LEFT JOIN portaluser PU ON PH.Doctorid=PU.managerid WHERE PH.PatientId='" + patientid + "'", connection);
            SqlDataAdapter sd2 = new SqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);
            GridView2.DataSource = dt2;
            GridView2.DataBind();

        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }

       
    }
}