using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekPABD
{
    public partial class FormTanggapan : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        private void Koneksi()
        {
            conn = new SqlConnection("Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=ProjekPABD;Integrated Security=True");
        }


        public FormTanggapan()
        {
            InitializeComponent();
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

        private void txtIsiTanggapan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdSaran_TextChanged(object sender, EventArgs e)
        {

        }
    }
}