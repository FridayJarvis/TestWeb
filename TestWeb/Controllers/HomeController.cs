using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWeb.DAL.Interfaces;
using TestWeb.Domain.Models;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPizzaRepos _pizzaRepos;

        public HomeController(ILogger<HomeController> logger, IPizzaRepos pizzaRepos)
        {
            _logger = logger;
            _pizzaRepos = pizzaRepos;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _pizzaRepos.Select();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
