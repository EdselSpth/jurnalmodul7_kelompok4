
﻿using jurnalmodul7_kelompok4;
﻿using System;

class program
{
    static void Main(string[] args)
    {
        var basepath = AppContext.BaseDirectory;
        var pathData = Path.Combine(basepath, "jurnal7_1_103022300088.json");
        var pathmem = Path.Combine(basepath, "jurnal7_2_103022300088.json");
        var pathgloss = Path.Combine(basepath, "jurnal7_3_103022300088.json");
        DataMahasiswa103022300088.ReadJSON(pathData);
        Console.WriteLine(" ");
        TeamMembers103022300088.ReadJson(pathmem);
        Console.WriteLine(" ");
        GlossaryReader103022300088.ReadJSON(pathgloss);
        DataMahasiswa_103022300109.ReadJSON();
        Console.WriteLine(" ");
        TeamMembers_103022300109.ReadJSON();
        Console.WriteLine(" ");
        GlossaryItem_103022300109.ReadJSON();
       // Code Bagian Miliki Edsel Septa Haryanto - 103022300016
            var basePath = AppContext.BaseDirectory; // Mencari path base program dijalankan
            var pathDataMahasiswa_Edsel = Path.Combine(basePath, "Jurnal7_1_103022300016.json"); // Menggabungkan path base dengan nama file json untuk menuju path json
            DataMahasiswa_103022300016.ReadJson(pathDataMahasiswa_Edsel); // Memanggil method ReadJson untuk membaca file json

            Console.WriteLine();
            var pathTeamMembers_Edsel = Path.Combine(basePath, "Jurnal7_2_103022300016.json"); // Menggabungkan path base dengan nama file json untuk menuju path json
            TeamMembers_103022300016.readJson(pathTeamMembers_Edsel); // Memanggil method readJson untuk membaca file json

            Console.WriteLine();
            var pathGlossary_Edsel = Path.Combine(basePath, "Jurnal7_3_103022300016.json"); // Menggabungkan path base dengan nama file json untuk menuju path json
            GlossaryItem_103022300016.ReadJSON(pathGlossary_Edsel); // Memanggil method readJson untuk membaca file json
        }
    }
}

