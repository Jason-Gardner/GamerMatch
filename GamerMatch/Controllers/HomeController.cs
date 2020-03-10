using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GamerMatch.Models;
using System.Net.Http;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace GamerMatch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration _config;
        private JsonDocument jDoc;
        private ApiController apiController;
        private DatabaseController databaseController;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
            apiController = new ApiController(config);
            databaseController = new DatabaseController(config);
        }
        
        public async Task<IActionResult> Index()
        {
            string steamID = "76561198208852060";
            string gameSearch = "Just Survive";

            ViewBag.ID = await apiController.SearchGames(steamID, gameSearch);

            return View();
        }

        public IActionResult HomePage()
        {
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
