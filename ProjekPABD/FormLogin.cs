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

            // password jadi bintang
            txtPassword.UseSystemPasswordChar = true;
        }

        // ===============================
        // LOAD (WAJIB ADA UNTUK DESIGNER)
        // ===============================
        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        // ===============================
        // LOGIN
        // ===============================
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

                    // ===============================
                    // CEK MAHASISWA
                    // ===============================
                    SqlCommand cmdMhs = new SqlCommand(
                        "SELECT id_mhs FROM mahasiswa WHERE username=@u AND password=@p", conn);

                    cmdMhs.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmdMhs.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                    object resultMhs = cmdMhs.ExecuteScalar();

                    if (resultMhs != null)
                    {
                        MessageBox.Show("Login sebagai Mahasiswa");

                        FormMahasiswa f = new FormMahasiswa();
                        f.idMhs = resultMhs.ToString();

                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                        return;
                    }

                    // ===============================
                    // CEK ADMIN
                    // ===============================
                    SqlCommand cmdAdmin = new SqlCommand(
                        "SELECT id_admin FROM admin WHERE username=@u AND password=@p", conn);

                    cmdAdmin.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmdAdmin.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                    object resultAdmin = cmdAdmin.ExecuteScalar();

                    if (resultAdmin != null)
                    {
                        MessageBox.Show("Login sebagai Admin");

                        FormAdmin f = new FormAdmin();

                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                        return;
                    }

                    // ===============================
                    // SALAH
                    // ===============================
                    MessageBox.Show("Username / Password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ===============================
        // RESET
        // ===============================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // ===============================
        // KELUAR
        // ===============================
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}