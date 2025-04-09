using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Code Bagian Miliki Edsel Septa Haryanto - 103022300016
            var basePath = AppContext.BaseDirectory; // Mencari path base program dijalankan
            var pathDataMahasiswa_Edsel = Path.Combine(basePath, "Jurnal7_1_103022300016.json"); // Menggabungkan path base dengan nama file json untuk menuju path json
            DataMahasiswa_103022300016.ReadJson(pathDataMahasiswa_Edsel); // Memanggil method ReadJson untuk membaca file json
        }
    }
}