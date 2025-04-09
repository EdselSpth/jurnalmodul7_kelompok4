using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class TeamMembers103022300088
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class Team
    {
        public List<Member> members { get; set; }
    }

    public static void ReadJson(string filepath)
    {
        string jsonString = File.ReadAllText(filepath);
        Team team = JsonSerializer.Deserialize<Team>(jsonString);

        Console.WriteLine("Team member list:");
        foreach (var member in team.members)
        {
            Console.WriteLine(member.nim + " " + member.firstName + " " + member.lastName +
                " (" + member.age + " " + member.gender + ")");
        }
    }
}
