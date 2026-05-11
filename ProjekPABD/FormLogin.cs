using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormLogin : Form
    {
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
        private void FormLogin_Load(
            object sender,
            EventArgs e)
        {

        }

        // ====================================
        // TEST KONEKSI
        // ====================================
        private void btnTesKoneksi_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    MessageBox.Show(
                        "Koneksi database berhasil!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Koneksi gagal : " + ex.Message);
            }
        }

        // ====================================
        // LOGIN
        // ====================================
        private void BtnLogin_Click(
            object sender,
            EventArgs e)
        {
            if (
                txtUsername.Text == "" ||
                txtPassword.Text == ""
            )
            {
                MessageBox.Show(
                    "Username dan Password wajib diisi!");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ====================================
                    //
                    // ====================================
                    // LOGIN ADMIN
                    // ====================================
                    SqlCommand cmdAdmin =
                        new SqlCommand(
                        "SELECT id_admin FROM admin WHERE username=@u AND password=@p",
                        conn);

                    cmdAdmin.Parameters.AddWithValue(
                        "@u",
                        txtUsername.Text.Trim());

                    cmdAdmin.Parameters.AddWithValue(
                        "@p",
                        txtPassword.Text.Trim());

                    object resultAdmin =
                        cmdAdmin.ExecuteScalar();

                    if (resultAdmin != null)
                    {
                        MessageBox.Show(
                            "Login sebagai Admin");

                        FormAdmin.idAdmin =
                            Convert.ToInt32(resultAdmin);

                        FormAdmin f =
                            new FormAdmin();

                        this.Hide();

                        f.Show();

                        return;
                    }
                    // LOGIN MAHASISWA (AMAN)
                    // ====================================
                    SqlCommand cmdMhs =
                        new SqlCommand(
                        "SELECT id_mhs FROM mahasiswa WHERE username=@u AND password=@p",
                        conn);

                    cmdMhs.Parameters.AddWithValue(
                        "@u",
                        txtUsername.Text.Trim());

                    cmdMhs.Parameters.AddWithValue(
                        "@p",
                        txtPassword.Text.Trim());

                    object resultMhs =
                        cmdMhs.ExecuteScalar();

                    if (resultMhs != null)
                    {
                        MessageBox.Show(
                            "Login sebagai Mahasiswa");

                        FormMahasiswa.idMahasiswa =
                            Convert.ToInt32(resultMhs);

                        FormMahasiswa f =
                            new FormMahasiswa();

                        this.Hide();

                        f.Show();

                        return;
                    }

                    
                 

                    // ====================================
                    // LOGIN GAGAL
                    // ====================================
                    MessageBox.Show(
                        "Username / Password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error : " + ex.Message);
            }
        }

        // ====================================
        // RESET LOGIN
        // ====================================
        private void btnReset_Click(
            object sender,
            EventArgs e)
        {
            txtUsername.Clear();

            txtPassword.Clear();

            txtUsername.Focus();
        }

     
        // ====================================
        // KELUAR
        // ====================================
        private void btnKeluar_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}