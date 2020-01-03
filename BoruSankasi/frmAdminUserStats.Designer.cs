namespace BoruSankasi
{
    partial class frmAdminUserStats
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
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeFirst = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeLast = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDrawbyDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(63, 121);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 28);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kullanıcı Seçin";
            // 
            // dateTimeFirst
            // 
            this.dateTimeFirst.Location = new System.Drawing.Point(35, 226);
            this.dateTimeFirst.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTimeFirst.Name = "dateTimeFirst";
            this.dateTimeFirst.Size = new System.Drawing.Size(200, 30);
            this.dateTimeFirst.TabIndex = 2;
            this.dateTimeFirst.ValueChanged += new System.EventHandler(this.dateTimeFirst_ValueChanged);
            // 
            // dateTimeLast
            // 
            this.dateTimeLast.Location = new System.Drawing.Point(35, 296);
            this.dateTimeLast.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTimeLast.Name = "dateTimeLast";
            this.dateTimeLast.Size = new System.Drawing.Size(200, 30);
            this.dateTimeLast.TabIndex = 3;
            this.dateTimeLast.ValueChanged += new System.EventHandler(this.dateTimeLast_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(74, 190);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Başlangıç tarihi";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(101, 259);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Bitiş Tarihi";
            // 
            // chartLine
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLine.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLine.Legends.Add(legend2);
            this.chartLine.Location = new System.Drawing.Point(282, 121);
            this.chartLine.Name = "chartLine";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SINAVLAR";
            this.chartLine.Series.Add(series2);
            this.chartLine.Size = new System.Drawing.Size(593, 292);
            this.chartLine.TabIndex = 6;
            this.chartLine.Text = "chart1";
            this.chartLine.Click += new System.EventHandler(this.chartLine_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.13913F);
            this.lblInfo.Location = new System.Drawing.Point(275, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(431, 40);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Son Sınav Başarı Oranları";
            // 
            // btnDrawbyDate
            // 
            this.btnDrawbyDate.Location = new System.Drawing.Point(50, 344);
            this.btnDrawbyDate.Name = "btnDrawbyDate";
            this.btnDrawbyDate.Size = new System.Drawing.Size(162, 52);
            this.btnDrawbyDate.TabIndex = 8;
            this.btnDrawbyDate.Text = "Tarihe göre Listele";
            this.btnDrawbyDate.UseVisualStyleBackColor = true;
            this.btnDrawbyDate.Click += new System.EventHandler(this.btnDrawbyDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sınav Tarihleri";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(314, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "% Başarı";
            // 
            // frmAdminUserStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 446);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDrawbyDate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chartLine);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dateTimeLast);
            this.Controls.Add(this.dateTimeFirst);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbUsers);
            this.MaximizeBox = false;
            this.Name = "frmAdminUserStats";
            this.Resizable = false;
            this.Text = "frmAdminUserStats";
            this.Load += new System.EventHandler(this.frmAdminUserStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateTimeFirst;
        private MetroFramework.Controls.MetroDateTime dateTimeLast;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDrawbyDate;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}