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
using System.Collections;
using System.Text.RegularExpressions;

namespace BoruSankasi
{
    public partial class frmSoruEkleme : MetroFramework.Forms.MetroForm
    {
        public frmSoruEkleme()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        private void frmSoruEkleme_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();
            LoadLectures();



        }

        void LoadLectures()
        {

            cmbDers.Items.Clear();
            cmbKonu.Items.Clear();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From ShowLectures;";
            dr = cmd.ExecuteReader();
            cmbDers.Items.Clear();
            while (dr.Read())
            {
                cmbDers.Items.Add(dr[0]);
            }
            con.Close();

            cmbDers.SelectedIndex = 0;
        }
        void LoadTopics(int DersID)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "EXECUTE GetTopics " + DersID + ";";
            dr = cmd.ExecuteReader();
            cmbKonu.Items.Clear();
            while (dr.Read())
            {
                cmbKonu.Items.Add(dr[1]);
            }
            cmbKonu.SelectedIndex = 0;

            con.Close();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTopics(cmbDers.SelectedIndex+1);
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        bool TextControl(string testValue)
        {

            var regx = new Regex("[^a-zA-Z0-9_.]");
            if (regx.IsMatch(testValue))
                return false;
            else
                return true;

        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

            Question newQuestion = new Question();
            
            newQuestion.m_Quest = txtSoru.Text;
            newQuestion.m_Answers.m_OptionOne = txtAnswerTrue.Text;
            newQuestion.m_Answers.m_OptionTwo = txtFalseAnswerOne.Text;
            newQuestion.m_Answers.m_OptionThree = txtFalseAnswerTwo.Text;
            newQuestion.m_Answers.m_OptionFour = txtFalseAnswerThree.Text;
             newQuestion.m_catID = cmbDers.SelectedIndex + 1;
            string Topic = cmbKonu.SelectedItem.ToString();

            bool isValid = true;
       while (1 < 2) {
                isValid = TextControl(txtAnswerTrue.Text);
                if (!isValid)
                    break;
                isValid = TextControl(txtFalseAnswerOne.Text);
                if (!isValid)
                    break;
                isValid = TextControl(txtFalseAnswerTwo.Text);
                if (!isValid)
                    break; isValid = TextControl(txtFalseAnswerThree.Text);
                if (!isValid)
                    break; isValid = TextControl(txtSoru.Text);
                if (!isValid)
                    break;


            }
            if (isValid) { 

            con.Open();
            cmd.Connection = con;
          
            if (chkImage.Checked)
            {
             
                cmd.CommandText = "EXECUTE AddQuestionWithImage " + newQuestion.m_catID + ",'" + Topic + "','" + newQuestion.m_Quest + "','" + newQuestion.m_Answers.m_OptionOne + "','" + newQuestion.m_Answers.m_OptionTwo + "','" + newQuestion.m_Answers.m_OptionThree + "','" + newQuestion.m_Answers.m_OptionFour + "','"+txtImagePath.Text+"';";
            }
            else
            {
                cmd.CommandText = "EXECUTE AddQuestion " + newQuestion.m_catID + ",'" + Topic + "','" + newQuestion.m_Quest + "','" + newQuestion.m_Answers.m_OptionOne + "','" + newQuestion.m_Answers.m_OptionTwo + "','" + newQuestion.m_Answers.m_OptionThree + "','" + newQuestion.m_Answers.m_OptionFour + "';";

            }
            int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    MessageBox.Show("Soru Ekleme başarılı..!");
                    con.Close();


                    ClearTextBoxes(); }

                else
                    MessageBox.Show("Soru Ekleme başarısız oldu..!");     
            }
            else
            {
                MessageBox.Show("Geçersiz karakterler girdiniz..");
            }



        }

        private void chkImage_CheckedChanged(object sender, EventArgs e)
        {

            if (chkImage.Checked)
            {
                if ((Application.OpenForms["frmPhotoUpload"] as frmPhotoUpload) != null)
                {

                    MessageBox.Show("Yükleme sayfası açık..");
                }
                else
                {
                    frmPhotoUpload frmUp = new frmPhotoUpload();
                    frmUp.Show();
                }


                txtImagePath.Text = "";
                grpPhoto.Visible = true;
            }

            else if (!chkImage.Checked)
            {
                txtImagePath.Text = "";

                grpPhoto.Visible = false;
            }


            }
        }
}
