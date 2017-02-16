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


namespace ElectricPro
{
   
    public partial class Form1 : Form
    {
        
        // هنا جملة الاتصال والمتطلبات لكي نربط بين السيكوال سيرفر والسي شارب
        // وايضا تعاريف مهمة من البيانات والجدول 
        SqlConnection conn = new SqlConnection("Server=DESKTOP-U9D8BHS\\YASIR;Database=INFOEMP;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable Dt = new DataTable("Table_1");
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdb;
        CurrencyManager cm;
        public Form1()
        {
            InitializeComponent();
           
            adapter = new SqlDataAdapter("select * from Table_1",conn);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'iNFOEMPDataSet.Table_1' table. You can move, or remove it, as needed.
            // this.table_1TableAdapter.Fill(this.iNFOEMPDataSet.Table_1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            try
            {
                this.skinEngine1.SkinFile = "Skins/DiamondPurple.ssk";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
