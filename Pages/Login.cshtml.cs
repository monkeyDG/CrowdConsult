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
            Users = MyUsersService.GetUsers();

            foreach (var user in Users) {
                if (Request.Form["emailLogIn"] == user.email && Request.Form["passwordLogIn"] == user.password) { // if the user filled in the login form
                    //HttpContext.Session.SetString("username", email); -- now deprecated, using TempData to store login
                    logged_in = user.email;
                    return RedirectToPage("Dashboard"); //if the login is successful, redirect to dashboard page which will be populated based on TempData email as id
                }
            }

            string profile_pic = "https://i.imgur.com/6HAmGNz.png";

            if (Request.Form["emailSignUp"] != "" && Request.Form["passwordSignUp"] != "") { // if the user has filled out the signup form and not the login form
                foreach (var user in Users) { // checks if that email already exists with a user
                    if (Request.Form["emailSignUp"] == user.email) { // if the user filled in the login form
                        return Redirect("/Login?success=alreadyexists"); // if we get here, the login attempt failed
                    }
                }

                if (!(String.IsNullOrEmpty(Request.Form["pictureSignUp"]))) {
                    profile_pic = Request.Form["pictureSignUp"];
                }
                var newUser = new Model.Users {
                    name = Request.Form["nameSignUp"],
                    company = Request.Form["companySignUp"],
                    phone = Request.Form["phoneSignUp"],
                    email = Request.Form["emailSignUp"],
                    location = Request.Form["tags"],
                    password = Request.Form["passwordSignUp"],
                    picture = profile_pic
                };
                
                MyUsersService.Create(newUser);
                logged_in = Request.Form["emailSignUp"];
                return RedirectToPage("Dashboard");
            }
            
            return Redirect("/Login?success=false"); // if we get here, the login attempt failed
        }
    }
}
