using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace jurnalmodul7_kelompok4
{
    class TeamMembers103022330036_TioFunny
    {
        public class DataMember()
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
            public string nim { get; set; }
        }

        public class Member()
        {
            public List<DataMember> members { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Users\\Haikal Cannavaro\\Documents\\modul7kpl_103022330036\\jurnalmodul7_kelompok4\\jurnal7_2_103022330036.json");
            var member = JsonSerializer.Deserialize<Member>(json);
            Console.WriteLine("Team Members:");
            for (int i = 1; i < member.members.Count; i++)
            {
                Console.WriteLine(
                    member.members.ElementAt(i).firstName + " " +
                    member.members.ElementAt(i).lastName + " " +
                    member.members.ElementAt(i).age + " " +
                    member.members.ElementAt(i).gender + " " +
                    member.members.ElementAt(i).nim);
            }
        }
    }
}
