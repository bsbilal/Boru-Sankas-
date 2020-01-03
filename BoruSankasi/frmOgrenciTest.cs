using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoruSankasi
{
    public partial class frmOgrenciTest : MetroFramework.Forms.MetroForm
    {
        Timer tmr = new Timer();
        DateTime dt = DateTime.Now;

        public frmOgrenciTest(int id)
        {
            this.g_OgrID = id;
            InitializeComponent();
            tmr.Interval = 1000;
            tmr.Tick += (sender, e) =>
            {
                if (pBarSure.Value !=0)
                {
                    pBarSure.Value-=1;
                }
                else
                {
                    tmr.Stop();
                    MessageBox.Show("Süreniz Doldu..!");

                    FinishExam();
                }

                TimeSpan diff = dt.Subtract(DateTime.Now);
     

                lblTime.Text ="Kalan Süre"+ string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds);
                if (dt < DateTime.Now)
                    ((Timer)sender).Stop();
            };
        }

        
        //db connectors
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int g_OgrID;

        Hashtable g_HtSorular = new Hashtable();
        Hashtable g_HtCats = new Hashtable();


        //option selected
        string[] optionSelected = new string[50];
        string[] trueAnswers = new string[50];
        int g_CatSum = 0;
        int g_TestID = 0;


        private void frmOgrenciTest_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
           
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Sınavdan cıkmak istiyor musunuz? Şıklarınız kaydedilecektir..", "Boru Sankası",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FinishExam();
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            
        }
        private void frmOgrenciTest_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now.AddHours(0).AddMinutes(50).AddSeconds(00);
            tmr.Start();
          

            pbQuestImage.SizeMode = PictureBoxSizeMode.StretchImage;
          



            for (int i = 0; i < 50; i++)
            {
                optionSelected[i] = "";
            }


            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();
            LoadQuestions();

            LoadLists();


        }


        private void LoadQuestions()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "EXECUTE GetQuestsForUser " + g_OgrID.ToString(); ;
            dr = cmd.ExecuteReader();
            g_HtSorular.Clear();
            int soruid = 1;
            g_HtCats.Clear();
            while (dr.Read())
            {
                Question Quest = new Question();
                Quest.m_Id = Convert.ToInt16(dr[0]);
                Quest.m_Quest = dr[1].ToString();
                Quest.m_catID = Convert.ToInt16(dr[3]);


                //hash de var mı
                if (g_HtCats.ContainsKey(Quest.m_catID.ToString()))
                {

                    QuestionCats Kategoriler = (QuestionCats)g_HtCats[Quest.m_catID.ToString()];
                    g_HtCats.Remove(Quest.m_catID.ToString());
                    Kategoriler.m_YanlisSayisi++;
                    g_HtCats.Add(Quest.m_catID.ToString(), Kategoriler);

                }
                else
                {
                    g_CatSum++;
                    QuestionCats Kategoriler = new QuestionCats();
                    Kategoriler.m_YanlisSayisi++;
                    g_HtCats.Add(Quest.m_catID.ToString(), Kategoriler);

                }                //hash de yoksa 






                int[] randArr = new int[4];
                randArr[0] = 1;
                randArr[1] = 1;
                randArr[2] = 1;
                randArr[3] = 1;

                Random rastgele = new Random();
                int i = 0;


                while (i < 4)
                {
                    int sayi = rastgele.Next(4, 8);
                    if (randArr.Contains(sayi))
                        continue;
                    randArr[i] = sayi;
                    i++;
                }
                trueAnswers[soruid - 1] = dr[4].ToString(); ;
                Quest.m_Answers.m_OptionOne = dr[randArr[0]].ToString();
                Quest.m_Answers.m_OptionTwo = dr[randArr[1]].ToString();
                Quest.m_Answers.m_OptionThree = dr[randArr[2]].ToString();
                Quest.m_Answers.m_OptionFour = dr[randArr[3]].ToString();
                string QuestNumber = "Soru " + soruid++.ToString();
                if(dr[8].ToString()!="-")
                Quest.m_ImagePath = dr[8].ToString();
                g_HtSorular.Add(QuestNumber, Quest);
            }

            con.Close();
        }

        private void LoadLists()
        {

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 1)
                {


                    listSorular.Items.Add("Soru " + (i + 1));
                }
                else if (i % 2 == 0)
                {
                    listSorular.Items.Add("Soru " + (i + 1));
                    //listSorular.Items[i].ForeColor = Color.Red;
                }
            }
            listSorular.SelectedIndex = 0;

        }


        private void listSorular_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            Question Quest = (Question)g_HtSorular[listSorular.SelectedItem.ToString()];
            txtSoru.Text = Quest.m_Quest;
            txtAnswerOne.Text = Quest.m_Answers.m_OptionOne;
            txtAnswerTwo.Text = Quest.m_Answers.m_OptionThree;
            txtAnswerThree.Text = Quest.m_Answers.m_OptionTwo;
            txtAnswerFour.Text = Quest.m_Answers.m_OptionFour;


            if (optionSelected[listSorular.SelectedIndex] != "")
            {
                if (optionSelected[listSorular.SelectedIndex] == Quest.m_Answers.m_OptionOne)
                    OptionChanged(optionSelected[listSorular.SelectedIndex], 1);

                else if (optionSelected[listSorular.SelectedIndex] == Quest.m_Answers.m_OptionTwo)
                    OptionChanged(optionSelected[listSorular.SelectedIndex], 3);

                else if (optionSelected[listSorular.SelectedIndex] == Quest.m_Answers.m_OptionThree)
                    OptionChanged(optionSelected[listSorular.SelectedIndex], 2);

                else if (optionSelected[listSorular.SelectedIndex] == Quest.m_Answers.m_OptionFour)
                    OptionChanged(optionSelected[listSorular.SelectedIndex], 4);

            }
            else//daha önce seçim yapılmamış            
                OptionChanged("", 0);
            if (Quest.m_ImagePath == "-")
                grpSoruFotograf.Visible = false;
            else
                LoadPhotoFromWeb(Quest.m_ImagePath);


        }

        private void LoadPhotoFromWeb(string ResimDogruCevap)
        {
            try
            {
                var request = WebRequest.Create(ResimDogruCevap);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pbQuestImage.ImageLocation = ResimDogruCevap;
                    pbQuestImage.Image = Bitmap.FromStream(stream);

                }

            }
            catch
            {
                MessageBox.Show("Fotoğraf sunucudan alınamadı!");
            }
        }

        private void txtAnswerOne_Click(object sender, EventArgs e)
        {
            OptionChanged(txtAnswerOne.Text, 1);
        }

        void OptionChanged(string Value, int index)
        {
            if (index == 0)
            {
                grpOptionOne.BackColor = Color.White;
                grpOptionTwo.BackColor = Color.White;
                grpOptionThree.BackColor = Color.White;
                grpOptionFour.BackColor = Color.White;
            }
            int soruID = listSorular.SelectedIndex;


            //if quest has optioned before
            if (index == 1)
            {
                grpOptionOne.BackColor = Color.Orange;
                grpOptionTwo.BackColor = Color.White;
                grpOptionThree.BackColor = Color.White;
                grpOptionFour.BackColor = Color.White;
                optionSelected[soruID] = Value;
            }

            else if (index == 2)
            {
                grpOptionOne.BackColor = Color.White;
                grpOptionTwo.BackColor = Color.Orange;
                grpOptionThree.BackColor = Color.White;
                grpOptionFour.BackColor = Color.White;
                optionSelected[soruID] = Value;
            }

            else if (index == 3)
            {
                grpOptionOne.BackColor = Color.White;
                grpOptionTwo.BackColor = Color.White;
                grpOptionThree.BackColor = Color.Orange;
                grpOptionFour.BackColor = Color.White;
                optionSelected[soruID] = Value;
            }

            else if (index == 4)
            {
                grpOptionOne.BackColor = Color.White;
                grpOptionTwo.BackColor = Color.White;
                grpOptionThree.BackColor = Color.White;
                grpOptionFour.BackColor = Color.Orange;
                optionSelected[soruID] = Value;
            }



        }

        private void txtAnswerTwo_Click(object sender, EventArgs e)
        {

            OptionChanged(txtAnswerTwo.Text, 2);

        }

        private void txtAnswerThree_Click(object sender, EventArgs e)
        {

            OptionChanged(txtAnswerThree.Text, 3);

        }

        private void txtAnswerFour_Click(object sender, EventArgs e)
        {

            OptionChanged(txtAnswerFour.Text, 4);

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (listSorular.SelectedIndex == 49)
                MessageBox.Show("son soru");
            else
                listSorular.SelectedIndex++;


        }

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            if (listSorular.SelectedIndex == 0)
                MessageBox.Show("ilk soru");
            else
                listSorular.SelectedIndex--;
        }

        private void btnFinsishQuiz_Click(object sender, EventArgs e)
        {
            FinishExam();
        }

        private void FinishExam()
        {
            int soruid = 1;
            string QuestNumber = "Soru " + soruid++.ToString();

            for (int i = 0; i < 50; i++)
            {
                try
                {
                    QuestNumber = "Soru " + soruid++.ToString();
                    Question Soru = (Question)g_HtSorular[QuestNumber];

                    if (trueAnswers[i] == optionSelected[i])
                    {
                        QuestionCats Kategoriler = (QuestionCats)g_HtCats[Soru.m_catID.ToString()];
                        g_HtCats.Remove(Soru.m_catID.ToString());
                        Kategoriler.m_YanlisSayisi--;
                        Kategoriler.m_DogruSayisi++;

                        g_HtCats.Add(Soru.m_catID.ToString(), Kategoriler);
                    }
                }
                catch (Exception ex)
                { break; }
            }





            WriteResultstoDB();


            this.Hide();

            frmOgrenciTestResult frmNew = new frmOgrenciTestResult(g_HtCats);
            frmNew.ShowDialog();
            this.Close();
        }

        private void WriteResultstoDB()
        {
            int QuizID = GetLastExamID();

            if (QuizID > 0)
            {
                QuizID++;

            }
            else
                QuizID = 1;


            DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 
            string resultAddQuery = "";
            ICollection keys = g_HtCats.Keys;
            foreach (String k in keys)
            {
                QuestionCats Kategoriler = (QuestionCats)g_HtCats[k];
                decimal dogru= Convert.ToDecimal(Kategoriler.m_DogruSayisi);
                decimal yanlis = Convert.ToDecimal(Kategoriler.m_YanlisSayisi);
                
                int toplamSoru = Kategoriler.m_DogruSayisi + Kategoriler.m_YanlisSayisi;
                string rate = "";
                try
                {
                     rate = (dogru / yanlis).ToString();

                }
                catch (Exception)
                {
                    rate ="0";//0 bölü 0
                }
                //user id olacak
                //EXECUTALTER PROCEDURE [dbo].[SinavSonucuEkle] (@m_ExamID int,@m_catID int,@m_UserID int,@m_rate float,@m_date date,@m_SoruSayisi int,@m_Yanlis_Sayisi int) 

                resultAddQuery += "EXECUTE SinavSonucuEkle "+QuizID.ToString()+","+  k +","+ g_OgrID.ToString() +","+ rate +",'"+ time.ToString(format)+"',"+ toplamSoru + ","+Kategoriler.m_YanlisSayisi+" ;";

                //Create Procedure AddtoTotalResults (@m_UserID int ,@m_catID int,@m_SoruSayisi int,@m_Yanlis_Sayisi int)

                resultAddQuery += " EXECUTE AddtoTotalResults " + g_OgrID.ToString() + "," + k + "," + toplamSoru + "," + Kategoriler.m_YanlisSayisi + "; ";
                   
            }

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = resultAddQuery;
                dr = cmd.ExecuteReader();

                con.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("İstatistik yazma hatası");
            }
            }

        private int GetLastExamID()
        {

       
            int returnId=-1;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "EXECUTE GetMaxTestID "+ g_OgrID;//+ user id
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    returnId = Convert.ToInt16(dr[0]);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Test verisi okuma hatası");
            }
            con.Close();

            return returnId;
        }

     
    }
}
