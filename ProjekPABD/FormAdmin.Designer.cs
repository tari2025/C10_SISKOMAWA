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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNIP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.buttonCari = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.buttonTanggapi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKomplain = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(61, 9);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // lblNIP
            // 
            this.lblNIP.AutoSize = true;
            this.lblNIP.Location = new System.Drawing.Point(61, 44);
            this.lblNIP.Name = "lblNIP";
            this.lblNIP.Size = new System.Drawing.Size(35, 20);
            this.lblNIP.TabIndex = 1;
            this.lblNIP.Text = "NIP";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(65, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseCompatibleTextRendering = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(61, 102);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(50, 168);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(191, 20);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data Komplain dan Saran";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(33, 489);
            this.lblCari.Name = "lblCari";
            this.lblCari.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCari.Size = new System.Drawing.Size(153, 20);
            this.lblCari.TabIndex = 6;
            this.lblCari.Text = "Cari Komplain/Saran";
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(361, 486);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 7;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(54, 438);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(119, 31);
            this.Update.TabIndex = 8;
            this.Update.TabStop = false;
            this.Update.Text = "Update";
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Update.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(379, 427);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(94, 34);
            this.btnTampil.TabIndex = 10;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // buttonTanggapi
            // 
            this.buttonTanggapi.Location = new System.Drawing.Point(517, 438);
            this.buttonTanggapi.Name = "buttonTanggapi";
            this.buttonTanggapi.Size = new System.Drawing.Size(109, 31);
            this.buttonTanggapi.TabIndex = 11;
            this.buttonTanggapi.Text = "Tanggapi";
            this.buttonTanggapi.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(590, 190);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(204, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 26);
            this.txtNama.TabIndex = 13;
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(204, 44);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(100, 26);
            this.txtNIP.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // txtKomplain
            // 
            this.txtKomplain.Location = new System.Drawing.Point(204, 110);
            this.txtKomplain.Name = "txtKomplain";
            this.txtKomplain.Size = new System.Drawing.Size(100, 26);
            this.txtKomplain.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(231, 483);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 17;
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(656, 541);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtKomplain);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonTanggapi);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNIP);
            this.Controls.Add(this.lblNama);
            this.Name = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNIP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button buttonTanggapi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKomplain;
        private System.Windows.Forms.TextBox textBox5;
    }
}