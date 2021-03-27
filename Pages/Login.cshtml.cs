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

        public IActionResult ValidateLogin(string email, string password)
        {
            Users = MyUsersService.GetUsers();
            print(Users)

            for user in Users {
                if email == Users.email && password = Users.password {
                    HttpContext.Session.SetString("username", email);
                    return RedirectToPage("Dashboard");
                } else {
                    return Page();
                }
            }
        }
    }
}
