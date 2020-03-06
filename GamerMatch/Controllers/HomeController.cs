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

namespace GamerMatch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private JsonDocument jDoc;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            userProfile user = await getProfile();
            return View(user);
        }
        public async Task<userProfile> getProfile()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response =
                    await httpClient.GetAsync("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=99ff3510b4cabfad5fa950d44aa31f1a&steamids=76561198208852060"))
                {
                    var summary = await response.Content.ReadAsStringAsync();
                    jDoc = JsonDocument.Parse(summary);
                    var player = jDoc.RootElement.GetProperty("response").GetProperty("players");
                    userProfile newUser = new userProfile()
                    {
                        steamid = player[0].GetProperty("steamid").ToString(),
                        
                        profileurl = player[0].GetProperty("profileurl").ToString(),
                        personastateflags = int.Parse(player[0].GetProperty("personastateflags").ToString())
                    };
                    return newUser;
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
