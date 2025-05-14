using Microsoft.AspNetCore.Mvc;
using SimuliationMamba.Contexts;
using SimuliationMamba.Models;

namespace SimuliationMamba.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Team> teams = new List<Team>();
            Team teamMember1 = new Team
            {
                Id = 1,
                Name = "Nail",
                ImgUrl= "team-1.jpg",
                Profession= "sjklznju"
            };
            Team teamMember2 = new Team
            {
                Id = 1,
                Name = "Nazrin",
                ImgUrl = "team-2.jpg",
                Profession = "sdafx"
            };
            Team teamMember3 = new Team
            {
                Id = 1,
                Name = "Natiq",
                ImgUrl = "team-3.jpg",
                Profession = "sfcaescafaf"
            };
            teams.Add(teamMember1);
            teams.Add(teamMember2);
            teams.Add(teamMember3);

            return View(teams);
        }
    }
}
