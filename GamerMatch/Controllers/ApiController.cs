using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GamerMatch.Controllers
{
    public class ApiController : Controller
    {
        private IConfiguration _config;
        private JsonDocument jDoc;

        public ApiController(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> SearchGames(string steamID, string gameSearch)
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

                    return null;
                }
            }
        }
    }
}