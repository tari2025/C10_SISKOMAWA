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
            this.SuspendLayout();
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load_1);
            this.ResumeLayout(false);

        }
    }
}