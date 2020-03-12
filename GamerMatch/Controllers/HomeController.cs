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
        public GamerMatchContext gc = new GamerMatchContext();

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
            apiController = new ApiController(config);
            databaseController = new DatabaseController(config);
        }

        public async Task<IActionResult> Index()
        {
            string gameSearch = "Garry's Mod";

            List<AspNetUsers> matchList = await databaseController.SearchMatchSteam(gameSearch);

            return View(matchList);

            //return View();
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Preferences()
        {
            AspNetUsers newUser = new AspNetUsers();
            foreach (var person in gc.AspNetUsers)
            {
                if (person.UserName == User.Identity.Name)
                {
                    newUser = person;
                }
            }
            return View(newUser);
        }

        public IActionResult UserPerf(string difficulty)
        {
            return View("HomePage");
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

