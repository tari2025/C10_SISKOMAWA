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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMahasiswa));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblSumberDaya = new System.Windows.Forms.Label();
            this.lblIsi = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.cmbSumberDaya = new System.Windows.Forms.ComboBox();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvKomplain = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(411, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(836, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD MAHASISWA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(103, 133);
            this.lblJenis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(46, 20);
            this.lblJenis.TabIndex = 1;
            this.lblJenis.Text = "Jenis";
            // 
            // lblSumberDaya
            // 
            this.lblSumberDaya.AutoSize = true;
            this.lblSumberDaya.Location = new System.Drawing.Point(103, 213);
            this.lblSumberDaya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumberDaya.Name = "lblSumberDaya";
            this.lblSumberDaya.Size = new System.Drawing.Size(106, 20);
            this.lblSumberDaya.TabIndex = 2;
            this.lblSumberDaya.Text = "Sumber Daya";
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Location = new System.Drawing.Point(103, 293);
            this.lblIsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(94, 20);
            this.lblIsi.TabIndex = 3;
            this.lblIsi.Text = "Isi Komplain";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(926, 133);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama";
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(926, 200);
            this.lblNim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(38, 20);
            this.lblNim.TabIndex = 5;
            this.lblNim.Text = "NIM";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(926, 267);
            this.lblProdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(45, 20);
            this.lblProdi.TabIndex = 6;
            this.lblProdi.Text = "Prodi";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(926, 333);
            this.lblHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(55, 20);
            this.lblHp.TabIndex = 7;
            this.lblHp.Text = "No HP";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(926, 400);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbJenis.Location = new System.Drawing.Point(103, 160);
            this.cmbJenis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(333, 28);
            this.cmbJenis.TabIndex = 9;
            // 
            // cmbSumberDaya
            // 
            this.cmbSumberDaya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSumberDaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSumberDaya.Location = new System.Drawing.Point(103, 240);
            this.cmbSumberDaya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSumberDaya.Name = "cmbSumberDaya";
            this.cmbSumberDaya.Size = new System.Drawing.Size(333, 28);
            this.cmbSumberDaya.TabIndex = 10;
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new System.Drawing.Point(103, 320);
            this.txtIsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsi.Multiline = true;
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(449, 92);
            this.txtIsi.TabIndex = 11;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(1054, 133);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(320, 26);
            this.txtNama.TabIndex = 12;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(1054, 200);
            this.txtNim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(320, 26);
            this.txtNim.TabIndex = 13;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(1054, 267);
            this.txtProdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(320, 26);
            this.txtProdi.TabIndex = 14;
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(1054, 333);
            this.txtHp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(320, 26);
            this.txtHp.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1054, 400);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(1093, 467);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(295, 26);
            this.txtCari.TabIndex = 17;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(103, 453);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(154, 53);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(283, 453);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 53);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(463, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 53);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(643, 453);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 53);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.Orange;
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(823, 453);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(154, 53);
            this.btnTampil.TabIndex = 22;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(1414, 464);
            this.BtnCari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(116, 47);
            this.BtnCari.TabIndex = 25;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Red;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(1427, 160);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(141, 53);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.YellowGreen;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetData.ForeColor = System.Drawing.Color.White;
            this.btnResetData.Location = new System.Drawing.Point(1427, 240);
            this.btnResetData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(141, 53);
            this.btnResetData.TabIndex = 24;
            this.btnResetData.Text = "RESET";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // dgvKomplain
            // 
            this.dgvKomplain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomplain.BackgroundColor = System.Drawing.Color.White;
            this.dgvKomplain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomplain.Location = new System.Drawing.Point(51, 560);
            this.dgvKomplain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKomplain.Name = "dgvKomplain";
            this.dgvKomplain.RowHeadersVisible = false;
            this.dgvKomplain.RowHeadersWidth = 62;
            this.dgvKomplain.RowTemplate.Height = 25;
            this.dgvKomplain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomplain.Size = new System.Drawing.Size(1517, 320);
            this.dgvKomplain.TabIndex = 26;
            this.dgvKomplain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomplain_CellClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1646, 38);
            this.bindingNavigator1.TabIndex = 27;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1646, 960);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblSumberDaya);
            this.Controls.Add(this.lblIsi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbSumberDaya);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.dgvKomplain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Mahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomplain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private BindingSource bindingSource1;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
    }
}