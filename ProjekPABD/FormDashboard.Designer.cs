namespace ProjekPABD
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.btnLoginMahasiswa = new System.Windows.Forms.Button();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.chartKomplain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.cmbDataCategory = new System.Windows.Forms.ComboBox();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.panelChartControl = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.dtPeriode = new System.Windows.Forms.DateTimePicker();
            this.lblChartType = new System.Windows.Forms.Label();
            this.lblDataCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKomplain)).BeginInit();
            this.panelChartControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::ProjekPABD.Properties.Resources.Sisko_Mawa_student_feedback_system_logo;
            this.pictureLogo.Location = new System.Drawing.Point(200, -7);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(900, 200);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(464, 200);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 74);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SISKOMAWA";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubTitle.Location = new System.Drawing.Point(330, 274);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(569, 36);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Sistem Informasi Saran dan Komplain Mahasiswa";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCari.Location = new System.Drawing.Point(50, 330);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(350, 37);
            this.txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(420, 328);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(130, 60);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(570, 328);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 60);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalData.Location = new System.Drawing.Point(50, 390);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(175, 36);
            this.lblTotalData.TabIndex = 6;
            this.lblTotalData.Text = "Total Data : 0";
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDashboard.ColumnHeadersHeight = 50;
            this.dgvDashboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dgvDashboard.Location = new System.Drawing.Point(32, 440);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.RowHeadersVisible = false;
            this.dgvDashboard.RowHeadersWidth = 62;
            this.dgvDashboard.RowTemplate.Height = 45;
            this.dgvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboard.Size = new System.Drawing.Size(688, 401);
            this.dgvDashboard.TabIndex = 7;
            this.dgvDashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDashboard_CellContentClick);
            // 
            // btnLoginMahasiswa
            // 
            this.btnLoginMahasiswa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoginMahasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMahasiswa.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoginMahasiswa.ForeColor = System.Drawing.Color.White;
            this.btnLoginMahasiswa.Location = new System.Drawing.Point(50, 861);
            this.btnLoginMahasiswa.Name = "btnLoginMahasiswa";
            this.btnLoginMahasiswa.Size = new System.Drawing.Size(293, 65);
            this.btnLoginMahasiswa.TabIndex = 8;
            this.btnLoginMahasiswa.Text = "LOGIN MAHASISWA";
            this.btnLoginMahasiswa.UseVisualStyleBackColor = false;
            this.btnLoginMahasiswa.Click += new System.EventHandler(this.BtnLoginMahasiswa_Click);
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLoginAdmin.Location = new System.Drawing.Point(420, 861);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(283, 65);
            this.btnLoginAdmin.TabIndex = 9;
            this.btnLoginAdmin.Text = "LOGIN ADMIN";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.BtnLoginAdmin_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(816, 861);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(250, 65);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "KELUAR";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // chartKomplain
            // 
            chartArea1.AxisX.Title = "Kategori";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.Title = "Jumlah";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            chartArea1.Name = "ChartArea1";
            this.chartKomplain.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Segoe UI", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartKomplain.Legends.Add(legend1);
            this.chartKomplain.Location = new System.Drawing.Point(15, 153);
            this.chartKomplain.Name = "chartKomplain";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Jumlah Data";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Enabled = false;
            series2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            series2.IsValueShownAsLabel = true;
            series2.Label = "#PERCENT{P0}";
            series2.Legend = "Legend1";
            series2.Name = "Distribusi";
            this.chartKomplain.Series.Add(series1);
            this.chartKomplain.Series.Add(series2);
            this.chartKomplain.Size = new System.Drawing.Size(576, 363);
            this.chartKomplain.TabIndex = 0;
            this.chartKomplain.Text = "chartKomplain";
            // 
            // cmbChartType
            // 
            this.cmbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChartType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbChartType.Items.AddRange(new object[] {
            "Bar Chart",
            "Pie Chart"});
            this.cmbChartType.Location = new System.Drawing.Point(183, 9);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(150, 36);
            this.cmbChartType.TabIndex = 1;
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbChartType_SelectedIndexChanged);
            // 
            // cmbDataCategory
            // 
            this.cmbDataCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDataCategory.Items.AddRange(new object[] {
            "Jenis Saran/Komplain",
            "Kategori Sumber Daya",
            "Status"});
            this.cmbDataCategory.Location = new System.Drawing.Point(183, 57);
            this.cmbDataCategory.Name = "cmbDataCategory";
            this.cmbDataCategory.Size = new System.Drawing.Size(267, 36);
            this.cmbDataCategory.TabIndex = 2;
            this.cmbDataCategory.SelectedIndexChanged += new System.EventHandler(this.cmbDataCategory_SelectedIndexChanged);
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefreshChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshChart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshChart.ForeColor = System.Drawing.Color.White;
            this.btnRefreshChart.Location = new System.Drawing.Point(456, 11);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(124, 41);
            this.btnRefreshChart.TabIndex = 5;
            this.btnRefreshChart.Text = "REFRESH";
            this.btnRefreshChart.UseVisualStyleBackColor = false;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // panelChartControl
            // 
            this.panelChartControl.BackColor = System.Drawing.Color.White;
            this.panelChartControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChartControl.Controls.Add(this.btnLoad);
            this.panelChartControl.Controls.Add(this.lblPeriode);
            this.panelChartControl.Controls.Add(this.dtPeriode);
            this.panelChartControl.Controls.Add(this.chartKomplain);
            this.panelChartControl.Controls.Add(this.cmbChartType);
            this.panelChartControl.Controls.Add(this.cmbDataCategory);
            this.panelChartControl.Controls.Add(this.lblChartType);
            this.panelChartControl.Controls.Add(this.lblDataCategory);
            this.panelChartControl.Controls.Add(this.btnRefreshChart);
            this.panelChartControl.Location = new System.Drawing.Point(742, 320);
            this.panelChartControl.Name = "panelChartControl";
            this.panelChartControl.Size = new System.Drawing.Size(596, 521);
            this.panelChartControl.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(456, 58);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(124, 35);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeriode.Location = new System.Drawing.Point(14, 106);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(94, 28);
            this.lblPeriode.TabIndex = 7;
            this.lblPeriode.Text = "Periode :";
            // 
            // dtPeriode
            // 
            this.dtPeriode.CustomFormat = "MMMM yyyy";
            this.dtPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPeriode.Location = new System.Drawing.Point(183, 108);
            this.dtPeriode.Name = "dtPeriode";
            this.dtPeriode.ShowUpDown = true;
            this.dtPeriode.Size = new System.Drawing.Size(200, 26);
            this.dtPeriode.TabIndex = 6;
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChartType.Location = new System.Drawing.Point(10, 13);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(129, 28);
            this.lblChartType.TabIndex = 3;
            this.lblChartType.Text = "Jenis Grafik:";
            // 
            // lblDataCategory
            // 
            this.lblDataCategory.AutoSize = true;
            this.lblDataCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataCategory.Location = new System.Drawing.Point(10, 60);
            this.lblDataCategory.Name = "lblDataCategory";
            this.lblDataCategory.Size = new System.Drawing.Size(149, 28);
            this.lblDataCategory.TabIndex = 4;
            this.lblDataCategory.Text = "Kategori Data:";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 950);
            this.Controls.Add(this.panelChartControl);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTotalData);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.btnLoginMahasiswa);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.btnKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Utama - SISKOMAWA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKomplain)).EndInit();
            this.panelChartControl.ResumeLayout(false);
            this.panelChartControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Component declarations
        private System.Windows.Forms.Label lblDataCategory;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Button btnLoginMahasiswa;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKomplain;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.ComboBox cmbDataCategory;
        private System.Windows.Forms.Button btnRefreshChart;
        private System.Windows.Forms.Panel panelChartControl;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.DateTimePicker dtPeriode;
        private System.Windows.Forms.Button btnLoad;
    }
}