using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class TeamMembers_103022300109
    {
        //buat ngeget json data member
        public class MemberData() { 
            public string firstName { get;set;}
            public string lastName { get;set;}
            public string gender { get;set;}
            public int age { get;set;}
            public string nim { get;set;}
        }

        //buat ngelist
        public class Members() { 
            public List<MemberData> members { get; set;}
        }

        //buat manggil datanya dari json berdasarkan class list diatas
        public static void ReadJSON() {
            string json = File.ReadAllText("C:\\Users\\rezai\\Source\\Repos\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_2_103022300109.json");
            var members = JsonSerializer.Deserialize<Members>(json);
            Console.WriteLine("List Member : ");
            for (int i = 1; i < members.members.Count; i++) {
                Console.WriteLine(
                    members.members.ElementAt(i).firstName + " " +
                    members.members.ElementAt(i).lastName + " " +
                    members.members.ElementAt(i).gender + " " +
                    members.members.ElementAt(i).age + " " +
                    members.members.ElementAt(i).nim + " "
                    );
            }
        }
    }
}
