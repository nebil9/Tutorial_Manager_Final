using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager_Final.Controllers
{
    public class ParentHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
