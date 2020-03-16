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

        public IActionResult Index()
        {

            return View();
        }

        [Authorize]
        public async Task<IActionResult> HomePage()
        {
            FindUser();
            ViewData["Games"] = gc.BoardGames.ToList<BoardGames>();
            ViewData["Users"] = gc.AspNetUsers.ToList<AspNetUsers>();
            ViewData["Friends"] = databaseController.GetMatches(currentUser);

            if(currentUser.SteamInfo != null)
            {
                ViewData["MyGames"] = await apiController.GetSteamLibrary(currentUser.SteamInfo);
            }
            else
            {
                ViewData["MyGames"] = null;
            }
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
                gc.SaveChanges();
                return View("HomePage");
            }
            else
            {
                currentUser.SteamInfo = steam;
                gc.SaveChanges();
                ViewData["MyGames"] = await apiController.GetSteamLibrary(currentUser.SteamInfo);
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


        public async Task<IActionResult> Results(string steamTitle, string boardTitle)
        {
            FindUser();

            List<AspNetUsers> matchList = await databaseController.SearchSplit(steamTitle, boardTitle);
            List<AspNetUsers> displayList = new List<AspNetUsers>();
            List<Matches> matches = gc.Matches.ToList<Matches>();

            foreach (AspNetUsers user in matchList)
            {
                foreach  (Matches match in matches)
                {
                    if (match.UserGet == user.UserName)
                    {
                        continue;
                    }
                    else
                    {
                        displayList.Add(user);
                    }
                }
            }

            ViewData["Search"] = new List<string>
            {
                steamTitle,
                boardTitle
            };

            return View(displayList);
        }

        public IActionResult Ratings()
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

