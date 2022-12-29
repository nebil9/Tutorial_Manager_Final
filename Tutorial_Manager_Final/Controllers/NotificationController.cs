using Microsoft.AspNetCore.Mvc;
using Tutorial_Manager_Final.Models;

namespace Tutorial_Manager_Final.Controllers
{

    public class NotificationController : Controller
    {

        private readonly TutorialContext _context;
        public NotificationController(TutorialContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(); 

        }

        public IActionResult NotiPar(int id)
        {
            var notifications = _context.Notifications.Where(x => x.TutId == id).ToList();

            return View(notifications);
        }
        public IActionResult NotiStu(int id)
        {
            var notifications = _context.Notifications.Where(x => x.StuId == id).ToList();

            return View(notifications);
        }
        public IActionResult NotiTut(int id)
        {
            var notifications = _context.Notifications.Where(x => x.ParId == id).ToList();

            return View(notifications);
        }
    }
}
