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

            this.txtCari = new System.Windows.Forms.TextBox();

            this.btnCari = new System.Windows.Forms.Button();

            this.btnRefresh = new System.Windows.Forms.Button();

            this.txtTanggapan =
                new System.Windows.Forms.RichTextBox();

            this.cmbStatus =
                new System.Windows.Forms.ComboBox();

            this.btnSimpan =
                new System.Windows.Forms.Button();

            this.btnReset =
                new System.Windows.Forms.Button();

            this.btnKeluar =
                new System.Windows.Forms.Button();

            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblStatus =
                new System.Windows.Forms.Label();

            this.lblTanggapan =
                new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();

            this.SuspendLayout();

            // =====================================
            // FORM
            // =====================================
            this.ClientSize =
                new System.Drawing.Size(1200, 720);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Dashboard Admin";

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            // =====================================
            // TITLE
            // =====================================
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.MidnightBlue;

            this.lblTitle.Location =
                new System.Drawing.Point(420, 20);

            this.lblTitle.Text =
                "DASHBOARD ADMIN";

            // =====================================
            // txtCari
            // =====================================
            this.txtCari.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtCari.Location =
                new System.Drawing.Point(40, 90);

            this.txtCari.Name =
                "txtCari";

            this.txtCari.Size =
                new System.Drawing.Size(280, 34);

            // =====================================
            // btnCari
            // =====================================
            this.btnCari.BackColor =
                System.Drawing.Color.DodgerBlue;

            this.btnCari.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCari.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnCari.ForeColor =
                System.Drawing.Color.White;

            this.btnCari.Location =
                new System.Drawing.Point(340, 88);

            this.btnCari.Name =
                "btnCari";

            this.btnCari.Size =
                new System.Drawing.Size(120, 40);

            this.btnCari.Text =
                "CARI";

            this.btnCari.UseVisualStyleBackColor = false;

            this.btnCari.Click +=
                new System.EventHandler(this.BtnCari_Click);

            // =====================================
            // btnRefresh
            // =====================================
            this.btnRefresh.BackColor =
                System.Drawing.Color.DarkOrange;

            this.btnRefresh.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnRefresh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnRefresh.ForeColor =
                System.Drawing.Color.White;

            this.btnRefresh.Location =
                new System.Drawing.Point(480, 88);

            this.btnRefresh.Name =
                "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(140, 40);

            this.btnRefresh.Text =
                "REFRESH";

            this.btnRefresh.UseVisualStyleBackColor = false;

            this.btnRefresh.Click +=
                new System.EventHandler(this.BtnRefresh_Click);

            // =====================================
            // DATAGRID
            // =====================================
            this.dgvAdmin.Location =
                new System.Drawing.Point(40, 150);

            this.dgvAdmin.Name =
                "dgvAdmin";

            this.dgvAdmin.Size =
                new System.Drawing.Size(1100, 300);

            this.dgvAdmin.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvAdmin.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvAdmin.ReadOnly = true;

            this.dgvAdmin.RowHeadersVisible = false;

            this.dgvAdmin.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAdmin_CellClick);

            // =====================================
            // STATUS
            // =====================================
            this.lblStatus.AutoSize = true;

            this.lblStatus.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblStatus.Location =
                new System.Drawing.Point(40, 490);

            this.lblStatus.Text =
                "Status";

            this.cmbStatus.Location =
                new System.Drawing.Point(140, 485);

            this.cmbStatus.Name =
                "cmbStatus";

            this.cmbStatus.Size =
                new System.Drawing.Size(220, 28);

            // =====================================
            // TANGGAPAN
            // =====================================
            this.lblTanggapan.AutoSize = true;

            this.lblTanggapan.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblTanggapan.Location =
                new System.Drawing.Point(40, 540);

            this.lblTanggapan.Text =
                "Tanggapan";

            this.txtTanggapan.Location =
                new System.Drawing.Point(140, 540);

            this.txtTanggapan.Name =
                "txtTanggapan";

            this.txtTanggapan.Size =
                new System.Drawing.Size(500, 120);

            // =====================================
            // BUTTON SIMPAN
            // =====================================
            this.btnSimpan.BackColor =
                System.Drawing.Color.SeaGreen;

            this.btnSimpan.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSimpan.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnSimpan.ForeColor =
                System.Drawing.Color.White;

            this.btnSimpan.Location =
                new System.Drawing.Point(760, 500);

            this.btnSimpan.Name =
                "btnSimpan";

            this.btnSimpan.Size =
                new System.Drawing.Size(180, 50);

            this.btnSimpan.Text =
                "SIMPAN";

            this.btnSimpan.UseVisualStyleBackColor = false;

            this.btnSimpan.Click +=
                new System.EventHandler(this.BtnSimpan_Click);

            // =====================================
            // BUTTON RESET
            // =====================================
            this.btnReset.BackColor =
                System.Drawing.Color.Gray;

            this.btnReset.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnReset.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnReset.ForeColor =
                System.Drawing.Color.White;

            this.btnReset.Location =
                new System.Drawing.Point(760, 570);

            this.btnReset.Name =
                "btnReset";

            this.btnReset.Size =
                new System.Drawing.Size(180, 50);

            this.btnReset.Text =
                "RESET";

            this.btnReset.UseVisualStyleBackColor = false;

            this.btnReset.Click +=
                new System.EventHandler(this.BtnReset_Click);

            // =====================================
            // BUTTON KELUAR
            // =====================================
            this.btnKeluar.BackColor =
                System.Drawing.Color.IndianRed;

            this.btnKeluar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnKeluar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnKeluar.ForeColor =
                System.Drawing.Color.White;

            this.btnKeluar.Location =
                new System.Drawing.Point(760, 640);

            this.btnKeluar.Name =
                "btnKeluar";

            this.btnKeluar.Size =
                new System.Drawing.Size(180, 50);

            this.btnKeluar.Text =
                "KELUAR";

            this.btnKeluar.UseVisualStyleBackColor = false;

            this.btnKeluar.Click +=
                new System.EventHandler(this.BtnKeluar_Click);

            // =====================================
            // ADD CONTROLS
            // =====================================
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefresh);

            this.Controls.Add(this.dgvAdmin);

            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.lblTanggapan);
            this.Controls.Add(this.txtTanggapan);

            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKeluar);

            this.Load +=
                new System.EventHandler(this.FormAdmin_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvAdmin;

        private System.Windows.Forms.TextBox txtCari;

        private System.Windows.Forms.Button btnCari;

        private System.Windows.Forms.Button btnRefresh;

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