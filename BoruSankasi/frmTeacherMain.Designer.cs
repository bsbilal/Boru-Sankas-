namespace BoruSankasi
{
    partial class frmTeacherMain
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
            this.btnIstatistik = new MetroFramework.Controls.MetroButton();
            this.btnSoruEkleme = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(140, 274);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(341, 78);
            this.btnIstatistik.Style = MetroFramework.MetroColorStyle.Green;
            this.btnIstatistik.TabIndex = 0;
            this.btnIstatistik.Text = "Istatistikleri Görüntüle";
            this.btnIstatistik.UseSelectable = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnSoruEkleme
            // 
            this.btnSoruEkleme.Location = new System.Drawing.Point(140, 123);
            this.btnSoruEkleme.Name = "btnSoruEkleme";
            this.btnSoruEkleme.Size = new System.Drawing.Size(341, 89);
            this.btnSoruEkleme.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSoruEkleme.TabIndex = 1;
            this.btnSoruEkleme.Text = "Soru Ekleme";
            this.btnSoruEkleme.UseSelectable = true;
            this.btnSoruEkleme.Click += new System.EventHandler(this.btnSoruEkleme_Click);
            // 
            // frmTeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 443);
            this.Controls.Add(this.btnSoruEkleme);
            this.Controls.Add(this.btnIstatistik);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "frmTeacherMain";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Admin Ekranı";
            this.Load += new System.EventHandler(this.frmTeacherMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIstatistik;
        private MetroFramework.Controls.MetroButton btnSoruEkleme;
    }
}