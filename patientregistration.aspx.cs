using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace ESmartHealthCard
{
    public partial class patientregistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=DESKTOP-75U41KT;Initial Catalog=ESmartHealthCard;Integrated Security=True";
            String myquery = "Select * from patient where patientid=" + TextBox1.Text;
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Panel1.Visible = true;
                Label9.Text = "Data Found";
                Label4.Text = TextBox1.Text;
                Label5.Text = ds.Tables[0].Rows[0]["name"].ToString();
                Label6.Text = ds.Tables[0].Rows[0]["cardtype"].ToString();
                Label7.Text = ds.Tables[0].Rows[0]["cardvalidity"].ToString();
                Label8.Text = ds.Tables[0].Rows[0]["address"].ToString();
                //Image1.ImageUrl = "http://localhost:1341/" + ds.Tables[0].Rows[0]["applicantimage"].ToString();
            }
            else
            {
                Label9.Text = "Patient ID Not Found";

            }
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=GridViewData.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Panel1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A6, 0, 0, 0, 0);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        protected void txthome_Click(object sender, EventArgs e)
        {
            Server.Transfer("home.aspx");
        }

    }
}