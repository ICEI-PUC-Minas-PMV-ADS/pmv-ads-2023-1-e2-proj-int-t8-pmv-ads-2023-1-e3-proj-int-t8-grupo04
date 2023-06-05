using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyClosetWeb.Data;
using MyClosetWeb.Models;
using Newtonsoft.Json;

namespace MyClosetWeb.Controllers
{
    public class ClosetController : Controller
    {
        private readonly DataContext _context;
        public User CurrentUser { get; set; }
        public Closet UserCloset { get; set; }

        public ClosetController(DataContext context)
        {
            _context = context;
        }

        public IActionResult LoadUser(User currentUser)
        {
            string userJson = (string)TempData["LoggedUser"];
            if(userJson is not null)
            {
                CurrentUser = JsonConvert.DeserializeObject<User>(userJson);
                ViewBag.CurrentUser = CurrentUser;
                TempData["userId"] = CurrentUser.UserId;
                LoadCLoset(CurrentUser.UserId);

                return View("Closet");
            }
            return Index();
        }

        private void LoadCLoset(int userId)
        {
            UserCloset = _context.Closet.Include(c => c.User)
                                                        .Include(c => c.Clothes)
                                                        .FirstOrDefault(c => c.UserId == userId);
            if (UserCloset is not null)
            {
                ViewBag.UserCloset = UserCloset;
            }
        }

        [HttpPost]
        public IActionResult RegisterCloset(Clothes newCloth)
        {
            var userId = (int)TempData["userId"];

            if (UserCloset is null && userId !=0)
            {
                UserCloset = new Closet();
                UserCloset.Clothes.Add(newCloth);
                UserCloset.UserId = userId;
                _context.Closet.Add(UserCloset);
                _context.SaveChanges();
            }
            return View("Closet");
        }
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
