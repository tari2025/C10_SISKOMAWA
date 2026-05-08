using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class Sumber_Daya_Kampus : Form
    {
        SqlConnection conn;

        public Sumber_Daya_Kampus()
        {
            InitializeComponent();
            Koneksi();
        }

        // ===============================
        // KONEKSI
        // ===============================
        private void Koneksi()
        {
            conn = new SqlConnection("Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");
        }

        // ===============================
        // LOAD
        // ===============================
        private void Sumber_Daya_Kampus_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        // ===============================
        // TAMPIL DATA
        // ===============================
        void TampilData()
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sumber_daya_kampus", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // INSERT
        // ===============================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtJenis.Text == "")
            {
                MessageBox.Show("Isi data dulu!");
                return;
            }

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO sumber_daya_kampus(nama_sumber, jenis, deskripsi) VALUES (@n,@j,@d)", conn);

            cmd.Parameters.AddWithValue("@n", txtNama.Text);
            cmd.Parameters.AddWithValue("@j", txtJenis.Text);
            cmd.Parameters.AddWithValue("@d", txtDeskripsi.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil ditambahkan");
            TampilData();
        }

        // ===============================
        // KLIK DATAGRID
        // ===============================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["id_sumber"].Value.ToString();
                txtNama.Text = row.Cells["nama_sumber"].Value.ToString();
                txtJenis.Text = row.Cells["jenis"].Value.ToString();
                txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
            }
        }

        // ===============================
        // UPDATE
        // ===============================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE sumber_daya_kampus SET nama_sumber=@n, jenis=@j, deskripsi=@d WHERE id_sumber=@id", conn);

            cmd.Parameters.AddWithValue("@n", txtNama.Text);
            cmd.Parameters.AddWithValue("@j", txtJenis.Text);
            cmd.Parameters.AddWithValue("@d", txtDeskripsi.Text);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil diubah");
            TampilData();
        }

        // ===============================
        // DELETE
        // ===============================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM sumber_daya_kampus WHERE id_sumber=@id", conn);

            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil dihapus");
            TampilData();
        }

        // ===============================
        // REFRESH
        // ===============================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void Sumber_Daya_Kampus_Load_1(object sender, EventArgs e)
        {

        }
    }
}