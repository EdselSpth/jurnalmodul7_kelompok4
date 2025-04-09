using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static jurnalmodul7_kelompok4.GlossaryItem_103022300016;

namespace jurnalmodul7_kelompok4
{
    class GlossaryItem_103022300016
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public class GlossEntry
        {
            public string id { get; set; }
            public string sortAs { get; set; }
            public string glossTerm { get; set; }
            public string acronym { get; set; }
            public string Abbrev { get; set; }
            public string GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class Root
        {
            public Glossary glossary { get; set; }
        }

        public static void ReadJSON(string filepath)
        {
            try
            {
                string jsonString = File.ReadAllText(filepath);
                Root data = JsonSerializer.Deserialize<Root>(jsonString);

                var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine("Gloss Entry Detail:");
                Console.WriteLine("ID        : " + entry.id);
                Console.WriteLine("SortAs    : " + entry.sortAs);
                Console.WriteLine("Term      : " + entry.glossTerm);
                Console.WriteLine("Acronym   : " + entry.acronym);
                Console.WriteLine("Abbrev    : " + entry.Abbrev);
                Console.WriteLine("See       : " + entry.GlossSee);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
