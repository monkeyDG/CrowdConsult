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

        [TempData]
        public string logged_in { get; set; }

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
            System.Diagnostics.Debug.WriteLine("OnGet");
        }

        public IActionResult OnPostAsync()
        {
            System.Diagnostics.Debug.WriteLine("OnPostAsync");
            var email = Request.Form["emailLogIn"];
            var password = Request.Form["passwordLogIn"];
            Users = MyUsersService.GetUsers();
            var returnVal = Page();

            foreach (var user in Users) {
                if (email == user.email && password == user.password) {
                    //HttpContext.Session.SetString("username", email);
                    logged_in = user.email;
                    return RedirectToPage("Dashboard");
                } else {
                    return Page();
                }
            }
            return returnVal;
        }
        
        public IActionResult ValidateLogin(string email, string password)
        {
            System.Diagnostics.Debug.WriteLine("IActionResult ValidateLogin");
            Users = MyUsersService.GetUsers();
            var returnVal = Page();

            foreach (var user in Users) {
                if (email == user.email && password == user.password) {
                    //HttpContext.Session.SetString("username", email);
                    logged_in = user.email;
                    return RedirectToPage("Dashboard");
                } else {
                    return Page();
                }
            }
        return returnVal;
        }
    }
}
