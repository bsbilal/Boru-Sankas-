namespace BoruSankasi
{
    partial class frmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.toggleUser = new MetroFramework.Controls.MetroToggle();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.grpLoginWithName = new System.Windows.Forms.GroupBox();
            this.grpAdmin.SuspendLayout();
            this.grpLoginWithName.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Öğretmen modu :";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(61, 58);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(120, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(87, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Şifreniz";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(61, 139);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(120, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // toggleUser
            // 
            this.toggleUser.AutoSize = true;
            this.toggleUser.Location = new System.Drawing.Point(136, 63);
            this.toggleUser.Name = "toggleUser";
            this.toggleUser.Size = new System.Drawing.Size(80, 21);
            this.toggleUser.TabIndex = 6;
            this.toggleUser.Text = "Off";
            this.toggleUser.UseSelectable = true;
            this.toggleUser.CheckedChanged += new System.EventHandler(this.toggleUser_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(117, 342);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 61);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(43, 55);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(127, 24);
            this.cmbUsers.TabIndex = 8;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.metroLabel3);
            this.grpAdmin.Controls.Add(this.txtPassword);
            this.grpAdmin.Controls.Add(this.txtUsername);
            this.grpAdmin.Controls.Add(this.metroLabel2);
            this.grpAdmin.Location = new System.Drawing.Point(65, 108);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(243, 200);
            this.grpAdmin.TabIndex = 9;
            this.grpAdmin.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(65, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Kullanıcı Adınız";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Adınızı Seçin";
            // 
            // grpLoginWithName
            // 
            this.grpLoginWithName.Controls.Add(this.cmbUsers);
            this.grpLoginWithName.Controls.Add(this.metroLabel4);
            this.grpLoginWithName.Location = new System.Drawing.Point(87, 153);
            this.grpLoginWithName.Name = "grpLoginWithName";
            this.grpLoginWithName.Size = new System.Drawing.Size(200, 100);
            this.grpLoginWithName.TabIndex = 11;
            this.grpLoginWithName.TabStop = false;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 471);
            this.Controls.Add(this.grpLoginWithName);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.toggleUser);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmGiris";
            this.Resizable = false;
            this.Text = "Hoşgeldiniz..! Lütfen Giriş Yapın";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.TextChanged += new System.EventHandler(this.frmGiris_TextChanged);
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            this.grpLoginWithName.ResumeLayout(false);
            this.grpLoginWithName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroToggle toggleUser;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.GroupBox grpAdmin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox grpLoginWithName;
    }
}