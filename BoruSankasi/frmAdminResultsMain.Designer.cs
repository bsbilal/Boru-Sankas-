namespace BoruSankasi
{
    partial class frmAdminResultsMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblBasari = new System.Windows.Forms.Label();
            this.btnOtherStatics = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.03478F);
            this.label1.Location = new System.Drawing.Point(340, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Başarılı Öğrenci";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.13913F);
            this.lblAd.Location = new System.Drawing.Point(433, 155);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(103, 38);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "label2";
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(266, 196);
            this.chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(531, 283);
            this.chartPie.TabIndex = 2;
            this.chartPie.Text = "chart1";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.13913F);
            this.lblSoru.Location = new System.Drawing.Point(356, 474);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(93, 33);
            this.lblSoru.TabIndex = 3;
            this.lblSoru.Text = "label2";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.13913F);
            this.lblDogru.Location = new System.Drawing.Point(356, 516);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(93, 33);
            this.lblDogru.TabIndex = 4;
            this.lblDogru.Text = "label2";
            // 
            // lblBasari
            // 
            this.lblBasari.AutoSize = true;
            this.lblBasari.BackColor = System.Drawing.Color.White;
            this.lblBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.13913F);
            this.lblBasari.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBasari.Location = new System.Drawing.Point(355, 552);
            this.lblBasari.Name = "lblBasari";
            this.lblBasari.Size = new System.Drawing.Size(81, 30);
            this.lblBasari.TabIndex = 5;
            this.lblBasari.Text = "label2";
            // 
            // btnOtherStatics
            // 
            this.btnOtherStatics.Location = new System.Drawing.Point(34, 219);
            this.btnOtherStatics.Name = "btnOtherStatics";
            this.btnOtherStatics.Size = new System.Drawing.Size(181, 152);
            this.btnOtherStatics.TabIndex = 6;
            this.btnOtherStatics.Text = "Diğer öğrencilerin istatistikleri";
            this.btnOtherStatics.UseSelectable = true;
            this.btnOtherStatics.Click += new System.EventHandler(this.btnOtherStatics_Click);
            // 
            // frmAdminResultsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 596);
            this.Controls.Add(this.btnOtherStatics);
            this.Controls.Add(this.lblBasari);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAdminResultsMain";
            this.Resizable = false;
            this.Text = "İstatistik Ekranı";
            this.Load += new System.EventHandler(this.frmAdminResultscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblBasari;
        private MetroFramework.Controls.MetroButton btnOtherStatics;
    }
}