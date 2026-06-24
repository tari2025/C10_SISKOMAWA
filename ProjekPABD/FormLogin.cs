using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormLogin : Form
    {
        // =====================================
        // TAMBAHKAN INI (PROPERTY UNTUK LOG)
        // =====================================
        public static int CurrentUserID { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentRole { get; set; }

        private readonly string connectionString =
            "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True";

        public FormLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        // ====================================
        // LOAD
        // ====================================
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        // ====================================
        // TEST KONEKSI
        // ====================================
        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Koneksi database berhasil!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
        }

        // ====================================
        // LOGIN
        // ====================================
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ====================================
                    // LOGIN ADMIN
                    // ====================================
                    SqlCommand cmdAdmin = new SqlCommand(
                        "SELECT id_admin FROM admin WHERE username=@u AND password=@p", conn);

                    cmdAdmin.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmdAdmin.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                    object resultAdmin = cmdAdmin.ExecuteScalar();

                    if (resultAdmin != null)
                    {
                        int idAdmin = Convert.ToInt32(resultAdmin);
                        string username = txtUsername.Text.Trim();

                        // =====================================
                        // TAMBAHKAN INI (SETELAH LOGIN BERHASIL)
                        // =====================================
                        CurrentUserID = idAdmin;
                        CurrentUsername = username;
                        CurrentRole = "Admin";

                        // LOG LOGIN
                        DAL dal = new DAL();
                        dal.InsertLog("LOGIN", $"Login berhasil sebagai Admin - IP: {GetLocalIPAddress()}");

                        MessageBox.Show("Login sebagai Admin");

                        FormAdmin.idAdmin = idAdmin;
                        FormAdmin f = new FormAdmin();
                        this.Hide();
                        f.Show();
                        return;
                    }

                    // ====================================
                    // LOGIN MAHASISWA
                    // ====================================
                    SqlCommand cmdMhs = new SqlCommand(
                        "SELECT id_mhs FROM mahasiswa WHERE username=@u AND password=@p", conn);

                    cmdMhs.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmdMhs.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                    object resultMhs = cmdMhs.ExecuteScalar();

                    if (resultMhs != null)
                    {
                        int idMhs = Convert.ToInt32(resultMhs);
                        string username = txtUsername.Text.Trim();

                        // =====================================
                        // TAMBAHKAN INI (SETELAH LOGIN BERHASIL)
                        // =====================================
                        CurrentUserID = idMhs;
                        CurrentUsername = username;
                        CurrentRole = "Mahasiswa";

                        // LOG LOGIN
                        DAL dal = new DAL();
                        dal.InsertLog("LOGIN", $"Login berhasil sebagai Mahasiswa - IP: {GetLocalIPAddress()}");

                        MessageBox.Show("Login sebagai Mahasiswa");

                        FormMahasiswa.idMahasiswa = idMhs;
                        FormMahasiswa f = new FormMahasiswa();
                        this.Hide();
                        f.Show();
                        return;
                    }

                    // ====================================
                    // LOGIN GAGAL
                    // ====================================
                    DAL dalError = new DAL();
                    dalError.InsertLog("LOGIN GAGAL", $"Username: {txtUsername.Text} - Password salah");

                    MessageBox.Show("Username / Password salah!");
                }
            }
            catch (Exception ex)
            {
                // ====================================
                // LOG ERROR
                // ====================================
                DAL dalError = new DAL();
                dalError.InsertLog("ERROR", ex.Message);

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        // ====================================
        // RESET LOGIN
        // ====================================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // ====================================
        // KELUAR
        // ====================================
        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // =====================================
        // TAMBAHKAN INI (METHOD AMBIL IP)
        // =====================================
        private string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "127.0.0.1";
            }
            catch
            {
                return "Unknown";
            }
        }
    }
}