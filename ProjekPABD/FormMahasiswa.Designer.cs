namespace ProjekPABD
{
    partial class FormMahasiswa
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtIdMhs;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCari;

        private System.Windows.Forms.ComboBox cmbJenis;

        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnCari;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblId, lblJenis, lblIsi;
        private System.Windows.Forms.Label lblNama, lblNim, lblProdi, lblNoHp, lblEmail, lblWelcome, lblCari;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIdMhs = new System.Windows.Forms.TextBox();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblIsi = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdMhs
            // 
            this.txtIdMhs.Location = new System.Drawing.Point(120, 40);
            this.txtIdMhs.Name = "txtIdMhs";
            this.txtIdMhs.Size = new System.Drawing.Size(100, 26);
            this.txtIdMhs.TabIndex = 0;
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new System.Drawing.Point(120, 120);
            this.txtIsi.Multiline = true;
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(200, 80);
            this.txtIsi.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(380, 40);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(100, 26);
            this.txtNama.TabIndex = 2;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(380, 70);
            this.txtNim.Name = "txtNim";
            this.txtNim.ReadOnly = true;
            this.txtNim.Size = new System.Drawing.Size(100, 26);
            this.txtNim.TabIndex = 3;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(380, 100);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.ReadOnly = true;
            this.txtProdi.Size = new System.Drawing.Size(100, 26);
            this.txtProdi.TabIndex = 4;
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(380, 130);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.ReadOnly = true;
            this.txtNoHp.Size = new System.Drawing.Size(100, 26);
            this.txtNoHp.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(380, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(513, 189);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 26);
            this.txtCari.TabIndex = 12;
            // 
            // cmbJenis
            // 
            this.cmbJenis.Location = new System.Drawing.Point(120, 80);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(121, 28);
            this.cmbJenis.TabIndex = 7;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(20, 220);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 8;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(110, 220);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 9;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.Click += new System.EventHandler(this.btnLihatTanggapan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(200, 220);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(290, 220);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(639, 192);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 13;
            this.btnCari.Text = "Cari";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
           
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(20, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(600, 180);
            this.dataGridView1.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(20, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "ID";
            // 
            // lblJenis
            // 
            this.lblJenis.Location = new System.Drawing.Point(20, 80);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(100, 23);
            this.lblJenis.TabIndex = 17;
            this.lblJenis.Text = "Jenis";
            // 
            // lblIsi
            // 
            this.lblIsi.Location = new System.Drawing.Point(20, 120);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(100, 23);
            this.lblIsi.TabIndex = 18;
            this.lblIsi.Text = "Isi";
            // 
            // lblNama
            // 
            this.lblNama.Location = new System.Drawing.Point(300, 40);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(100, 23);
            this.lblNama.TabIndex = 19;
            this.lblNama.Text = "Nama";
            // 
            // lblNim
            // 
            this.lblNim.Location = new System.Drawing.Point(300, 70);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(100, 23);
            this.lblNim.TabIndex = 20;
            this.lblNim.Text = "NIM";
            // 
            // lblProdi
            // 
            this.lblProdi.Location = new System.Drawing.Point(300, 100);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(100, 23);
            this.lblProdi.TabIndex = 21;
            this.lblProdi.Text = "Prodi";
            // 
            // lblNoHp
            // 
            this.lblNoHp.Location = new System.Drawing.Point(300, 130);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(100, 23);
            this.lblNoHp.TabIndex = 22;
            this.lblNoHp.Text = "No HP";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(300, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(200, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(100, 23);
            this.lblWelcome.TabIndex = 24;
            this.lblWelcome.Text = "Sistem Saran Mahasiswa";
            // 
            // lblCari
            // 
            this.lblCari.Location = new System.Drawing.Point(509, 133);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(100, 23);
            this.lblCari.TabIndex = 14;
            this.lblCari.Text = "Cari";
            // 
            // FormMahasiswa
            // 
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.txtIdMhs);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblIsi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblNoHp);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormMahasiswa";
            this.Text = "Form Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}