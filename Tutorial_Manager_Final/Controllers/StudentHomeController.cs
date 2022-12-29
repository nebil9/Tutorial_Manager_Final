using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager_Final.Controllers
{
    public class StudentHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
