using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsDataSet.TelPhTable' table. You can move, or remove it, as needed.
            this.telPhTableTableAdapter.Fill(this.dbsDataSet.TelPhTable);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtPhonNum.Enabled = value;
            txtFullName.Enabled = value;
            txtEmail.Enabled = value;
            txtAddress.Enabled = value;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                dbsDataSet.TelPhTable.AddTelPhTableRow(dbsDataSet.TelPhTable.NewTelPhTableRow());
                telPhTableBindingSource.MoveLast();
                txtPhonNum.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbsDataSet.TelPhTable.RejectChanges();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtPhonNum.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            telPhTableBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Edit(false);
                telPhTableBindingSource.EndEdit();
                telPhTableTableAdapter.Update(dbsDataSet.TelPhTable);
                dataGridView1.Refresh();
                txtPhonNum.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                MessageBox.Show("Your Data has been successfully saved ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbsDataSet.TelPhTable.RejectChanges();

            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (MessageBox.Show("Are You sure want to Delete this Record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    telPhTableBindingSource.RemoveCurrent();
                }
            }

        }
    }
}
