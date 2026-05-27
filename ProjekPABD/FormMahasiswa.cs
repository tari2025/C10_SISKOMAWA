using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        BindingSource bs = new BindingSource();

        string connectionString = "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        int idSelected = 0;

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        // =============================================
        // FORM LOAD
        // =============================================
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadMahasiswa();
            LoadData();

            // STYLE DATAGRIDVIEW
            dgvKomplain.EnableHeadersVisualStyles = false;
            dgvKomplain.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvKomplain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKomplain.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKomplain.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgvKomplain.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvKomplain.RowTemplate.Height = 28;
            dgvKomplain.ColumnHeadersHeight = 35;

            // BINDING NAVIGATOR
            bindingNavigator1.BindingSource = bs;
            bs.PositionChanged += new EventHandler(Bs_PositionChanged);
        }

        // =============================================
        private bool ValidasiInput()
        {
            // NAMA
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                txtNama.Focus();
                return false;
            }

            if (txtNama.Text.Length < 3)
            {
                MessageBox.Show("Nama minimal 3 karakter!");
                txtNama.Focus();
                return false;
            }

            // VALIDASI NAMA TIDAK BOLEH ANGKA
            foreach (char c in txtNama.Text)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Nama tidak boleh mengandung angka!");
                    txtNama.Focus();
                    return false;
                }
            }

            // NIM
            if (string.IsNullOrWhiteSpace(txtNim.Text))
            {
                MessageBox.Show("NIM tidak boleh kosong!");
                txtNim.Focus();
                return false;
            }

            // VALIDASI NIM HANYA ANGKA
            long nim;

            if (!long.TryParse(txtNim.Text, out nim))
            {
                MessageBox.Show("NIM hanya boleh angka!");
                txtNim.Focus();
                return false;
            }

            // PRODI
            if (string.IsNullOrWhiteSpace(txtProdi.Text))
            {
                MessageBox.Show("Prodi tidak boleh kosong!");
                txtProdi.Focus();
                return false;
            }

            // NO HP
            if (string.IsNullOrWhiteSpace(txtHp.Text))
            {
                MessageBox.Show("No HP tidak boleh kosong!");
                txtHp.Focus();
                return false;
            }

            long nomor;

            if (!long.TryParse(txtHp.Text, out nomor))
            {
                MessageBox.Show("No HP hanya boleh angka!");
                txtHp.Focus();
                return false;
            }

            // EMAIL
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!");
                txtEmail.Focus();
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Format email tidak valid!");
                txtEmail.Focus();
                return false;
            }

            // JENIS
            if (cmbJenis.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis!");
                cmbJenis.Focus();
                return false;
            }

            // SUMBER DAYA
            if (cmbSumberDaya.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih sumber daya!");
                cmbSumberDaya.Focus();
                return false;
            }

            // ISI
            if (string.IsNullOrWhiteSpace(txtIsi.Text))
            {
                MessageBox.Show("Isi komplain tidak boleh kosong!");
                txtIsi.Focus();
                return false;
            }

            return true;
        }
            
        // =============================================
        // LOAD COMBO
        // =============================================
        private void LoadCombo()
        {
            cmbJenis.Items.Clear();
            cmbJenis.Items.Add("saran");
            cmbJenis.Items.Add("komplain");

            cmbSumberDaya.Items.Clear();
            try
            {
                conn.Open();
                string query = "SELECT kategori FROM sumber_daya_kampus";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbSumberDaya.Items.Add(dr["kategori"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load combo:\n" + ex.Message);
            }
        }

        // =============================================
        // LOAD DATA
        // =============================================
        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string query = "SELECT * FROM view_laporan_komplain WHERE id_mhs=@id_mhs";
                da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@id_mhs", idMahasiswa);
                dt = new DataTable();
                da.Fill(dt);

                bs.DataSource = dt;
                dgvKomplain.DataSource = bs;

                if (dgvKomplain.Columns["id_mhs"] != null)
                {
                    dgvKomplain.Columns["id_mhs"].Visible = false;
                }

                dgvKomplain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKomplain.RowHeadersVisible = false;
                bindingNavigator1.BindingSource = bs;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data:\n" + ex.Message);
            }
        }

        // =============================================
        // LOAD MAHASISWA
        // =============================================
        private void LoadMahasiswa()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string query = "SELECT * FROM mahasiswa WHERE id_mhs=@id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idMahasiswa);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNama.Text = dr["nama"].ToString();
                    txtNim.Text = dr["nim"].ToString();
                    txtProdi.Text = dr["prodi"].ToString();
                    txtHp.Text = dr["no_hp"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load mahasiswa:\n" + ex.Message);
            }
        }

        // =============================================
        // GET ID SUMBER (SCALAR)
        // =============================================
        private int GetIdSumber(SqlConnection connection)
        {
            string querySumber = "SELECT id_sumber FROM sumber_daya_kampus WHERE kategori=@kategori";
            SqlCommand cmdSumber = new SqlCommand(querySumber, connection);
            cmdSumber.Parameters.AddWithValue("@kategori", cmbSumberDaya.Text);
            object result = cmdSumber.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                MessageBox.Show("Kategori tidak ditemukan!");
                return -1;
            }
            return Convert.ToInt32(result);
        }

        // =============================================
        // TAMBAH (STORED PROCEDURE)
        // =============================================
        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int idSumber = GetIdSumber(conn);
                    if (idSumber == -1) return;

                    SqlCommand cmd = new SqlCommand("sp_TambahKomplain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mhs", idMahasiswa);
                    cmd.Parameters.AddWithValue("@id_sumber", idSumber);
                    cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                    cmd.Parameters.AddWithValue("@isi", txtIsi.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil ditambah!");
                    BtnClear_Click(sender, e);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah:\n" + ex.Message);
            }
        }

        // =============================================
        // UPDATE (STORED PROCEDURE)
        // =============================================
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            if (idSelected == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int idSumber = GetIdSumber(conn);
                    if (idSumber == -1) return;

                    SqlCommand cmd = new SqlCommand("sp_UpdateKomplain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_saran", idSelected);
                    cmd.Parameters.AddWithValue("@id_sumber", idSumber);
                    cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                    cmd.Parameters.AddWithValue("@isi", txtIsi.Text);
                    cmd.ExecuteNonQuery();

                    string queryMahasiswa = "UPDATE mahasiswa SET nim=@nim, nama=@nama, prodi=@prodi, no_hp=@hp, email=@email WHERE id_mhs=@id";
                    SqlCommand cmdMhs = new SqlCommand(queryMahasiswa, conn);
                    cmdMhs.Parameters.AddWithValue("@nim", txtNim.Text);
                    cmdMhs.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmdMhs.Parameters.AddWithValue("@prodi", txtProdi.Text);
                    cmdMhs.Parameters.AddWithValue("@hp", txtHp.Text);
                    cmdMhs.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmdMhs.Parameters.AddWithValue("@id", idMahasiswa);
                    cmdMhs.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diupdate!");
                    BtnClear_Click(sender, e);
                    LoadMahasiswa();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update:\n" + ex.Message);
            }
        }

        // =============================================
        // DELETE (STORED PROCEDURE)
        // =============================================
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (idSelected == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            DialogResult hasil = MessageBox.Show("Yakin ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteKomplain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_saran", idSelected);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus!");
                    BtnClear_Click(sender, e);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hapus:\n" + ex.Message);
            }
        }

        // =============================================
        // SEARCH (STORED PROCEDURE)
        // =============================================
        private void BtnCari_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_CariKomplain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", txtCari.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtCari = new DataTable();
                    da.Fill(dtCari);

                    bs.DataSource = dtCari;
                    dgvKomplain.DataSource = bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cari:\n" + ex.Message);
            }
        }

        // =============================================
        // TEST SQL INJECTION
        // =============================================
        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE mahasiswa SET nama='HACKED' WHERE nim='" + txtNim.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " baris terupdate");
                }
                LoadMahasiswa();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Injection Error:\n" + ex.Message);
            }
        }

        // =============================================
        // RESET DATA
        // =============================================
        private void BtnResetData_Click(
        object sender,
        EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(
                        connectionString))
                {
                    conn.Open();

                    string query = @"
            UPDATE mahasiswa
            SET nama =
            CASE
                WHEN nim='202401'
                    THEN 'Andi'

                WHEN nim='202403'
                    THEN 'Citra'

                WHEN nim='202404'
                    THEN 'Dewi'

                ELSE nama
            END";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            conn);

                    cmd.ExecuteNonQuery();
                }

                LoadMahasiswa();

                LoadData();

                MessageBox.Show(
                    "Data berhasil direset!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal reset:\n" +
                    ex.Message);
            }
        }
        // =============================================
        // TAMPIL
        // =============================================
        private void BtnTampil_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            LoadData();
        }

        // =============================================
        // GRID CLICK
        // =============================================
        private void DgvKomplain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bs.Position = e.RowIndex;
            DataGridViewRow row = dgvKomplain.Rows[e.RowIndex];

            idSelected = Convert.ToInt32(row.Cells[0].Value);
            cmbJenis.Text = row.Cells["jenis"].Value.ToString();
            cmbSumberDaya.Text = row.Cells["kategori"].Value.ToString();
            txtIsi.Text = row.Cells["isi"].Value.ToString();
        }

        // =============================================
        // BINDING NAVIGATOR
        // =============================================
        // BINDING NAVIGATOR
        // =============================================
        private void Bs_PositionChanged(object sender, EventArgs e)
        {
            if (bs.Current == null) return;

            DataRowView row = (DataRowView)bs.Current;
            try
            {
                idSelected = Convert.ToInt32(row["id_saran"]);
                cmbJenis.Text = row["jenis"].ToString();
                cmbSumberDaya.Text = row["kategori"].ToString();
                txtIsi.Text = row["isi"].ToString();
            }
            catch { }
        }
        // =============================================
        // LABEL TITLE
        // =============================================
        private void LblTitle_Click(
            object sender,
            EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        private void txtProdi_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        // =============================================
        // CLEAR
        // =============================================
        private void BtnClear_Click(
            object sender,
            EventArgs e)
        {
            cmbJenis.SelectedIndex = -1;
            cmbSumberDaya.SelectedIndex = -1;

            txtIsi.Clear();
            txtCari.Clear();

            idSelected = 0;
        }

    }
}