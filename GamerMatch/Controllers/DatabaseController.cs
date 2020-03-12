﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamerMatch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GamerMatch.Controllers
{
    public class DatabaseController : Controller
    {
        private IConfiguration _config;
        private ApiController apiController;

        public DatabaseController(IConfiguration config)
        {
            _config = config;
            apiController = new ApiController(config);
        }
        public async Task<List<AspNetUsers>> SearchMatch(string gameSearch)
        {
            GamerMatchContext db = new GamerMatchContext();
            List<AspNetUsers> matchList = new List<AspNetUsers>();

            foreach (AspNetUsers user in db.AspNetUsers)
            {
                if (await apiController.SearchGames(user.SteamInfo, gameSearch) != null)
                {
                    matchList.Add(user);
                }
            }

            return matchList;
        }
    }
}