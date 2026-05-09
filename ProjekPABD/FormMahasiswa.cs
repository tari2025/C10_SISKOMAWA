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

        DataTable dt =
            new DataTable();

        BindingSource bs =
            new BindingSource();

        int idSelected = 0;

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();

            // FORM LOAD
            this.Load +=
                new EventHandler(
                    FormMahasiswa_Load);
        }

        // =====================================
        // DESIGN FORM
        // =====================================
        void DesignForm()
        {
            this.BackColor =
                Color.WhiteSmoke;

            this.Font =
                new Font("Segoe UI", 10F);

            dgvKomplain.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvKomplain.BackgroundColor =
                Color.White;

            dgvKomplain.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvKomplain.RowHeadersVisible =
                false;

            // tombol warna
            btnTambah.BackColor =
                Color.LimeGreen;

            btnUpdate.BackColor =
                Color.DodgerBlue;

            btnDelete.BackColor =
                Color.Crimson;

            btnClear.BackColor =
                Color.Gray;

            btnTampil.BackColor =
                Color.Goldenrod;

            btnTest.BackColor =
                Color.Red;

            btnResetData.BackColor =
                Color.YellowGreen;

            // tulisan putih
            btnTambah.ForeColor =
                Color.White;

            btnUpdate.ForeColor =
                Color.White;

            btnDelete.ForeColor =
                Color.White;

            btnClear.ForeColor =
                Color.White;

            btnTampil.ForeColor =
                Color.White;

            btnTest.ForeColor =
                Color.White;

            btnResetData.ForeColor =
                Color.White;

            // flat
            btnTambah.FlatStyle =
                FlatStyle.Flat;

            btnUpdate.FlatStyle =
                FlatStyle.Flat;

            btnDelete.FlatStyle =
                FlatStyle.Flat;

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnTampil.FlatStyle =
                FlatStyle.Flat;

            btnTest.FlatStyle =
                FlatStyle.Flat;

            btnResetData.FlatStyle =
                FlatStyle.Flat;
        }

        // =====================================
        // FORM LOAD
        // =====================================
        private void FormMahasiswa_Load(
            object sender,
            EventArgs e)
        {
            DesignForm();

            // =========================
            // ISI COMBOBOX JENIS
            // =========================
            cmbJenis.Items.Clear();

            cmbJenis.Items.Add("saran");

            cmbJenis.Items.Add("komplain");

            // =========================
            // LOAD DATA
            // =========================
            LoadMahasiswa();

            LoadSumberDaya();

            LoadData();
        }

        // =====================================
        // LOAD DATA MAHASISWA
        // =====================================
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

        // =====================================
        // LOAD SUMBER DAYA
        // =====================================
        void LoadSumberDaya()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    "SELECT kategori FROM sumber_daya_kampus";

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

        // =====================================
        // LOAD DATAGRID
        // =====================================
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

                    WHERE s.id_mhs=@id";

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

                    bs.DataSource =
                        dt;

                    dgvKomplain.DataSource =
                        bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // TEST SQL INJECTION
        // =====================================
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
                    (
                        id_mhs,
                        id_sumber,
                        jenis,
                        isi,
                        status
                    )
                    VALUES
                    (
                        @id,
                        1,
                        'saran',
                        'HACKED SQL INJECTION',
                        'menunggu'
                    )";

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

        // =====================================
        // RESET DATA HACK
        // =====================================
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
                    "DELETE FROM saran_komplain WHERE isi='HACKED SQL INJECTION'";

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

        // =====================================
        // GRID CLICK
        // =====================================
        private void dgvKomplain_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvKomplain.Rows[e.RowIndex];

                idSelected =
                    Convert.ToInt32(
                        row.Cells[0].Value);

                cmbJenis.Text =
                    row.Cells[4].Value.ToString();

                cmbSumberDaya.Text =
                    row.Cells[5].Value.ToString();

                txtIsi.Text =
                    row.Cells[6].Value.ToString();
            }
        }

        // =====================================
        // TAMBAH
        // =====================================
        private void btnTambah_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Tombol Tambah diklik");
        }

        // =====================================
        // UPDATE
        // =====================================
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Tombol Update diklik");
        }

        // =====================================
        // DELETE
        // =====================================
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Tombol Delete diklik");
        }

        // =====================================
        // CLEAR
        // =====================================
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            txtIsi.Clear();

            txtCari.Clear();

            cmbJenis.SelectedIndex = -1;

            cmbSumberDaya.SelectedIndex = -1;
        }

        // =====================================
        // TAMPIL
        // =====================================
        private void btnTampil_Click(
            object sender,
            EventArgs e)
        {
            LoadData();
        }

        // =====================================
        // CARI
        // =====================================
        private void BtnCari_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Fitur cari aktif");
        }
    }
}