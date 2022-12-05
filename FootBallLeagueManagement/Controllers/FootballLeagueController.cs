using FootBallLeagueManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootBallLeagueManagement.Controllers
{
    public class FootballLeagueController : Controller
    {
        private readonly FootBallLeagueDbContext _context;
        public FootballLeagueController(FootBallLeagueDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<FootballLeague> objCatlist = _context.FootballLeagues;
            return View(objCatlist);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FootballLeague Football)
        {
            if (ModelState.IsValid)
            {
                _context.FootballLeagues.Add(Football);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }

            return View(Football);
        }
    }
}

