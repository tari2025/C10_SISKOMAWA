using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPABD
{
    internal class DataReportClass
    {
        // =============================================
        // CLASS DATA UNTUK REPORT
        // =============================================
        public class DataReport
        {
            public int id_saran { get; set; }
            public int id_mhs { get; set; }
            public string nim { get; set; }
            public string nama { get; set; }
            public string prodi { get; set; }
            public string kategori { get; set; }
            public string jenis { get; set; }
            public string isi { get; set; }
            public string status { get; set; }
            public string tanggapan { get; set; }
            public DateTime created_at { get; set; }
        }
    }
}
