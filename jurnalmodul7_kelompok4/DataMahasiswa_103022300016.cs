using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class DataMahasiswa_103022300016
    {

        public class Address
        {
            [JsonPropertyName("streetAddress")] // membaca property streetAddress pada json

            public String StreetAddress { get; set; } // getter setter streetAddress

            [JsonPropertyName("city")] // membaca property city pada json

            public String City { get; set; } // getter setter city

            [JsonPropertyName("state")] // membaca property state pada json

            public String State { get; set; } // getter setter state
        }

        public class Course
        {
            [JsonPropertyName("code")] // membaca property code pada json

            public String Code { get; set; } // getter setter code

            [JsonPropertyName("name")] // membaca property name pada json

            public String Name { get; set; } // getter setter name
        }

        public class Mahasiswa
        {
            [JsonPropertyName("firstName")] // membaca property firstName pada json

            public String firstName { get; set; }   // getter setter firstName

            [JsonPropertyName("lastName")] // membaca property lastName pada json

            public String lastName { get; set; } // getter setter lastName

            [JsonPropertyName("gender")] // membaca property gender pada json

            public String Gender { get; set; } // getter setter gender

            [JsonPropertyName("age")] // membaca property age pada json

            public int Age { get; set; } // getter setter age

            public Course[] courses { get; set; } // getter setter courses
        }

        public static void ReadJson(string filepath)
        {
            try
            {
                String jsonString = File.ReadAllText(filepath); // membaca file json
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString); // mendeserialisasi json ke dalam object mahasiswa

                Console.WriteLine("Nama Depan: " + mhs.firstName + " " + mhs.lastName);
                Console.WriteLine("Jenis Kelamin: " + mhs.Gender);
                Console.WriteLine("Umur: " + mhs.Age);
                Console.WriteLine("Daftar Mata Kuliah: ");
                foreach (var course in mhs.courses)
                {
                    Console.WriteLine("Kode: " + course.Code + ", Nama: " + course.Name);
                }


            } catch(Exception ex)
            {
                Console.WriteLine("Error: Gagal melakukan deserialisasi " + ex.Message); // menangkap error deserialisasi
            }
        }
    }
}
