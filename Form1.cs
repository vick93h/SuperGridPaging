using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using TemplateContainer;
namespace SuperGridPaging
{
    public partial class Form1 : Form
    {
        List<Rootobjects> list_RootObjects = new List<Rootobjects>();
        DataTable dt=new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            superGrid1.PageSize = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListtoDataTableConverter _converter = new ListtoDataTableConverter();

            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["TemplateContainer.Properties.Settings.OP1090_BoschMandriniAvvitatureConnectionString"].ConnectionString;
            var queryTimeoutInSeconds = 500;
            
            string query = "SELECT * FROM dbo.Rootobjects ORDER BY ID";
            
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                try
                {
                   
                    
                    list_RootObjects = conn.Query<Rootobjects>(query, commandTimeout: queryTimeoutInSeconds, buffered: false).ToList();
                   dt= _converter.ToDataTable(list_RootObjects);
                    superGrid1.SetPagedDataSource(dt, bindingNavigator1);
                    
                }
                catch (SqlException error)
                {
                    Console.WriteLine("Errore: " + error.ToString());
                }
            }
        }
    }
}
