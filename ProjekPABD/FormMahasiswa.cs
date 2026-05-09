using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormMahasiswa : Form
    {
        private readonly string connectionString =
        "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        SqlCommand cmd;

        SqlDataAdapter da;

        DataSet ds;

        DataTable dt =
            new DataTable();

        BindingSource bs =
            new BindingSource();

        int idSelected = 0;

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();
        }

        // ===============================
        // DESIGN MODERN
        // ===============================
        void DesignForm()
        {
            this.BackColor =
                Color.WhiteSmoke;

            this.Font =
                new Font("Segoe UI", 10F);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            // ===============================
            // DATAGRIDVIEW
            // ===============================
            dgvKomplain.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvKomplain.BackgroundColor =
                Color.White;

            dgvKomplain.BorderStyle =
                BorderStyle.Fixed3D;

            dgvKomplain.RowHeadersVisible =
                false;

            dgvKomplain.AllowUserToAddRows =
                false;

            dgvKomplain.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // ===============================
            // BUTTON TAMBAH
            // ===============================
            btnTambah.BackColor =
                Color.LimeGreen;

            btnTambah.ForeColor =
                Color.White;

            btnTambah.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // BUTTON UPDATE
            // ===============================
            btnUpdate.BackColor =
                Color.DodgerBlue;

            btnUpdate.ForeColor =
                Color.White;

            btnUpdate.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // BUTTON DELETE
            // ===============================
            btnDelete.BackColor =
                Color.Crimson;

            btnDelete.ForeColor =
                Color.White;

            btnDelete.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // BUTTON CLEAR
            // ===============================
            btnClear.BackColor =
                Color.Gray;

            btnClear.ForeColor =
                Color.White;

            btnClear.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // BUTTON TAMPIL
            // ===============================
            btnTampil.BackColor =
                Color.Orange;

            btnTampil.ForeColor =
                Color.White;

            btnTampil.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // BUTTON TEST
            // ===============================
            btnTest.BackColor =
                Color.Red;

            btnTest.ForeColor =
                Color.White;

            btnTest.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // BUTTON RESET
            // ===============================
            btnResetData.BackColor =
                Color.YellowGreen;

            btnResetData.ForeColor =
                Color.White;

            btnResetData.FlatStyle =
                FlatStyle.Flat;

            // ===============================
            // TEXTBOX
            // ===============================
            txtNama.BorderStyle =
                BorderStyle.FixedSingle;

            txtNim.BorderStyle =
                BorderStyle.FixedSingle;

            txtProdi.BorderStyle =
                BorderStyle.FixedSingle;

            txtHp.BorderStyle =
                BorderStyle.FixedSingle;

            txtEmail.BorderStyle =
                BorderStyle.FixedSingle;

            txtIsi.BorderStyle =
                BorderStyle.FixedSingle;

            txtCari.BorderStyle =
                BorderStyle.FixedSingle;

            // ===============================
            // COMBOBOX
            // ===============================
            cmbJenis.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbJenis.FlatStyle =
                FlatStyle.Popup;

            cmbSumberDaya.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbSumberDaya.FlatStyle =
                FlatStyle.Popup;
        }

        // ===============================
        // LOAD MAHASISWA
        // ===============================
        void LoadMahasiswa()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    "SELECT * FROM mahasiswa WHERE id_mhs=@id";

                    cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idMahasiswa);

                    SqlDataReader rd =
                        cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        txtNama.Text =
                            rd["nama"].ToString();

                        txtNim.Text =
                            rd["nim"].ToString();

                        txtProdi.Text =
                            rd["prodi"].ToString();

                        txtHp.Text =
                            rd["no_hp"].ToString();

                        txtEmail.Text =
                            rd["email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // LOAD SUMBER DAYA
        // ===============================
        void LoadSumberDaya()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    "SELECT * FROM sumber_daya_kampus";

                    cmd =
                        new SqlCommand(
                            query,
                            conn);

                    SqlDataReader rd =
                        cmd.ExecuteReader();

                    cmbSumberDaya.Items.Clear();

                    while (rd.Read())
                    {
                        cmbSumberDaya.Items.Add(
                            rd["kategori"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // LOAD DATA
        // ===============================
        void LoadData()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        s.id_saran,
                        m.nim,
                        m.nama,
                        m.prodi,
                        s.jenis,
                        sk.kategori,
                        s.isi,
                        s.status,
                        ISNULL(
                            t.isi_tanggapan,
                            'Belum ada tanggapan'
                        ) AS tanggapan,
                        s.created_at

                    FROM saran_komplain s

                    JOIN mahasiswa m
                    ON s.id_mhs = m.id_mhs

                    JOIN sumber_daya_kampus sk
                    ON s.id_sumber = sk.id_sumber

                    LEFT JOIN tanggapan t
                    ON s.id_saran = t.id_saran

                    WHERE s.id_mhs = @id";

                    cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idMahasiswa);

                    da =
                        new SqlDataAdapter(cmd);

                    dt.Clear();

                    da.Fill(dt);

                    bs.DataSource = dt;

                    dgvKomplain.DataSource = bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // FORM LOAD
        // ===============================
        private void FormMahasiswa_Load(
            object sender,
            EventArgs e)
        {
            DesignForm();

            cmbJenis.Items.Add("saran");

            cmbJenis.Items.Add("komplain");

            LoadMahasiswa();

            LoadSumberDaya();

            LoadData();
        }

        // ===============================
        // TEST SQL INJECTION
        // ===============================
        private void btnTest_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO saran_komplain
                    (id_mhs,id_sumber,jenis,isi,status)
                    VALUES
                    (@id,1,'HACKED',
                    'SQL Injection berhasil',
                    'HACKED')";

                    cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idMahasiswa);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Simulasi hack berhasil!");

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // RESET DATA HACK
        // ===============================
        private void btnResetData_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    "DELETE FROM saran_komplain WHERE status='HACKED'";

                    cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Data hack berhasil direset!");

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}