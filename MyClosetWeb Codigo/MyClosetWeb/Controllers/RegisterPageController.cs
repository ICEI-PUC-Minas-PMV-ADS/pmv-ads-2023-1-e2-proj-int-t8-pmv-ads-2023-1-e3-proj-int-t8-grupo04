using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyClosetWeb.Data;
using MyClosetWeb.Models;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace MyClosetWeb.Controllers
{
    public class RegisterPageController : Controller
    {
        private readonly DataContext _context;

        public RegisterPageController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult RegisterPage(User newUser)
        {            
            if (ModelState.IsValid)
            {                
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return Closet();
            }
            return View(newUser);
        }        
        [HttpPost]
        public IActionResult CheckUser(User User)
        {

            var isUserRegistred = _context.Users.FirstOrDefault(u => u.Email.Equals(User.Email)
                                                    && u.Password.Equals(u.Password));
            if (isUserRegistred is not null)
            {
                string userJson = JsonConvert.SerializeObject(isUserRegistred);

                TempData["LoggedUser"] = userJson;

                return RedirectToAction("LoadUser", "Closet");
            }

            return Register();
        }

        // GET: RegisterController
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }         
        public ActionResult Register()
        {
            return View("~/Views/Home/RegisterPage.cshtml");
        }             
        public ActionResult Closet()
        {
            return View("~/Views/Closet/Closet.cshtml");
        }        
    }
}
