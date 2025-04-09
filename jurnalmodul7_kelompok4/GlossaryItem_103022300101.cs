using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class GlossaryItem_103022300101
    {
        // Kelas GlossDef untuk mendefinisikan istilah terkait dengan glossary
        public class GlossDef
        {
            public string para { get; set; }  // Paragraf definisi
            public List<string> GlossSeeAlso { get; set; }  // Daftar istilah terkait
        }

        // Kelas GlossEntry yang berisi data entry glossary
        public class GlossEntry
        {
            public string ID { get; set; }  // ID dari glossary
            public string SortAs { get; set; }  // Urutan pengurutan
            public string GlossTerm { get; set; }  // Istilah glossary
            public string Acronym { get; set; }  // Akronim dari istilah
            public string Abbrev { get; set; }  // Singkatan istilah
            public GlossDef GlossDef { get; set; }  // Definisi istilah
            public string GlossSee { get; set; }  // Referensi lain dalam glossary
        }

        // Kelas GlossList yang memuat GlossEntry
        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        // Kelas GlossDiv untuk mendefinisikan bagian dari glossary
        public class GlossDiv
        {
            public string title { get; set; }  // Judul glossary
            public GlossList GlossList { get; set; }  // Daftar istilah dalam glossary
        }

        // Kelas Glossary untuk mendefinisikan keseluruhan glossary
        public class Glossary
        {
            public string title { get; set; }  // Judul utama glossary
            public GlossDiv GlossDiv { get; set; }  // Bagian glossary
        }

        // Kelas Root untuk mendefinisikan struktur root dari JSON
        public class Root
        {
            public Glossary glossary { get; set; }
        }

        // Fungsi untuk membaca dan menampilkan data JSON dari file
        public static void ReadJSON()
        {
            // Membaca file JSON
            string jsonString = File.ReadAllText("D:\\telkom\\Praktikum\\EdselSpth\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_3_103022300101.json");

            // Deserialisasi JSON menjadi objek Root
            Root data = JsonSerializer.Deserialize<Root>(jsonString);

            // Mengakses data dari objek Root
            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            // Menampilkan informasi detail dari glossary entry
            Console.WriteLine("Gloss Entry Detail:");
            Console.WriteLine("ID        : " + entry.ID);
            Console.WriteLine("SortAs    : " + entry.SortAs);
            Console.WriteLine("Term      : " + entry.GlossTerm);
            Console.WriteLine("Acronym   : " + entry.Acronym);
            Console.WriteLine("Abbrev    : " + entry.Abbrev);
            Console.WriteLine("Def. Para : " + entry.GlossDef.para);
            Console.WriteLine("See Also  : " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine("See       : " + entry.GlossSee);
        }
    }
}