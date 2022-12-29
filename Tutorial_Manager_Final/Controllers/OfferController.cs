using Microsoft.AspNetCore.Mvc;
using Tutorial_Manager_Final.Models;

namespace Tutorial_Manager_Final.Controllers
{
    public class OfferController : Controller
    {
        private readonly TutorialContext _context;
        public OfferController(TutorialContext context)
        {
            _context = context;
        }
        public IActionResult Index( int id)
        {
            var offers = _context.Offers.Where(temp => temp.TutId == id).ToList();

            return View(offers);
        }
        public IActionResult Accept(int id)
        {
            var accept = _context.Offers.Find(id);

            return View(accept);
        }
        [HttpPost]
        public IActionResult Accept(Offer offer)
        {
            _context.Offers.Update(offer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Reject(int id)
        {
            var reject = _context.Offers.Find(id);

            return View(reject);
        }
        [HttpPost]
        public IActionResult Reject(Offer offer)
        {
            _context.Offers.Update(offer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
