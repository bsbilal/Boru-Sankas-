namespace BoruSankasi
{
    partial class frmOgrenciMain
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
            this.btnTesteGir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnTesteGir
            // 
            this.btnTesteGir.Enabled = false;
            this.btnTesteGir.Location = new System.Drawing.Point(71, 190);
            this.btnTesteGir.Name = "btnTesteGir";
            this.btnTesteGir.Size = new System.Drawing.Size(209, 98);
            this.btnTesteGir.TabIndex = 0;
            this.btnTesteGir.Text = "Teste Başla";
            this.btnTesteGir.UseSelectable = true;
            this.btnTesteGir.Click += new System.EventHandler(this.btnTesteGir_Click);
            // 
            // frmOgrenciMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 465);
            this.Controls.Add(this.btnTesteGir);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmOgrenciMain";
            this.Resizable = false;
            this.Text = "frmOgrenciMain";
            this.Load += new System.EventHandler(this.frmOgrenciMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTesteGir;
    }
}