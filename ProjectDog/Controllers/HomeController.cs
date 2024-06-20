using Microsoft.AspNetCore.Mvc;
using ProjectDog.Models;
using System.Diagnostics;

namespace ProjectDog.Controllers
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
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }
              
        public IActionResult ForgetPassword()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult PaymentInformation()
        {
            return View();
        }

        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult ADAPolicy()
        {
            return View();
        }
        public IActionResult CopyrigtPolicy()
        {
            return View();
        }
         public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Video()
        {
            return View();
        }


    }
}
