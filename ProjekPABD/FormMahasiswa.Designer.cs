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

        private System.Windows.Forms.ComboBox cmbSumber;
        private System.Windows.Forms.Label lblSumber;
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
            this.SuspendLayout();
            // 
            // FormMahasiswa
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "FormMahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            this.ResumeLayout(false);

        }
    }
}