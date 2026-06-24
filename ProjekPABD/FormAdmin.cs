using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace ProjekPABD
{
    public partial class FormAdmin : Form
    {
        // =====================================
        // CONNECTION
        // =====================================
        private readonly string connectionString =
            "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dtKomplain;
        private SqlCommand cmd;
        private DataTable dtExcel = new DataTable();
        private int idSaran = 0;
        public static int idAdmin = 1;

        // =====================================
        // CONSTRUCTOR
        // =====================================
        public FormAdmin()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        // =====================================
        // LOAD
        // =====================================
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("menunggu");
            cmbStatus.Items.Add("diproses");
            cmbStatus.Items.Add("selesai");

            TampilData();
        }

        // =====================================
        // METHOD HELPER - SEMBUNYIKAN KOLOM
        // =====================================
        private void SembunyikanKolom()
        {
            if (dgvAdmin.Columns["id_saran"] != null)
                dgvAdmin.Columns["id_saran"].Visible = false;

            if (dgvAdmin.Columns["isi_tanggapan"] != null)
                dgvAdmin.Columns["isi_tanggapan"].Visible = false;

            if (dgvAdmin.Columns["responded_at"] != null)
                dgvAdmin.Columns["responded_at"].Visible = false;
        }

        // =====================================
        // TAMPIL DATA
        // =====================================
        private void TampilData(string keyword = "")
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string query = @"
                SELECT 
                    s.id_saran,
                    m.nama,
                    m.nim,
                    s.jenis,
                    s.isi,
                    s.status,
                    s.created_at,
                    ISNULL(t.isi_tanggapan, '') AS isi_tanggapan,
                    t.responded_at
                FROM saran_komplain s
                JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                LEFT JOIN tanggapan t ON s.id_saran = t.id_saran
                ORDER BY s.created_at DESC";

                da = new SqlDataAdapter(query, conn);
                dtKomplain = new DataTable();
                da.Fill(dtKomplain);

                dgvAdmin.DataSource = dtKomplain;
                SembunyikanKolom();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // CARI DATA
        // =====================================
        private void CariData()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string query = @"
                SELECT
                    s.id_saran,
                    m.nama,
                    m.nim,
                    s.jenis,
                    s.isi,
                    s.status,
                    s.created_at,
                    ISNULL(t.isi_tanggapan, '') AS isi_tanggapan,
                    t.responded_at
                FROM saran_komplain s
                JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                LEFT JOIN tanggapan t ON s.id_saran = t.id_saran
                WHERE 
                    m.nama LIKE @cari 
                    OR m.nim LIKE @cari 
                    OR s.jenis LIKE @cari 
                    OR s.status LIKE @cari
                ORDER BY s.created_at DESC";

                da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text + "%");

                dtKomplain = new DataTable();
                da.Fill(dtKomplain);

                dgvAdmin.DataSource = dtKomplain;
                SembunyikanKolom();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // GRID CLICK
        // =====================================
        private void DgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];

                if (dgvAdmin.Columns["id_saran"] != null)
                {
                    idSaran = Convert.ToInt32(row.Cells["id_saran"].Value);
                }

                if (dgvAdmin.Columns["status"] != null)
                {
                    cmbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
                }

                if (dgvAdmin.Columns["isi_tanggapan"] != null)
                {
                    txtTanggapan.Text = row.Cells["isi_tanggapan"].Value?.ToString() ?? "";
                }
            }
        }

        // =====================================
        // SIMPAN TANGGAPAN
        // =====================================
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (idSaran == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTanggapan.Text))
            {
                MessageBox.Show("Tanggapan tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string updateStatus = @"
                UPDATE saran_komplain 
                SET status = @status 
                WHERE id_saran = @id";

                cmd = new SqlCommand(updateStatus, conn);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", idSaran);
                cmd.ExecuteNonQuery();

                string cekTanggapan = "SELECT COUNT(*) FROM tanggapan WHERE id_saran = @id";
                cmd = new SqlCommand(cekTanggapan, conn);
                cmd.Parameters.AddWithValue("@id", idSaran);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    string insert = @"
                    INSERT INTO tanggapan (id_saran, id_admin, isi_tanggapan, responded_at)
                    VALUES (@id_saran, @id_admin, @isi, GETDATE())";

                    cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@id_saran", idSaran);
                    cmd.Parameters.AddWithValue("@id_admin", idAdmin);
                    cmd.Parameters.AddWithValue("@isi", txtTanggapan.Text);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string updateTanggapan = @"
                    UPDATE tanggapan 
                    SET isi_tanggapan = @isi, responded_at = GETDATE()
                    WHERE id_saran = @id";

                    cmd = new SqlCommand(updateTanggapan, conn);
                    cmd.Parameters.AddWithValue("@isi", txtTanggapan.Text);
                    cmd.Parameters.AddWithValue("@id", idSaran);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("Tanggapan berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TampilData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // RESET FORM
        // =====================================
        private void ResetForm()
        {
            txtTanggapan.Clear();
            cmbStatus.SelectedIndex = -1;
            idSaran = 0;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
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
            ResetForm();
        }

        // =====================================
        // BUTTON REKAP DATA
        // =====================================
        private void btnRekapData_Click(object sender, EventArgs e)
        {
            FormRekapData f = new FormRekapData();
            f.ShowDialog();
        }

        // =====================================
        // IMPORT EXCEL
        // =====================================
        private void BtnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Pilih File Excel";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.License.SetNonCommercialPersonal("PABD");

                    using (var package = new ExcelPackage(new FileInfo(ofd.FileName)))
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets[0];
                        dtExcel = new DataTable();

                        for (int col = 1; col <= ws.Dimension.End.Column; col++)
                        {
                            dtExcel.Columns.Add(ws.Cells[1, col].Text);
                        }

                        for (int row = 2; row <= ws.Dimension.End.Row; row++)
                        {
                            DataRow dr = dtExcel.NewRow();
                            for (int col = 1; col <= ws.Dimension.End.Column; col++)
                            {
                                dr[col - 1] = ws.Cells[row, col].Text;
                            }
                            dtExcel.Rows.Add(dr);
                        }
                    }

                    dgvAdmin.DataSource = dtExcel;
                    MessageBox.Show($"Excel berhasil dibaca! {dtExcel.Rows.Count} data ditemukan.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error import Excel: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================
        // IMPORT EXCEL KE DATABASE
        // =====================================
        private void btnImportDatabase_Click(object sender, EventArgs e)
        {
            if (dtExcel.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diimport! Import Excel terlebih dahulu.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Yakin ingin mengimport {dtExcel.Rows.Count} data ke database?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                int successCount = 0;
                int errorCount = 0;

                foreach (DataRow row in dtExcel.Rows)
                {
                    try
                    {
                        string query = @"
                        INSERT INTO mahasiswa (nim, nama, prodi, no_hp, email, username, password)
                        VALUES (@nim, @nama, @prodi, @hp, @email, @username, @password)";

                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nim", row["nim"]?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@nama", row["nama"]?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@prodi", row["prodi"]?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@hp", row["no_hp"]?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@email", row["email"]?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@username", row["username"]?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@password", row["password"]?.ToString() ?? "");

                        cmd.ExecuteNonQuery();
                        successCount++;
                    }
                    catch
                    {
                        errorCount++;
                    }
                }

                conn.Close();

                MessageBox.Show($"Import selesai!\n✅ Berhasil: {successCount} data\n❌ Gagal: {errorCount} data",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TampilData();
                dtExcel.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error import ke database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // =====================================
        // KELUAR
        // =====================================
        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Yakin ingin keluar dari form admin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =====================================
        // EMPTY EVENT HANDLERS
        // =====================================
        private void pictureBoxLogo_Click(object sender, EventArgs e) { }
        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}