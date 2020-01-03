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

namespace BoruSankasi
{
    public partial class frmOgrenciMain : MetroFramework.Forms.MetroForm
    {
        public frmOgrenciMain(int id)
        {

            InitializeComponent();
            this.g_UserID = id;
        }
        int g_UserID;

        public int checkCount = -1;
        private void frmOgrenciMain_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;

            con = new SqlConnection(SQLConnect.ConnectionString);

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "EXECUTE CheckUsertoQuiz "+g_UserID.ToString();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    checkCount = Convert.ToInt16(dr[0]);

                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();


            }

            if (checkCount > -1)
            {
                btnTesteGir.Enabled = false;

                MessageBox.Show("Sınav olmuşsunuz yarın tekrar sınav olabilirsiniz..");
            }
            else
            {
                btnTesteGir.Enabled = true;
            }
        }

        private void btnIstatistikGor_Click(object sender, EventArgs e)
        {

        }

        private void btnTesteGir_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Sınava başlamak istiyor musunuz? Her gün bir tane sınav olabilirsiniz..", "Boru Sankası", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                frmOgrenciTest frmNew = new frmOgrenciTest(g_UserID);
                frmNew.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
          
        }
    }
}
