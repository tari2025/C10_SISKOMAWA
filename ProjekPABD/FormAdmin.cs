using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormAdmin : Form
    {
        SqlConnection conn;

        public FormAdmin()
        {
            InitializeComponent();
            Koneksi();
        }

        void Koneksi()
        {
            conn = new SqlConnection("Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("pending");
            cmbStatus.Items.Add("diproses");
            cmbStatus.Items.Add("selesai");

            TampilData();
        }

        void TampilData(string keyword = "")
        {
            conn.Open();

            string query = @"
            SELECT s.id_saran, m.nama, sd.nama_sumber, 
                   s.jenis, s.isi, s.status
            FROM saran_komplain s
            JOIN mahasiswa m ON s.id_mhs = m.id_mhs
            JOIN sumber_daya_kampus sd ON s.id_sumber = sd.id_sumber";

            if (keyword != "")
                query += " WHERE s.isi LIKE @cari";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            if (keyword != "")
                da.SelectCommand.Parameters.AddWithValue("@cari", "%" + keyword + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["id_saran"].Value.ToString();
                txtIsi.Text = row.Cells["isi"].Value.ToString();
                cmbStatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE saran_komplain SET isi=@i, status=@s WHERE id_saran=@id", conn);

            cmd.Parameters.AddWithValue("@i", txtIsi.Text);
            cmd.Parameters.AddWithValue("@s", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data diupdate");
            TampilData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM saran_komplain WHERE id_saran=@id", conn);

            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data dihapus");
            TampilData();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilData(txtCari.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnTanggapi_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            FormTanggapan f = new FormTanggapan(txtId.Text);
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // dummy event biar designer tidak error
        private void FormAdmin_Load_1(object sender, EventArgs e) { }
        private void btnTampil_Click(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}