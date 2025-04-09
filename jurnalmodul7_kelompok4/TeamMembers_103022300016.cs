using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static jurnalmodul7_kelompok4.DataMahasiswa_103022300016;
using static jurnalmodul7_kelompok4.TeamMembers_103022300016;

namespace jurnalmodul7_kelompok4
{
    public class TeamMembers_103022300016
    {
        public class TeamMembers
        {
            [JsonPropertyName("firstName")] // membaca property firstName pada json

            public string firstName { get; set; } // getter setter firstName

            [JsonPropertyName("lastName")] // membaca property lastName pada json

            public string lastName { get; set; } // getter setter lastName

            [JsonPropertyName("gender")] // membaca property gender pada json

            public string Gender { get; set; } // getter setter phone number

            [JsonPropertyName("age")] // membaca property age pada json

            public int Age { get; set; } // getter setter age

            [JsonPropertyName("nim")] // membaca property nim pada json

            public string NIM { get; set; } // getter setter class
            
        }

        public class List
        {
            [JsonPropertyName("members")] // membaca property members
            public List<TeamMembers> tm { get; set; } // Getter Setter untuk courses
        }

        public static void readJson(string filePath)
        {
            try
            {
                // membaca file json
                String jsonString = File.ReadAllText(filePath);
                List ATM = JsonSerializer.Deserialize<List>(jsonString); // mendeserialisasi json ke dalam object arrayTeamMember

                Console.WriteLine("Daftar Anggota Kelompok 4 : ");
                foreach (var TeamMembers in ATM.tm)
                {
                    Console.WriteLine($"{TeamMembers.NIM} {TeamMembers.firstName + TeamMembers.lastName} ({TeamMembers.Age} {TeamMembers.Gender})");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error: Gagal melakukan deserialisasi " + ex.Message);
            }
            

        }
    }
}
