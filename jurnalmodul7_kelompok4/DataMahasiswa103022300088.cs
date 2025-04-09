using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300088
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

    public static void ReadJSON(string filepath)
    {
        String jsonString = File.ReadAllText(filepath);
        Mahasiswa student = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine("First Name : " + student.firstName);
        Console.WriteLine("Last Name  : " + student.lastName);
        Console.WriteLine("Gender     : " + student.gender);
        Console.WriteLine("Age        : " + student.age);
        Console.WriteLine("Address    : " +
            student.address.streetAddress + ", " +
            student.address.city + ", " +
            student.address.state);
        Console.WriteLine("Courses    : ");
        foreach (var course in student.courses)
        {
            Console.WriteLine("  - " + course.code + " : " + course.name);
        }
    }
}
