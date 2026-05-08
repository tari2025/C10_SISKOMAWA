using System;
using System.Data.SqlClient;
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

            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).BeginInit();

            this.SuspendLayout();

            // =====================================
            // FORM
            // =====================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.ClientSize =
                new System.Drawing.Size(1350, 720);

            this.Name = "FormMahasiswa";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Dashboard Mahasiswa";

            this.Load +=
                new System.EventHandler(this.FormMahasiswa_Load);

            // =====================================
            // TITLE
            // =====================================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(400, 20);

            this.lblTitle.Text =
                "DASHBOARD MAHASISWA";

            // =====================================
            // LABEL DATA DIRI
            // =====================================

            this.lblNama.AutoSize = true;
            this.lblNama.Location =
                new System.Drawing.Point(760, 100);
            this.lblNama.Text = "Nama";

            this.lblNim.AutoSize = true;
            this.lblNim.Location =
                new System.Drawing.Point(760, 140);
            this.lblNim.Text = "NIM";

            this.lblProdi.AutoSize = true;
            this.lblProdi.Location =
                new System.Drawing.Point(760, 180);
            this.lblProdi.Text = "Prodi";

            this.lblHp.AutoSize = true;
            this.lblHp.Location =
                new System.Drawing.Point(760, 220);
            this.lblHp.Text = "No HP";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location =
                new System.Drawing.Point(760, 260);
            this.lblEmail.Text = "Email";

            // =====================================
            // TEXTBOX DATA DIRI
            // =====================================

            this.txtNama.Location =
                new System.Drawing.Point(830, 95);

            this.txtNama.Size =
                new System.Drawing.Size(220, 26);

            this.txtNim.Location =
                new System.Drawing.Point(830, 135);

            this.txtNim.Size =
                new System.Drawing.Size(220, 26);

            this.txtProdi.Location =
                new System.Drawing.Point(830, 175);

            this.txtProdi.Size =
                new System.Drawing.Size(220, 26);

            this.txtHp.Location =
                new System.Drawing.Point(830, 215);

            this.txtHp.Size =
                new System.Drawing.Size(220, 26);

            this.txtEmail.Location =
                new System.Drawing.Point(830, 255);

            this.txtEmail.Size =
                new System.Drawing.Size(220, 26);

            // =====================================
            // COMBO
            // =====================================

            this.cmbJenis.Location =
                new System.Drawing.Point(60, 110);

            this.cmbJenis.Size =
                new System.Drawing.Size(260, 28);

            this.cmbSumberDaya.Location =
                new System.Drawing.Point(60, 170);

            this.cmbSumberDaya.Size =
                new System.Drawing.Size(420, 28);

            // =====================================
            // ISI
            // =====================================

            this.txtIsi.Location =
                new System.Drawing.Point(60, 240);

            this.txtIsi.Size =
                new System.Drawing.Size(500, 100);

            // =====================================
            // BUTTON
            // =====================================

            this.btnTambah.Location =
                new System.Drawing.Point(600, 320);

            this.btnTambah.Size =
                new System.Drawing.Size(120, 40);

            this.btnTambah.Text =
                "Tambah";

            this.btnTambah.Click +=
                new System.EventHandler(this.btnTambah_Click);

            this.btnUpdate.Location =
                new System.Drawing.Point(740, 320);

            this.btnUpdate.Size =
                new System.Drawing.Size(120, 40);

            this.btnUpdate.Text =
                "Update";

            this.btnUpdate.Click +=
                new System.EventHandler(this.BtnUpdate_Click);

            this.btnDelete.Location =
                new System.Drawing.Point(880, 320);

            this.btnDelete.Size =
                new System.Drawing.Size(120, 40);

            this.btnDelete.Text =
                "Delete";

            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location =
                new System.Drawing.Point(1020, 320);

            this.btnClear.Size =
                new System.Drawing.Size(120, 40);

            this.btnClear.Text =
                "Clear";

            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // =====================================
            // CARI
            // =====================================

            this.txtCari.Location =
                new System.Drawing.Point(60, 370);

            this.txtCari.Size =
                new System.Drawing.Size(300, 26);

            this.btnCari.Location =
                new System.Drawing.Point(380, 365);

            this.btnCari.Size =
                new System.Drawing.Size(100, 35);

            this.btnCari.Text =
                "Cari";

            this.btnCari.Click +=
                new System.EventHandler(this.BtnCari_Click);

            this.btnTampil.Location =
                new System.Drawing.Point(500, 365);

            this.btnTampil.Size =
                new System.Drawing.Size(100, 35);

            this.btnTampil.Text =
                "Tampil";

            this.btnTampil.Click +=
                new System.EventHandler(this.btnTampil_Click);

            // =====================================
            // DATAGRID
            // =====================================

            this.dgvKomplain.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvKomplain.ColumnHeadersHeight = 34;

            this.dgvKomplain.Location =
                new System.Drawing.Point(60, 430);

            this.dgvKomplain.Name =
                "dgvKomplain";

            this.dgvKomplain.ReadOnly = true;

            this.dgvKomplain.RowHeadersWidth = 62;

            this.dgvKomplain.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvKomplain.Size =
                new System.Drawing.Size(1210, 230);

            this.dgvKomplain.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvKomplain_CellClick);

            // =====================================
            // ADD CONTROL
            // =====================================

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.lblEmail);

            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbSumberDaya);

            this.Controls.Add(this.txtIsi);

            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnTampil);

            this.Controls.Add(this.dgvKomplain);

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
    }
}