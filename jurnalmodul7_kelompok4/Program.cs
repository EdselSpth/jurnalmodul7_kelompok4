using jurnalmodul7_kelompok4;
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
    }
}
