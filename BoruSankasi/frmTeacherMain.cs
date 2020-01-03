using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoruSankasi
{
    public partial class frmTeacherMain : MetroFramework.Forms.MetroForm
    {
        public frmTeacherMain()
        {
            InitializeComponent();
        }

        private void frmTeacherMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSoruEkleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSoruEkleme frmNew = new frmSoruEkleme();
            frmNew.ShowDialog();
            this.Close();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminResultsMain frmNew = new frmAdminResultsMain();
            frmNew.ShowDialog();
            this.Close();
        }
    }
}
