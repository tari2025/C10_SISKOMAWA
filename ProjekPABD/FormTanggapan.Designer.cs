namespace ProjekPABD
{
    partial class FormTanggapan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSaran = new System.Windows.Forms.TextBox();
            this.txtIsiTanggapan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Saran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Isi Tanggapan";
            // 
            // txtIdSaran
            // 
            this.txtIdSaran.Location = new System.Drawing.Point(200, 70);
            this.txtIdSaran.Name = "txtIdSaran";
            this.txtIdSaran.Size = new System.Drawing.Size(200, 26);
            this.txtIdSaran.TabIndex = 2;
            this.txtIdSaran.TextChanged += new System.EventHandler(this.txtIdSaran_TextChanged);
            // 
            // txtIsiTanggapan
            // 
            this.txtIsiTanggapan.Location = new System.Drawing.Point(200, 140);
            this.txtIsiTanggapan.Multiline = true;
            this.txtIsiTanggapan.Name = "txtIsiTanggapan";
            this.txtIsiTanggapan.Size = new System.Drawing.Size(300, 100);
            this.txtIsiTanggapan.TabIndex = 3;
            this.txtIsiTanggapan.TextChanged += new System.EventHandler(this.txtIsiTanggapan_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(200, 270);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 30);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(320, 270);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 30);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FormTanggapan
            // 
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSaran);
            this.Controls.Add(this.txtIsiTanggapan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Name = "FormTanggapan";
            this.Text = "Form Tanggapan";
            this.Load += new System.EventHandler(this.FormTanggapan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSaran;
        private System.Windows.Forms.TextBox txtIsiTanggapan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}