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

            ((ISupportInitialize)
                (this.dgvKomplain)).BeginInit();

            this.SuspendLayout();

            // =====================================
            // FORM
            // =====================================
            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.BackColor =
                Color.WhiteSmoke;

            this.ClientSize =
                new Size(1280, 720);

            this.Name =
                "FormMahasiswa";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Dashboard Mahasiswa";

            this.Load +=
                new EventHandler(
                    this.FormMahasiswa_Load);

            // =====================================
            // TITLE
            // =====================================
            lblTitle.AutoSize =
                false;

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            lblTitle.ForeColor =
                Color.DarkBlue;

            lblTitle.Location =
                new Point(320, 20);

            lblTitle.Name =
                "lblTitle";

            lblTitle.Size =
                new Size(650, 50);

            lblTitle.Text =
                "DASHBOARD MAHASISWA";

            lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            // =====================================
            // LABEL
            // =====================================
            lblJenis.AutoSize =
                true;

            lblJenis.Location =
                new Point(80, 100);

            lblJenis.Text =
                "Jenis";

            lblSumberDaya.AutoSize =
                true;

            lblSumberDaya.Location =
                new Point(80, 160);

            lblSumberDaya.Text =
                "Sumber Daya";

            lblIsi.AutoSize =
                true;

            lblIsi.Location =
                new Point(80, 220);

            lblIsi.Text =
                "Isi Komplain";

            lblNama.AutoSize =
                true;

            lblNama.Location =
                new Point(720, 100);

            lblNama.Text =
                "Nama";

            lblNim.AutoSize =
                true;

            lblNim.Location =
                new Point(720, 150);

            lblNim.Text =
                "NIM";

            lblProdi.AutoSize =
                true;

            lblProdi.Location =
                new Point(720, 200);

            lblProdi.Text =
                "Prodi";

            lblHp.AutoSize =
                true;

            lblHp.Location =
                new Point(720, 250);

            lblHp.Text =
                "No HP";

            lblEmail.AutoSize =
                true;

            lblEmail.Location =
                new Point(720, 300);

            lblEmail.Text =
                "Email";

            // =====================================
            // COMBOBOX
            // =====================================
            cmbJenis.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbJenis.FlatStyle =
                FlatStyle.Popup;

            cmbJenis.Location =
                new Point(80, 120);

            cmbJenis.Name =
                "cmbJenis";

            cmbJenis.Size =
                new Size(260, 30);

            cmbSumberDaya.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbSumberDaya.FlatStyle =
                FlatStyle.Popup;

            cmbSumberDaya.Location =
                new Point(80, 180);

            cmbSumberDaya.Name =
                "cmbSumberDaya";

            cmbSumberDaya.Size =
                new Size(260, 30);

            // =====================================
            // TEXTBOX ISI
            // =====================================
            txtIsi.Location =
                new Point(80, 240);

            txtIsi.Multiline =
                true;

            txtIsi.Name =
                "txtIsi";

            txtIsi.Size =
                new Size(350, 70);

            // =====================================
            // TEXTBOX DATA DIRI
            // =====================================
            txtNama.Location =
                new Point(820, 100);

            txtNama.Name =
                "txtNama";

            txtNama.Size =
                new Size(250, 30);

            txtNim.Location =
                new Point(820, 150);

            txtNim.Name =
                "txtNim";

            txtNim.Size =
                new Size(250, 30);

            txtProdi.Location =
                new Point(820, 200);

            txtProdi.Name =
                "txtProdi";

            txtProdi.Size =
                new Size(250, 30);

            txtHp.Location =
                new Point(820, 250);

            txtHp.Name =
                "txtHp";

            txtHp.Size =
                new Size(250, 30);

            txtEmail.Location =
                new Point(820, 300);

            txtEmail.Name =
                "txtEmail";

            txtEmail.Size =
                new Size(250, 30);

            // =====================================
            // BUTTON TAMBAH
            // =====================================
            btnTambah.BackColor =
                Color.LimeGreen;

            btnTambah.FlatStyle =
                FlatStyle.Flat;

            btnTambah.ForeColor =
                Color.White;

            btnTambah.Location =
                new Point(80, 340);

            btnTambah.Name =
                "btnTambah";

            btnTambah.Size =
                new Size(120, 40);

            btnTambah.Text =
                "Tambah";

            btnTambah.UseVisualStyleBackColor =
                false;

            btnTambah.Click +=
                new EventHandler(
                    this.btnTambah_Click);

            // =====================================
            // BUTTON UPDATE
            // =====================================
            btnUpdate.BackColor =
                Color.DodgerBlue;

            btnUpdate.FlatStyle =
                FlatStyle.Flat;

            btnUpdate.ForeColor =
                Color.White;

            btnUpdate.Location =
                new Point(220, 340);

            btnUpdate.Name =
                "btnUpdate";

            btnUpdate.Size =
                new Size(120, 40);

            btnUpdate.Text =
                "Update";

            btnUpdate.UseVisualStyleBackColor =
                false;

            btnUpdate.Click +=
                new EventHandler(
                    this.btnUpdate_Click);

            // =====================================
            // BUTTON DELETE
            // =====================================
            btnDelete.BackColor =
                Color.Crimson;

            btnDelete.FlatStyle =
                FlatStyle.Flat;

            btnDelete.ForeColor =
                Color.White;

            btnDelete.Location =
                new Point(360, 340);

            btnDelete.Name =
                "btnDelete";

            btnDelete.Size =
                new Size(120, 40);

            btnDelete.Text =
                "Delete";

            btnDelete.UseVisualStyleBackColor =
                false;

            btnDelete.Click +=
                new EventHandler(
                    this.btnDelete_Click);

            // =====================================
            // BUTTON CLEAR
            // =====================================
            btnClear.BackColor =
                Color.Gray;

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.ForeColor =
                Color.White;

            btnClear.Location =
                new Point(500, 340);

            btnClear.Name =
                "btnClear";

            btnClear.Size =
                new Size(120, 40);

            btnClear.Text =
                "Clear";

            btnClear.UseVisualStyleBackColor =
                false;

            btnClear.Click +=
                new EventHandler(
                    this.btnClear_Click);

            // =====================================
            // BUTTON TAMPIL
            // =====================================
            btnTampil.BackColor =
                Color.Orange;

            btnTampil.FlatStyle =
                FlatStyle.Flat;

            btnTampil.ForeColor =
                Color.White;

            btnTampil.Location =
                new Point(640, 340);

            btnTampil.Name =
                "btnTampil";

            btnTampil.Size =
                new Size(120, 40);

            btnTampil.Text =
                "Tampil";

            btnTampil.UseVisualStyleBackColor =
                false;

            btnTampil.Click +=
                new EventHandler(
                    this.btnTampil_Click);

            // =====================================
            // BUTTON TEST
            // =====================================
            btnTest.BackColor =
                Color.Red;

            btnTest.FlatStyle =
                FlatStyle.Flat;

            btnTest.ForeColor =
                Color.White;

            btnTest.Location =
                new Point(1110, 120);

            btnTest.Name =
                "btnTest";

            btnTest.Size =
                new Size(110, 40);

            btnTest.Text =
                "TEST";

            btnTest.UseVisualStyleBackColor =
                false;

            btnTest.Click +=
                new EventHandler(
                    this.btnTest_Click);

            // =====================================
            // BUTTON RESET
            // =====================================
            btnResetData.BackColor =
                Color.YellowGreen;

            btnResetData.FlatStyle =
                FlatStyle.Flat;

            btnResetData.ForeColor =
                Color.White;

            btnResetData.Location =
                new Point(1110, 180);

            btnResetData.Name =
                "btnResetData";

            btnResetData.Size =
                new Size(110, 40);

            btnResetData.Text =
                "RESET";

            btnResetData.UseVisualStyleBackColor =
                false;

            btnResetData.Click +=
                new EventHandler(
                    this.btnResetData_Click);

            // =====================================
            // SEARCH
            // =====================================
            txtCari.Location =
                new Point(850, 350);

            txtCari.Name =
                "txtCari";

            txtCari.Size =
                new Size(230, 30);

            BtnCari.Location =
                new Point(1100, 348);

            BtnCari.Name =
                "BtnCari";

            BtnCari.Size =
                new Size(90, 35);

            BtnCari.Text =
                "Cari";

            BtnCari.UseVisualStyleBackColor =
                true;

            BtnCari.Click +=
                new EventHandler(
                    this.BtnCari_Click);

            // =====================================
            // DATAGRIDVIEW
            // =====================================
            dgvKomplain.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvKomplain.BackgroundColor =
                Color.White;

            dgvKomplain.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvKomplain.Location =
                new Point(40, 420);

            dgvKomplain.Name =
                "dgvKomplain";

            dgvKomplain.RowHeadersVisible =
                false;

            dgvKomplain.RowTemplate.Height =
                25;

            dgvKomplain.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvKomplain.Size =
                new Size(1180, 240);

            dgvKomplain.CellClick +=
                new DataGridViewCellEventHandler(
                    this.dgvKomplain_CellClick);

            // =====================================
            // ADD CONTROL
            // =====================================
            this.Controls.Add(lblTitle);

            this.Controls.Add(lblJenis);
            this.Controls.Add(lblSumberDaya);
            this.Controls.Add(lblIsi);

            this.Controls.Add(lblNama);
            this.Controls.Add(lblNim);
            this.Controls.Add(lblProdi);
            this.Controls.Add(lblHp);
            this.Controls.Add(lblEmail);

            this.Controls.Add(cmbJenis);
            this.Controls.Add(cmbSumberDaya);

            this.Controls.Add(txtIsi);

            this.Controls.Add(txtNama);
            this.Controls.Add(txtNim);
            this.Controls.Add(txtProdi);
            this.Controls.Add(txtHp);
            this.Controls.Add(txtEmail);

            this.Controls.Add(txtCari);

            this.Controls.Add(btnTambah);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnTampil);

            this.Controls.Add(btnTest);
            this.Controls.Add(btnResetData);

            this.Controls.Add(BtnCari);

            this.Controls.Add(dgvKomplain);

            ((ISupportInitialize)
                (this.dgvKomplain)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }
    }
}