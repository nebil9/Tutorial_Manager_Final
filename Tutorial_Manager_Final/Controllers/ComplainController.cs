using Microsoft.AspNetCore.Mvc;
using Tutorial_Manager_Final.Models;


namespace Tutorial_Manager_Final.Controllers
{
    public class ComplainController : Controller
    {
        private readonly TutorialContext _context;
        public ComplainController(TutorialContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
           
            return View();
        }
        public IActionResult ParentCreate(int id)
        {
            ViewBag.index = id;
            return View();
        }
        [HttpPost]
        public IActionResult ParentCreate(Complain complain)
        {
            _context.Complains.Add(complain);
            _context.SaveChanges();
            return Redirect("");
        }

        public IActionResult TutorCreate(int id)
        {
            ViewBag.index = id;
            return View();
        }
        [HttpPost]
        public IActionResult TutorCreate(Complain complain)
        {
            _context.Complains.Add(complain);
            _context.SaveChanges();
            return Redirect("/TutorHome/Index");
        }
        public IActionResult StudentCreate(int id)
        {
            ViewBag.index = id;
            return View();
        }
        [HttpPost]
        public IActionResult StudentCreate(Complain complain)
        {
            _context.Complains.Add(complain);
            _context.SaveChanges();
            return Redirect("/StudentHome/Index");
        }
    }
}
