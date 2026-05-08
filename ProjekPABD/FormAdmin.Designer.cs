namespace ProjekPABD
{
    partial class FormAdmin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.txtTanggapan = new System.Windows.Forms.RichTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTanggapan = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();

            this.SuspendLayout();

            // ===============================
            // FORM
            // ===============================
            this.ClientSize =
                new System.Drawing.Size(1000, 650);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Dashboard Admin";

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            // ===============================
            // TITLE
            // ===============================
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(320, 20);

            this.lblTitle.Text =
                "DASHBOARD ADMIN";

            // ===============================
            // DATAGRID
            // ===============================
            this.dgvAdmin.Location =
                new System.Drawing.Point(20, 80);

            this.dgvAdmin.Size =
                new System.Drawing.Size(950, 300);

            this.dgvAdmin.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvAdmin.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvAdmin.ReadOnly = true;

            this.dgvAdmin.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);

            // ===============================
            // STATUS
            // ===============================
            this.lblStatus.AutoSize = true;

            this.lblStatus.Location =
                new System.Drawing.Point(40, 420);

            this.lblStatus.Text =
                "Status";

            this.cmbStatus.Location =
                new System.Drawing.Point(120, 415);

            this.cmbStatus.Size =
                new System.Drawing.Size(180, 28);

            // ===============================
            // TANGGAPAN
            // ===============================
            this.lblTanggapan.AutoSize = true;

            this.lblTanggapan.Location =
                new System.Drawing.Point(40, 470);

            this.lblTanggapan.Text =
                "Tanggapan";

            this.txtTanggapan.Location =
                new System.Drawing.Point(120, 470);

            this.txtTanggapan.Size =
                new System.Drawing.Size(400, 100);

            // ===============================
            // BUTTON SIMPAN
            // ===============================
            this.btnSimpan.Location =
                new System.Drawing.Point(600, 420);

            this.btnSimpan.Size =
                new System.Drawing.Size(120, 40);

            this.btnSimpan.Text =
                "Simpan";

            this.btnSimpan.Click +=
                new System.EventHandler(this.btnSimpan_Click);

            // ===============================
            // BUTTON RESET
            // ===============================
            this.btnReset.Location =
                new System.Drawing.Point(600, 480);

            this.btnReset.Size =
                new System.Drawing.Size(120, 40);

            this.btnReset.Text =
                "Reset";

            this.btnReset.Click +=
                new System.EventHandler(this.btnReset_Click);

            // ===============================
            // BUTTON KELUAR
            // ===============================
            this.btnKeluar.Location =
                new System.Drawing.Point(600, 540);

            this.btnKeluar.Size =
                new System.Drawing.Size(120, 40);

            this.btnKeluar.Text =
                "Keluar";

            this.btnKeluar.Click +=
                new System.EventHandler(this.btnKeluar_Click);

            // ===============================
            // ADD CONTROLS
            // ===============================
            this.Controls.Add(this.dgvAdmin);

            this.Controls.Add(this.txtTanggapan);

            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKeluar);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTanggapan);

            this.Load +=
                new System.EventHandler(this.FormAdmin_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvAdmin;

        private System.Windows.Forms.RichTextBox txtTanggapan;

        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKeluar;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTanggapan;
    }
}