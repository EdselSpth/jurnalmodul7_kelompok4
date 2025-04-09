using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class DataMahasiswa_103022300109
    {
        //bagian ini buat ngeget json Mahasiswa
        public class Mahasiswa() 
        { 
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; } 
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        //ini buat ngeget json Addressnya
        public class Address() { 
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        //yg ini buat ngeget json coursenya
        public class Course()
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void ReadJSON() {
            //utk memberi tahu lokasi jsonnya
            string json = File.ReadAllText("C:\\Users\\rezai\\Source\\Repos\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_1_103022300109.json");
            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
            //buat ngambil data data yg ada dari jsonnya
            Console.WriteLine("Nama Mahasiswa : " + mahasiswa.firstName + " " + mahasiswa.lastName);
            Console.WriteLine("Gender : " + mahasiswa.gender);
            Console.WriteLine("Umur : " + mahasiswa.age);
            Console.WriteLine("Alamat : " + mahasiswa.address.streetAddress + ", " + mahasiswa.address.city + ", " + mahasiswa.address.state);
            Console.WriteLine("Daftar Mata Kuliah :");
            //biar ngambil semua data json pada course soalnya kan coursenya gak cuma 1 jadi di loop biar keliatan smua
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            { 
                Console.WriteLine(mahasiswa.courses.ElementAt(i).code + " " + mahasiswa.courses.ElementAt(i).name);
            }
        }
    }
}
