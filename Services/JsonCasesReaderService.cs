using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Adm4379Example.Model;

namespace Adm4379Example.services
{
    public class JsonCasesReaderService
    {
        public JsonCasesReaderService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string getJsonFilePath
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "cases.json"); }
        }

        public IEnumerable<Cases> GetCases()
        {
            using(var jsonFileReader = File.OpenText(getJsonFilePath))
            {
                return JsonSerializer.Deserialize<Cases[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}