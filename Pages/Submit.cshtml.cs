using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Adm4379Example.services;
using Adm4379Example.Model;

namespace Adm4379Example.Pages
{
    public class SubmitModel : PageModel
    {
        private readonly ILogger<SubmitModel> _logger;
        private JsonCountriesReaderService service;
        public IEnumerable<Countries> Countries;

        public SubmitModel(ILogger<SubmitModel> logger, JsonCountriesReaderService jcrs)
        {
            _logger = logger;
            service = jcrs;
        }

        public void OnGet()
        {
            Countries = service.GetCountries();
        }
    }
}
