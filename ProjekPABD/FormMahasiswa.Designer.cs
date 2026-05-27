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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblJenis = new Label();
            this.lblSumberDaya = new Label();
            this.lblIsi = new Label();
            this.lblNama = new Label();
            this.lblNim = new Label();
            this.lblProdi = new Label();
            this.lblHp = new Label();
            this.lblEmail = new Label();
            this.cmbJenis = new ComboBox();
            this.cmbSumberDaya = new ComboBox();
            this.txtIsi = new TextBox();
            this.txtNama = new TextBox();
            this.txtNim = new TextBox();
            this.txtProdi = new TextBox();
            this.txtHp = new TextBox();
            this.txtEmail = new TextBox();
            this.txtCari = new TextBox();
            this.btnTambah = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.btnTampil = new Button();
            this.BtnCari = new Button();
            this.btnTest = new Button();
            this.btnResetData = new Button();
            this.dgvKomplain = new DataGridView();
            ((ISupportInitialize)(this.dgvKomplain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(250, 24);
            this.lblTitle.Text = "Form Komplain Mahasiswa";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new Point(12, 50);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new Size(85, 13);
            this.lblJenis.Text = "Jenis Komplain:";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new Point(150, 47);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new Size(200, 21);
            // 
            // lblSumberDaya
            // 
            this.lblSumberDaya.AutoSize = true;
            this.lblSumberDaya.Location = new Point(12, 80);
            this.lblSumberDaya.Name = "lblSumberDaya";
            this.lblSumberDaya.Size = new Size(80, 13);
            this.lblSumberDaya.Text = "Sumber Daya:";
            // 
            // cmbSumberDaya
            // 
            this.cmbSumberDaya.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSumberDaya.FormattingEnabled = true;
            this.cmbSumberDaya.Location = new Point(150, 77);
            this.cmbSumberDaya.Name = "cmbSumberDaya";
            this.cmbSumberDaya.Size = new Size(200, 21);
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Location = new Point(12, 110);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new Size(66, 13);
            this.lblIsi.Text = "Isi Komplain:";
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new Point(150, 107);
            this.txtIsi.Multiline = true;
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new Size(350, 60);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new Point(12, 180);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new Size(38, 13);
            this.lblNama.Text = "Nama:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new Point(150, 177);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new Size(200, 20);
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new Point(12, 210);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new Size(30, 13);
            this.lblNim.Text = "NIM:";
            // 
            // txtNim
            // 
            this.txtNim.Location = new Point(150, 207);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new Size(200, 20);
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new Point(12, 240);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new Size(36, 13);
            this.lblProdi.Text = "Prodi:";
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new Point(150, 237);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new Size(200, 20);
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new Point(12, 270);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new Size(40, 13);
            this.lblHp.Text = "No HP:";
            // 
            // txtHp
            // 
            this.txtHp.Location = new Point(150, 267);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new Size(200, 20);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(12, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(35, 13);
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(150, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 20);
            // 
            // txtCari
            // 
            this.txtCari.Location = new Point(150, 380);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new Size(200, 20);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new Point(12, 340);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new Size(75, 30);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new Point(93, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(75, 30);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(174, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(75, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(255, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(75, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new Point(425, 340);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new Size(75, 30);
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new EventHandler(this.btnTampil_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new Point(356, 378);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new Size(75, 23);
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new EventHandler(this.BtnCari_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new Point(506, 340);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new Size(75, 30);
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new Point(587, 340);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new Size(75, 30);
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Visible = false;
            // 
            // dgvKomplain
            // 
            this.dgvKomplain.AllowUserToAddRows = false;
            this.dgvKomplain.AllowUserToDeleteRows = false;
            this.dgvKomplain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomplain.Location = new Point(12, 410);
            this.dgvKomplain.Name = "dgvKomplain";
            this.dgvKomplain.ReadOnly = true;
            this.dgvKomplain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomplain.Size = new Size(800, 250);
            this.dgvKomplain.CellClick += new DataGridViewCellEventHandler(this.dgvKomplain_CellClick);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(850, 680);
            this.Controls.Add(this.dgvKomplain);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.lblIsi);
            this.Controls.Add(this.cmbSumberDaya);
            this.Controls.Add(this.lblSumberDaya);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMahasiswa";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Komplain Mahasiswa";
            this.Load += new EventHandler(this.FormMahasiswa_Load);
            ((ISupportInitialize)(this.dgvKomplain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}