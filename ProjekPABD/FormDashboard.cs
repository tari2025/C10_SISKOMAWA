using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormDashboard : Form
    {
        // =====================================
        // CONNECTION
        // =====================================
        private readonly string connectionString =
        "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        SqlDataAdapter da;
        DataSet ds;

        // =====================================
        // CONSTRUCTOR
        // =====================================
        public FormDashboard()
        {
            InitializeComponent();
        }

        // =====================================
        // LOAD
        // =====================================
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "SISKOMAWA";

            lblSubTitle.Text =
                "Sistem Informasi Saran dan Komplain Mahasiswa";

            TampilData();
        }

        // =====================================
        // TAMPIL DATA
        // =====================================
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
                        m.nama AS Nama,
                        m.nim AS NIM,
                        s.jenis AS Jenis,
                        sk.kategori AS Kategori,
                        s.isi AS Isi,
                        s.status AS Status,
                        s.created_at AS Tanggal

                    FROM saran_komplain s

                    JOIN mahasiswa m
                    ON s.id_mhs = m.id_mhs

                    JOIN sumber_daya_kampus sk
                    ON s.id_sumber = sk.id_sumber

                    ORDER BY s.created_at DESC";

                    da = new SqlDataAdapter(query, conn);

                    ds = new DataSet();

                    da.Fill(ds);

                    dgvDashboard.DataSource =
                        ds.Tables[0];

                    lblTotalData.Text =
                        "Total Data : " +
                        dgvDashboard.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);
            }
        }

        // =====================================
        // CARI DATA
        // =====================================
        void CariData()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        m.nama AS Nama,
                        m.nim AS NIM,
                        s.jenis AS Jenis,
                        sk.kategori AS Kategori,
                        s.isi AS Isi,
                        s.status AS Status,
                        s.created_at AS Tanggal

                    FROM saran_komplain s

                    JOIN mahasiswa m
                    ON s.id_mhs = m.id_mhs

                    JOIN sumber_daya_kampus sk
                    ON s.id_sumber = sk.id_sumber

                    WHERE
                        m.nama LIKE @cari
                        OR m.nim LIKE @cari
                        OR s.jenis LIKE @cari
                        OR s.status LIKE @cari

                    ORDER BY s.created_at DESC";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, conn);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@cari",
                        "%" + txtCari.Text + "%");

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    dgvDashboard.DataSource =
                        ds.Tables[0];

                    lblTotalData.Text =
                        "Total Data : " +
                        dgvDashboard.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);
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
        // LOGIN MAHASISWA
        // =====================================
        private void BtnLoginMahasiswa_Click(object sender, EventArgs e)
        {
            FormLogin f =
                new FormLogin();

            f.Show();

            this.Hide();
        }

        // =====================================
        // LOGIN ADMIN
        // =====================================
        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLogin f =
                new FormLogin();

            f.Show();

            this.Hide();
        }

        // =====================================
        // KELUAR
        // =====================================
        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Yakin ingin keluar?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =====================================
        // LABEL SUBTITLE
        // =====================================
        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}