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

        [TempData]
        public string logged_in { get; set; }

        public void OnGet()
        {
            //TESTING -- now deprecated, using TempData to store login:
            //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyEmail)))
            //{
            //    HttpContext.Session.SetString(SessionKeyEmail, "email");
            //    HttpContext.Session.SetString(SessionKeyPassword, "password");
            //}
        }

        public IActionResult OnPostAsync()
        {
            //System.Diagnostics.Debug.WriteLine("OnPostAsync");
            var emailLogIn = Request.Form["emailLogIn"];
            var passwordLogIn = Request.Form["passwordLogIn"];
            var emailSignUp = Request.Form["emailSignUp"];
            var passwordSignUp = Request.Form["passwordSignUp"];
            Users = MyUsersService.GetUsers();
            var returnVal = Page();

            foreach (var user in Users) {
                if ((emailLogIn == user.email && passwordLogIn == user.password) || (emailSignUp == user.email && passwordSignUp == user.password)) {
                    //HttpContext.Session.SetString("username", email);
                    logged_in = user.email;
                    return RedirectToPage("Dashboard");
                } else {
                    return Redirect("/Login?success=false");
                }
            }
            return returnVal;
        }
    }
}
