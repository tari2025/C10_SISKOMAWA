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
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.btnLoginMahasiswa = new System.Windows.Forms.Button();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();

            this.SuspendLayout();

            // =====================================
            // pictureLogo
            // =====================================
            this.pictureLogo.Image = global::ProjekPABD.Properties.Resources.Sisko_Mawa_student_feedback_system_logo;
            this.pictureLogo.Location = new System.Drawing.Point(530, 20);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(250, 180);
            this.pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;

            // =====================================
            // lblTitle
            // =====================================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(470, 210);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SISKOMAWA";

            // =====================================
            // lblSubTitle
            // =====================================
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubTitle.Location = new System.Drawing.Point(365, 280);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(580, 30);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Sistem Informasi Saran dan Komplain Mahasiswa";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);

            // =====================================
            // dgvDashboard
            // =====================================
            this.dgvDashboard.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvDashboard.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvDashboard.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvDashboard.ColumnHeadersHeight = 40;

            this.dgvDashboard.Location =
                new System.Drawing.Point(100, 340);

            this.dgvDashboard.Name = "dgvDashboard";

            this.dgvDashboard.ReadOnly = true;

            this.dgvDashboard.RowHeadersVisible = false;

            this.dgvDashboard.RowTemplate.Height = 35;

            this.dgvDashboard.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvDashboard.Size =
                new System.Drawing.Size(1150, 260);

            this.dgvDashboard.TabIndex = 3;

            // =====================================
            // btnLoginMahasiswa
            // =====================================
            this.btnLoginMahasiswa.BackColor =
                System.Drawing.Color.RoyalBlue;

            this.btnLoginMahasiswa.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLoginMahasiswa.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);

            this.btnLoginMahasiswa.ForeColor =
                System.Drawing.Color.White;

            this.btnLoginMahasiswa.Location =
                new System.Drawing.Point(180, 650);

            this.btnLoginMahasiswa.Name =
                "btnLoginMahasiswa";

            this.btnLoginMahasiswa.Size =
                new System.Drawing.Size(280, 55);

            this.btnLoginMahasiswa.TabIndex = 4;

            this.btnLoginMahasiswa.Text =
                "LOGIN MAHASISWA";

            this.btnLoginMahasiswa.UseVisualStyleBackColor = false;

            this.btnLoginMahasiswa.Click +=
                new System.EventHandler(this.BtnLoginMahasiswa_Click);

            // =====================================
            // btnLoginAdmin
            // =====================================
            this.btnLoginAdmin.BackColor =
                System.Drawing.Color.SeaGreen;

            this.btnLoginAdmin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLoginAdmin.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);

            this.btnLoginAdmin.ForeColor =
                System.Drawing.Color.White;

            this.btnLoginAdmin.Location =
                new System.Drawing.Point(520, 650);

            this.btnLoginAdmin.Name =
                "btnLoginAdmin";

            this.btnLoginAdmin.Size =
                new System.Drawing.Size(280, 55);

            this.btnLoginAdmin.TabIndex = 5;

            this.btnLoginAdmin.Text =
                "LOGIN ADMIN";

            this.btnLoginAdmin.UseVisualStyleBackColor = false;

            this.btnLoginAdmin.Click +=
                new System.EventHandler(this.BtnLoginAdmin_Click);

            // =====================================
            // btnKeluar
            // =====================================
            this.btnKeluar.BackColor =
                System.Drawing.Color.IndianRed;

            this.btnKeluar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnKeluar.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);

            this.btnKeluar.ForeColor =
                System.Drawing.Color.White;

            this.btnKeluar.Location =
                new System.Drawing.Point(860, 650);

            this.btnKeluar.Name =
                "btnKeluar";

            this.btnKeluar.Size =
                new System.Drawing.Size(220, 55);

            this.btnKeluar.TabIndex = 6;

            this.btnKeluar.Text =
                "KELUAR";

            this.btnKeluar.UseVisualStyleBackColor = false;

            this.btnKeluar.Click +=
                new System.EventHandler(this.BtnKeluar_Click);

            // =====================================
            // FormDashboard
            // =====================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.ClientSize =
                new System.Drawing.Size(1350, 760);

            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.btnLoginMahasiswa);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.btnKeluar);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "FormDashboard";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Dashboard Utama";

            this.Load +=
                new System.EventHandler(this.FormDashboard_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Button btnLoginMahasiswa;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Button btnKeluar;
    }
}