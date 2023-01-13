using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserDetail.Data;
using UserDetail.Models;

namespace UserDetail.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //using (var ctx = new UserDetailContext())
            //{
            //    var user = new User() { FirstName = "test user", FamilyName = "kaushal" };

            //    ctx.User.Add(user);
            //    ctx.SaveChanges();
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}