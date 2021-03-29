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
    public class SubmitModel : PageModel
    {
        private readonly ILogger<SubmitModel> _logger;
        //deprecated, for reading from JSON file -----------------------------------------------
        //private JsonCasesReaderService service; 
        //public IEnumerable<Cases> Cases;

        //public SubmitModel(ILogger<SubmitModel> logger, JsonCasesReaderService jcasesrs)
        //{
        //    _logger = logger;
        //    service = jcasesrs;
        //}

        public CountriesService MyCountriesService;
        public IEnumerable<Countries> Countries;

        public CasesService MyCasesService;
        public IEnumerable<Cases> Cases;
         public UsersService MyUsersService;
        public IEnumerable<Users> Users;

        public SubmitModel(ILogger<SubmitModel> logger, CountriesService counServ, CasesService caseServ, UsersService usersServ)
        {
            _logger = logger;
            MyCountriesService = counServ;
            MyCasesService = caseServ;
            MyUsersService = usersServ;
        }

        public IActionResult OnPostAsync()
        {
            //System.Diagnostics.Debug.WriteLine("OnPostAsync");
            var company = Request.Form["company"];
            var title = Request.Form["title"];
            var country = Request.Form["country"];
            var bounty = Request.Form["bounty"];
            var tags = Request.Form["tags"];
            var subject = Request.Form["subject"];

            var newCase = new Model.Cases {
                //id = 
            };
            

            MyCasesService.Create(newCase);

            return RedirectToPage("Active");
        }

        public void OnGet()
        {
            Countries = MyCountriesService.GetCountries();
            Cases = MyCasesService.GetCases();
            Users = MyUsersService.GetUsers();
        }
        
        public bool caseFound = false;
    }
}
