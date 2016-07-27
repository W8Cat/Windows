using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Diagnostics;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://it.bcr.md/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        public WS()
        {
            InitializeComponent();
        }

        private IContainer components = null;

        private void InitializeComponent()
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        [WebMethod]
        public DataSet GetInvoicesDetails(int OrganizationID)
        {
            SqlConnection myConn = new SqlConnection("Data Source=tcp:HQ-SQL-TEST\\INSTANCE02,2433;Initial Catalog=RETAIL;Provider=SQLNCLI11.1;Integrated Security=SSPI;Auto Translate=False;");
            SqlDataAdapter myData = new SqlDataAdapter("PartnersInvoicesDetails", myConn);
            myData.SelectCommand.CommandType = CommandType.StoredProcedure;
            myData.SelectCommand.Parameters.Add(new SqlParameter("@OrganizationID", SqlDbType.Int, 5));
            myData.SelectCommand.Parameters["@OrganizationID"].Value = OrganizationID;

            DataSet ds = new DataSet();
            myData.Fill(ds);
            ds.Tables[0].TableName = "Organizations";
            ds.Tables[1].TableName = "Statistics";
            ds.Tables[2].TableName = "Unpayd";
            ds.Tables[3].TableName = "Payd";
            ds.Relations.Add(ds.Tables[0].Columns["OrganizationID"], ds.Tables[1].Columns["OrganizationID"]);
            return ds;
        }
    }
}
