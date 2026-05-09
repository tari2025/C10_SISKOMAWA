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
        

        // ====================================
        // LOGIN
        // ====================================
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
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
                    // MODE VULNERABLE
                    // ====================================

                    if (cmbMode.Text == "Vulnerable")
                    {
                        // =========================
                        // LOGIN MAHASISWA
                        // =========================

                        string queryMhs =
                            "SELECT id_mhs FROM mahasiswa " +
                            "WHERE username='"
                            + txtUsername.Text +
                            "' AND password='"
                            + txtPassword.Text + "'";

                        SqlCommand cmdMhs =
                            new SqlCommand(
                            queryMhs,
                            conn);

                        object resultMhs =
                            cmdMhs.ExecuteScalar();

                        if (resultMhs != null)
                        {
                            MessageBox.Show(
                                "Login Mahasiswa berhasil (Vulnerable)");

                            FormMahasiswa.idMahasiswa =
                                Convert.ToInt32(resultMhs);

                            FormMahasiswa f =
                                new FormMahasiswa();

                            this.Hide();

                            f.Show();

                            return;
                        }

                        // =========================
                        // LOGIN ADMIN
                        // =========================

                        string queryAdmin =
                            "SELECT id_admin FROM admin " +
                            "WHERE username='"
                            + txtUsername.Text +
                            "' AND password='"
                            + txtPassword.Text + "'";

                        SqlCommand cmdAdmin =
                            new SqlCommand(
                            queryAdmin,
                            conn);

                        object resultAdmin =
                            cmdAdmin.ExecuteScalar();

                        if (resultAdmin != null)
                        {
                            MessageBox.Show(
                                "Login Admin berhasil (Vulnerable)");

                            FormAdmin.idAdmin =
                                Convert.ToInt32(resultAdmin);

                            FormAdmin f =
                                new FormAdmin();

                            this.Hide();

                            f.Show();

                            return;
                        }
                    }

                    // ====================================
                    // MODE SECURE
                    // ====================================
                    else
                    {
                        // =========================
                        // LOGIN MAHASISWA
                        // =========================

                        SqlCommand cmdMhs =
                            new SqlCommand(
                            "SELECT id_mhs FROM mahasiswa " +
                            "WHERE username=@u " +
                            "AND password=@p",
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
                                "Login Mahasiswa berhasil (Secure)");

                            FormMahasiswa.idMahasiswa =
                                Convert.ToInt32(resultMhs);

                            FormMahasiswa f =
                                new FormMahasiswa();

                            this.Hide();

                            f.Show();

                            return;
                        }

                        // =========================
                        // LOGIN ADMIN
                        // =========================

                        SqlCommand cmdAdmin =
                            new SqlCommand(
                            "SELECT id_admin FROM admin " +
                            "WHERE username=@u " +
                            "AND password=@p",
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
                                "Login Admin berhasil (Secure)");

                            FormAdmin.idAdmin =
                                Convert.ToInt32(resultAdmin);

                            FormAdmin f =
                                new FormAdmin();

                            this.Hide();

                            f.Show();

                            return;
                        }
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
        // TEST SQL INJECTION
        // ====================================
        private void btnTest_Click(object sender, EventArgs e)
        {
            txtUsername.Text =
                "' OR 1=1 --";

            txtPassword.Text =
                "bebas";

            MessageBox.Show(
                "Payload SQL Injection berhasil dimasukkan");
        }

        // ====================================
        // RESET TEST
        // ====================================
        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();

            txtPassword.Clear();

            cmbMode.SelectedIndex = 1;

            txtUsername.Focus();

            MessageBox.Show(
                "Form berhasil direset");
        }

        // ====================================
        // RESET
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
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}