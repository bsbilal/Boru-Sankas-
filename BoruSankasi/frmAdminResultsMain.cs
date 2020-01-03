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
using System.Windows.Forms.DataVisualization.Charting;

namespace BoruSankasi
{
    public partial class frmAdminResultsMain : MetroFramework.Forms.MetroForm
    {
        public frmAdminResultsMain()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void frmAdminResultscs_Load(object sender, EventArgs e)
        {

            int DogruSayisi = 0;
            int ToplamSoruSayi = 0;
            decimal Yuzde=0;
            string kullaniciAdi = "";
            string isim = "";

            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "EXECUTE GetBestUser ";
                dr = cmd.ExecuteReader(); 
                if (dr.Read())
                {
                    DogruSayisi =Convert.ToInt16( dr[0]);
                    ToplamSoruSayi = Convert.ToInt16(dr[1]);
                    Yuzde = Convert.ToDecimal(dr[2]);
                    Yuzde = Math.Round(Yuzde, 4);
                    kullaniciAdi = dr[3].ToString();
                    isim = dr[4].ToString();





                }
         
                con.Close();

                lblAd.Text = isim;
                lblDogru.Text = DogruSayisi.ToString()+ " tanesi doğru cevaplanmış." ;
                lblSoru.Text = "Toplam " + ToplamSoruSayi.ToString()+" sorunun" ;
                lblBasari.Text = "Öğrencinin başarı oranı :%"+(Yuzde*100).ToString();


                //reset your chart series and legends
                chartPie.Series.Clear();
                chartPie.Legends.Clear();

                //Add a new Legend(if needed) and do some formating
                chartPie.Legends.Add("MyLegend");
                chartPie.Legends[0].LegendStyle = LegendStyle.Table;
                chartPie.Legends[0].Docking = Docking.Bottom;
                chartPie.Legends[0].Alignment = StringAlignment.Center;
                chartPie.Legends[0].Title = "Tablo Değerleri";
                chartPie.Legends[0].BorderColor = Color.Black;

                 string seriesname = "MySeriesName";
                chartPie.Series.Add(seriesname);
                 chartPie.Series[seriesname].ChartType = SeriesChartType.Pie;
                chartPie.Series[seriesname].Points.AddXY("Doğrular", DogruSayisi);
                  
                chartPie.Series[seriesname].Points.AddXY("Yanlışlar", ToplamSoruSayi-DogruSayisi);


            }
            catch (Exception )
            {
                MessageBox.Show("okuma hatası");
            }








        }

        private void btnOtherStatics_Click(object sender, EventArgs e)
        {

        

            this.Hide();
            frmAdminUserStats frmNew = new frmAdminUserStats();
            frmNew.ShowDialog();
       
            this.Close();
        }
    }
}
