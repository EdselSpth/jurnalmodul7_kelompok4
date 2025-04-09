using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok4
{
    class GlossaryItem_103022300109
    {
        public class Glossary
        { 
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class  GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossEntry
        { 
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossDef        
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public class GlossaryData
        {
            public Glossary glossary { get; set; }
        }

        public static void ReadJSON()
        {
            try
            {
                string json = File.ReadAllText("C:\\Users\\rezai\\Source\\Repos\\jurnalmodul7_kelompok4\\jurnalmodul7_kelompok4\\jurnal7_3_103022300109.json");
                GlossaryData glossaryData = JsonSerializer.Deserialize<GlossaryData>(json);

                GlossEntry glossEntry = glossaryData.glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine($"ID: {glossEntry.ID}, \nSortAs: {glossEntry.SortAs}\nGlossTerm: {glossEntry.GlossTerm}" +
                    $"\nAcronym: {glossEntry.Acronym}\nAbbrev: {glossEntry.Abbrev}\nGlossSee: {glossEntry.GlossSee}" +
                    $"\nGlossDef para: {glossEntry.GlossDef.para}" + $"\nGlossSeeAlso: {glossEntry.GlossDef.GlossSeeAlso.ElementAt(0) + glossEntry.GlossDef.GlossSeeAlso.ElementAt(1)}"
                    );
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}
