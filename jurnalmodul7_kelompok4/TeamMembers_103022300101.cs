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
        public class Mahasiswa()
        {
            public List<member> member { get; set; }
        }
        public class member()
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }
        public static void readJSON()
        {
            string json = File.ReadAllText("D:\\telkom\\Praktikum\\EdselSpth\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_2_103022300101.json");
            var mahasiswa = JsonSerializer.Deserialize<member>(json);
            Console.WriteLine("Team member list:");
            for (int i = 0; i < mahasiswa.member.Count; i++)
            {
                Console.WriteLine(mahasiswa.courses.ElementAt(i).code + " " + mahasiswa.courses.ElementAt(i).name);
            }
        }
    }
}
