using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormDashboard : Form
    {
        private readonly string connectionString =
        "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        SqlDataAdapter da;
        DataSet ds;

        public FormDashboard()
        {
            InitializeComponent();
        }

        // ===============================
        // LOAD
        // ===============================
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "SISKOMAWA";

            lblSubTitle.Text =
                "Sistem Informasi Saran dan Komplain Mahasiswa";

            TampilData();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);
            }
        }

        // ===============================
        // LOGIN MAHASISWA
        // ===============================
        private void BtnLoginMahasiswa_Click(object sender, EventArgs e)
        {
            FormLogin f =
                new FormLogin();

            f.Show();

            this.Hide();
        }

        // ===============================
        // LOGIN ADMIN
        // ===============================
        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLogin f =
                new FormLogin();

            f.Show();

            this.Hide();
        }

        // ===============================
        // KELUAR
        // ===============================
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

        // ===============================
        // LABEL SUBTITLE
        // ===============================
        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}