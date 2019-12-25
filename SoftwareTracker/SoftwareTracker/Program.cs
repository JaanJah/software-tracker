using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SoftwareTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var links = LoadJson();
            foreach (var item in links)
            {
                Console.WriteLine(item);
            }
        }


        static List<string> LoadJson()
        {
            string json = File.ReadAllText($"{Directory.GetCurrentDirectory()}/links.json");
            return JsonConvert.DeserializeObject<Links>(json).links;
        }
    }
}
