using System;

class program
{
    static void Main(string[] args)
    {
        var basepath = AppContext.BaseDirectory;
        var pathData = Path.Combine(basepath, "jurnal7_1_103022300088.json");
        var pathmem = Path.Combine(basepath, "jurnal7_2_103022300088.json");
        DataMahasiswa103022300088.ReadJSON(pathData);
        Console.WriteLine(" ");
        TeamMembers103022300088.ReadJson(pathmem);
    }
}
