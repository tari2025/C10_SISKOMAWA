using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ProjekPABD;Integrated Security=True");

        public FormAdmin()
        {
            InitializeComponent();
        }

        // ================== LOAD ==================
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Koneksi Berhasil");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Koneksi Gagal");
            }

            tampilData();
            hitungData();
        }

        // ================== TAMPIL DATA ==================
        void tampilData()
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                "SELECT s.id_saran, s.isi, s.status, t.isi_tanggapan " +
                "FROM saran_komplain s " +
                "LEFT JOIN tanggapan t ON s.id_saran = t.id_saran",
                conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 🔥 ini penting
            }
        }

        // ================== HITUNG DATA ==================
        void hitungData()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM saran", conn);
            int total = (int)cmd.ExecuteScalar();

            conn.Close();

            lblTotal.Text = "Total Data: " + total;
        }

        // ================== KLIK DATAGRID ==================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["id_saran"].Value.ToString();
                txtIsi.Text = row.Cells["isi"].Value.ToString();
                cmbStatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        // ================== INSERT ==================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtIsi.Text == "")
            {
                MessageBox.Show("Isi tidak boleh kosong!");
                return;
            }

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO saran (isi, status) VALUES (@isi, @status)", conn);

            cmd.Parameters.AddWithValue("@isi", txtIsi.Text);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil ditambahkan");

            tampilData();
            hitungData();
        }

        // ================== UPDATE ==================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIsi.Text == "")
            {
                MessageBox.Show("Isi tidak boleh kosong!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin update?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE saran SET isi=@isi, status=@status WHERE id_saran=@id", conn);

                cmd.Parameters.AddWithValue("@isi", txtIsi.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diupdate");

                tampilData();
                hitungData();
            }
        }

        // ================== DELETE ==================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            DialogResult result = MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM saran WHERE id_saran=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtId.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dihapus");

                tampilData();
                hitungData();
            }
        }

        // ================== CARI ==================
        private void btnCari_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cari jalan");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hapus jalan");
        }

        private void btnTanggapi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tanggapi jalan");
        }

        // ================== LOGOUT ==================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}