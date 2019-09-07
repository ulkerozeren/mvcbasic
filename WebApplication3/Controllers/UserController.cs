using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<Models.User>  userList;

            using (DataContext dataContext = new DataContext())
            {
                userList = dataContext.Users.Select(x=>x).ToList();
            }

            return View(userList);
        
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Users.Add(user);
                dataContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}