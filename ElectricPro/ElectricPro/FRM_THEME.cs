using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricPro
{
    public partial class FRM_THEME : Form
    {
        public FRM_THEME()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pathOfTheme ="Skins/" + cmbTheme.Text + ".ssk";
            Properties.Settings.Default.Save();
            skinEngine1.SkinFile = Properties.Settings.Default.pathOfTheme;


        }

        private void FRM_THEME_Load(object sender, EventArgs e)
        {
            cmbTheme.SelectedIndex = 0;
        }
    }
}
