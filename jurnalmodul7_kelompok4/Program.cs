using System;
using System.IO;
using jurnalmodul7_kelompok4; // Import namespace yang isinya class DataMahasiswa dan KuliahMahasiswa

class program
{
    static void Main(string[] args)
    {
        // Panggil method ReadJSON dari class DataMahasiswa buat baca file JSON mahasiswa
        DataMahasiswa_103022300109.ReadJSON();

        Console.WriteLine(" "); // Biar ada jarak/pemisah di output console

        // Panggil method ReadJson dari class KuliahMahasiswa buat baca file JSON course mata kuliah
        //KuliahMahasiswa_103022300101.ReadJson(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_2_103022300101.json");
    }
}
