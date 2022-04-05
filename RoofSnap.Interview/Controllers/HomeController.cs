using Microsoft.AspNetCore.Mvc;
using RoofSnap.Interview.Models;
using System.Diagnostics;
using RoofSnap.Interview.HttpClients;

namespace RoofSnap.Interview.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBeerClient _beerClient;

        public HomeController(ILogger<HomeController> logger, IBeerClient beerClient)
        {
            _logger = logger;
            _beerClient = beerClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel()
            {
                RawBeerData = await _beerClient.GetBeersAsync(),
                // TODO: The collections below are wrong. Find and implement the interfaces that will properly populate these.
                GroupedByBrand = await _beerClient.GetBeersAsync(),
                SortedByIBU = await _beerClient.GetBeersAsync()
            };

            return View(viewModel);
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