namespace ProjekPABD
{
    partial class FormMahasiswa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblTitle = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.cmbSumberDaya = new System.Windows.Forms.ComboBox();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnTampil = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnResetData = new System.Windows.Forms.Button();
            this.dgvKomplain = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNavFirst = new System.Windows.Forms.ToolStripButton();
            this.btnNavPrev = new System.Windows.Forms.ToolStripButton();
            this.lblNavPos = new System.Windows.Forms.ToolStripLabel();
            this.btnNavNext = new System.Windows.Forms.ToolStripButton();
            this.btnNavLast = new System.Windows.Forms.ToolStripButton();
            this.lblNavCount = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Navy;
            this.LblTitle.Location = new System.Drawing.Point(270, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(477, 48);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "DASHBOARD MAHASISWA";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // cmbJenis
            // 
            this.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbJenis.Location = new System.Drawing.Point(20, 82);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(200, 33);
            this.cmbJenis.TabIndex = 11;
            // 
            // cmbSumberDaya
            // 
            this.cmbSumberDaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSumberDaya.Location = new System.Drawing.Point(20, 132);
            this.cmbSumberDaya.Name = "cmbSumberDaya";
            this.cmbSumberDaya.Size = new System.Drawing.Size(200, 33);
            this.cmbSumberDaya.TabIndex = 12;
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new System.Drawing.Point(20, 182);
            this.txtIsi.Multiline = true;
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(460, 80);
            this.txtIsi.TabIndex = 13;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNama.Location = new System.Drawing.Point(600, 82);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = false;
            this.txtNama.Size = new System.Drawing.Size(220, 31);
            this.txtNama.TabIndex = 14;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(600, 127);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(220, 31);
            this.txtNim.TabIndex = 15;
            // 
            // txtProdi
            // 
            this.txtProdi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtProdi.Location = new System.Drawing.Point(600, 172);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.ReadOnly = false;
            this.txtProdi.Size = new System.Drawing.Size(220, 31);
            this.txtProdi.TabIndex = 16;
            this.txtProdi.TextChanged += new System.EventHandler(this.txtProdi_TextChanged);
            // 
            // txtHp
            // 
            this.txtHp.BackColor = System.Drawing.Color.AliceBlue;
            this.txtHp.Location = new System.Drawing.Point(600, 217);
            this.txtHp.Name = "txtHp";
            this.txtHp.ReadOnly = false;
            this.txtHp.Size = new System.Drawing.Size(220, 31);
            this.txtHp.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEmail.Location = new System.Drawing.Point(600, 262);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(220, 31);
            this.txtEmail.TabIndex = 18;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(600, 310);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(155, 31);
            this.txtCari.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jenis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sumber Daya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Isi Komplain / Saran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "NIM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prodi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "No HP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(520, 295);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(122, 25);
            this.lblCari.TabIndex = 9;
            this.lblCari.Text = "Cari Komplain";
            // 
            // BtnTambah
            // 
            this.BtnTambah.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTambah.ForeColor = System.Drawing.Color.White;
            this.BtnTambah.Location = new System.Drawing.Point(20, 280);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(90, 35);
            this.BtnTambah.TabIndex = 20;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = false;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(120, 280);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(90, 35);
            this.BtnUpdate.TabIndex = 21;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(220, 280);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 35);
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Gray;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(320, 280);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(90, 35);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // BtnTampil
            // 
            this.BtnTampil.BackColor = System.Drawing.Color.Orange;
            this.BtnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTampil.ForeColor = System.Drawing.Color.White;
            this.BtnTampil.Location = new System.Drawing.Point(840, 308);
            this.BtnTampil.Name = "BtnTampil";
            this.BtnTampil.Size = new System.Drawing.Size(100, 28);
            this.BtnTampil.TabIndex = 24;
            this.BtnTampil.Text = "Tampil Semua";
            this.BtnTampil.UseVisualStyleBackColor = false;
            this.BtnTampil.Click += new System.EventHandler(this.BtnTampil_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCari.ForeColor = System.Drawing.Color.White;
            this.BtnCari.Location = new System.Drawing.Point(762, 308);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(70, 28);
            this.BtnCari.TabIndex = 25;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = false;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.BackColor = System.Drawing.Color.Red;
            this.BtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTest.ForeColor = System.Drawing.Color.White;
            this.BtnTest.Location = new System.Drawing.Point(830, 65);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(120, 35);
            this.BtnTest.TabIndex = 26;
            this.BtnTest.Text = "TES";
            this.BtnTest.UseVisualStyleBackColor = false;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnResetData
            // 
            this.BtnResetData.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetData.ForeColor = System.Drawing.Color.White;
            this.BtnResetData.Location = new System.Drawing.Point(830, 108);
            this.BtnResetData.Name = "BtnResetData";
            this.BtnResetData.Size = new System.Drawing.Size(120, 35);
            this.BtnResetData.TabIndex = 27;
            this.BtnResetData.Text = "Reset Data";
            this.BtnResetData.UseVisualStyleBackColor = false;
            this.BtnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            // 
            // dgvKomplain
            // 
            this.dgvKomplain.AllowUserToAddRows = false;
            this.dgvKomplain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomplain.BackgroundColor = System.Drawing.Color.White;
            this.dgvKomplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKomplain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomplain.Location = new System.Drawing.Point(20, 355);
            this.dgvKomplain.MultiSelect = false;
            this.dgvKomplain.Name = "dgvKomplain";
            this.dgvKomplain.ReadOnly = true;
            this.dgvKomplain.RowHeadersVisible = false;
            this.dgvKomplain.RowHeadersWidth = 62;
            this.dgvKomplain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomplain.Size = new System.Drawing.Size(930, 260);
            this.dgvKomplain.TabIndex = 28;
            this.dgvKomplain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKomplain_CellClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bindingNavigator1.CountItem = this.lblNavCount;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ForeColor = System.Drawing.Color.White;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNavFirst,
            this.btnNavPrev,
            this.lblNavPos,
            this.lblNavCount,
            this.btnNavNext,
            this.btnNavLast});
            this.bindingNavigator1.Location = new System.Drawing.Point(20, 622);
            this.bindingNavigator1.MoveFirstItem = this.btnNavFirst;
            this.bindingNavigator1.MoveLastItem = this.btnNavLast;
            this.bindingNavigator1.MoveNextItem = this.btnNavNext;
            this.bindingNavigator1.MovePreviousItem = this.btnNavPrev;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.lblNavPos;
            this.bindingNavigator1.Size = new System.Drawing.Size(246, 34);
            this.bindingNavigator1.TabIndex = 29;
            // 
            // btnNavFirst
            // 
            this.btnNavFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNavFirst.Name = "btnNavFirst";
            this.btnNavFirst.Size = new System.Drawing.Size(36, 29);
            this.btnNavFirst.Text = "|◀";
            this.btnNavFirst.ToolTipText = "Data Pertama";
            // 
            // btnNavPrev
            // 
            this.btnNavPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNavPrev.Name = "btnNavPrev";
            this.btnNavPrev.Size = new System.Drawing.Size(34, 29);
            this.btnNavPrev.Text = "◀";
            this.btnNavPrev.ToolTipText = "Data Sebelumnya";
            // 
            // lblNavPos
            // 
            this.lblNavPos.Name = "lblNavPos";
            this.lblNavPos.Size = new System.Drawing.Size(22, 29);
            this.lblNavPos.Text = "0";
            // 
            // btnNavNext
            // 
            this.btnNavNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNavNext.Name = "btnNavNext";
            this.btnNavNext.Size = new System.Drawing.Size(34, 29);
            this.btnNavNext.Text = "▶";
            this.btnNavNext.ToolTipText = "Data Berikutnya";
            // 
            // btnNavLast
            // 
            this.btnNavLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNavLast.Name = "btnNavLast";
            this.btnNavLast.Size = new System.Drawing.Size(36, 29);
            this.btnNavLast.Text = "▶|";
            this.btnNavLast.ToolTipText = "Data Terakhir";
            // 
            // lblNavCount
            // 
            this.lblNavCount.Name = "lblNavCount";
            this.lblNavCount.Size = new System.Drawing.Size(54, 29);
            this.lblNavCount.Text = "of {0}";
            // 
            // FormMahasiswa
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbSumberDaya);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnTampil);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnResetData);
            this.Controls.Add(this.dgvKomplain);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Mahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.Label label4, label5, label6, label7, label8;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.ComboBox cmbSumberDaya;
        private System.Windows.Forms.TextBox txtIsi, txtNama, txtNim;
        private System.Windows.Forms.TextBox txtProdi, txtHp, txtEmail, txtCari;
        private System.Windows.Forms.Button BtnTambah, BtnUpdate, BtnDelete;
        private System.Windows.Forms.Button BtnClear, BtnTampil, BtnCari;
        private System.Windows.Forms.Button BtnTest, BtnResetData;
        private System.Windows.Forms.DataGridView dgvKomplain;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnNavFirst;
        private System.Windows.Forms.ToolStripButton btnNavPrev;
        private System.Windows.Forms.ToolStripLabel lblNavPos;
        private System.Windows.Forms.ToolStripButton btnNavNext;
        private System.Windows.Forms.ToolStripButton btnNavLast;
        private System.Windows.Forms.ToolStripLabel lblNavCount;
    }
}