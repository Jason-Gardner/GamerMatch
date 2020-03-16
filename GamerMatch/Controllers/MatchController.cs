using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamerMatch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GamerMatch.Controllers
{
    public class MatchController : Controller
    {
        private IConfiguration _config;
        private DatabaseController databaseController;
        private ApiController apiController;
        GamerMatchContext db = new GamerMatchContext();

        public MatchController(IConfiguration config)
        {
            _config = config;
            databaseController = new DatabaseController(config);
            apiController = new ApiController(config);
        }

        //Just for testing purposes
        public AspNetUsers SetTestUser()
        {
            AspNetUsers testUser = new AspNetUsers();

            foreach (AspNetUsers user in db.AspNetUsers)
            {
                if (user.Id == "1")
                {
                    testUser = user;
                }
            }

            return testUser;
        }

        public bool CompareBoardGameUserPref(AspNetUsers activeUser, AspNetUsers matchUser)
        {
            bool match;

            if (activeUser.UserPref == matchUser.UserPref)
            {
                match = true;
            }
            else
            {
                match = false;
            }

            return match;
        }

        public int CompareBoardGameLists(AspNetUsers activeUser, AspNetUsers matchUser)
        {
            int matchNumber = 0;
            List<string> gameListActive = databaseController.GetBoardGames(activeUser.BoardGamePref);
            List<string> gameListMatched = databaseController.GetBoardGames(matchUser.BoardGamePref);

            for (int i = 0; i < gameListActive.Count; i++)
            {
                for (int j = 0; j < gameListMatched.Count; j++)
                {
                    if (gameListActive[i] == gameListMatched[j])
                    {
                        matchNumber += 1;
                    }
                }
            }
            return matchNumber;
        }

        public int CompareBoardGameMatchTotal(bool userPrefMatch)
        {
            int matchScore = 0;

            //Algorithm that weighs input parameters to generate match score
            if (userPrefMatch)
            {
                matchScore += 100;
            }

            return matchScore;
        }

        public async Task<int> GetSteamRecentlyPlayed(AspNetUsers user)
        {
            List<string> listRecent = await apiController.MyGames(user.SteamInfo);

            int totalRecent = listRecent.Count();

            return totalRecent;
        }

        public async Task<int> CompareSteamRecentlyPlayed(AspNetUsers activeUser, AspNetUsers matchUser)
        {
            int matchNumber = 0;
            List<string> gameListActive = await apiController.MyGames(activeUser.SteamInfo);
            List<string> gameListMatched = await apiController.MyGames(matchUser.SteamInfo);

            for (int i = 0; i < gameListActive.Count; i++)
            {
                for (int j = 0; j < gameListMatched.Count; j++)
                {
                    if (gameListActive[i] == gameListMatched[j])
                    {
                        matchNumber += 1;
                    }
                }
            }
            return matchNumber;
        }

        public IActionResult MatchUsers(string matchUser)
        {
            AspNetUsers activeUser = FindUser();

            MatchTable newMatch = new MatchTable();
            newMatch.UserSend = activeUser.Id;
            newMatch.UserGet = matchUser;
            newMatch.Status = 1;

            db.MatchTable.Add(newMatch);
            db.SaveChanges();

            return Redirect("~/Home/HomePage");
        }

        public List<AspNetUsers> RegenerateMatchList(List<string> matchNames)
        {
            List<AspNetUsers> matchList = new List<AspNetUsers>();

            for (int i = 0; i < matchNames.Count; i++)
            {
                foreach (AspNetUsers user in db.AspNetUsers)
                {
                    if (matchNames[i] == user.UserName)
                    {
                        matchList.Add(user);
                    }
                }
            }

            return (matchList);
        }

        public IActionResult DenyMatch(AspNetUsers user, string title)
        {
            AspNetUsers activeUser = FindUser();

            MatchTable Deny = new MatchTable();
        
            Deny.UserGet = activeUser.Id;
            Deny.UserSend = user.UserName;
            Deny.Status = 2;
            db.MatchTable.Add(Deny);
            db.SaveChanges();

            ViewData["Search"] = title;

            return View("../Home/Results");
        }

        public AspNetUsers FindUser()
        {
            AspNetUsers activeUser = new AspNetUsers();

            foreach (var person in db.AspNetUsers)
            {
                if (person.UserName == User.Identity.Name)
                {
                    activeUser = person;
                }
            }

            return activeUser;
        }
    }
}