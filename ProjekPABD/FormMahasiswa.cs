using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection conn;

        public string idMhs;

        public FormMahasiswa()
        {
            InitializeComponent();
            Koneksi();
        }

        // ===============================
        // KONEKSI DATABASE
        // ===============================
        private void Koneksi()
        {
            conn = new SqlConnection("Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");
        }

        // ===============================
        // LOAD FORM
        // ===============================
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            cmbJenis.Items.Add("saran");
            cmbJenis.Items.Add("komplain");

            // contoh isi sumber (sementara)
            cmbSumber.Items.Add("Perpustakaan");
            cmbSumber.Items.Add("Lab Komputer");
            cmbSumber.Items.Add("Wifi Kampus");

            LoadSumber();
            TampilData();
        }

        // ===============================
        // LOAD COMBOBOX SUMBER DAYA
        // ===============================
        void LoadSumber()
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sumber_daya_kampus", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSumber.DataSource = dt;
                cmbSumber.DisplayMember = "nama_sumber";
                cmbSumber.ValueMember = "id_sumber";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============================
        // TAMPIL DATA (JOIN)
        // ===============================
        void TampilData(string keyword = "")
        {
            try
            {
                conn.Open();

                string query = @"
                SELECT s.id_saran, m.nama, sd.nama_sumber, s.jenis, s.isi, s.status, s.created_at
                FROM saran_komplain s
                JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                JOIN sumber_daya_kampus sd ON s.id_sumber = sd.id_sumber";

                if (keyword != "")
                {
                    query += " WHERE s.isi LIKE @cari";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                if (keyword != "")
                {
                    da.SelectCommand.Parameters.AddWithValue("@cari", "%" + keyword + "%");
                }

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
        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (cmbSumber.Text == "" || cmbJenis.Text == "" || txtIsi.Text == "")
            {
                MessageBox.Show("Isi semua data!");
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO saran_komplain
                    (id_mhs, id_sumber, jenis, isi, created_at, status)
                    VALUES (@mhs,@sumber,@jenis,@isi,GETDATE(),'pending')", conn);

                cmd.Parameters.AddWithValue("@mhs", idMhs);
                cmd.Parameters.AddWithValue("@sumber", cmbSumber.SelectedValue);
                cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                cmd.Parameters.AddWithValue("@isi", txtIsi.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Saran berhasil dikirim!");

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
        // UPDATE
        // ===============================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_saran"].Value);

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE saran_komplain SET jenis=@j, isi=@i, id_sumber=@s WHERE id_saran=@id", conn);

            cmd.Parameters.AddWithValue("@j", cmbJenis.Text);
            cmd.Parameters.AddWithValue("@i", txtIsi.Text);
            cmd.Parameters.AddWithValue("@s", cmbSumber.SelectedValue);
            cmd.Parameters.AddWithValue("@id", id);

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
            if (dataGridView1.CurrentRow == null) return;

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

        // ===============================
        // SEARCH
        // ===============================
        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilData(txtCari.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
        }
    }
}