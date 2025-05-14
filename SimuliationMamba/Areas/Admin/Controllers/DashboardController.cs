using Microsoft.AspNetCore.Mvc;
using SimuliationMamba.Contexts;
using SimuliationMamba.Models;
using System.Numerics;

namespace SimuliationMamba.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController()
        {
           _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            List<Team> team = _context.Teams.ToList();
            return View(team);
        }
        public IActionResult TeamTable() 
        {
            List<Team>team=_context.Teams.ToList();
            return View(team);
        }

    }
}
