using Microsoft.AspNetCore.Mvc;
using SimuliationMamba.Contexts;
using SimuliationMamba.Models;

namespace SimuliationMamba.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamMembersController : Controller
    {
        private readonly AppDbContext _context;
        public TeamMembersController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            List<Team>team=_context.Teams.ToList();
            return View(team);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
