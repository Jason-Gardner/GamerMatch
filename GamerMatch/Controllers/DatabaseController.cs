﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamerMatch.Models;
using Microsoft.AspNetCore.Http;
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
        public async Task<List<AspNetUsers>> SearchMatchSteam(string gameSearch)
        {
            GamerMatchContext db = new GamerMatchContext();
            List<AspNetUsers> matchList = new List<AspNetUsers>();
            HttpContext.Session.SetString("Searched Game", gameSearch);

            foreach (AspNetUsers user in db.AspNetUsers)
            {
                if (user.SteamInfo != null)
                {
                    try
                    {
                        if (await apiController.SearchGames(user.SteamInfo, gameSearch) != null)
                        {
                            matchList.Add(user);
                        }
                    }
                    catch (KeyNotFoundException)
                    {
                        continue;
                    }
                }
            }

            return matchList;
        }

        public List<AspNetUsers> SearchMatchBoardGames(string gameTitle)
        {
            GamerMatchContext db = new GamerMatchContext();
            List<AspNetUsers> matchList = new List<AspNetUsers>();
            HttpContext.Session.SetString("Searched Game", gameTitle);
            List<string> gameList = new List<string>();
            string userGames = null;

            foreach (AspNetUsers user in db.AspNetUsers)
            {
                if (user.BoardGamePref != null)
                {
                    userGames = user.BoardGamePref;
                    gameList = GetBoardGames(userGames);

                    foreach (string game in gameList)
                    {
                        if (game == gameTitle)
                        {
                            matchList.Add(user);
                        }
                    }
                }
            }

            return matchList;
        }


        public string SetBoardGames (List<string> boardGameList)
        {
            string boardGameString = null;

            for(int i = 0; i < boardGameList.Count; i++)
            {
                if(i == 0)
                {
                    boardGameString += boardGameList[i];
                }
                else
                {
                    boardGameString += (',' + boardGameList[i]);
                }
            }

            return boardGameString;
        }

        public List<string> GetBoardGames (string boardGameString)
        {
            List<string> boardGameList = boardGameString.Split(',').ToList<string>();

            return boardGameList;
        }
    }
}
