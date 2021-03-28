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
using Microsoft.AspNetCore.Http;

namespace Adm4379Example.Pages
{
    public class LogInModel : PageModel
    {
        private readonly ILogger<LogInModel> _logger;
        public UsersService MyUsersService;
        public IEnumerable<Users> Users;

        public LogInModel(ILogger<LogInModel> logger, UsersService usersServ)
        {
            _logger = logger;
            MyUsersService = usersServ;
        }

        public const string SessionKeyEmail = "";
        public const string SessionKeyPassword = "";

        //TODO: delete below
        public string SessionInfo_Email { get; private set; }
        public string SessionInfo_Password { get; private set; } 


        public void OnGet()
        {
            //TESTING:
            //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyEmail)))
            //{
            //    HttpContext.Session.SetString(SessionKeyEmail, "email");
            //    HttpContext.Session.SetString(SessionKeyPassword, "password");
            //}

            //var email = HttpContext.Session.SetString(SessionKeyEmail);
            //var password = HttpContext.Session.SetString(SessionKeyPassword);
        }
        
        public IActionResult ValidateLogin(string email, string password)
        {
            Users = MyUsersService.GetUsers();
            var returnVal = Page();

            foreach (var user in Users) {
                if (email == user.email && password == user.password) {
                    HttpContext.Session.SetString("username", email);
                    return RedirectToPage("Dashboard");
                } else {
                    return Page();
                }
            }
        return returnVal;
        }
    }
}
