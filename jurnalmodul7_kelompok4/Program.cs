using System;
using System.IO;
using jurnalmodul7_kelompok4; // Import namespace yang isinya class DataMahasiswa dan KuliahMahasiswa

class program
{
    static void Main(string[] args)
    {
        // Panggil method ReadJSON dari class DataMahasiswa buat baca file JSON mahasiswa
        DataMahasiswa_103022300101.ReadJSON();

        Console.WriteLine(" "); // Biar ada jarak/pemisah di output console

        TeamMembers_103022300101.ReadJson();

        Console.WriteLine("");

        GlossaryItem_103022300101.ReadJSON();
    }
}
