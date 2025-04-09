using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class TeamMembers_103022300101
    {
        //Class buat struktur data di JSON
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }
        //Class untuk menambahkan data Team yang ada di JSON
        public class Team
        {
            public List<Member> members { get; set; }
        }
        //Class untuk menampilkan data Team Member
        public static void ReadJson()
        {
            string jsonString = File.ReadAllText("D:\\telkom\\Praktikum\\EdselSpth\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_2_103022300101.json"); //untuk mengetahui File JSON yang mna yang akan diambi
            Team team = JsonSerializer.Deserialize<Team>(jsonString);

            Console.WriteLine("Team member list:");
            //Perulangan untuk menampilkan semua data Team Member
            foreach (var member in team.members)
            {
                Console.WriteLine(member.nim + " " + member.firstName + " " + member.lastName +
                    " (" + member.age + " " + member.gender + ")");
            }
        }
    }
}
