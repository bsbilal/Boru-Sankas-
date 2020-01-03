namespace BoruSankasi
{
    partial class frmPhotoUpload
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
            this.webBrowserNew = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserNew
            // 
            this.webBrowserNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserNew.Location = new System.Drawing.Point(20, 60);
            this.webBrowserNew.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNew.Name = "webBrowserNew";
            this.webBrowserNew.Size = new System.Drawing.Size(760, 370);
            this.webBrowserNew.TabIndex = 0;
            // 
            // frmPhotoUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserNew);
            this.MaximizeBox = false;
            this.Name = "frmPhotoUpload";
            this.Resizable = false;
            this.Text = "Sunucuya Fotoğraf Yükleme";
            this.Load += new System.EventHandler(this.frmPhotoUpload_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserNew;
    }
}