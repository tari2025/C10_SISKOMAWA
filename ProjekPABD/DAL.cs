using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ProjekPABD
{
    public class DAL
    {
        public static string GetConnectionString()
        {
            return @"Data Source=LAPTOP-6B5BO8RM\SA;
                     Initial Catalog=ProjekPABD;
                     Integrated Security=True";
        }
        private readonly string connectionString = GetConnectionString();

        public static string GetLocalIPAddress()
        {
            string localIP = string.Empty;

            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting local IP address: " + ex.Message);
            }

            return localIP;
        }

        // =====================insert LOG========================

        public void InsertLog(string aktivitas, string detail = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string ip = GetLocalIPAddress();
                    string username = Environment.UserName;

                    string query = @"
                    INSERT INTO log_aktivitas
                    (username, aktivitas, tanggal, status, ip_address)
                    VALUES
                    (@username, @aktivitas, GETDATE(), @status, @ip)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@aktivitas", aktivitas + " " + detail);
                    cmd.Parameters.AddWithValue("@status", "Success");
                    cmd.Parameters.AddWithValue("@ip", ip);

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }
        // GET DATA KOMPLAIN
        // =============================================
        public DataTable GetDataKomplain()
        {
            DataTable dt = new DataTable();
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
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // =============================================
        // GET DATA CHART
        // =============================================
        public DataTable GetDataChart()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT 
                    sk.kategori,
                    COUNT(*) AS JumlahKomplain
                FROM saran_komplain s
                INNER JOIN sumber_daya_kampus sk 
                    ON s.id_sumber = sk.id_sumber
                GROUP BY sk.kategori
                ORDER BY COUNT(*) DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // =============================================
        // SEARCH DATA KOMPLAIN
        // =============================================
        public DataTable SearchDataKomplain(string keyword)
        {
            DataTable dt = new DataTable();
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
                WHERE 
                    m.nama LIKE @cari 
                    OR m.nim LIKE @cari 
                    OR s.jenis LIKE @cari 
                    OR s.status LIKE @cari
                ORDER BY s.created_at DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@cari", "%" + keyword + "%");
                da.Fill(dt);
            }
            return dt;
        }

        // =============================================
        // INSERT LOG KE DATABASE
        // =============================================
        public void InsertLog(string aktivitas, string detail = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string ip = GetLocalIPAddress();
                    string username = Environment.UserName;

                    string query = @"
                    INSERT INTO log_aktivitas (username, aktivitas, tanggal, status, ip_address)
                    VALUES (@username, @aktivitas, GETDATE(), @status, @ip)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@aktivitas", aktivitas + " " + detail);
                    cmd.Parameters.AddWithValue("@status", "Success");
                    cmd.Parameters.AddWithValue("@ip", ip);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error InsertLog: " + ex.Message);
            }
        }

        // =============================================
        // INSERT LOG UNTUK TEST INJECTION
        // =============================================
        public void insertLog(string aktivitas)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO log_aktivitas (aktivitas, tanggal) VALUES (@aktivitas, GETDATE())";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@aktivitas", aktivitas);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error InsertLog: " + ex.Message);
            }
        }

        // =============================================
        // SQL INJECTION - DEMONSTRASI KERENTANAN
        // =============================================
        public void TestInject(string nim)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE mahasiswa SET nama='HACKED' WHERE nim='" + nim + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        // =============================================
        // LOGIN ADMIN
        // =============================================
        public DataTable LoginAdmin(string username, string password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_admin, username, nama FROM admin WHERE username = @u AND password = @p";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@u", username);
                da.SelectCommand.Parameters.AddWithValue("@p", password);
                da.Fill(dt);
            }
            return dt;
        }

        // =============================================
        // LOGIN MAHASISWA
        // =============================================
        public DataTable LoginMahasiswa(string username, string password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_mhs, nim, nama, prodi FROM mahasiswa WHERE username = @u AND password = @p";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@u", username);
                da.SelectCommand.Parameters.AddWithValue("@p", password);
                da.Fill(dt);
            }
            return dt;
        }

        // =============================================
        // GET ALL MAHASISWA
        // =============================================
        public DataTable GetMahasiswa()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_mhs, nim, nama, prodi, no_hp, email, username FROM mahasiswa ORDER BY created_at DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // =============================================
        // INSERT MAHASISWA
        // =============================================
        public bool InsertMahasiswa(string nim, string nama, string prodi, string noHp, string email, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdCek = new SqlCommand("SELECT COUNT(*) FROM mahasiswa WHERE nim = @nim", conn);
                cmdCek.Parameters.AddWithValue("@nim", nim);
                int countNim = (int)cmdCek.ExecuteScalar();
                if (countNim > 0)
                {
                    throw new Exception("NIM sudah terdaftar!");
                }

                cmdCek = new SqlCommand("SELECT COUNT(*) FROM mahasiswa WHERE username = @username", conn);
                cmdCek.Parameters.AddWithValue("@username", username);
                int countUser = (int)cmdCek.ExecuteScalar();
                if (countUser > 0)
                {
                    throw new Exception("Username sudah digunakan!");
                }

                string query = @"
                INSERT INTO mahasiswa (nim, nama, prodi, no_hp, email, username, password)
                VALUES (@nim, @nama, @prodi, @no_hp, @email, @username, @password)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nim", nim);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@prodi", prodi);
                cmd.Parameters.AddWithValue("@no_hp", noHp);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =============================================
        // UPDATE KOMPLAIN
        // =============================================
        public bool UpdateKomplain(int idSaran, string status, string tanggapan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryStatus = "UPDATE saran_komplain SET status = @status WHERE id_saran = @id";
                    SqlCommand cmd = new SqlCommand(queryStatus, conn, transaction);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", idSaran);
                    cmd.ExecuteNonQuery();

                    string cekTanggapan = "SELECT COUNT(*) FROM tanggapan WHERE id_saran = @id";
                    SqlCommand cmdCek = new SqlCommand(cekTanggapan, conn, transaction);
                    cmdCek.Parameters.AddWithValue("@id", idSaran);
                    int count = (int)cmdCek.ExecuteScalar();

                    if (count == 0)
                    {
                        string queryInsert = @"
                        INSERT INTO tanggapan (id_saran, id_admin, isi_tanggapan, responded_at)
                        VALUES (@id, 1, @isi, GETDATE())";
                        SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction);
                        cmdInsert.Parameters.AddWithValue("@id", idSaran);
                        cmdInsert.Parameters.AddWithValue("@isi", tanggapan);
                        cmdInsert.ExecuteNonQuery();
                    }
                    else
                    {
                        string queryUpdate = @"
                        UPDATE tanggapan SET isi_tanggapan = @isi, responded_at = GETDATE()
                        WHERE id_saran = @id";
                        SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn, transaction);
                        cmdUpdate.Parameters.AddWithValue("@isi", tanggapan);
                        cmdUpdate.Parameters.AddWithValue("@id", idSaran);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // =============================================
        // GET REKAP DATA
        // =============================================
        public DataTable GetRekapData(int bulan, int tahun, string jenis = null, string status = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
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

                if (!string.IsNullOrEmpty(jenis) && jenis != "Semua")
                    query += " AND s.jenis = @jenis";

                if (!string.IsNullOrEmpty(status) && status != "Semua")
                    query += " AND s.status = @status";

                query += " ORDER BY s.created_at DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                da.SelectCommand.Parameters.AddWithValue("@tahun", tahun);

                if (!string.IsNullOrEmpty(jenis) && jenis != "Semua")
                    da.SelectCommand.Parameters.AddWithValue("@jenis", jenis);

                if (!string.IsNullOrEmpty(status) && status != "Semua")
                    da.SelectCommand.Parameters.AddWithValue("@status", status);

                da.Fill(dt);
            }
            return dt;
        
        }
    }
}