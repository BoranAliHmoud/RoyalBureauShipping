using Certificate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoyalBureauShipping.Models;

namespace RoyalBureauShipping.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
  

        private readonly IWebHostEnvironment _environment;

        public AccountController(ApplicationDbContext context )
        {
            _context = context;
        
        }

        public IActionResult Login()
        {
            var users = _context.Users.ToList();

            if (users == null ||users.Count==0)
            {
                User user = new User 
                {
                    FirstName= "Admin",
                    LastName ="Admin",
                    Email= "RoyalBureauShipping@admin.com",
                    Password="123456789"
                };
               _context.Users.Add(user);
                //عشان يعمل حفظ 
                _context.SaveChanges();
            }
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost (User data)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Email==data.Email && x.Password==data.Password);
            if (user != null)
            {
				string storesJson = JsonConvert.SerializeObject(user);
				HttpContext.Session.SetString("User", storesJson);
				return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("Login");
        }
        public IActionResult Logout() 
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
