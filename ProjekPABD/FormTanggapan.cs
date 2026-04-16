using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");

        public FormMahasiswa()
        {
            InitializeComponent();
        }

        // Kalau mau kirim ID dari Admin
        public FormTanggapan(string id)
        {
            InitializeComponent();
            txtIdSaran.Text = id;
        }

        private void FormTanggapan_Load(object sender, EventArgs e)
        {
            txtIdSaran.Clear();
            txtIsiTanggapan.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtIdSaran.Text == "" || txtIsiTanggapan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!");
                return;
            }

            MessageBox.Show("Tanggapan berhasil disimpan!");

            txtIdSaran.Clear();
            txtIsiTanggapan.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}