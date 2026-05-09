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
            this.BackColor =
                Color.WhiteSmoke;

            this.ClientSize =
                new Size(1280, 720);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Dashboard Mahasiswa";

            // =====================================
            // TITLE
            // =====================================
            lblTitle.Text =
                "DASHBOARD MAHASISWA";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            lblTitle.ForeColor =
                Color.DarkBlue;

            lblTitle.AutoSize =
                false;

            lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            lblTitle.Location =
                new Point(330, 20);

            lblTitle.Size =
                new Size(600, 50);

            // =====================================
            // LABEL KIRI
            // =====================================
            lblJenis.Text =
                "Jenis";

            lblJenis.Location =
                new Point(80, 100);

            lblJenis.AutoSize =
                true;

            lblSumberDaya.Text =
                "Sumber Daya";

            lblSumberDaya.Location =
                new Point(80, 160);

            lblSumberDaya.AutoSize =
                true;

            lblIsi.Text =
                "Isi Komplain";

            lblIsi.Location =
                new Point(80, 220);

            lblIsi.AutoSize =
                true;

            // =====================================
            // LABEL KANAN
            // =====================================
            lblNama.Text =
                "Nama";

            lblNama.Location =
                new Point(700, 100);

            lblNama.AutoSize =
                true;

            lblNim.Text =
                "NIM";

            lblNim.Location =
                new Point(700, 150);

            lblNim.AutoSize =
                true;

            lblProdi.Text =
                "Prodi";

            lblProdi.Location =
                new Point(700, 200);

            lblProdi.AutoSize =
                true;

            lblHp.Text =
                "No HP";

            lblHp.Location =
                new Point(700, 250);

            lblHp.AutoSize =
                true;

            lblEmail.Text =
                "Email";

            lblEmail.Location =
                new Point(700, 300);

            lblEmail.AutoSize =
                true;

            // =====================================
            // COMBOBOX
            // =====================================
            cmbJenis.Location =
                new Point(80, 120);

            cmbJenis.Size =
                new Size(260, 30);

            cmbJenis.FlatStyle =
                FlatStyle.Popup;

            cmbJenis.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbSumberDaya.Location =
                new Point(80, 180);

            cmbSumberDaya.Size =
                new Size(260, 30);

            cmbSumberDaya.FlatStyle =
                FlatStyle.Popup;

            cmbSumberDaya.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // =====================================
            // TEXTBOX ISI
            // =====================================
            txtIsi.Location =
                new Point(80, 240);

            txtIsi.Size =
                new Size(350, 70);

            txtIsi.Multiline =
                true;

            txtIsi.BorderStyle =
                BorderStyle.FixedSingle;

            // =====================================
            // TEXTBOX KANAN
            // =====================================
            txtNama.Location =
                new Point(780, 100);

            txtNama.Size =
                new Size(260, 30);

            txtNama.BorderStyle =
                BorderStyle.FixedSingle;

            txtNim.Location =
                new Point(780, 150);

            txtNim.Size =
                new Size(260, 30);

            txtNim.BorderStyle =
                BorderStyle.FixedSingle;

            txtProdi.Location =
                new Point(780, 200);

            txtProdi.Size =
                new Size(260, 30);

            txtProdi.BorderStyle =
                BorderStyle.FixedSingle;

            txtHp.Location =
                new Point(780, 250);

            txtHp.Size =
                new Size(260, 30);

            txtHp.BorderStyle =
                BorderStyle.FixedSingle;

            txtEmail.Location =
                new Point(780, 300);

            txtEmail.Size =
                new Size(260, 30);

            txtEmail.BorderStyle =
                BorderStyle.FixedSingle;

            // =====================================
            // BUTTON TAMBAH
            // =====================================
            btnTambah.Text =
                "Tambah";

            btnTambah.Location =
                new Point(80, 340);

            btnTambah.Size =
                new Size(120, 40);

            btnTambah.BackColor =
                Color.LimeGreen;

            btnTambah.ForeColor =
                Color.White;

            btnTambah.FlatStyle =
                FlatStyle.Flat;

            btnTambah.Click +=
                new EventHandler(
                    this.btnTambah_Click);

            // =====================================
            // BUTTON UPDATE
            // =====================================
            btnUpdate.Text =
                "Update";

            btnUpdate.Location =
                new Point(220, 340);

            btnUpdate.Size =
                new Size(120, 40);

            btnUpdate.BackColor =
                Color.DodgerBlue;

            btnUpdate.ForeColor =
                Color.White;

            btnUpdate.FlatStyle =
                FlatStyle.Flat;

            btnUpdate.Click +=
                new EventHandler(
                    this.btnUpdate_Click);

            // =====================================
            // BUTTON DELETE
            // =====================================
            btnDelete.Text =
                "Delete";

            btnDelete.Location =
                new Point(360, 340);

            btnDelete.Size =
                new Size(120, 40);

            btnDelete.BackColor =
                Color.Crimson;

            btnDelete.ForeColor =
                Color.White;

            btnDelete.FlatStyle =
                FlatStyle.Flat;

            btnDelete.Click +=
                new EventHandler(
                    this.btnDelete_Click);

            // =====================================
            // BUTTON CLEAR
            // =====================================
            btnClear.Text =
                "Clear";

            btnClear.Location =
                new Point(500, 340);

            btnClear.Size =
                new Size(120, 40);

            btnClear.BackColor =
                Color.Gray;

            btnClear.ForeColor =
                Color.White;

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.Click +=
                new EventHandler(
                    this.btnClear_Click);

            // =====================================
            // BUTTON TAMPIL
            // =====================================
            btnTampil.Text =
                "Tampil";

            btnTampil.Location =
                new Point(640, 340);

            btnTampil.Size =
                new Size(120, 40);

            btnTampil.BackColor =
                Color.Orange;

            btnTampil.ForeColor =
                Color.White;

            btnTampil.FlatStyle =
                FlatStyle.Flat;

            btnTampil.Click +=
                new EventHandler(
                    this.btnTampil_Click);

            // =====================================
            // BUTTON TEST
            // =====================================
            btnTest.Text =
                "Test";

            btnTest.Location =
                new Point(1080, 180);

            btnTest.Size =
                new Size(120, 40);

            btnTest.BackColor =
                Color.Red;

            btnTest.ForeColor =
                Color.White;

            btnTest.FlatStyle =
                FlatStyle.Flat;

            btnTest.Click +=
                new EventHandler(
                    this.btnTest_Click);

            // =====================================
            // BUTTON RESET
            // =====================================
            btnResetData.Text =
                "Reset";

            btnResetData.Location =
                new Point(1080, 120);

            btnResetData.Size =
                new Size(120, 40);

            btnResetData.BackColor =
                Color.YellowGreen;

            btnResetData.ForeColor =
                Color.White;

            btnResetData.FlatStyle =
                FlatStyle.Flat;

            btnResetData.Click +=
                new EventHandler(
                    this.btnResetData_Click);

            // =====================================
            // SEARCH
            // =====================================
            txtCari.Location =
                new Point(860, 350);

            txtCari.Size =
                new Size(220, 30);

            txtCari.BorderStyle =
                BorderStyle.FixedSingle;

            BtnCari.Text =
                "Cari";

            BtnCari.Location =
                new Point(1100, 347);

            BtnCari.Size =
                new Size(90, 35);

            BtnCari.Click +=
                new EventHandler(
                    this.BtnCari_Click);

            // =====================================
            // DATAGRIDVIEW
            // =====================================
            dgvKomplain.Location =
                new Point(40, 420);

            dgvKomplain.Size =
                new Size(1180, 240);

            dgvKomplain.BackgroundColor =
                Color.White;

            dgvKomplain.BorderStyle =
                BorderStyle.Fixed3D;

            dgvKomplain.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvKomplain.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvKomplain.RowHeadersVisible =
                false;

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
