using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Adm4379Example.services;
using Adm4379Example.Model;
using Adm4379Example.Services;

namespace Adm4379Example.Pages
{
    public class ActiveModel : PageModel
    {
        private readonly ILogger<ActiveModel> _logger;
        //deprecated, for reading from JSON file -----------------------------------------------
        //private JsonCasesReaderService service; 
        //public IEnumerable<Cases> Cases;

        //public ActiveModel(ILogger<ActiveModel> logger, JsonCasesReaderService jcasesrs)
        //{
        //    _logger = logger;
        //    service = jcasesrs;
        //}

        public CountriesService MyCountriesService;
        public IEnumerable<Countries> Countries;

        public CasesService MyCasesService;
        public IEnumerable<Cases> Cases;

        public ActiveModel(ILogger<ActiveModel> logger, CountriesService counServ, CasesService caseServ)
        {
            _logger = logger;
            MyCountriesService = counServ;
            MyCasesService = caseServ;
        }


        public void OnGet()
        {
            Countries = MyCountriesService.GetCountries();
            Cases = MyCasesService.GetCases();
        }
        
        public bool caseFound = false;
    }
}
