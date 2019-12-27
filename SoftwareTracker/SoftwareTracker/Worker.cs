using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace SoftwareTracker
{
    class Worker
    {
        private readonly HttpClient httpClient;

        public Worker()
        {
            httpClient = new HttpClient();
        }


        /// <summary>
        /// Load links.json file
        /// </summary>
        private List<string> LoadJson()
        {
            string json = File.ReadAllText($"{Directory.GetCurrentDirectory()}/links.json");
            return JsonConvert.DeserializeObject<Links>(json).links;
        }

        /// <summary>
        /// Parse owner and repos from JSON
        /// </summary>
        public Tuple<List<string>, List<string>> GetOwnersAndRepos()
        {
            // Get links from JSON
            List<string> links = LoadJson();

            // Store owners/repos in lists
            List<string> owners = new List<string>();
            List<string> repos = new List<string>();

            // Parse owners/repos from links
            foreach (var item in links)
            {
                owners.Add(item.Split("/")[0]);
                repos.Add(item.Split("/")[1]);
            }
            return new Tuple<List<string>, List<string>>(owners, repos);
        }

        public string GetLatestRelease()
        {
            // TODO
            return null;
        }
    }
}
