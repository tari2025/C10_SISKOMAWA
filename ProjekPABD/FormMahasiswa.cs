using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        string connectionString =
        "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();

            conn =
                new SqlConnection(connectionString);
        }

        // =====================================
        // LOAD FORM
        // =====================================
        private void FormMahasiswa_Load(
            object sender,
            EventArgs e)
        {
            LoadCombo();

            LoadMahasiswa();

            LoadData();
        }

        // =====================================
        // LOAD COMBOBOX
        // =====================================
        private void LoadCombo()
        {
            cmbJenis.Items.Clear();

            cmbJenis.Items.Add("saran");
            cmbJenis.Items.Add("komplain");

            cmbSumberDaya.Items.Clear();

            cmbSumberDaya.Items.Add("Infrastruktur");
            cmbSumberDaya.Items.Add("Fasilitas Akademik");
            cmbSumberDaya.Items.Add("Kemahasiswaan");
        }

        // =====================================
        // LOAD DATA GRID
        // =====================================
        private void LoadData()
        {
            try
            {
                conn.Open();

                string query = @"
                SELECT
                    sk.id_saran,
                    m.nim,
                    m.nama,
                    m.prodi,
                    sk.jenis,
                    sdk.kategori,
                    sk.isi,
                    sk.status,
                    sk.tanggapan,
                    sk.created_at
                FROM saran_komplain sk
                JOIN mahasiswa m
                    ON sk.id_mhs = m.id_mhs
                JOIN sumber_daya_kampus sdk
                    ON sk.id_sumber = sdk.id_sumber";

                da =
                    new SqlDataAdapter(
                        query,
                        conn);

                dt =
                    new DataTable();

                da.Fill(dt);

                dgvKomplain.DataSource =
                    dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // LOAD DATA MAHASISWA
        // =====================================
        private void LoadMahasiswa()
        {
            try
            {
                conn.Open();

                string query = @"
                SELECT *
                FROM mahasiswa
                WHERE id_mhs=@id";

                cmd =
                    new SqlCommand(
                        query,
                        conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idMahasiswa);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNama.Text =
                        dr["nama"].ToString();

                    txtNim.Text =
                        dr["nim"].ToString();

                    txtProdi.Text =
                        dr["prodi"].ToString();

                    txtNoHP.Text =
                        dr["no_HP"].ToString();

                    txtEmail.Text =
                        dr["email"].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // TAMBAH DATA
        // =====================================
        private void btnTambah_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string querySumber =
                    "SELECT id_sumber FROM sumber_daya_kampus " +
                    "WHERE kategori=@kategori";

                    SqlCommand cmdSumber =
                        new SqlCommand(
                            querySumber,
                            conn);

                    cmdSumber.Parameters.AddWithValue(
                        "@kategori",
                        cmbSumberDaya.Text);

                    int idSumber =
                        Convert.ToInt32(
                            cmdSumber.ExecuteScalar());

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
                        @id_mhs,
                        @id_sumber,
                        @jenis,
                        @isi,
                        'menunggu'
                    )";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@id_mhs",
                        idMahasiswa);

                    cmd.Parameters.AddWithValue(
                        "@id_sumber",
                        idSumber);

                    cmd.Parameters.AddWithValue(
                        "@jenis",
                        cmbJenis.Text);

                    cmd.Parameters.AddWithValue(
                        "@isi",
                        txtIsi.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Data berhasil ditambah!");

                    LoadData();
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

                    string query =
                        "UPDATE mahasiswa " +
                        "SET nama='HACKED' " +
                        "WHERE nim = '" +
                        txtNim.Text + "'";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            conn);

                    int result =
                        cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        result + " baris terupdate");
                }

                LoadMahasiswa();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // RESET DATA
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

                    string query = @"
                    IF OBJECT_ID('dbo.Mahasiswa_Backup') IS NOT NULL
                    BEGIN
                        DELETE FROM dbo.mahasiswa;

                        INSERT INTO dbo.mahasiswa
                        SELECT * FROM dbo.Mahasiswa_Backup;
                    END";

                    using (SqlCommand cmd =
                        new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data berhasil direset");

                LoadMahasiswa();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Reset gagal: " + ex.Message);
            }
        }

        // =====================================
        // CLEAR
        // =====================================
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            cmbJenis.SelectedIndex = -1;

            cmbSumberDaya.SelectedIndex = -1;

            txtIsi.Clear();
        }

        // =====================================
        // CARI
        // =====================================
        private void BtnCari_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DataView dv =
                    dt.DefaultView;

                dv.RowFilter =
                    "isi LIKE '%" +
                    txtCari.Text +
                    "%'";

                dgvKomplain.DataSource =
                    dv;
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

                cmbJenis.Text =
                    row.Cells["jenis"].Value.ToString();

                cmbSumberDaya.Text =
                    row.Cells["kategori"].Value.ToString();

                txtIsi.Text =
                    row.Cells["isi"].Value.ToString();
            }
        }

        // =====================================
        // UPDATE
        // =====================================
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Fitur update aktif");
        }

        // =====================================
        // DELETE
        // =====================================
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Fitur delete aktif");
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
    }
}