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

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            long steamID = 76561198208852060;
            string gameSearch = "Just Survive";

            ViewBag.ID = await SearchGames(steamID, gameSearch);

            return View();
        }

        public async Task<long> SearchGames(long steamID, string gameSearch)
        {
            using (var httpClient = new HttpClient())
            {
                var apiKey = _config["ApiKey"];

                using (var response =
                    await httpClient.GetAsync($"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamID}&include_appinfo=1"))
                {
                    var summary = await response.Content.ReadAsStringAsync();
                    jDoc = JsonDocument.Parse(summary);
                    var games = jDoc.RootElement.GetProperty("response").GetProperty("games");

                    for (int i = 0; i < games.GetArrayLength(); i++)
                    {
                        var game = games[i].GetProperty("name").GetString();

                        if (game == gameSearch)
                        {
                            return steamID;
                        }
                    }

                    return 0;
                }
            }
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
