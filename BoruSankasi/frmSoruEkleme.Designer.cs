namespace BoruSankasi
{
    partial class frmSoruEkleme
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
            this.cmbDers = new MetroFramework.Controls.MetroComboBox();
            this.cmbKonu = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAnswerTrue = new MetroFramework.Controls.MetroTextBox();
            this.txtFalseAnswerOne = new MetroFramework.Controls.MetroTextBox();
            this.txtFalseAnswerTwo = new MetroFramework.Controls.MetroTextBox();
            this.txtFalseAnswerThree = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnAddQuestion = new MetroFramework.Controls.MetroButton();
            this.txtSoru = new System.Windows.Forms.RichTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.txtImagePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.grpPhoto = new System.Windows.Forms.GroupBox();
            this.grpPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.ItemHeight = 24;
            this.cmbDers.Location = new System.Drawing.Point(71, 148);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 30);
            this.cmbDers.TabIndex = 0;
            this.cmbDers.UseSelectable = true;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // cmbKonu
            // 
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.ItemHeight = 24;
            this.cmbKonu.Location = new System.Drawing.Point(71, 228);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(121, 30);
            this.cmbKonu.TabIndex = 1;
            this.cmbKonu.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(71, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Konu";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Ders";
            // 
            // txtAnswerTrue
            // 
            // 
            // 
            // 
            this.txtAnswerTrue.CustomButton.Image = null;
            this.txtAnswerTrue.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtAnswerTrue.CustomButton.Name = "";
            this.txtAnswerTrue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnswerTrue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnswerTrue.CustomButton.TabIndex = 1;
            this.txtAnswerTrue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnswerTrue.CustomButton.UseSelectable = true;
            this.txtAnswerTrue.CustomButton.Visible = false;
            this.txtAnswerTrue.Lines = new string[0];
            this.txtAnswerTrue.Location = new System.Drawing.Point(404, 278);
            this.txtAnswerTrue.MaxLength = 32767;
            this.txtAnswerTrue.Name = "txtAnswerTrue";
            this.txtAnswerTrue.PasswordChar = '\0';
            this.txtAnswerTrue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnswerTrue.SelectedText = "";
            this.txtAnswerTrue.SelectionLength = 0;
            this.txtAnswerTrue.SelectionStart = 0;
            this.txtAnswerTrue.ShortcutsEnabled = true;
            this.txtAnswerTrue.Size = new System.Drawing.Size(318, 23);
            this.txtAnswerTrue.TabIndex = 4;
            this.txtAnswerTrue.UseSelectable = true;
            this.txtAnswerTrue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnswerTrue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFalseAnswerOne
            // 
            // 
            // 
            // 
            this.txtFalseAnswerOne.CustomButton.Image = null;
            this.txtFalseAnswerOne.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtFalseAnswerOne.CustomButton.Name = "";
            this.txtFalseAnswerOne.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFalseAnswerOne.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFalseAnswerOne.CustomButton.TabIndex = 1;
            this.txtFalseAnswerOne.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFalseAnswerOne.CustomButton.UseSelectable = true;
            this.txtFalseAnswerOne.CustomButton.Visible = false;
            this.txtFalseAnswerOne.Lines = new string[0];
            this.txtFalseAnswerOne.Location = new System.Drawing.Point(404, 330);
            this.txtFalseAnswerOne.MaxLength = 32767;
            this.txtFalseAnswerOne.Name = "txtFalseAnswerOne";
            this.txtFalseAnswerOne.PasswordChar = '\0';
            this.txtFalseAnswerOne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFalseAnswerOne.SelectedText = "";
            this.txtFalseAnswerOne.SelectionLength = 0;
            this.txtFalseAnswerOne.SelectionStart = 0;
            this.txtFalseAnswerOne.ShortcutsEnabled = true;
            this.txtFalseAnswerOne.Size = new System.Drawing.Size(318, 23);
            this.txtFalseAnswerOne.TabIndex = 5;
            this.txtFalseAnswerOne.UseSelectable = true;
            this.txtFalseAnswerOne.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFalseAnswerOne.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFalseAnswerTwo
            // 
            // 
            // 
            // 
            this.txtFalseAnswerTwo.CustomButton.Image = null;
            this.txtFalseAnswerTwo.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtFalseAnswerTwo.CustomButton.Name = "";
            this.txtFalseAnswerTwo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFalseAnswerTwo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFalseAnswerTwo.CustomButton.TabIndex = 1;
            this.txtFalseAnswerTwo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFalseAnswerTwo.CustomButton.UseSelectable = true;
            this.txtFalseAnswerTwo.CustomButton.Visible = false;
            this.txtFalseAnswerTwo.Lines = new string[0];
            this.txtFalseAnswerTwo.Location = new System.Drawing.Point(404, 379);
            this.txtFalseAnswerTwo.MaxLength = 32767;
            this.txtFalseAnswerTwo.Name = "txtFalseAnswerTwo";
            this.txtFalseAnswerTwo.PasswordChar = '\0';
            this.txtFalseAnswerTwo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFalseAnswerTwo.SelectedText = "";
            this.txtFalseAnswerTwo.SelectionLength = 0;
            this.txtFalseAnswerTwo.SelectionStart = 0;
            this.txtFalseAnswerTwo.ShortcutsEnabled = true;
            this.txtFalseAnswerTwo.Size = new System.Drawing.Size(318, 23);
            this.txtFalseAnswerTwo.TabIndex = 6;
            this.txtFalseAnswerTwo.UseSelectable = true;
            this.txtFalseAnswerTwo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFalseAnswerTwo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFalseAnswerThree
            // 
            // 
            // 
            // 
            this.txtFalseAnswerThree.CustomButton.Image = null;
            this.txtFalseAnswerThree.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtFalseAnswerThree.CustomButton.Name = "";
            this.txtFalseAnswerThree.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFalseAnswerThree.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFalseAnswerThree.CustomButton.TabIndex = 1;
            this.txtFalseAnswerThree.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFalseAnswerThree.CustomButton.UseSelectable = true;
            this.txtFalseAnswerThree.CustomButton.Visible = false;
            this.txtFalseAnswerThree.Lines = new string[0];
            this.txtFalseAnswerThree.Location = new System.Drawing.Point(404, 435);
            this.txtFalseAnswerThree.MaxLength = 32767;
            this.txtFalseAnswerThree.Name = "txtFalseAnswerThree";
            this.txtFalseAnswerThree.PasswordChar = '\0';
            this.txtFalseAnswerThree.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFalseAnswerThree.SelectedText = "";
            this.txtFalseAnswerThree.SelectionLength = 0;
            this.txtFalseAnswerThree.SelectionStart = 0;
            this.txtFalseAnswerThree.ShortcutsEnabled = true;
            this.txtFalseAnswerThree.Size = new System.Drawing.Size(318, 23);
            this.txtFalseAnswerThree.TabIndex = 7;
            this.txtFalseAnswerThree.UseSelectable = true;
            this.txtFalseAnswerThree.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFalseAnswerThree.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(295, 278);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Doğru Cevap";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(295, 382);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 20);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Yanlıs Cevap";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(404, 477);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(318, 64);
            this.btnAddQuestion.TabIndex = 12;
            this.btnAddQuestion.Text = "Soru ekle";
            this.btnAddQuestion.UseSelectable = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(393, 74);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(318, 70);
            this.txtSoru.TabIndex = 13;
            this.txtSoru.Text = "";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(294, 330);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(85, 20);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Yanlıs Cevap";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(295, 435);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Yanlıs Cevap";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(295, 74);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(37, 20);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Soru";
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Location = new System.Drawing.Point(393, 157);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(106, 21);
            this.chkImage.TabIndex = 17;
            this.chkImage.Text = "Resimli Soru";
            this.chkImage.UseVisualStyleBackColor = true;
            this.chkImage.CheckedChanged += new System.EventHandler(this.chkImage_CheckedChanged);
            // 
            // txtImagePath
            // 
            // 
            // 
            // 
            this.txtImagePath.CustomButton.Image = null;
            this.txtImagePath.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtImagePath.CustomButton.Name = "";
            this.txtImagePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImagePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImagePath.CustomButton.TabIndex = 1;
            this.txtImagePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImagePath.CustomButton.UseSelectable = true;
            this.txtImagePath.CustomButton.Visible = false;
            this.txtImagePath.Lines = new string[0];
            this.txtImagePath.Location = new System.Drawing.Point(6, 41);
            this.txtImagePath.MaxLength = 32767;
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.PasswordChar = '\0';
            this.txtImagePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImagePath.SelectedText = "";
            this.txtImagePath.SelectionLength = 0;
            this.txtImagePath.SelectionStart = 0;
            this.txtImagePath.ShortcutsEnabled = true;
            this.txtImagePath.Size = new System.Drawing.Size(318, 23);
            this.txtImagePath.TabIndex = 18;
            this.txtImagePath.UseSelectable = true;
            this.txtImagePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImagePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 18);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(142, 20);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Fotoğrafın web adresi";
            // 
            // grpPhoto
            // 
            this.grpPhoto.Controls.Add(this.txtImagePath);
            this.grpPhoto.Controls.Add(this.metroLabel9);
            this.grpPhoto.Location = new System.Drawing.Point(393, 179);
            this.grpPhoto.Name = "grpPhoto";
            this.grpPhoto.Size = new System.Drawing.Size(329, 79);
            this.grpPhoto.TabIndex = 20;
            this.grpPhoto.TabStop = false;
            this.grpPhoto.Visible = false;
            // 
            // frmSoruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 568);
            this.Controls.Add(this.grpPhoto);
            this.Controls.Add(this.chkImage);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtFalseAnswerThree);
            this.Controls.Add(this.txtFalseAnswerTwo);
            this.Controls.Add(this.txtFalseAnswerOne);
            this.Controls.Add(this.txtAnswerTrue);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbKonu);
            this.Controls.Add(this.cmbDers);
            this.MaximizeBox = false;
            this.Name = "frmSoruEkleme";
            this.Resizable = false;
            this.Text = "Soru Ekleme";
            this.Load += new System.EventHandler(this.frmSoruEkleme_Load);
            this.grpPhoto.ResumeLayout(false);
            this.grpPhoto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbDers;
        private MetroFramework.Controls.MetroComboBox cmbKonu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAnswerTrue;
        private MetroFramework.Controls.MetroTextBox txtFalseAnswerOne;
        private MetroFramework.Controls.MetroTextBox txtFalseAnswerTwo;
        private MetroFramework.Controls.MetroTextBox txtFalseAnswerThree;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnAddQuestion;
        private System.Windows.Forms.RichTextBox txtSoru;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.CheckBox chkImage;
        private MetroFramework.Controls.MetroTextBox txtImagePath;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox grpPhoto;
    }
}