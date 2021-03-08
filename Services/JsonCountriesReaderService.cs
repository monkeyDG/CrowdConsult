using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Adm4379Example.Model;

namespace Adm4379Example.services
{
    public class JsonCountriesReaderService
    {
        public JsonCountriesReaderService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string getJsonFilePath
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "countries.json"); }
        }

        public IEnumerable<Countries> GetCountries()
        {
            using(var jsonFileReader = File.OpenText(getJsonFilePath))
            {
                return JsonSerializer.Deserialize<Countries[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}