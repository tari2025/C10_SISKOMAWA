using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekPABD
{
    partial class FormMahasiswa
    {
        private IContainer components = null;

        private Label lblTitle;

        private Label lblJenis;
        private Label lblSumberDaya;
        private Label lblIsi;

        private Label lblNama;
        private Label lblNim;
        private Label lblProdi;
        private Label lblHp;
        private Label lblEmail;

        private ComboBox cmbJenis;
        private ComboBox cmbSumberDaya;

        private TextBox txtIsi;

        private TextBox txtNama;
        private TextBox txtNim;
        private TextBox txtProdi;
        private TextBox txtHp;
        private TextBox txtEmail;

        private TextBox txtCari;

        private Button btnTambah;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnTampil;
        private Button BtnCari;

        private Button btnTest;
        private Button btnResetData;

        private DataGridView dgvKomplain;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblSumberDaya = new System.Windows.Forms.Label();
            this.lblIsi = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.cmbSumberDaya = new System.Windows.Forms.ComboBox();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvKomplain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(330, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD MAHASISWA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(80, 100);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(46, 20);
            this.lblJenis.TabIndex = 1;
            this.lblJenis.Text = "Jenis";
            // 
            // lblSumberDaya
            // 
            this.lblSumberDaya.AutoSize = true;
            this.lblSumberDaya.Location = new System.Drawing.Point(80, 160);
            this.lblSumberDaya.Name = "lblSumberDaya";
            this.lblSumberDaya.Size = new System.Drawing.Size(106, 20);
            this.lblSumberDaya.TabIndex = 2;
            this.lblSumberDaya.Text = "Sumber Daya";
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Location = new System.Drawing.Point(80, 220);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(94, 20);
            this.lblIsi.TabIndex = 3;
            this.lblIsi.Text = "Isi Komplain";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(700, 100);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama";
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(700, 150);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(38, 20);
            this.lblNim.TabIndex = 5;
            this.lblNim.Text = "NIM";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(700, 200);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(45, 20);
            this.lblProdi.TabIndex = 6;
            this.lblProdi.Text = "Prodi";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(700, 250);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(55, 20);
            this.lblHp.TabIndex = 7;
            this.lblHp.Text = "No HP";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(700, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbJenis.Location = new System.Drawing.Point(80, 120);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(260, 28);
            this.cmbJenis.TabIndex = 9;
            // 
            // cmbSumberDaya
            // 
            this.cmbSumberDaya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSumberDaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSumberDaya.Location = new System.Drawing.Point(80, 180);
            this.cmbSumberDaya.Name = "cmbSumberDaya";
            this.cmbSumberDaya.Size = new System.Drawing.Size(260, 28);
            this.cmbSumberDaya.TabIndex = 10;
            // 
            // txtIsi
            // 
            this.txtIsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIsi.Location = new System.Drawing.Point(80, 240);
            this.txtIsi.Multiline = true;
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(350, 70);
            this.txtIsi.TabIndex = 11;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(780, 100);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(260, 26);
            this.txtNama.TabIndex = 12;
            // 
            // txtNim
            // 
            this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNim.Location = new System.Drawing.Point(780, 150);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(260, 26);
            this.txtNim.TabIndex = 13;
            // 
            // txtProdi
            // 
            this.txtProdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdi.Location = new System.Drawing.Point(780, 200);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(260, 26);
            this.txtProdi.TabIndex = 14;
            // 
            // txtHp
            // 
            this.txtHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHp.Location = new System.Drawing.Point(780, 250);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(260, 26);
            this.txtHp.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(780, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // txtCari
            // 
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Location = new System.Drawing.Point(860, 350);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(220, 26);
            this.txtCari.TabIndex = 17;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(80, 340);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(120, 40);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(220, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(360, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(500, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.Orange;
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(640, 340);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(120, 40);
            this.btnTampil.TabIndex = 22;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(1100, 347);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(90, 35);
            this.BtnCari.TabIndex = 25;
            this.BtnCari.Text = "Cari";
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Red;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(1080, 180);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 40);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.YellowGreen;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetData.ForeColor = System.Drawing.Color.White;
            this.btnResetData.Location = new System.Drawing.Point(1080, 120);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(120, 40);
            this.btnResetData.TabIndex = 24;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // dgvKomplain
            // 
            this.dgvKomplain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomplain.BackgroundColor = System.Drawing.Color.White;
            this.dgvKomplain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKomplain.ColumnHeadersHeight = 34;
            this.dgvKomplain.Location = new System.Drawing.Point(40, 420);
            this.dgvKomplain.Name = "dgvKomplain";
            this.dgvKomplain.RowHeadersVisible = false;
            this.dgvKomplain.RowHeadersWidth = 62;
            this.dgvKomplain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomplain.Size = new System.Drawing.Size(1180, 240);
            this.dgvKomplain.TabIndex = 26;
            this.dgvKomplain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomplain_CellClick);
            // 
            // FormMahasiswa
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblSumberDaya);
            this.Controls.Add(this.lblIsi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbSumberDaya);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.dgvKomplain);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Mahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
