using Microsoft.AspNetCore.Mvc;
using Tutorial_Manager_Final.Models;

namespace Tutorial_Manager_Final.Controllers
{
    public class PerformanceController : Controller
    {
        private readonly TutorialContext _context;
        public PerformanceController(TutorialContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var performance = _context.Performances.Where(temp => temp.StuId == id).ToList();

            return View(performance); /*The view should be made*/
        }
        public IActionResult Details(int id)
        {
            var performance = _context.Performances.Find(id);
              return View(performance);
        }

        public IActionResult TutorsView(int id)
        {
            var performance = _context.Performances.Where(temp => temp.TutId == id).ToList();

            return View(performance);
        }
        public IActionResult Edit(int id)
        {
            var performance = _context.Performances.Find(id);

            return View(performance);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult Edit(int id, Performance performance)
        {
            _context.Performances.Update(performance); /*should be modified*/
            _context.SaveChanges();

            return RedirectToAction("Index"); /*should be modified*/
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Performance performance)
        {
            _context.Performances.Add(performance);
            _context.SaveChanges();
            return RedirectToAction("TutorsView");
        }
    }
}
