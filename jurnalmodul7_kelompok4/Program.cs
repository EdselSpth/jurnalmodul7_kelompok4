
﻿using System.Net.WebSockets;
using System.Reflection.Metadata;
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
public class Member
{ 
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}
public class MemberList
{ 
    public List<Member> anggota { get; set; }
}

public class TeamMembers_103022300092_Abdul
{
    public static void ReadJSON(string filePath)
    {
        try {


            string jsonString = File.ReadAllText(filePath);
            MemberList members = JsonSerializer.Deserialize<MemberList>(jsonString);
            if (members != null && members.anggota != null)
            {
                Console.WriteLine("Daftar Kelompok: ");
                foreach (var member in members.anggota)
                {
                    Console.WriteLine($"{member.firstName}{member.firstName},{member.gender},{member.age},{member.nim}");
                    }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: " + e.Message);
        }
        
    }

    
}
class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_103022300092_AbdulAzizSaepurohmat.ReadJsonAsync(@"C:\Users\ABD AZIZ\Source\Repos\jurnalmodul7_kelompok4\jurnalmodul7_kelompok4\jurnal7_1_103022300092.json");
        Console.WriteLine("");
        TeamMembers_103022300092_Abdul.ReadJSON(@"C:\Users\ABD AZIZ\Source\Repos\jurnalmodul7_kelompok4\jurnalmodul7_kelompok4\jurnal7_2_103022300092.json");
    }
}


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


