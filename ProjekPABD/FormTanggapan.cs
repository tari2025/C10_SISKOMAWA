using System;
using System.Windows.Forms;

namespace SISKOMAWA
{
    public partial class FormTanggapan : Form
    {
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
    }
}