using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class DataMahasiswa103022330036_TioFunny
    {
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

        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Users\\Haikal Cannavaro\\Documents\\modul7kpl_103022330036\\jurnalmodul7_kelompok4\\jurnal7_103022330036.json");
            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
            //berfungsi untuk mendeserialisasi json ke dalam class mahasiswa
            Console.WriteLine("Nama: " + mahasiswa.firstName + " " + mahasiswa.lastName);
            Console.WriteLine("Gender: " + mahasiswa.gender);
            Console.WriteLine("Umur: " + mahasiswa.age);
            Console.WriteLine("Alamat: " + mahasiswa.address.streetAddress + ", " + mahasiswa.address.city + ", " + mahasiswa.address.state);
            Console.WriteLine("Mata Kuliah:"); //untuk ngambil data yang berada di json

            for (int i = 0; i < mahasiswa.courses.Count; i++)
                {   
                Console.WriteLine(mahasiswa.courses.ElementAt(i).code + " - " + mahasiswa.courses.ElementAt(i).name);
                }
            }
        }

    }
       

       
