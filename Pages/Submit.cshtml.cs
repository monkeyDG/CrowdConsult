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

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int msSinceEpoch = (int)t.TotalSeconds*1000; // gets us the ms since epoch, which is the datetime format used throughout this project

            List<Model.Responses> emptyResponses = new List<Model.Responses>();

            var newCase = new Model.Cases {
                user_email = TempData.Peek("logged_in").ToString(), //only logged in users can post business cases, which is verified by getting to this page. Therefore TempData should always contain the email of the user.
                company = Request.Form["company"],
                title = Request.Form["title"],
                country = Request.Form["country"],
                tags = Request.Form["tags"],
                description = Request.Form["description"],
                datetime = msSinceEpoch,
                bounty = int.Parse(Request.Form["bounty"]), //need to recast as int type to save in db
                num_responses = 0,
                logo = "https://i.imgur.com/DZwcb9O.png",
                Responses = emptyResponses
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
