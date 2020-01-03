using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace BoruSankasi
{
    public partial class frmGiris : MetroFramework.Forms.MetroForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        int g_userID;
        private void frmGiris_Load(object sender, EventArgs e)
        {
            grpAdmin.Visible = false;
            grpLoginWithName.Visible = true;
            LoadUsers();




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
            try
            {
                while (dr.Read())
                {
                    values.Add(dr[0].ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı yükleme hatası..");
            }
           
     
            con.Close();
            return values;

        }


        bool TextControl(string testValue)
        {

            var regx = new Regex("[^a-zA-Z0-9_.]");
            if (regx.IsMatch(testValue))
                return false;
            else
                return true;

        }





        private void frmGiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         


            
                if (toggleUser.Checked)
            {
                         

                if (TextControl(txtUsername.Text)|| TextControl(txtPassword.Text))
                {



                    con = new SqlConnection(SQLConnect.ConnectionString);
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "EXECUTE LoginControl '" + txtUsername.Text.ToString() + "','" + txtPassword.Text.ToString() + "';";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                        this.Hide();
                        frmTeacherMain frmNew = new frmTeacherMain();
                        frmNew.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("hatalı deger girdiniz");
            }
                else if (!toggleUser.Checked)//user login

                {
                    this.Hide();
                    frmOgrenciMain frmNew = new frmOgrenciMain(g_userID);
                    frmNew.ShowDialog();
                    this.Close();

                }

          

           

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toggleUser_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleUser.Checked)
                {
                grpAdmin.Visible = true;
                grpLoginWithName.Visible = false;
                }
            else
            {
                grpAdmin.Visible = false;
                grpLoginWithName.Visible = true;
            }



        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserID();
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
                if (dr.Read())
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


    }
   
}
