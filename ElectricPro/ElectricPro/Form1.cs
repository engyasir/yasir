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
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace ElectricPro
{
   
    public partial class Form1 : Form
    {
        
        // هنا جملة الاتصال والمتطلبات لكي نربط بين السيكوال سيرفر والسي شارب
        // وايضا تعاريف مهمة من البيانات والجدول 
        SqlConnection conn = new SqlConnection("Server=DESKTOP-U9D8BHS\\YASIR;Database=INFOEMP;Integrated Security=True");
        SqlDataAdapter adapter;
       System.Data. DataTable Dt = new System.Data.DataTable("Table_1");
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdb;
        CurrencyManager cm;
        public Form1()
        {
            InitializeComponent();

            adapter = new SqlDataAdapter("select * from Table_1", conn);
            adapter.Fill(Dt);
            dgv.DataSource = Dt;

            // هنا كي نحمل المعلومات ونربطها بين التصميم التكستبوكس والجدول مع الداتاكردفيو
            txtIDName.DataBindings.Add("text", Dt, "Employee_ID");
            txtEmpName.DataBindings.Add("text", Dt, "Full_Name");
            txtJopName.DataBindings.Add("text", Dt, "Job");
            txtJobDegree.DataBindings.Add("text", Dt, "Job_Degree");
            txtStage.DataBindings.Add("text", Dt, "Job_Stage");
            txtGraduate.DataBindings.Add("text", Dt, "Graduate");
            txtPlaceGradu.DataBindings.Add("text", Dt, "Place_of_Graduate");
            txtSex.DataBindings.Add("text", Dt, "Sex");
            dateTimeFirstJob.DataBindings.Add("text", Dt, "First_job_Date");
            txtDepartment.DataBindings.Add("text", Dt, "Department");
            txtClass.DataBindings.Add("text", Dt, "Class");
            txtTotalYear.DataBindings.Add("text", Dt, "Working_Years");
            txtSalary.DataBindings.Add("text", Dt, "salary");
            txtWorkPlace.DataBindings.Add("text", Dt, "Place_Of_working");
            txtLevel.DataBindings.Add("text", Dt, "leveles");

            // هذا الايعاز في الاسفل مهم يسهل علينا كتابة العمليات الاربعة من اضافة وحذف ... الخ
            cm = (CurrencyManager)this.BindingContext[Dt];


        }

        struct DataParameter
        {
            public List<Table_1> Table_1list;
            public string fileName { set; get; }

        }
        DataParameter _inputParameter;

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'iNFOEMPDataSet.Table_1' table. You can move, or remove it, as needed.
            // this.table_1TableAdapter.Fill(this.iNFOEMPDataSet.Table_1);
            //bindGridview();
            using (INFOEMPDataSet ds = new INFOEMPDataSet())
            {
                table1BindingSource.DataSource = ds.Table_1.ToList();
            }

            // Begin Load theme
            if (Properties.Settings.Default.pathOfTheme!="")
            {
                skinEngine1.SkinFile = Properties.Settings.Default.pathOfTheme;
            }
           
            

            // Ebd




        }
      public static  int currentPosition;
        private void button1_Click(object sender, EventArgs e)
        {

            currentPosition = cm.Position;
            var frm = new Frm2();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // زر الاضافة
            cm.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(adapter);
            adapter.Update(Dt);
            cm.Refresh();
            MessageBox.Show("Add Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // زر تفريغ الخانات وعمل حقل جديد فارغ
            cm.AddNew();
            txtIDName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // زر التعديل 

                cm.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(Dt);
                cm.Refresh();
                MessageBox.Show("Update Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // زرالحذف 
            // هنا رسالة قبل الحذف حيث يستفسر هل نريد فعلا الحذف او التراجع عن الحذف ؟
            try
            {
                DialogResult del = MessageBox.Show("Are you sure to delete file", "worring", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    cm.RemoveAt(cm.Position);
                    cm.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(adapter);

                    adapter.Update(Dt);
                    MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Do Not Delete!", "Worring", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"يجب حذف بيانات الموظف الشخصية اولا ");
                

            }
        }

        private void dateTimeFirstJob_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimeFirstJob.Value;
            DateTime to = DateTime.Now;
            TimeSpan tspan = to - from;
            double days = tspan.TotalDays;
            txtTotalYear.Text = (days / 360).ToString("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(Dt);
            string Expr = " like'%" + txtSearch.Text + "%'";


            if (rdName.Checked) Expr = "Full_Name" + Expr;

            else if (rdJobAddress.Checked) Expr = "Job" + Expr;

            dv.RowFilter = Expr;
            dgv.DataSource = dv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_THEME frm = new FRM_THEME();
            frm.ShowDialog();
            if (Properties.Settings.Default.pathOfTheme != "")
            {
                skinEngine1.SkinFile = Properties.Settings.Default.pathOfTheme;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            // زر تفريغ الخانات وعمل حقل جديد فارغ
            cm.AddNew();
            txtIDName.Focus(); 
        }

        private void btnExelSeave_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy)

                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel WorkBook |*.xls" })
            {
                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    _inputParameter.fileName = sfd.FileName;
                    _inputParameter.Table_1list = table1BindingSource.DataSource as List<Table_1>;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_inputParameter);
                }
            }
            
                  

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Table_1> List = ((DataParameter)e.Argument).Table_1list;
            string fileName = ((DataParameter)e.Argument).fileName; 
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = false;

            int index = 1 ;
            int Process = List.Count;

            ws.Cells[1, 1] = "Employee_ID";
            ws.Cells[1, 2] = "Full_Name";
            ws.Cells[1, 3] = "Job";
            ws.Cells[1, 4] = "Job_Degree";
            ws.Cells[1, 5] = "Job_Stage";
            ws.Cells[1, 6] = "Graduate";
            ws.Cells[1, 7] = "Place_of_Graduate";
            ws.Cells[1, 8] = "Sex";
            ws.Cells[1, 9] = "First_job_Date ";
            ws.Cells[1, 10] = "Department";
            ws.Cells[1, 11] = "Class";
            ws.Cells[1, 12] = "Working_Years";
            ws.Cells[1, 13] = "salary";
            ws.Cells[1, 14] = "Place_Of_working";
            ws.Cells[1, 15] = "leveles";


            foreach ( Table_1 t in List)
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index ++ * 100 / Process);
                    ws.Cells[index,1] = t.Employee_ID.ToString();
                    ws.Cells[index,2] = t.Full_Name;
                    ws.Cells[index,3] = t.Job;
                    ws.Cells[index,4] = t.Job_Degree.ToString();
                    ws.Cells[index,5] = t.Job_Stage.ToString();
                    ws.Cells[index,6] = t.Graduate;
                    ws.Cells[index,7] = t.Place_of_Graduate;
                    ws.Cells[index,8] = t.Sex;
                    ws.Cells[index,9] = t.First_job_Date.ToString();
                    ws.Cells[index,10] = t.Department;
                    ws.Cells[index,11] = t.Class;
                    ws.Cells[index,12] = t.Working_Years.ToString();
                    ws.Cells[index,13] = t.salary.ToString();
                    ws.Cells[index,14] = t.Place_Of_working;
                    ws.Cells[index,15] = t.leveles;


                }
            }
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing,Type.Missing);
            Excel.Quit();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblstate.Text = string.Format("Processing .... {0}", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error==null)
            {
                Thread.Sleep(100);
                lblstate.Text = "Your Data Exported";
            }
        }
    }
}
