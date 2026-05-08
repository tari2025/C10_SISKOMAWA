using System;
using System.Data;
using System.Data.SqlClient;
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

        int idSelected = 0;

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();
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

                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", idMahasiswa);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        txtNama.Text = rd["nama"].ToString();
                        txtNim.Text = rd["nim"].ToString();
                        txtProdi.Text = rd["prodi"].ToString();
                        txtHp.Text = rd["no_hp"].ToString();
                        txtEmail.Text = rd["email"].ToString();
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

                    cmd = new SqlCommand(query, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

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
        // TAMPIL DATA
        // ===============================
        void TampilData()
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
                        ISNULL(t.isi_tanggapan,'Belum ada tanggapan') AS tanggapan,
                        s.created_at

                    FROM saran_komplain s

                    JOIN mahasiswa m
                    ON s.id_mhs = m.id_mhs

                    JOIN sumber_daya_kampus sk
                    ON s.id_sumber = sk.id_sumber

                    LEFT JOIN tanggapan t
                    ON s.id_saran = t.id_saran";

                    cmd = new SqlCommand(query, conn);

                    da = new SqlDataAdapter(cmd);

                    ds = new DataSet();

                    da.Fill(ds);

                    dgvKomplain.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // CLEAR FORM
        // ===============================
        void ClearForm()
        {
            cmbJenis.SelectedIndex = -1;
            cmbSumberDaya.SelectedIndex = -1;

            txtIsi.Clear();
            txtCari.Clear();

            idSelected = 0;
        }

        // ===============================
        // FORM LOAD
        // ===============================
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            cmbJenis.Items.Add("saran");
            cmbJenis.Items.Add("komplain");

            LoadMahasiswa();

            LoadSumberDaya();

            TampilData();
        }

        // ===============================
        // TAMBAH
        // ===============================
        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    txtNama.Text == "" ||
                    txtNim.Text == "" ||
                    txtProdi.Text == "" ||
                    txtHp.Text == "" ||
                    txtEmail.Text == "" ||
                    cmbJenis.Text == "" ||
                    cmbSumberDaya.Text == "" ||
                    txtIsi.Text == ""
                )
                {
                    MessageBox.Show("Semua data wajib diisi!");
                    return;
                }

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateMhs = @"
                    UPDATE mahasiswa
                    SET
                        nama=@nama,
                        nim=@nim,
                        prodi=@prodi,
                        no_hp=@hp,
                        email=@email
                    WHERE id_mhs=@id";

                    cmd = new SqlCommand(updateMhs, conn);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@nim", txtNim.Text);
                    cmd.Parameters.AddWithValue("@prodi", txtProdi.Text);
                    cmd.Parameters.AddWithValue("@hp", txtHp.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", idMahasiswa);

                    cmd.ExecuteNonQuery();

                    string cari =
                    "SELECT id_sumber FROM sumber_daya_kampus WHERE kategori=@kategori";

                    cmd = new SqlCommand(cari, conn);

                    cmd.Parameters.AddWithValue(
                        "@kategori",
                        cmbSumberDaya.Text);

                    int idSumber =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    string insert = @"
                    INSERT INTO saran_komplain
                    (id_mhs,id_sumber,jenis,isi)
                    VALUES
                    (@id_mhs,@id_sumber,@jenis,@isi)";

                    cmd = new SqlCommand(insert, conn);

                    cmd.Parameters.AddWithValue("@id_mhs", idMahasiswa);
                    cmd.Parameters.AddWithValue("@id_sumber", idSumber);
                    cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                    cmd.Parameters.AddWithValue("@isi", txtIsi.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan");

                    TampilData();

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // GRID CLICK
        // ===============================
        private void dgvKomplain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvKomplain.Rows[e.RowIndex];

                idSelected =
                    Convert.ToInt32(row.Cells[0].Value);

                cmbJenis.Text =
                    row.Cells[4].Value.ToString();

                cmbSumberDaya.Text =
                    row.Cells[5].Value.ToString();

                txtIsi.Text =
                    row.Cells[6].Value.ToString();
            }
        }

        // ===============================
        // UPDATE
        // ===============================
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string cari =
                    "SELECT id_sumber FROM sumber_daya_kampus WHERE kategori=@kategori";

                    cmd = new SqlCommand(cari, conn);

                    cmd.Parameters.AddWithValue(
                        "@kategori",
                        cmbSumberDaya.Text);

                    int idSumber =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    string query = @"
                    UPDATE saran_komplain
                    SET
                        id_sumber=@id_sumber,
                        jenis=@jenis,
                        isi=@isi
                    WHERE id_saran=@id";

                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_sumber", idSumber);
                    cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                    cmd.Parameters.AddWithValue("@isi", txtIsi.Text);
                    cmd.Parameters.AddWithValue("@id", idSelected);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diupdate");

                    TampilData();

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // DELETE
        // ===============================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    "DELETE FROM saran_komplain WHERE id_saran=@id";

                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", idSelected);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");

                    TampilData();

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // CARI
        // ===============================
        private void BtnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCari.Text == "")
                {
                    MessageBox.Show("Masukkan keyword pencarian!");
                    return;
                }

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
                        ISNULL(t.isi_tanggapan,'Belum ada tanggapan') AS tanggapan,
                        s.created_at

                    FROM saran_komplain s

                    JOIN mahasiswa m
                    ON s.id_mhs = m.id_mhs

                    JOIN sumber_daya_kampus sk
                    ON s.id_sumber = sk.id_sumber

                    LEFT JOIN tanggapan t
                    ON s.id_saran = t.id_saran

                    WHERE
                        m.nama LIKE @cari
                        OR m.nim LIKE @cari
                        OR s.jenis LIKE @cari
                        OR sk.kategori LIKE @cari
                        OR s.status LIKE @cari
                        OR s.isi LIKE @cari";

                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@cari",
                        "%" + txtCari.Text + "%");

                    da = new SqlDataAdapter(cmd);

                    ds = new DataSet();

                    da.Fill(ds);

                    dgvKomplain.DataSource = ds.Tables[0];

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data tidak ditemukan!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // CLEAR
        // ===============================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

            TampilData();
        }

        // ===============================
        // TAMPIL
        // ===============================
        private void btnTampil_Click(object sender, EventArgs e)
        {
            txtCari.Clear();

            TampilData();
        }
    }
}

