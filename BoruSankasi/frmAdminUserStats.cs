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
using System.Windows.Forms.DataVisualization.Charting;


namespace BoruSankasi
{
    public partial class frmAdminUserStats : MetroFramework.Forms.MetroForm
    {
        public frmAdminUserStats()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Hashtable g_Quizzies = new Hashtable();
        string ValueFirst = "";
        string ValueLast = "";


        int g_userID = 0;
        private void frmAdminUserStats_Load(object sender, EventArgs e)
        {
            LoadUsers();
            cmbUsers.SelectedIndex = 0;

           
        }

        private void GetStatsbyDate(int GunFarki)
        {

            chartLine.Series.Clear();
            lblInfo.Text = "Seçilen tarihler arasındaki sonuçlar";


            int[] examID = new int[GunFarki*32];
            int kayitSayisi = 0;
            con = new SqlConnection(SQLConnect.ConnectionString);

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "EXECUTE GetBeetweenDates '" + ValueFirst + "','" + ValueLast + "'," + g_userID.ToString();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    examID[kayitSayisi++] = Convert.ToInt16(dr[0]);

                }

            }
            catch (Exception)
            {
                throw;


            }
            con.Close();


            var series = new Series("Sınav Sonuçları");

            chartLine.ChartAreas[0].AxisY.Maximum = 100;
            chartLine.ChartAreas[0].AxisY.Minimum = 0;
            series.ChartType = SeriesChartType.Line;

            try
            {
                con = new SqlConnection(SQLConnect.ConnectionString);

                cmd.Connection = con;
                for (int i = 0; i < kayitSayisi; i++)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "select sum(yanlisSayisi),sum(soruSayisi),resultDate from tblQuizResults where ExamID=" + examID[i] + " GROUP BY resultDate HAVING Count(*) > 1 ;";


                    dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {

                        if (dr[0] == DBNull.Value)
                            continue;
                        else if (dr[1] == DBNull.Value)
                            continue;
                        else if (dr[2] == DBNull.Value)
                            continue;

                        UserResults uResults = new UserResults();
                        uResults.m_tarih = dr[2].ToString();
                        uResults.m_yanlisSayisi = Convert.ToInt16(dr[0]);
                        uResults.m_dogruSayisi = Convert.ToInt16(dr[1]) - Convert.ToInt16(dr[0]);
                        // g_Quizzies.Add(examID[i], uResults);
                        decimal ratio = (Convert.ToDecimal(uResults.m_dogruSayisi) / Convert.ToDecimal(dr[1])) * 100;

                        series.Points.Add(Convert.ToDouble(ratio));
                        series.Points[i].AxisLabel = uResults.m_tarih;


                    }

                    con.Close();

                }


                chartLine.Series.Add(series);



            }
            catch (Exception)
            {

                throw;
            }
            if (kayitSayisi == 0)
            {
                this.Resizable = true;
                this.Size = new Size(300, 440);
                this.Resizable = false;

                MessageBox.Show("Öğrencinin yeterli sayıda sonucu yok.");
            }
            else
            {
                this.Resizable = true;
                this.Size = new Size(850, 440);
                this.Resizable = false;
            }

            }


            private void GetUserID()
        {

            try
            {
                con = new SqlConnection(SQLConnect.ConnectionString);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select id From tblUsers Where AdSoyad='" + cmbUsers.SelectedItem.ToString() + "' ;";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    g_userID = Convert.ToInt16(dr[0]);

                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        void GetUserStats()
        {
            chartLine.Series.Clear();

         

            int[] examID = new int[5];
            int kayitSayisi = 0;
            try
            {
                con = new SqlConnection(SQLConnect.ConnectionString);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "EXECUTE GETTOPFIVETIMES " + g_userID.ToString();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {//GetBeetweenDates , first date, last date , userid
                    examID[kayitSayisi++] = Convert.ToInt16(dr[0]);

                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

            var series = new Series("Sınav Sonuçları");

            chartLine.ChartAreas[0].AxisY.Maximum = 100;
            chartLine.ChartAreas[0].AxisY.Minimum = 0;
            series.ChartType = SeriesChartType.Line;
     
            try
            {
                con = new SqlConnection(SQLConnect.ConnectionString);

                cmd.Connection = con;
                for (int i = 0; i < kayitSayisi; i++)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;

                    cmd.CommandText = "select sum(yanlisSayisi),sum(soruSayisi),resultDate from tblQuizResults where ExamID=" + examID[i] + " GROUP BY resultDate HAVING Count(*) > 1 ;";
                    //select sum(yanlisSayisi),sum(soruSayisi),resultDate from tblQuizResults where ExamID=40 GROUP BY resultDate HAVING Count(*) > 1 


                    dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {

                        if (dr[0] == DBNull.Value)
                            continue;
                        else if (dr[1] == DBNull.Value)
                            continue;
                        else if (dr[2] == DBNull.Value)
                            continue;

                        UserResults uResults = new UserResults();
                        uResults.m_tarih = dr[2].ToString();
                        uResults.m_yanlisSayisi = Convert.ToInt16(dr[0]);
                        uResults.m_dogruSayisi = Convert.ToInt16(dr[1]) - Convert.ToInt16(dr[0]);
                        //g_Quizzies.Add(examID[i], uResults);
                        decimal ratio = (Convert.ToDecimal(uResults.m_dogruSayisi) / Convert.ToDecimal(dr[1])) * 100;

                        series.Points.Add(Convert.ToDouble( ratio));
                        series.Points[i].AxisLabel = uResults.m_tarih;


                    }

                    con.Close();

                }
               

                chartLine.Series.Add(series);



            }
            catch (Exception)
            {

                throw;
            }
            if (kayitSayisi == 0)
            {
                this.Resizable = true;
                this.Size = new Size(300, 440);
                this.Resizable = false;

                MessageBox.Show("Öğrencinin yeterli sayıda sonucu yok.");
            }
            else
            {
                this.Resizable = true;
                this.Size = new Size(850, 440);
                this.Resizable = false;
            }

        }

        private void LoadUsers()
        {
            cmbUsers.Items.Clear();

            List<string> users = new List<string>();
            users = bindUsers();

            foreach (string item in users)
            {
                cmbUsers.Items.Add(item);
            }
            cmbUsers.SelectedIndex = 0;


        }

        public List<string> bindUsers()
        {
            List<string> values = new List<string>();
            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "EXECUTE LoadUsernames;";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                values.Add(dr[0].ToString());
            }

            con.Close();
            return values;

        }

        private void chartLine_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeFirst_ValueChanged(object sender, EventArgs e)
        {


            if (dateTimeFirst.Value > dateTimeLast.Value)          
                    btnDrawbyDate.Enabled = false;
            
            else
                btnDrawbyDate.Enabled = true;



        }

        private void dateTimeLast_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeFirst.Value > dateTimeLast.Value)
            
                btnDrawbyDate.Enabled = false;
            
            else
                btnDrawbyDate.Enabled = true;
        }

        private void btnDrawbyDate_Click(object sender, EventArgs e)
        {
         
            if (dateTimeLast.Value> dateTimeFirst.Value)
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                ValueFirst = dateTimeFirst.Value.ToString(format);
                ValueLast = dateTimeLast.Value.ToString(format);
                TimeSpan difference = getDateDifference(dateTimeLast.Value, dateTimeFirst.Value);
                int differenceInDays = difference.Days;
                GetStatsbyDate(differenceInDays);
            }

        }

        TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            
            TimeSpan ts = date1 - date2;

            if (date1 < date2)
                return -ts;
            return ts;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserID();

            GetUserStats();
        }
    }
}
