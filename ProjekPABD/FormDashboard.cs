using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjekPABD
{
    public partial class FormDashboard : Form
    {
        // =====================================
        // CONNECTION
        // =====================================
        private readonly string connectionString =
            "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        private SqlDataAdapter da;
        private DataSet ds;

        // =====================================
        // CONSTRUCTOR
        // =====================================
        public FormDashboard()
        {
            InitializeComponent();
        }

        // =====================================
        // FORM LOAD
        // =====================================
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = "SISKOMAWA";
                lblSubTitle.Text = "Sistem Informasi Saran dan Komplain Mahasiswa";

                if (cmbChartType.Items.Count > 0)
                    cmbChartType.SelectedIndex = 0;
                if (cmbDataCategory.Items.Count > 0)
                    cmbDataCategory.SelectedIndex = 0;

                TampilData();
                LoadChartData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================
        // TAMPIL DATA - DENGAN PRIVASI
        // =====================================
        private void TampilData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        m.nama AS Nama,
                        m.nim AS NIM,
                        s.jenis AS Jenis,
                        sk.kategori AS Kategori,
                        s.isi AS Isi,
                        s.status AS Status,
                        s.created_at AS Tanggal
                    FROM saran_komplain s
                    JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                    JOIN sumber_daya_kampus sk ON s.id_sumber = sk.id_sumber
                    ORDER BY s.created_at DESC";

                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds);

                    dgvDashboard.DataSource = ds.Tables[0];

                    if (dgvDashboard.Columns["Nama"] != null)
                        dgvDashboard.Columns["Nama"].Visible = false;
                    if (dgvDashboard.Columns["NIM"] != null)
                        dgvDashboard.Columns["NIM"].Visible = false;

                    lblTotalData.Text = "Total Data : " + dgvDashboard.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        // =====================================
        // LOAD CHART DATA
        // =====================================
        private void LoadChartData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (cmbDataCategory.SelectedItem == null)
                    {
                        MessageBox.Show("Silakan pilih kategori data terlebih dahulu!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string selectedCategory = cmbDataCategory.SelectedItem.ToString();
                    string query = "";

                    switch (selectedCategory)
                    {
                        case "Jenis Saran/Komplain":
                        case "📋 Jenis Saran/Komplain":
                            query = @"
                            SELECT 
                                s.jenis AS Kategori,
                                COUNT(*) AS Jumlah
                            FROM saran_komplain s
                            GROUP BY s.jenis
                            ORDER BY Jumlah DESC";
                            break;

                        case "Kategori Sumber Daya":
                        case "🏫 Kategori Sumber Daya":
                            query = @"
                            SELECT 
                                sk.kategori AS Kategori,
                                COUNT(*) AS Jumlah
                            FROM saran_komplain s
                            JOIN sumber_daya_kampus sk ON s.id_sumber = sk.id_sumber
                            GROUP BY sk.kategori
                            ORDER BY Jumlah DESC";
                            break;

                        case "Status":
                        case "📌 Status":
                            query = @"
                            SELECT 
                                s.status AS Kategori,
                                COUNT(*) AS Jumlah
                            FROM saran_komplain s
                            GROUP BY s.status
                            ORDER BY Jumlah DESC";
                            break;

                        default:
                            query = @"
                            SELECT 
                                s.jenis AS Kategori,
                                COUNT(*) AS Jumlah
                            FROM saran_komplain s
                            GROUP BY s.jenis
                            ORDER BY Jumlah DESC";
                            break;
                    }

                    da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    chartKomplain.Series["Jumlah Data"].Points.Clear();
                    chartKomplain.Series["Distribusi"].Points.Clear();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Tidak ada data untuk ditampilkan di chart!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        string category = row["Kategori"].ToString();
                        int jumlah = Convert.ToInt32(row["Jumlah"]);

                        chartKomplain.Series["Jumlah Data"].Points.AddXY(category, jumlah);
                        chartKomplain.Series["Distribusi"].Points.AddXY(category, jumlah);
                    }

                    chartKomplain.Titles.Clear();
                    Title title = new Title($"Distribusi Data - {selectedCategory}");
                    title.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                    chartKomplain.Titles.Add(title);

                    UpdateChartType();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================
        // UPDATE CHART TYPE
        // =====================================
        private void UpdateChartType()
        {
            try
            {
                string selectedType = cmbChartType.SelectedItem?.ToString() ?? "Bar Chart";

                switch (selectedType)
                {
                    case "Bar Chart":
                        chartKomplain.Series["Jumlah Data"].Enabled = true;
                        chartKomplain.Series["Jumlah Data"].ChartType = SeriesChartType.Column;
                        chartKomplain.Series["Distribusi"].Enabled = false;
                        chartKomplain.Series["Jumlah Data"].IsValueShownAsLabel = true;
                        break;

                    case "Pie Chart":
                        chartKomplain.Series["Jumlah Data"].Enabled = false;
                        chartKomplain.Series["Distribusi"].Enabled = true;
                        chartKomplain.Series["Distribusi"].ChartType = SeriesChartType.Pie;
                        chartKomplain.Series["Distribusi"].Label = "#PERCENT{P0}";
                        chartKomplain.Series["Distribusi"].IsValueShownAsLabel = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================
        // CARI DATA
        // =====================================
        private void CariData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        m.nama AS Nama,
                        m.nim AS NIM,
                        s.jenis AS Jenis,
                        sk.kategori AS Kategori,
                        s.isi AS Isi,
                        s.status AS Status,
                        s.created_at AS Tanggal
                    FROM saran_komplain s
                    JOIN mahasiswa m ON s.id_mhs = m.id_mhs
                    JOIN sumber_daya_kampus sk ON s.id_sumber = sk.id_sumber
                    WHERE m.nama LIKE @cari OR m.nim LIKE @cari OR s.jenis LIKE @cari OR s.status LIKE @cari
                    ORDER BY s.created_at DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvDashboard.DataSource = ds.Tables[0];

                    if (dgvDashboard.Columns["Nama"] != null)
                        dgvDashboard.Columns["Nama"].Visible = false;
                    if (dgvDashboard.Columns["NIM"] != null)
                        dgvDashboard.Columns["NIM"].Visible = false;

                    lblTotalData.Text = "Total Data : " + dgvDashboard.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        // =====================================
        // EVENT HANDLERS
        // =====================================
        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartType();
        }

        private void cmbDataCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            CariData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtCari.Text = "Cari data...";
                txtCari.ForeColor = System.Drawing.Color.Gray;
                TampilData();
                LoadChartData();
                MessageBox.Show("✅ Data berhasil direfresh!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            try
            {
                LoadChartData();
                MessageBox.Show("✅ Chart berhasil direfresh!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                TampilData();
                LoadChartData();
                MessageBox.Show("✅ Data berhasil dimuat!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoginMahasiswa_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =====================================
        // TEXTBOX CARI 
        // =====================================
        private void txtCari_Enter(object sender, EventArgs e)
        {
            if (txtCari.Text == "Cari data...")
            {
                txtCari.Text = "";
                txtCari.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCari_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                txtCari.Text = "Cari data...";
                txtCari.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // =====================================
        // EMPTY EVENT HANDLERS (untuk desain)
        // =====================================
        private void lblSubTitle_Click(object sender, EventArgs e) { }
        private void pictureLogo_Click(object sender, EventArgs e) { }
        private void dgvDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
    }
}
