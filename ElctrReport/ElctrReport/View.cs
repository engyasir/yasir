using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ElctrReport
{
    public partial class View : Form
    {
        int x;
        SqlConnection con = new SqlConnection();

        public View()
        {
            InitializeComponent();
        }

        public View(string x)
        {
            InitializeComponent();
            this.x = int.Parse(x);
        }

        private void View_Load(object sender, EventArgs e)
        {
            
            con.ConnectionString = @"Data Source=DESKTOP-U9D8BHS\YASIR;Initial Catalog=INFOEMP;Integrated Security=True ";
            string sql = "SELECT  Table_1.Employee_ID, Table_1.Full_Name, Table_1.Job, Table_1.Job_Degree, Table_1.First_job_Date, Table_1.Department, Table_2.Birth_Date, Table_2.Birth_Place, Table_1.Working_Years, Table_1.Place_Of_working, Table_2.Card_Number, Table_2.Gavernatore, Table_2.Relajon, Table_2.Street FROM  Table_1 INNER JOIN  Table_2 ON Table_1.Employee_ID = Table_2.Information_ID";
            DataSet1 ds = new DataSet1();
            SqlDataAdapter dad = new SqlDataAdapter(sql, con);
            dad.Fill(ds.Tables["OrderTable"]);
            CryOrder ord = new CryOrder();
            ord.SetDataSource(ds.Tables["OrderTable"]);
            crystalReportViewer1.ReportSource = ord;
            crystalReportViewer1.Refresh();


        }
    }
}
