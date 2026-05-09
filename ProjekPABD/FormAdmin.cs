using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormAdmin : Form
    {
        // =====================================
        // CONNECTION
        // =====================================
        private readonly SqlConnection conn =
        new SqlConnection(
        "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");

        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;

        int idSaran = 0;

        public static int idAdmin = 1;

        // =====================================
        // CONSTRUCTOR
        // =====================================
        public FormAdmin()
        {
            InitializeComponent();
        }

        // =====================================
        // LOAD
        // =====================================
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("menunggu");
            cmbStatus.Items.Add("diproses");
            cmbStatus.Items.Add("selesai");

            TampilData();
        }

        // =====================================
        // TAMPIL DATA
        // =====================================
        void TampilData()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string query = @"
                SELECT
                    s.id_saran,
                    m.nama,
                    m.nim,
                    s.jenis,
                    s.isi,
                    s.status,
                    ISNULL(t.isi_tanggapan,'Belum ada tanggapan') AS tanggapan,
                    s.created_at

                FROM saran_komplain s

                JOIN mahasiswa m
                ON s.id_mhs = m.id_mhs

                LEFT JOIN tanggapan t
                ON s.id_saran = t.id_saran

                ORDER BY s.created_at DESC";

                da = new SqlDataAdapter(query, conn);

                ds = new DataSet();

                da.Fill(ds);

                dgvAdmin.DataSource = ds.Tables[0];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // CARI DATA
        // =====================================
        void CariData()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string query = @"
                SELECT
                    s.id_saran,
                    m.nama,
                    m.nim,
                    s.jenis,
                    s.isi,
                    s.status,
                    ISNULL(t.isi_tanggapan,'Belum ada tanggapan') AS tanggapan,
                    s.created_at

                FROM saran_komplain s

                JOIN mahasiswa m
                ON s.id_mhs = m.id_mhs

                LEFT JOIN tanggapan t
                ON s.id_saran = t.id_saran

                WHERE
                    m.nama LIKE @cari
                    OR m.nim LIKE @cari
                    OR s.jenis LIKE @cari
                    OR s.status LIKE @cari

                ORDER BY s.created_at DESC";

                da = new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@cari",
                    "%" + txtCari.Text + "%");

                ds = new DataSet();

                da.Fill(ds);

                dgvAdmin.DataSource = ds.Tables[0];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // BUTTON CARI
        // =====================================
        private void BtnCari_Click(object sender, EventArgs e)
        {
            CariData();
        }

        // =====================================
        // BUTTON REFRESH
        // =====================================
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Clear();

            TampilData();
        }

        // =====================================
        // GRID CLICK
        // =====================================
        private void DgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAdmin.Rows[e.RowIndex];

                idSaran =
                    Convert.ToInt32(row.Cells[0].Value);

                cmbStatus.Text =
                    row.Cells[5].Value.ToString();

                txtTanggapan.Text =
                    row.Cells[6].Value.ToString();
            }
        }

        // =====================================
        // SIMPAN
        // =====================================
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (idSaran == 0)
            {
                MessageBox.Show(
                    "Pilih data terlebih dahulu");

                return;
            }

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string update = @"
                UPDATE saran_komplain
                SET status=@status
                WHERE id_saran=@id";

                cmd = new SqlCommand(update, conn);

                cmd.Parameters.AddWithValue(
                    "@status",
                    cmbStatus.Text);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idSaran);

                cmd.ExecuteNonQuery();

                string cek =
                    "SELECT COUNT(*) FROM tanggapan WHERE id_saran=@id";

                cmd = new SqlCommand(cek, conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idSaran);

                int count =
                    Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    string insert = @"
                    INSERT INTO tanggapan
                    (id_saran,id_admin,isi_tanggapan)
                    VALUES
                    (@id_saran,@id_admin,@isi)";

                    cmd = new SqlCommand(insert, conn);

                    cmd.Parameters.AddWithValue(
                        "@id_saran",
                        idSaran);

                    cmd.Parameters.AddWithValue(
                        "@id_admin",
                        idAdmin);

                    cmd.Parameters.AddWithValue(
                        "@isi",
                        txtTanggapan.Text);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string updateTanggapan = @"
                    UPDATE tanggapan
                    SET isi_tanggapan=@isi
                    WHERE id_saran=@id";

                    cmd = new SqlCommand(
                        updateTanggapan,
                        conn);

                    cmd.Parameters.AddWithValue(
                        "@isi",
                        txtTanggapan.Text);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idSaran);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show(
                    "Tanggapan berhasil disimpan");

                TampilData();

                txtTanggapan.Clear();

                cmbStatus.SelectedIndex = -1;

                idSaran = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // RESET
        // =====================================
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtTanggapan.Clear();

            cmbStatus.SelectedIndex = -1;

            idSaran = 0;
        }

        // =====================================
        // KELUAR
        // =====================================
        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
