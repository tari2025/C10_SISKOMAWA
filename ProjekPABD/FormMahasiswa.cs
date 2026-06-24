using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private DAL dbLogic = new DAL();

        string connectionString = "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        int idSelected = 0;
        private byte[] fotoBytes = null;
        private string fotoPath = "";

        public static int idMahasiswa;

        public FormMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadMahasiswa();
            LoadData();

            dgvKomplain.EnableHeadersVisualStyles = false;
            dgvKomplain.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvKomplain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKomplain.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKomplain.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgvKomplain.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvKomplain.RowTemplate.Height = 28;
            dgvKomplain.ColumnHeadersHeight = 35;

            bindingNavigator1.BindingSource = bs;
            bs.PositionChanged += new EventHandler(Bs_PositionChanged);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.LightGray;
        }

        private void BtnUploadFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Pilih Foto Komplain";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string ext = Path.GetExtension(ofd.FileName).ToLower();
                        string[] allowedExt = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
                        if (!Array.Exists(allowedExt, extItem => extItem == ext))
                        {
                            MessageBox.Show("Format file tidak didukung!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        fotoPath = ofd.FileName;
                        fotoBytes = File.ReadAllBytes(fotoPath);

                        if (fotoBytes.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Ukuran foto maksimal 5 MB!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            fotoBytes = null;
                            fotoPath = "";
                            return;
                        }

                        using (MemoryStream ms = new MemoryStream(fotoBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                        MessageBox.Show("Foto berhasil diupload!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal upload foto:\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus(); return false;
            }
            if (txtNama.Text.Length < 3)
            {
                MessageBox.Show("Nama minimal 3 karakter!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus(); return false;
            }
            foreach (char c in txtNama.Text)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Nama tidak boleh mengandung angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNama.Focus(); return false;
                }
            }
            if (string.IsNullOrWhiteSpace(txtNim.Text))
            {
                MessageBox.Show("NIM tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNim.Focus(); return false;
            }
            if (!long.TryParse(txtNim.Text, out _))
            {
                MessageBox.Show("NIM hanya boleh angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNim.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txtProdi.Text))
            {
                MessageBox.Show("Prodi tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdi.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txtHp.Text))
            {
                MessageBox.Show("No HP tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHp.Focus(); return false;
            }
            if (!long.TryParse(txtHp.Text, out _))
            {
                MessageBox.Show("No HP hanya boleh angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHp.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); return false;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Format email tidak valid! (contoh: nama@email.com)", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); return false;
            }
            if (cmbJenis.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis (saran/komplain)!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbJenis.Focus(); return false;
            }
            if (cmbSumberDaya.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih sumber daya!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSumberDaya.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txtIsi.Text))
            {
                MessageBox.Show("Isi komplain tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsi.Focus(); return false;
            }
            return true;
        }

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
                    cmbSumberDaya.Items.Add(dr["kategori"].ToString());
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load combo:\n" + ex.Message);
            }
        }

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
                    dgvKomplain.Columns["id_mhs"].Visible = false;

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

        private int GetIdSumber(SqlConnection connection, SqlTransaction transaction = null)
        {
            string querySumber = "SELECT id_sumber FROM sumber_daya_kampus WHERE kategori=@kategori";
            SqlCommand cmdSumber = new SqlCommand(querySumber, connection, transaction);
            cmdSumber.Parameters.AddWithValue("@kategori", cmbSumberDaya.Text);
            object result = cmdSumber.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                MessageBox.Show("Kategori tidak ditemukan!");
                return -1;
            }
            return Convert.ToInt32(result);
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        int idSumber = GetIdSumber(conn, transaction);
                        if (idSumber == -1) { transaction.Rollback(); return; }

                        SqlCommand cmd = new SqlCommand("sp_TambahKomplain", conn, transaction);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_mhs", idMahasiswa);
                        cmd.Parameters.AddWithValue("@id_sumber", idSumber);
                        cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                        cmd.Parameters.AddWithValue("@isi", txtIsi.Text);
                        if (fotoBytes != null)
                            cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = fotoBytes;
                        else
                            cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        dbLogic.InsertLog("KIRIM KOMPLAIN",
                            $"ID Mahasiswa: {idMahasiswa}, Jenis: {cmbJenis.Text}, Ada Foto: {(fotoBytes != null ? "Ya" : "Tidak")}");

                        MessageBox.Show("Data berhasil ditambah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnClear_Click(sender, e);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                dbLogic.InsertLog("ERROR", ex.Message);
                MessageBox.Show("Gagal tambah:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            if (idSelected == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        int idSumber = GetIdSumber(conn, transaction);
                        if (idSumber == -1) { transaction.Rollback(); return; }

                        SqlCommand cmd = new SqlCommand("sp_UpdateKomplain", conn, transaction);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_saran", idSelected);
                        cmd.Parameters.AddWithValue("@id_sumber", idSumber);
                        cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                        cmd.Parameters.AddWithValue("@isi", txtIsi.Text);

                        if (fotoBytes != null)
                        {
                            cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = fotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                        }

                        cmd.ExecuteNonQuery();

                        string queryMahasiswa = "UPDATE mahasiswa SET nim=@nim, nama=@nama, prodi=@prodi, no_hp=@hp, email=@email WHERE id_mhs=@id";
                        SqlCommand cmdMhs = new SqlCommand(queryMahasiswa, conn, transaction);
                        cmdMhs.Parameters.AddWithValue("@nim", txtNim.Text);
                        cmdMhs.Parameters.AddWithValue("@nama", txtNama.Text);
                        cmdMhs.Parameters.AddWithValue("@prodi", txtProdi.Text);
                        cmdMhs.Parameters.AddWithValue("@hp", txtHp.Text);
                        cmdMhs.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmdMhs.Parameters.AddWithValue("@id", idMahasiswa);
                        cmdMhs.ExecuteNonQuery();

                        transaction.Commit();

                        dbLogic.InsertLog("UPDATE KOMPLAIN",
                            $"ID Saran: {idSelected}, Ada Foto: {(fotoBytes != null ? "Ya" : "Tidak")}");

                        MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnClear_Click(sender, e);
                        LoadMahasiswa();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                dbLogic.InsertLog("ERROR", ex.Message);
                MessageBox.Show("Gagal update:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (idSelected == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Yakin ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteKomplain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_saran", idSelected);
                    cmd.ExecuteNonQuery();

                    dbLogic.InsertLog("DELETE KOMPLAIN", $"ID Saran: {idSelected}");
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnClear_Click(sender, e);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                dbLogic.InsertLog("ERROR", ex.Message);
                MessageBox.Show("Gagal hapus:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                dbLogic.InsertLog("ERROR", ex.Message);
                MessageBox.Show("Gagal cari:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnResetData_Click(object sender, EventArgs e)
        {
            // KONFIRMASI SEDERHANA (tanpa detail)
            DialogResult result = MessageBox.Show(
                "Yakin ingin mereset data mahasiswa?",  // ✅ HANYA INI
                "Konfirmasi Reset Data",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                UPDATE mahasiswa SET nama =
                CASE
                    WHEN nim='202401' THEN 'Andi'
                    WHEN nim='202403' THEN 'Citra'
                    WHEN nim='202404' THEN 'Dewi'
                    ELSE nama
                END";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    LoadMahasiswa();
                    LoadData();

                    dbLogic.InsertLog("RESET DATA", $"Data mahasiswa berhasil direset, {rowsAffected} baris terupdate");

                    MessageBox.Show($"Data berhasil direset!\n{rowsAffected} data terupdate.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                dbLogic.InsertLog("ERROR", ex.Message);
                MessageBox.Show("Gagal reset data:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTampil_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            LoadData();
        }

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

                if (row.Row.Table.Columns.Contains("foto") && row["foto"] != DBNull.Value)
                {
                    byte[] foto = (byte[])row["foto"];
                    using (MemoryStream ms = new MemoryStream(foto))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox1.BackColor = Color.LightGray;
                }
            }
            catch { }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cmbJenis.SelectedIndex = -1;
            cmbSumberDaya.SelectedIndex = -1;
            txtIsi.Clear();
            txtCari.Clear();
            idSelected = 0;

            fotoBytes = null;
            fotoPath = "";
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.LightGray;
        }

        // =============================================
        // EMPTY EVENTS
        // =============================================
        private void LblTitle_Click(object sender, EventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void txtProdi_TextChanged(object sender, EventArgs e) { }
        private void dgvKomplain_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // =============================================
        // TOMBOL TEST INJECTION
        // =============================================
        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNim.Text))
            {
                MessageBox.Show("Masukkan NIM untuk test injection!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNim.Focus();
                return;
            }

            if (MessageBox.Show(
                $"Yakin ingin melakukan test injection??\nNama akan diubah menjadi 'HACKED'",
                "Konfirmasi Test Injection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    dbLogic.TestInject(txtNim.Text);

                    MessageBox.Show("SQL Injection berhasil dijalankan!\nNama mahasiswa telah diubah menjadi 'HACKED'",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbLogic.insertLog($"Melakukan test injection pada NIM: {txtNim.Text}");

                    LoadMahasiswa();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =============================================
        // TOMBOL LOAD
        // =============================================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMahasiswa();
                LoadData();
                MessageBox.Show("Data berhasil dimuat ulang!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================
        // TOMBOL TEST
        // =============================================
        private void BtnTest_Click(object sender, EventArgs e)
        {
            // Panggil method Test Injection
            btnTestInjection_Click(sender, e);
        }
    }
}