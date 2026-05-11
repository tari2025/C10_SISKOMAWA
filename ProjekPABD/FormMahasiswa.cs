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
        BindingSource bs =
        new BindingSource();

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
        // LOAD DATA GRID (VIEW)
        // 
        // =====================================
        // LOAD DATA GRID (VIEW + BINDING)
        // =====================================
        private void LoadData()
        {
            try
            {
                conn.Open();

                string query =
                "SELECT * FROM view_laporan_komplain WHERE id_mhs=@id_mhs";

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

                // BINDING
                bs.DataSource = dt;

                dgvKomplain.DataSource =
                    bs;

                bindingNavigator1.BindingSource =
                    bs;

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
        // TAMBAH DATA (SP)
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

                    SqlCommand cmd =
                        new SqlCommand(
                            "sp_TambahKomplain",
                            conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

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
        // UPDATE DATA (SP)
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

                    SqlCommand cmd =
                        new SqlCommand(
                            "sp_UpdateKomplain",
                            conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@id_saran",
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
        // DELETE DATA (SP)
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

                    SqlCommand cmd =
                        new SqlCommand(
                            "sp_DeleteKomplain",
                            conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@id_saran",
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
        // CARI DATA (SP)
        // =====================================
        private void BtnCari_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd =
                        new SqlCommand(
                            "sp_CariKomplain",
                            conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@keyword",
                        txtCari.Text);

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dtCari =
                        new DataTable();

                    da.Fill(dtCari);

                    dgvKomplain.DataSource =
                        dtCari;
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
                    row.Cells[6].Value.ToString();

                cmbSumberDaya.Text =
                    row.Cells[5].Value.ToString();

                txtIsi.Text =
                    row.Cells[7].Value.ToString();
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
