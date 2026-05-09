using System;
using System.Windows.Forms;

namespace ProjekPABD
{
    partial class FormMahasiswa
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

        private void InitializeComponent()
        {
            this.dgvKomplain = new System.Windows.Forms.DataGridView();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.cmbSumberDaya = new System.Windows.Forms.ComboBox();
            this.txtIsi = new System.Windows.Forms.RichTextBox();
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
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblSumber = new System.Windows.Forms.Label();
            this.lblIsi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKomplain
            // 
            this.dgvKomplain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomplain.ColumnHeadersHeight = 34;
            this.dgvKomplain.Location = new System.Drawing.Point(56, 390);
            this.dgvKomplain.Name = "dgvKomplain";
            this.dgvKomplain.ReadOnly = true;
            this.dgvKomplain.RowHeadersWidth = 62;
            this.dgvKomplain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomplain.Size = new System.Drawing.Size(1215, 250);
            this.dgvKomplain.TabIndex = 24;
            this.dgvKomplain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomplain_CellClick);
            // 
            // cmbJenis
            // 
            this.cmbJenis.Location = new System.Drawing.Point(56, 90);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(224, 28);
            this.cmbJenis.TabIndex = 9;
            // 
            // cmbSumberDaya
            // 
            this.cmbSumberDaya.Location = new System.Drawing.Point(56, 144);
            this.cmbSumberDaya.Name = "cmbSumberDaya";
            this.cmbSumberDaya.Size = new System.Drawing.Size(220, 28);
            this.cmbSumberDaya.TabIndex = 10;
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new System.Drawing.Point(56, 220);
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(245, 85);
            this.txtIsi.TabIndex = 11;
            this.txtIsi.Text = "";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(930, 55);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 26);
            this.txtNama.TabIndex = 12;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(930, 105);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(250, 26);
            this.txtNim.TabIndex = 13;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(930, 155);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(250, 26);
            this.txtProdi.TabIndex = 14;
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(930, 205);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(250, 26);
            this.txtHp.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(930, 255);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(860, 335);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(250, 26);
            this.txtCari.TabIndex = 22;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.GreenYellow;
            this.btnTambah.Location = new System.Drawing.Point(56, 330);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(120, 40);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(190, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(324, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Location = new System.Drawing.Point(458, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCari.Location = new System.Drawing.Point(1130, 330);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 35);
            this.btnCari.TabIndex = 23;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.Gold;
            this.btnTampil.Location = new System.Drawing.Point(592, 330);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(120, 40);
            this.btnTampil.TabIndex = 21;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.GreenYellow;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(295, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(631, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FORM SARAN & KOMPLAIN MAHASISWA";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(860, 60);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama";
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(860, 110);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(38, 20);
            this.lblNim.TabIndex = 5;
            this.lblNim.Text = "NIM";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(860, 160);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(45, 20);
            this.lblProdi.TabIndex = 6;
            this.lblProdi.Text = "Prodi";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(860, 210);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(55, 20);
            this.lblHp.TabIndex = 7;
            this.lblHp.Text = "No HP";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(860, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(56, 58);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(46, 20);
            this.lblJenis.TabIndex = 1;
            this.lblJenis.Text = "Jenis";
            // 
            // lblSumber
            // 
            this.lblSumber.AutoSize = true;
            this.lblSumber.Location = new System.Drawing.Point(56, 121);
            this.lblSumber.Name = "lblSumber";
            this.lblSumber.Size = new System.Drawing.Size(168, 20);
            this.lblSumber.TabIndex = 2;
            this.lblSumber.Text = "Sumber Daya Kampus";
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Location = new System.Drawing.Point(56, 190);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(94, 20);
            this.lblIsi.TabIndex = 3;
            this.lblIsi.Text = "Isi Komplain";
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblSumber);
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
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dgvKomplain);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Mahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvKomplain;

        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.ComboBox cmbSumberDaya;

        private System.Windows.Forms.RichTextBox txtIsi;

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCari;

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTampil;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblSumber;
        private System.Windows.Forms.Label lblIsi;
    }
}