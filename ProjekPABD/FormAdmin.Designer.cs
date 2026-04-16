namespace ProjekPABD
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTanggapi;
        private System.Windows.Forms.Button btnCari;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIsi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTanggapi = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();

            this.lblId = new System.Windows.Forms.Label();
            this.lblIsi = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DATA GRID
            this.dataGridView1.Location = new System.Drawing.Point(20, 280);
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // TEXTBOX
            this.txtId.Location = new System.Drawing.Point(120, 50);
            this.txtId.ReadOnly = true;

            this.txtIsi.Location = new System.Drawing.Point(120, 90);
            this.txtIsi.Multiline = true;
            this.txtIsi.Size = new System.Drawing.Size(250, 70);

            this.txtCari.Location = new System.Drawing.Point(650, 240);
            this.txtCari.Size = new System.Drawing.Size(120, 26);

            // COMBO
            this.cmbStatus.Items.AddRange(new object[] { "menunggu", "diproses", "selesai" });
            this.cmbStatus.Location = new System.Drawing.Point(120, 180);

            // BUTTONS
            this.btnUpdate.Location = new System.Drawing.Point(280, 220);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnHapus.Location = new System.Drawing.Point(400, 220);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            this.btnTanggapi.Location = new System.Drawing.Point(510, 220);
            this.btnTanggapi.Text = "Tanggapi";
            this.btnTanggapi.Click += new System.EventHandler(this.btnTanggapi_Click);

            this.btnCari.Location = new System.Drawing.Point(780, 240);
            this.btnCari.Text = "Cari";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);

            this.btnLogout.Location = new System.Drawing.Point(850, 450);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // LABEL
            this.lblId.Location = new System.Drawing.Point(20, 50);
            this.lblId.Text = "ID Saran";

            this.lblIsi.Location = new System.Drawing.Point(20, 90);
            this.lblIsi.Text = "Isi";

            this.lblStatus.Location = new System.Drawing.Point(20, 180);
            this.lblStatus.Text = "Status";

            this.lblTitle.Location = new System.Drawing.Point(250, 10);
            this.lblTitle.Text = "Dashboard Admin";

            this.lblTotal.Location = new System.Drawing.Point(650, 300);
            this.lblTotal.Text = "Total Data: 0";

            // FORM
            this.ClientSize = new System.Drawing.Size(1000, 500);

            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTanggapi);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnLogout);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIsi);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotal);

            this.Name = "FormAdmin";
            this.Text = "Form Admin";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}