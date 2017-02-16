using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricPro
{
    public partial class Frm2 : Form
    {
        // هنا جملة الاتصال والمتطلبات لكي نربط بين السيكوال سيرفر والسي شارب
        // وايضا تعاريف مهمة من البيانات والجدول 
        SqlConnection conn = new SqlConnection("Server=DESKTOP-U9D8BHS\\YASIR;Database=INFOEMP;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable Dt = new DataTable("Table_2");
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdb;
        CurrencyManager cm;
        
        public Frm2()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select * from Table_2", conn);
            adapter.Fill(Dt);
            dgv2.DataSource = Dt;
           

            // هنا كي نحمل المعلومات ونربطها بين التصميم التكستبوكس والجدول مع الداتاكردفيو
            txtInfoID.DataBindings.Add("text", Dt, "Information_ID");
            txtName.DataBindings.Add("text", Dt, "Full_Name");
            dateTimebirth.DataBindings.Add("text", Dt, "Birth_Date");
            txtbirthPlace.DataBindings.Add("text", Dt, "Birth_Place");
            txtCardName.DataBindings.Add("text", Dt, "Name_of_presonal_card_Office");
            txtFile.DataBindings.Add("text", Dt, "Number_Of_File_Card");
            txtPage.DataBindings.Add("text", Dt, "Number_Of_Page_Card");
            txtCardNumber.DataBindings.Add("text", Dt, "Card_Number");
            dateTimeCardIssuse.DataBindings.Add("text", Dt, "Card_Issuse_Date");
            txtSertfNumber.DataBindings.Add("text", Dt, "Sertificate_Number");
            dateTimesertfNumber.DataBindings.Add("text", Dt, "Sertificate_Issuse_Date");
            txtMarridState.DataBindings.Add("text", Dt, "Marride_State");
            txtWifeName.DataBindings.Add("text", Dt, "Wife_Name");
            txtBoyNum.DataBindings.Add("text", Dt, "boys_Number");
            txtGirlNum.DataBindings.Add("text", Dt, "Daughter_Number");
            txtKidsTotal.DataBindings.Add("text", Dt, "Total_Children");
            txtFoodCardNum.DataBindings.Add("text", Dt, "Food_Card_Number");
            dateTimeFoodCardIssuse.DataBindings.Add("text", Dt, "Food_Card_Issuse");
            txtGovrName.DataBindings.Add("text", Dt, "Gavernatore");
            txtReligNam.DataBindings.Add("text", Dt, "Relajon");
            txtStreetNam.DataBindings.Add("text", Dt, "Street");
            txtHouseNum.DataBindings.Add("text", Dt, "House");
            txtPhoneNum.DataBindings.Add("text", Dt, "Mobile_Number");
            txtEmail.DataBindings.Add("text", Dt, "E_Mail");

            // هذا الايعاز في الاسفل مهم يسهل علينا كتابة العمليات الاربعة من اضافة وحذف ... الخ
            cm = (CurrencyManager)this.BindingContext[Dt];

           


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                // زر الاضافة
                cm.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(Dt);
                cm.Refresh();
                MessageBox.Show("Add Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // زر تفريغ الخانات وعمل حقل جديد فارغ
            cm.AddNew();
            txtInfoID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //زر التعديل

            cm.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(Dt);
                cm.Refresh();
                MessageBox.Show("Update Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // زرالحذف 
            // هنا رسالة قبل الحذف حيث يستفسر هل نريد فعلا الحذف او التراجع عن الحذف ؟
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKidsTotal_TextChanged(object sender, EventArgs e)
        {

          



        }

        private void txtBoyNum_TextChanged(object sender, EventArgs e)
        {
           
                
            }



        private void txtGirlNum_TextChanged(object sender, EventArgs e)
        {
          //  txtKidsTotal.Text = (Convert.ToInt32(txtBoyNum.Text) + Convert.ToInt32(txtGirlNum.Text)).ToString();
        }

        private void txtKidsTotal_KeyUp(object sender, KeyEventArgs e)
        {
            txtKidsTotal.Text = (Convert.ToInt32(txtBoyNum.Text) + Convert.ToInt32(txtGirlNum.Text)).ToString();
        }
    }
}
