using System;

class program
{
    static void Main(string[] args)
    {
        var basepath = AppContext.BaseDirectory;
        var pathData = Path.Combine(basepath, "jurnal7_1_103022300088.json");
        DataMahasiswa103022300088.ReadJSON(pathData);
    }
}
