using System;
using System.Collections;
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
    public partial class frmOgrenciTestResult : MetroFramework.Forms.MetroForm
    {

        Hashtable g_catResults = new Hashtable();
        Hashtable g_catNames = new Hashtable();
        public frmOgrenciTestResult(Hashtable catResults)
        {
            InitializeComponent();
            this.g_catResults = catResults;
        }

        private void frmOgrenciTestResult_Load(object sender, EventArgs e)
        {

            chartResults.ChartAreas[0].AxisY.Maximum = 100;
            chartResults.ChartAreas[0].AxisY.Minimum = 0;

            GetKategoriNames();
            int index = 0;
           
            ICollection keys = g_catResults.Keys;
            
            decimal[] rates = new decimal[g_catResults.Count];

            foreach (String k in keys)
            {

               

                QuestionCats Kategoriler = (QuestionCats)g_catResults[k];
                decimal dogru = Convert.ToDecimal(Kategoriler.m_DogruSayisi);
                decimal yanlis = Convert.ToDecimal(Kategoriler.m_YanlisSayisi);

                int toplamSoru = Kategoriler.m_DogruSayisi + Kategoriler.m_YanlisSayisi;
                  try
                {
                    rates[index] =Convert.ToDecimal(dogru / yanlis);
                    rates[index] = rates[index] * 100;

                }
                catch (Exception)
                {
                    rates[index] = 0;//0 bölü 0
                }


                 chartResults.Series["Başarı yüzdeniz"].Points.Add(Convert.ToDouble(rates[index++]));
                chartResults.Series["Başarı yüzdeniz"].Points[index-1].AxisLabel = (string)g_catNames[k];

                chartResults.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
            }

        }

        private void GetKategoriNames()
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();
            con.Open();
            try
            {
               
                cmd.Connection = con;
                cmd.CommandText = "EXECUTE GetCatNames";//0 id 1 ders adı 2. bölüm
                string catID = "";
                string lectureName = "";

                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {

                    catID = dr[0].ToString();
                    lectureName = dr[1].ToString() + " - " + dr[2].ToString();
                    g_catNames.Add(catID, lectureName);
       
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Test verisi okuma hatası");
            }
            con.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
