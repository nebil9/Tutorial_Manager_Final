using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_Manager_Final.Models;

namespace Tutorial_Manager_Final.Controllers
{
    public class ProfileController : Controller
    {
        private readonly TutorialContext _context;
        public ProfileController(TutorialContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Edit(int id)
        {
            var exsitingProfile = _context.Profiles.Find(id); /*should be modified*/
            return View(exsitingProfile);
        }
       
        [HttpPost, ActionName("Edit")]
        public IActionResult Edit( Profile profile )
        {

            _context.Profiles.Update(profile); /*should be modified*/
            _context.SaveChanges();

            return Redirect("/Home/Index"); /*should be modified*/
        }

    }
}
