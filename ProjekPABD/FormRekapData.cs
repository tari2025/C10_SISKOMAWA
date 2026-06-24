using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjekPABD
{
    public partial class FormRekapData : Form
    {
        private readonly string connectionString = "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dtRekap;

        public FormRekapData()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormRekapData_Load(object sender, EventArgs e)
        {
            dtpBulan.Value = DateTime.Now;
            cmbJenis.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                int bulan = dtpBulan.Value.Month;
                int tahun = dtpBulan.Value.Year;

                string jenisFilter = cmbJenis.SelectedItem?.ToString() ?? "Semua";
                string statusFilter = cmbStatus.SelectedItem?.ToString() ?? "Semua";

                string query = @"
                SELECT 
                    m.nama,
                    m.nim,
                    s.jenis,
                    sk.kategori AS Kategori,
                    s.isi,
                    s.status,
                    s.created_at AS Tanggal,
                    ISNULL(t.isi_tanggapan, '-') AS Tanggapan
                FROM saran_komplain s
                JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                JOIN sumber_daya_kampus sk ON s.id_sumber = sk.id_sumber
                LEFT JOIN tanggapan t ON s.id_saran = t.id_saran
                WHERE MONTH(s.created_at) = @bulan 
                AND YEAR(s.created_at) = @tahun";

                if (jenisFilter != "Semua")
                    query += " AND s.jenis = @jenis";

                if (statusFilter != "Semua")
                    query += " AND s.status = @status";

                query += " ORDER BY s.created_at DESC";

                da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                da.SelectCommand.Parameters.AddWithValue("@tahun", tahun);

                if (jenisFilter != "Semua")
                    da.SelectCommand.Parameters.AddWithValue("@jenis", jenisFilter.ToLower());

                if (statusFilter != "Semua")
                    da.SelectCommand.Parameters.AddWithValue("@status", statusFilter.ToLower());

                dtRekap = new DataTable();
                da.Fill(dtRekap);

                dgvRekap.DataSource = dtRekap;
                RenameColumns();
                lblTotalData.Text = $"Total Data : {dtRekap.Rows.Count}";

                conn.Close();

                dgvRekap.Visible = true;
                lblTotalData.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void RenameColumns()
        {
            if (dgvRekap.Columns["nama"] != null)
                dgvRekap.Columns["nama"].HeaderText = "Nama Mahasiswa";
            if (dgvRekap.Columns["nim"] != null)
                dgvRekap.Columns["nim"].HeaderText = "NIM";
            if (dgvRekap.Columns["jenis"] != null)
                dgvRekap.Columns["jenis"].HeaderText = "Jenis";
            if (dgvRekap.Columns["Kategori"] != null)
                dgvRekap.Columns["Kategori"].HeaderText = "Kategori";
            if (dgvRekap.Columns["isi"] != null)
                dgvRekap.Columns["isi"].HeaderText = "Isi";
            if (dgvRekap.Columns["status"] != null)
                dgvRekap.Columns["status"].HeaderText = "Status";
            if (dgvRekap.Columns["Tanggal"] != null)
                dgvRekap.Columns["Tanggal"].HeaderText = "Tanggal Dibuat";
            if (dgvRekap.Columns["Tanggapan"] != null)
                dgvRekap.Columns["Tanggapan"].HeaderText = "Tanggapan Admin";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dtpBulan.Value = DateTime.Now;
            cmbJenis.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            LoadData();
        }

        // =============================================
        // CETAK PAKAI CRYSTAL REPORT (SESUAI MODUL)
        // =============================================
        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dtRekap == null || dtRekap.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 1. Load Crystal Report
                ReportDocument report = new ReportDocument();
                string reportPath = Application.StartupPath + "\\CrystalReport.rpt";

                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show($"File laporan tidak ditemukan!\n{reportPath}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                report.Load(reportPath);

                // 2. Ambil data dengan format sesuai DSKomplain
                DataTable dtCetak = GetDataForReport();

                // 3. Set DataSource
                DataSet ds = new DataSet();
                ds.Tables.Add(dtCetak);
                ds.Tables[0].TableName = "DSkomplain"; // Nama class DSKomplain

                report.SetDataSource(ds);

                // 4. Buka FormReport (seperti di modul)
                FormReport frm = new FormReport(report);
                frm.ShowDialog(); // Tampilkan Crystal Report Viewer
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Cetak: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================
        // AMBIL DATA UNTUK REPORT (SESUAI DataReport)
        // =============================================
        private DataTable GetDataForReport()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                int bulan = dtpBulan.Value.Month;
                int tahun = dtpBulan.Value.Year;
                string jenisFilter = cmbJenis.SelectedItem?.ToString() ?? "Semua";
                string statusFilter = cmbStatus.SelectedItem?.ToString() ?? "Semua";

                string query = @"
                SELECT 
                    s.id_saran,
                    s.id_mhs,
                    m.nim,
                    m.nama,
                    m.prodi,
                    sk.kategori,
                    s.jenis,
                    s.isi,
                    s.status,
                    ISNULL(t.isi_tanggapan, '-') AS tanggapan,
                    s.created_at
                FROM saran_komplain s
                JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                JOIN sumber_daya_kampus sk ON s.id_sumber = sk.id_sumber
                LEFT JOIN tanggapan t ON s.id_saran = t.id_saran
                WHERE MONTH(s.created_at) = @bulan 
                AND YEAR(s.created_at) = @tahun";

                if (jenisFilter != "Semua")
                    query += " AND s.jenis = @jenis";
                if (statusFilter != "Semua")
                    query += " AND s.status = @status";

                query += " ORDER BY s.created_at DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                da.SelectCommand.Parameters.AddWithValue("@tahun", tahun);
                if (jenisFilter != "Semua")
                    da.SelectCommand.Parameters.AddWithValue("@jenis", jenisFilter.ToLower());
                if (statusFilter != "Semua")
                    da.SelectCommand.Parameters.AddWithValue("@status", statusFilter.ToLower());

                da.Fill(dt);
            }
            return dt;
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Yakin ingin keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvRekap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}