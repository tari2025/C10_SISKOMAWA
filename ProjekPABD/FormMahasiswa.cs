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

        int idSelected = 0;

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();

            conn =
                new SqlConnection(connectionString);
        }

        // =====================================
        // FORM LOAD
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

            try
            {
                conn.Open();

                string query =
                "SELECT kategori FROM sumber_daya_kampus";

                cmd =
                    new SqlCommand(
                        query,
                        conn);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbSumberDaya.Items.Add(
                        dr["kategori"].ToString());
                }

                dr.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    sk.created_at
                FROM saran_komplain sk
                JOIN mahasiswa m
                    ON sk.id_mhs = m.id_mhs
                JOIN sumber_daya_kampus sdk
                    ON sk.id_sumber = sdk.id_sumber
                WHERE m.id_mhs = @id_mhs";

                da =
                    new SqlDataAdapter(
                        query,
                        conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@id_mhs",
                    idMahasiswa);

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

                string query =
                "SELECT * FROM mahasiswa WHERE id_mhs=@id";

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

                    txtHp.Text =
                        dr["no_hp"].ToString();

                    txtEmail.Text =
                        dr["email"].ToString();
                }

                dr.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // TEST KONEKSI
        // =====================================
        private void btnTesKoneksi_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    MessageBox.Show(
                        "Koneksi berhasil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Koneksi gagal : " +
                    ex.Message);
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
        // UPDATE DATA
        // =====================================
        private void btnUpdate_Click(
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
                    UPDATE saran_komplain
                    SET
                        id_sumber=@id_sumber,
                        jenis=@jenis,
                        isi=@isi
                    WHERE id_saran=@id";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idSelected);

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
                        "Data berhasil diupdate");

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // DELETE DATA
        // =====================================
        private void btnDelete_Click(
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
                    "DELETE FROM saran_komplain " +
                    "WHERE id_saran=@id";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idSelected);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Data berhasil dihapus");

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
                    UPDATE mahasiswa
                    SET nama =
                    CASE
                        WHEN nim='202401' THEN 'Andi'
                        WHEN nim='202403' THEN 'Citra'
                        WHEN nim='202404' THEN 'Dewi'
                        ELSE nama
                    END";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            conn);

                    int result =
                        cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        result +
                        " data berhasil direset");
                }

                LoadMahasiswa();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Reset gagal: " +
                    ex.Message);
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