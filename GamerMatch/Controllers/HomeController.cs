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
using Microsoft.AspNetCore.Authorization;

namespace GamerMatch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration _config;
        private ApiController apiController;
        private DatabaseController databaseController;
        private MatchController matchController;
        public GamerMatchContext gc = new GamerMatchContext();
        private AspNetUsers currentUser = new AspNetUsers();

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
            apiController = new ApiController(config);
            databaseController = new DatabaseController(config);
            matchController = new MatchController(config);
        }

        public async Task<IActionResult> Index()
        {
            string gameSearch = "Garry's Mod";

            List<AspNetUsers> matchList = await databaseController.SearchMatchSteam(gameSearch);

            return View(matchList);

            //return View();
        }

        [Authorize]
        public async Task<IActionResult> HomePage()
        {
            FindUser();
            ViewData["Games"] = gc.BoardGames.ToList<BoardGames>();
            ViewData["Users"] = gc.AspNetUsers.ToList<AspNetUsers>();
            ViewData["MyGames"] = await apiController.MyGames(currentUser.SteamInfo);
            return View(currentUser);
        }

        public IActionResult Preferences()
        {
            FindUser();
            return View(currentUser);
        }

        public IActionResult UserPerf(string difficulty)
        {
            return View("HomePage");
        }

        //Temp Test Zone
        public IActionResult Privacy()
        {
            List<string> gameList = new List<string>()
            {"Game 1", "Game 2", "Game 3", "Game 4"
            };

            //AspNetUsers user = matchController.SetTestUser();
            //gameList = databaseController.GetBoardGames(user.BoardGamePref);

            string gameString = databaseController.SetBoardGames(gameList);



            return View("Privacy", gameString);
        }

        public void FindUser()
        {
            foreach (var person in gc.AspNetUsers)
            {
                if (person.Email == User.Identity.Name)
                {
                    currentUser = person;
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

