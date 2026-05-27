using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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

        // =====================================
        // FORM LOAD
        // =====================================
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadMahasiswa();
            LoadData();
        }

        // =====================================
        // LOAD COMBOBOX
        // =====================================
        private void LoadCombo()
        {
            // Contoh isian combo box
            cmbJenis.Items.Clear();
            cmbJenis.Items.Add("Komplain Akademik");
            cmbJenis.Items.Add("Komplain Fasilitas");
            cmbJenis.Items.Add("Komplain Pelayanan");
            cmbJenis.SelectedIndex = -1;

            cmbSumberDaya.Items.Clear();
            cmbSumberDaya.Items.Add("WhatsApp");
            cmbSumberDaya.Items.Add("Email");
            cmbSumberDaya.Items.Add("Telepon");
            cmbSumberDaya.Items.Add("Langsur");
            cmbSumberDaya.SelectedIndex = -1;
        }

        // =====================================
        // LOAD MAHASISWA (Data untuk DataGridView)
        // =====================================
        private void LoadMahasiswa()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Komplain ORDER BY Id DESC";
                da = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvKomplain.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadMahasiswa: " + ex.Message);
                conn.Close();
            }
        }

        // =====================================
        // LOAD DATA KE FORM (untuk update)
        // =====================================
        private void LoadData()
        {
            if (dgvKomplain.SelectedRows.Count > 0)
            {
                idSelected = Convert.ToInt32(dgvKomplain.SelectedRows[0].Cells["Id"].Value);
                cmbJenis.Text = dgvKomplain.SelectedRows[0].Cells["Jenis"].Value.ToString();
                cmbSumberDaya.Text = dgvKomplain.SelectedRows[0].Cells["SumberDaya"].Value.ToString();
                txtIsi.Text = dgvKomplain.SelectedRows[0].Cells["Isi"].Value.ToString();
                txtNama.Text = dgvKomplain.SelectedRows[0].Cells["Nama"].Value.ToString();
                txtNim.Text = dgvKomplain.SelectedRows[0].Cells["Nim"].Value.ToString();
                txtProdi.Text = dgvKomplain.SelectedRows[0].Cells["Prodi"].Value.ToString();
                txtHp.Text = dgvKomplain.SelectedRows[0].Cells["Hp"].Value.ToString();
                txtEmail.Text = dgvKomplain.SelectedRows[0].Cells["Email"].Value.ToString();
            }
        }

        // =====================================
        // VALIDASI INPUT (DIPERBAIKI)
        // =====================================
        private bool ValidasiInput()
        {
            // VALIDASI JENIS
            if (cmbJenis.SelectedIndex == -1)
            {
                MessageBox.Show("Jenis harus dipilih!");
                cmbJenis.Focus();
                return false;
            }

            // VALIDASI SUMBER DAYA
            if (cmbSumberDaya.SelectedIndex == -1)
            {
                MessageBox.Show("Sumber daya harus dipilih!");
                cmbSumberDaya.Focus();
                return false;
            }

            // VALIDASI ISI
            if (string.IsNullOrWhiteSpace(txtIsi.Text))
            {
                MessageBox.Show("Isi komplain tidak boleh kosong!");
                txtIsi.Focus();
                return false;
            }

            // VALIDASI NAMA
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                txtNama.Focus();
                return false;
            }

            // NAMA TIDAK BOLEH ANGKA
            foreach (char c in txtNama.Text)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Nama tidak boleh mengandung angka!");
                    txtNama.Focus();
                    return false;
                }
            }

            // VALIDASI NIM
            if (string.IsNullOrWhiteSpace(txtNim.Text))
            {
                MessageBox.Show("NIM tidak boleh kosong!");
                txtNim.Focus();
                return false;
            }

            // NIM HARUS ANGKA (DIPERBAIKI)
            string nim = txtNim.Text.Trim();
            if (!long.TryParse(nim, out _))
            {
                MessageBox.Show("NIM hanya boleh angka!");
                txtNim.Focus();
                return false;
            }

            // VALIDASI NO HP (DIPERBAIKI)
            if (string.IsNullOrWhiteSpace(txtHp.Text))
            {
                MessageBox.Show("No HP tidak boleh kosong!");
                txtHp.Focus();
                return false;
            }

            // NO HP HARUS ANGKA (DIPERBAIKI - sebelumnya salah pake txtNim)
            if (!long.TryParse(txtHp.Text.Trim(), out _))
            {
                MessageBox.Show("No HP hanya boleh angka!");
                txtHp.Focus();
                return false;
            }

            // VALIDASI EMAIL
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!");
                txtEmail.Focus();
                return false;
            }

            // FORMAT EMAIL
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // BUTTON TAMBAH
        // =====================================
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                conn.Open();
                string query = @"INSERT INTO Komplain (Jenis, SumberDaya, Isi, Nama, Nim, Prodi, Hp, Email) 
                                 VALUES (@Jenis, @SumberDaya, @Isi, @Nama, @Nim, @Prodi, @Hp, @Email)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Jenis", cmbJenis.Text);
                cmd.Parameters.AddWithValue("@SumberDaya", cmbSumberDaya.Text);
                cmd.Parameters.AddWithValue("@Isi", txtIsi.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@Nim", txtNim.Text);
                cmd.Parameters.AddWithValue("@Prodi", txtProdi.Text);
                cmd.Parameters.AddWithValue("@Hp", txtHp.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil ditambahkan!");
                ClearForm();
                LoadMahasiswa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        // =====================================
        // BUTTON UPDATE
        // =====================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idSelected == 0)
            {
                MessageBox.Show("Pilih data yang akan diupdate!");
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn.Open();
                string query = @"UPDATE Komplain SET 
                                 Jenis = @Jenis, 
                                 SumberDaya = @SumberDaya, 
                                 Isi = @Isi, 
                                 Nama = @Nama, 
                                 Nim = @Nim, 
                                 Prodi = @Prodi, 
                                 Hp = @Hp, 
                                 Email = @Email 
                                 WHERE Id = @Id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Jenis", cmbJenis.Text);
                cmd.Parameters.AddWithValue("@SumberDaya", cmbSumberDaya.Text);
                cmd.Parameters.AddWithValue("@Isi", txtIsi.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@Nim", txtNim.Text);
                cmd.Parameters.AddWithValue("@Prodi", txtProdi.Text);
                cmd.Parameters.AddWithValue("@Hp", txtHp.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Id", idSelected);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diupdate!");
                ClearForm();
                LoadMahasiswa();
                idSelected = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        // =====================================
        // BUTTON DELETE
        // =====================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSelected == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Komplain WHERE Id = @Id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", idSelected);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil dihapus!");
                    ClearForm();
                    LoadMahasiswa();
                    idSelected = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conn.Close();
                }
            }
        }

        // =====================================
        // BUTTON CLEAR
        // =====================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cmbJenis.SelectedIndex = -1;
            cmbSumberDaya.SelectedIndex = -1;
            txtIsi.Clear();
            txtNama.Clear();
            txtNim.Clear();
            txtProdi.Clear();
            txtHp.Clear();
            txtEmail.Clear();
            txtCari.Clear();
            idSelected = 0;
        }

        // =====================================
        // BUTTON TAMPIL
        // =====================================
        private void btnTampil_Click(object sender, EventArgs e)
        {
            LoadMahasiswa();
        }

        // =====================================
        // BUTTON CARI
        // =====================================
        private void BtnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadMahasiswa();
                return;
            }

            try
            {
                conn.Open();
                string query = @"SELECT * FROM Komplain 
                                 WHERE Nama LIKE @Keyword 
                                 OR Nim LIKE @Keyword 
                                 OR Prodi LIKE @Keyword";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgvKomplain.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        // =====================================
        // DATAGRIDVIEW CLICK
        // =====================================
        private void dgvKomplain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKomplain.Rows[e.RowIndex];
                idSelected = Convert.ToInt32(row.Cells["Id"].Value);
                cmbJenis.Text = row.Cells["Jenis"].Value.ToString();
                cmbSumberDaya.Text = row.Cells["SumberDaya"].Value.ToString();
                txtIsi.Text = row.Cells["Isi"].Value.ToString();
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                txtNim.Text = row.Cells["Nim"].Value.ToString();
                txtProdi.Text = row.Cells["Prodi"].Value.ToString();
                txtHp.Text = row.Cells["Hp"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}