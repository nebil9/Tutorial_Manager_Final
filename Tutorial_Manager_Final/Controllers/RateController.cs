using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_Manager_Final.Models;

namespace Tutorial_Manager_Final.Controllers
{
    public class RateController : Controller
    {
        private readonly TutorialContext _context;
        public RateController(TutorialContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(int id)
        {
                  ViewBag.index = id;

            var rates = _context.Rates
             .Include(r => r.Tut)
              .AsNoTracking();

            

            // if (TutorId == null) return BadRequest();
            /*                else
                            {
                            var Tutor = _context.Tutors.Find(TutorId);

    
                            return View(Tutor);
                        }*/

            return View(rates);
        }
        [HttpPost]
        public IActionResult Create(Rate rate)
        {
            _context.Rates.Add(rate);
            _context.SaveChanges();
            return Redirect("/StudentHome/Index");
        }
    }
}
