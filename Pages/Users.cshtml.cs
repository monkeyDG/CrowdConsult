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

namespace Adm4379Example.Pages
{
    public class UsersModel : PageModel
    {
        private readonly ILogger<UsersModel> _logger;
        //deprecated, for reading from JSON file -----------------------------------------------
        //private JsonCasesReaderService service; 
        //public IEnumerable<Cases> Cases;

        //public ActiveModel(ILogger<UsersModel> logger, JsonCasesReaderService jcasesrs)
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

        public UsersModel(ILogger<UsersModel> logger, CountriesService counServ, CasesService caseServ, UsersService usersServ)
        {
            _logger = logger;
            MyCountriesService = counServ;
            MyCasesService = caseServ;
            MyUsersService = usersServ;
        }

        public IActionResult OnGet()
        {
            Countries = MyCountriesService.GetCountries();
            Cases = MyCasesService.GetCases();
            Users = MyUsersService.GetUsers();
            foreach (var user in Users) {
                if (TempData.Peek("logged_in") != null) { // checks if someone is logged in
                    if (TempData.Peek("logged_in").ToString() == user.email) { // if the user page belongs to the person currently logged in, redirect to the dashboard
                        return RedirectToPage("Dashboard");
                    }
                }
            }
            return null;
        }
    }
}
