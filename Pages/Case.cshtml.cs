using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Adm4379Example.services;
using Adm4379Example.Model;

namespace Adm4379Example.Pages
{
    public class CaseModel : PageModel
    {
        private readonly ILogger<CaseModel> _logger;
        private JsonCasesReaderService service;
        public IEnumerable<Cases> Cases;

        public CaseModel(ILogger<CaseModel> logger, JsonCasesReaderService jcasesrs)
        {
            _logger = logger;
            service = jcasesrs;
        }

        public void OnGet()
        {
            Cases = service.GetCases();
        }
        Uri myUri = new Uri("http://www.example.com?param1=good&param2=bad");
        //string tmp = "test";
        //string param1 = HttpUtility.ParseQueryString(tmp).Get("param1");
        //WIP
        

    }
}
