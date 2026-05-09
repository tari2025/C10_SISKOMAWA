using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::ProjekPABD.Properties.Resources.Sisko_Mawa_student_feedback_system_logo;
            this.pictureLogo.Location = new System.Drawing.Point(242, -7);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(742, 219);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(455, 215);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SISKOMAWA";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubTitle.Location = new System.Drawing.Point(365, 280);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(481, 30);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Sistem Informasi Saran dan Komplain Mahasiswa";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCari.Location = new System.Drawing.Point(100, 320);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(300, 34);
            this.txtCari.TabIndex = 3;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(420, 318);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(76, 35);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(520, 322);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalData.Location = new System.Drawing.Point(1030, 325);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(139, 28);
            this.lblTotalData.TabIndex = 6;
            this.lblTotalData.Text = "Total Data : 0";
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDashboard.ColumnHeadersHeight = 40;
            this.dgvDashboard.Location = new System.Drawing.Point(100, 380);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.RowHeadersVisible = false;
            this.dgvDashboard.RowHeadersWidth = 62;
            this.dgvDashboard.RowTemplate.Height = 35;
            this.dgvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboard.Size = new System.Drawing.Size(1150, 220);
            this.dgvDashboard.TabIndex = 7;
            // 
            // btnLoginMahasiswa
            // 
            this.btnLoginMahasiswa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoginMahasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMahasiswa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoginMahasiswa.ForeColor = System.Drawing.Color.White;
            this.btnLoginMahasiswa.Location = new System.Drawing.Point(180, 650);
            this.btnLoginMahasiswa.Name = "btnLoginMahasiswa";
            this.btnLoginMahasiswa.Size = new System.Drawing.Size(280, 55);
            this.btnLoginMahasiswa.TabIndex = 8;
            this.btnLoginMahasiswa.Text = "LOGIN MAHASISWA";
            this.btnLoginMahasiswa.UseVisualStyleBackColor = false;
            this.btnLoginMahasiswa.Click += new System.EventHandler(this.BtnLoginMahasiswa_Click);
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLoginAdmin.Location = new System.Drawing.Point(520, 650);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(280, 55);
            this.btnLoginAdmin.TabIndex = 9;
            this.btnLoginAdmin.Text = "LOGIN ADMIN";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.BtnLoginAdmin_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(860, 650);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(220, 55);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "KELUAR";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 760);
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
            this.Text = "Dashboard Utama";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureLogo;
        private Label lblTitle;
        private Label lblSubTitle;

        private TextBox txtCari;
        private Button btnCari;
        private Button btnRefresh;
        private Label lblTotalData;

        private DataGridView dgvDashboard;

        private Button btnLoginMahasiswa;
        private Button btnLoginAdmin;
        private Button btnKeluar;
    }
}

