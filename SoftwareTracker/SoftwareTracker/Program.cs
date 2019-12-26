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
            List<string> links = LoadJson();

            List<string> owners = new List<string>();
            List<string> repos = new List<string>();
            foreach (var item in links)
            {
                owners.Add(item.Split("/")[0]);
                repos.Add(item.Split("/")[1]);
            }
            
        }


        static List<string> LoadJson()
        {
            string json = File.ReadAllText($"{Directory.GetCurrentDirectory()}/links.json");
            return JsonConvert.DeserializeObject<Links>(json).links;
        }
    }
}
