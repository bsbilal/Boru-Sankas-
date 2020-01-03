namespace BoruSankasi
{
    partial class frmOgrenciTestResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(581, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 114);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chartResults
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResults.Legends.Add(legend1);
            this.chartResults.Location = new System.Drawing.Point(23, 127);
            this.chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Başarı yüzdeniz";
            this.chartResults.Series.Add(series1);
            this.chartResults.Size = new System.Drawing.Size(509, 300);
            this.chartResults.TabIndex = 2;
            this.chartResults.Text = "chart1";
            // 
            // frmOgrenciTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartResults);
            this.Controls.Add(this.btnExit);
            this.Name = "frmOgrenciTestResult";
            this.Text = "Test Sonucu";
            this.Load += new System.EventHandler(this.frmOgrenciTestResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
    }
}