using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    partial class FormMahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.dgvKomplain =
                new System.Windows.Forms.DataGridView();

            this.bindingNavigator1 =
                new System.Windows.Forms.BindingNavigator(this.components);

            this.bindingNavigatorMoveFirstItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorMovePreviousItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorMoveNextItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorMoveLastItem =
                new System.Windows.Forms.ToolStripButton();

            this.txtNama =
                new System.Windows.Forms.TextBox();

            this.txtNim =
                new System.Windows.Forms.TextBox();

            this.txtProdi =
                new System.Windows.Forms.TextBox();

            this.txtHp =
                new System.Windows.Forms.TextBox();

            this.txtEmail =
                new System.Windows.Forms.TextBox();

            this.txtIsi =
                new System.Windows.Forms.TextBox();

            this.txtCari =
                new System.Windows.Forms.TextBox();

            this.cmbJenis =
                new System.Windows.Forms.ComboBox();

            this.cmbSumberDaya =
                new System.Windows.Forms.ComboBox();

            this.btnTambah =
                new System.Windows.Forms.Button();

            this.btnUpdate =
                new System.Windows.Forms.Button();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.btnClear =
                new System.Windows.Forms.Button();

            this.btnTampil =
                new System.Windows.Forms.Button();

            this.BtnCari =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvKomplain)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.bindingNavigator1)).BeginInit();

            this.bindingNavigator1.SuspendLayout();

            this.SuspendLayout();

            // ====================================
            // dgvKomplain
            // ====================================

            this.dgvKomplain.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvKomplain.Location =
                new System.Drawing.Point(25, 300);

            this.dgvKomplain.Name =
                "dgvKomplain";

            this.dgvKomplain.RowHeadersWidth = 51;

            this.dgvKomplain.RowTemplate.Height = 24;

            this.dgvKomplain.Size =
                new System.Drawing.Size(900, 220);

            this.dgvKomplain.TabIndex = 0;

            this.dgvKomplain.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvKomplain_CellClick);

            // ====================================
            // bindingNavigator1
            // ====================================

            this.bindingNavigator1.AddNewItem = null;

            this.bindingNavigator1.CountItem = null;

            this.bindingNavigator1.DeleteItem = null;

            this.bindingNavigator1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.bindingNavigatorMoveFirstItem,
                    this.bindingNavigatorMovePreviousItem,
                    this.bindingNavigatorMoveNextItem,
                    this.bindingNavigatorMoveLastItem
                });

            this.bindingNavigator1.Location =
                new System.Drawing.Point(0, 0);

            this.bindingNavigator1.MoveFirstItem =
                this.bindingNavigatorMoveFirstItem;

            this.bindingNavigator1.MoveLastItem =
                this.bindingNavigatorMoveLastItem;

            this.bindingNavigator1.MoveNextItem =
                this.bindingNavigatorMoveNextItem;

            this.bindingNavigator1.MovePreviousItem =
                this.bindingNavigatorMovePreviousItem;

            this.bindingNavigator1.Name =
                "bindingNavigator1";

            this.bindingNavigator1.Size =
                new System.Drawing.Size(950, 27);

            this.bindingNavigator1.TabIndex = 1;

            // ====================================
            // navigator
            // ====================================

            this.bindingNavigatorMoveFirstItem.Text = "|<";
            this.bindingNavigatorMovePreviousItem.Text = "<";
            this.bindingNavigatorMoveNextItem.Text = ">";
            this.bindingNavigatorMoveLastItem.Text = ">|";

            // ====================================
            // txtNama
            // ====================================

            this.txtNama.Location =
                new System.Drawing.Point(25, 50);

            this.txtNama.Name =
                "txtNama";

            this.txtNama.Size =
                new System.Drawing.Size(250, 22);

            // ====================================
            // txtNim
            // ====================================

            this.txtNim.Location =
                new System.Drawing.Point(300, 50);

            this.txtNim.Name =
                "txtNim";

            this.txtNim.Size =
                new System.Drawing.Size(250, 22);

            // ====================================
            // txtProdi
            // ====================================

            this.txtProdi.Location =
                new System.Drawing.Point(575, 50);

            this.txtProdi.Name =
                "txtProdi";

            this.txtProdi.Size =
                new System.Drawing.Size(250, 22);

            // ====================================
            // txtHp
            // ====================================

            this.txtHp.Location =
                new System.Drawing.Point(25, 90);

            this.txtHp.Name =
                "txtHp";

            this.txtHp.Size =
                new System.Drawing.Size(250, 22);

            // ====================================
            // txtEmail
            // ====================================

            this.txtEmail.Location =
                new System.Drawing.Point(300, 90);

            this.txtEmail.Name =
                "txtEmail";

            this.txtEmail.Size =
                new System.Drawing.Size(250, 22);

            // ====================================
            // cmbJenis
            // ====================================

            this.cmbJenis.FormattingEnabled = true;

            this.cmbJenis.Location =
                new System.Drawing.Point(575, 90);

            this.cmbJenis.Name =
                "cmbJenis";

            this.cmbJenis.Size =
                new System.Drawing.Size(250, 24);

            // ====================================
            // cmbSumberDaya
            // ====================================

            this.cmbSumberDaya.FormattingEnabled = true;

            this.cmbSumberDaya.Location =
                new System.Drawing.Point(25, 120);

            this.cmbSumberDaya.Name =
                "cmbSumberDaya";

            this.cmbSumberDaya.Size =
                new System.Drawing.Size(250, 24);

            // ====================================
            // txtIsi
            // ====================================

            this.txtIsi.Location =
                new System.Drawing.Point(25, 160);

            this.txtIsi.Multiline = true;

            this.txtIsi.Name =
                "txtIsi";

            this.txtIsi.Size =
                new System.Drawing.Size(800, 80);

            // ====================================
            // txtCari
            // ====================================

            this.txtCari.Location =
                new System.Drawing.Point(25, 250);

            this.txtCari.Name =
                "txtCari";

            this.txtCari.Size =
                new System.Drawing.Size(250, 22);

            // ====================================
            // btnTambah
            // ====================================

            this.btnTambah.Location =
                new System.Drawing.Point(25, 540);

            this.btnTambah.Name =
                "btnTambah";

            this.btnTambah.Size =
                new System.Drawing.Size(100, 40);

            this.btnTambah.Text =
                "Tambah";

            this.btnTambah.UseVisualStyleBackColor = true;

            this.btnTambah.Click +=
                new System.EventHandler(
                    this.btnTambah_Click);

            // ====================================
            // btnUpdate
            // ====================================

            this.btnUpdate.Location =
                new System.Drawing.Point(140, 540);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(100, 40);

            this.btnUpdate.Text =
                "Update";

            this.btnUpdate.UseVisualStyleBackColor = true;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // ====================================
            // btnDelete
            // ====================================

            this.btnDelete.Location =
                new System.Drawing.Point(255, 540);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(100, 40);

            this.btnDelete.Text =
                "Delete";

            this.btnDelete.UseVisualStyleBackColor = true;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // ====================================
            // btnClear
            // ====================================

            this.btnClear.Location =
                new System.Drawing.Point(370, 540);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(100, 40);

            this.btnClear.Text =
                "Clear";

            this.btnClear.UseVisualStyleBackColor = true;

            this.btnClear.Click +=
                new System.EventHandler(
                    this.btnClear_Click);

            // ====================================
            // btnTampil
            // ====================================

            this.btnTampil.Location =
                new System.Drawing.Point(485, 540);

            this.btnTampil.Name =
                "btnTampil";

            this.btnTampil.Size =
                new System.Drawing.Size(100, 40);

            this.btnTampil.Text =
                "Tampil";

            this.btnTampil.UseVisualStyleBackColor = true;

            this.btnTampil.Click +=
                new System.EventHandler(
                    this.btnTampil_Click);

            // ====================================
            // BtnCari
            // ====================================

            this.BtnCari.Location =
                new System.Drawing.Point(300, 245);

            this.BtnCari.Name =
                "BtnCari";

            this.BtnCari.Size =
                new System.Drawing.Size(100, 30);

            this.BtnCari.Text =
                "Cari";

            this.BtnCari.UseVisualStyleBackColor = true;

            this.BtnCari.Click +=
                new System.EventHandler(
                    this.BtnCari_Click);

            // ====================================
            // FORM
            // ====================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(950, 620);

            this.Controls.Add(this.dgvKomplain);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbSumberDaya);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.BtnCari);

            this.Name =
                "FormMahasiswa";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "PORTAL SARAN & KOMPLAIN MAHASISWA";

            this.Load +=
                new System.EventHandler(
                    this.FormMahasiswa_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvKomplain)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.bindingNavigator1)).EndInit();

            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKomplain;

        private System.Windows.Forms.BindingNavigator bindingNavigator1;

        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.TextBox txtCari;

        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.ComboBox cmbSumberDaya;

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button BtnCari;
    }
}