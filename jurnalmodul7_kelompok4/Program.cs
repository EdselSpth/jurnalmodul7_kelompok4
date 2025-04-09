using System.Net.WebSockets;
using System.Text.Json;

public class Address
{ 
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}
public class Course
{ 
    public string code { get; set; }
    public string name { get; set; }
}
public class Biodata
{ 
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }
}
public class DataMahasiswa_103022300092_AbdulAzizSaepurohmat
{
    public static void ReadJsonAsync(String filePath)
    {
        try {
            using FileStream jsonString = File.OpenRead(filePath);
            Biodata mhs = JsonSerializer.Deserialize<Biodata>(jsonString);
            if (mhs != null)
            {
                Console.WriteLine($"Nama{mhs.firstName}{mhs.firstName}");
                Console.WriteLine($"Jenis Kelamin: {mhs.gender}");
                Console.WriteLine($"Umur : {mhs.age}");
                Console.WriteLine($"Alamat : {mhs.address.streetAddress}{mhs.address.city}{mhs.address.state}");
                for (int i = 0; 1 < mhs.courses.Count; i++)
                {
                    Console.WriteLine($"Mata Kuliah {i + 1}:{mhs.courses[i].code},{mhs.courses[i].name}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"error: "+ e.Message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_103022300092_AbdulAzizSaepurohmat.ReadJsonAsync(@"C:\Users\ABD AZIZ\Source\Repos\jurnalmodul7_kelompok4\jurnalmodul7_kelompok4\jurnal7_1_103022300092.json");
    }
}
