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
            ViewData["Games"] = gc.BoardGames.ToList<BoardGames>();
            return View(currentUser);
        }

        public async Task<IActionResult> UserPerf(string steam, string difficulty, string[] boardgames)
        {
            FindUser();

            List<string> myGames = boardgames.ToList<string>();
            currentUser.BoardGamePref = databaseController.SetBoardGames(myGames);

            currentUser.UserPref = difficulty;
            ViewData["Games"] = gc.BoardGames.ToList<BoardGames>();
            ViewData["Users"] = gc.AspNetUsers.ToList<AspNetUsers>();

            if (steam == null)
            {
                return View("HomePage");
            }
            else
            {
                currentUser.SteamInfo = steam;
                ViewData["MyGames"] = await apiController.MyGames(currentUser.SteamInfo);
                return View("HomePage");
            }
        }

        //Temp Test Zone
        public IActionResult Privacy()
        {
            string gameSearch = "Game 1";

            List<AspNetUsers> matchList = databaseController.SearchMatchBoardGames(gameSearch);
            return View(matchList);
        }

        public void FindUser()
        {
            foreach (var person in gc.AspNetUsers)
            {
                if (person.UserName == User.Identity.Name)
                {
                    currentUser = person;
                }
            }
        }

        public async Task<IActionResult> Results(string game, string boardgame, string difficult)
        {
            List<AspNetUsers> userList = new List<AspNetUsers>();

            if (difficult != null)
            {
                await foreach (var item in gc.AspNetUsers)
                {
                    if (item.UserPref == difficult)
                    {
                        userList.Add(item);
                    }
                }
            }

            return View(userList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

