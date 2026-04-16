using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private readonly string connectionString =
        "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=projekPABD;Integrated Security=True";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // boleh kosong
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Username dan Password wajib diisi!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // CEK MAHASISWA
                    SqlCommand cmdMhs = new SqlCommand(
                        "SELECT COUNT(*) FROM mahasiswa WHERE username=@u AND password=@p", conn);

                    cmdMhs.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmdMhs.Parameters.AddWithValue("@p", txtPassword.Text);

                    int mhs = (int)cmdMhs.ExecuteScalar();

                    if (mhs > 0)
                    {
                        MessageBox.Show("Login sebagai Mahasiswa");

                        FormMahasiswa f = new FormMahasiswa();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        return;
                    }

                    // CEK ADMIN
                    SqlCommand cmdAdmin = new SqlCommand(
                        "SELECT COUNT(*) FROM admin WHERE username=@u AND password=@p", conn);

                    cmdAdmin.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmdAdmin.Parameters.AddWithValue("@p", txtPassword.Text);

                    int adm = (int)cmdAdmin.ExecuteScalar();

                    if (adm > 0)
                    {
                        MessageBox.Show("Login sebagai Admin");

                        FormAdmin f = new FormAdmin();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username / Password salah!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}