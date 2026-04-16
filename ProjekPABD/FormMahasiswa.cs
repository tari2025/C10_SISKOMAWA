using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");
       
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        // ===============================
        void HitungData()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM saran_komplain", conn);
            int total = (int)cmd.ExecuteScalar();

            conn.Close();

            MessageBox.Show("Total Data Saran: " + total);
        }
        // LOAD FORM
        // ===============================
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            cmbJenis.Items.Clear();
            cmbJenis.Items.Add("saran");
            cmbJenis.Items.Add("komplain");

            TampilData();
        }

        // ===============================
        // TAMPIL DATA
        // ===============================
        void TampilData(string keyword = "")
        {
            conn.Open();

            SqlDataAdapter da;

            if (keyword == "")
            {
                da = new SqlDataAdapter("SELECT * FROM saran_komplain", conn);
            }
            else
            {
                da = new SqlDataAdapter(
                "SELECT * FROM saran_komplain WHERE isi LIKE '%" + keyword + "%'", conn);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        // ===============================
        // KLIK GRID → ISI TEXTBOX
        // ===============================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtIdMhs.Text = row.Cells["id_mhs"].Value.ToString();
            txtIsi.Text = row.Cells["isi"].Value.ToString();
            cmbJenis.Text = row.Cells["jenis"].Value.ToString();
        }

        // ===============================
        // AUTO ISI DATA MAHASISWA
        // ===============================
        private void txtIdMhs_TextChanged(object sender, EventArgs e)
        {
            if (txtIdMhs.Text == "") return;

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                "SELECT nama, nim, prodi, no_hp, email FROM mahasiswa WHERE id_mhs=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtIdMhs.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNama.Text = dr["nama"].ToString();
                    txtNim.Text = dr["nim"].ToString();
                    txtProdi.Text = dr["prodi"].ToString();
                    txtNoHp.Text = dr["no_hp"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // INSERT (KIRIM)
        // ===============================
        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (txtIdMhs.Text == "" || cmbJenis.Text == "" || txtIsi.Text == "")
            {
                MessageBox.Show("Isi semua data!");
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                "INSERT INTO saran_komplain(id_mhs, jenis, isi, status) VALUES (@id,@j,@i,'pending')", conn);

                cmd.Parameters.AddWithValue("@id", txtIdMhs.Text);
                cmd.Parameters.AddWithValue("@j", cmbJenis.Text);
                cmd.Parameters.AddWithValue("@i", txtIsi.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dikirim!");

                TampilData();

                txtIsi.Clear();
                cmbJenis.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // UPDATE (UBAH)
        // ===============================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ubah data?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_saran"].Value);

                conn.Open();

                SqlCommand cmd = new SqlCommand(
                "UPDATE saran_komplain SET jenis=@j, isi=@i WHERE id_saran=@id", conn);

                cmd.Parameters.AddWithValue("@j", cmbJenis.Text);
                cmd.Parameters.AddWithValue("@i", txtIsi.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diubah");

                TampilData();
            }
        }

        // ===============================
        // DELETE (HAPUS)
        // ===============================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_saran"].Value);

                conn.Open();

                SqlCommand cmd = new SqlCommand(
                "DELETE FROM saran_komplain WHERE id_saran=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dihapus");

                TampilData();
            }
        }

        // ===============================
        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        // SEARCH (CARI)
        // ===============================


        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null &&
                    row.Cells[1].Value.ToString().ToLower().Contains(keyword))
                {
                    row.Selected = true;
                }
            }
        }

        // ===============================
        // LIHAT TANGGAPAN
        // ===============================
        private void btnLihatTanggapan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_saran"].Value);

            conn.Open();

            SqlCommand cmd = new SqlCommand(
            "SELECT isi_tanggapan, responded_at FROM tanggapan WHERE id_saran=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show(
                    "Tanggapan:\n" + dr["isi_tanggapan"].ToString() +
                    "\n\nTanggal:\n" + dr["responded_at"].ToString());
            }
            else
            {
                MessageBox.Show("Belum ada tanggapan");
            }

            conn.Close();
        }
    }
}