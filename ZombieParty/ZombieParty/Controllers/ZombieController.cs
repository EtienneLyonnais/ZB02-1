using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MaListe = new List<Zombie>();

            return View();
        }
    }
}
