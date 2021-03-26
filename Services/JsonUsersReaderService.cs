using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Adm4379Example.Model;

namespace Adm4379Example.services
{
    public class JsonUsersReaderService
    {
        public JsonUsersReaderService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string getJsonFilePath
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "users.json"); }
        }

        public IEnumerable<users> GetUsers()
        {
            using(var jsonFileReader = File.OpenText(getJsonFilePath))
            {
                return JsonSerializer.Deserialize<users[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}