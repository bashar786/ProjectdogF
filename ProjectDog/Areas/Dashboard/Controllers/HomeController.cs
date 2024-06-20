using Microsoft.AspNetCore.Mvc;

namespace ProjectDog.Areas.Dashboard.Controllers
{

    [Area("Dashboard")]
    public class HomeController : Controller
    {

        [Route("/Dashboard")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Dashboard/Calander")]
        public IActionResult Calander()
        {
            return View();
        }

        [Route("/Dashboard/Settings")]

        public IActionResult Settings()
        {
            return View();
        }

        [Route("/Dashboard/AdvanceSearch")]

        public IActionResult AdvanceSearch()
        {
            return View();
        }
         [Route("/Dashboard/faqs")]
        public IActionResult Faqs()
        {
            return View();
        }
         [Route("/Dashboard/downloads")]
        public IActionResult Downloads()
        {
            return View();
        }

        [Route("/Dashboard/employment")]
        public IActionResult Employment()
        {
            return View();
        }
        
        [Route("/Dashboard/MyInfo")]
        public IActionResult MyInfo()
        {
            return View();
        }
        [Route("/Dashboard/contactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }
         [Route("/Dashboard/projectCenetral")]
        public IActionResult ProjectCenetral()
        {
            return View();
        }
        [Route("/Dashboard/projectManagment")]
        public IActionResult ProjectManagment()
        {
            return View();
        }
         [Route("/Dashboard/projectLeads")]
        public IActionResult ProjectLeads()
        {
            return View();
        }
        [Route("/Dashboard/NewProject")]
        public IActionResult NewProject()
        {
            return View();
        }
        
        [Route("/Dashboard/Adminpage")]
        public IActionResult Adminpage()
        {
            return View();
        }



    }
}
