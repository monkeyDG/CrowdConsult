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
using Adm4379Example.Services;
using Microsoft.AspNetCore.Http;

namespace Adm4379Example.Pages
{
    public class CaseModel : PageModel
    {
        private readonly ILogger<CaseModel> _logger;
        //deprecated, for reading from JSON file -----------------------------------------------
        //private JsonCasesReaderService service; 
        //public IEnumerable<Cases> Cases;

        //public CaseModel(ILogger<CaseModel> logger, JsonCasesReaderService jcasesrs)
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

        public CaseModel(ILogger<CaseModel> logger, CountriesService counServ, CasesService caseServ, UsersService usersServ)
        {
            _logger = logger;
            MyCountriesService = counServ;
            MyCasesService = caseServ;
            MyUsersService = usersServ;
        }
        
        public IActionResult OnPostAsync()
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int msSinceEpoch = (int)t.TotalSeconds*1000; // gets us the ms since epoch, which is the datetime format used throughout this project

            string case_id = Request.Form["case_id"]; // uses a hidden field to pass the case id which was parsed from the query string

            List<Model.Responses> emptyResponses = new List<Model.Responses>();

            var newResponse = new Model.Responses {
                response_user = TempData.Peek("logged_in").ToString(), //only logged in users can post business cases, which is verified by getting to this page. Therefore TempData should always contain the email of the user.
                response_description = Request.Form["response_content"],
                response_datetime = msSinceEpoch,
                response_is_best = false
            };
            
            MyCasesService.addResponse(newResponse, case_id);

            return Redirect("/Case?id=" + case_id);
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
