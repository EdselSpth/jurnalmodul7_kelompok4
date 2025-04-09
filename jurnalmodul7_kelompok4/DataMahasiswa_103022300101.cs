using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class DataMahasiswa_103022300101
    {
        //Class buat struktur data di JSON
        public class Mahasiswa()
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        //Class buat menambahkan data alamat mahasiswa
        public class Address()
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        //Class buat menambahkan data matkul mahasiswa
        public class Course()
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void ReadJSON()
        {
            //Path ke file JSON
            string json = File.ReadAllText("D:\\telkom\\Praktikum\\EdselSpth\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_1_103022300101.json");
            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
            //Menampilkan data yang ada di JSON ke layar
            Console.WriteLine("Nama Mahasiswa : " + mahasiswa.firstName + " " + mahasiswa.lastName);
            Console.WriteLine("Gender : " + mahasiswa.gender);
            Console.WriteLine("Umur : " + mahasiswa.age);
            Console.WriteLine("Alamat : " + mahasiswa.address.streetAddress + ", " + mahasiswa.address.city + ", " + mahasiswa.address.state);
            Console.WriteLine("Daftar Mata Kuliah :");
            //Perulangan untuk menampilkan semua matkul
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine(mahasiswa.courses.ElementAt(i).code + " " + mahasiswa.courses.ElementAt(i).name);
            }
        }
    }
}