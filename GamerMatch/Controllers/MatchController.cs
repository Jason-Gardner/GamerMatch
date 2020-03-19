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

        public int CompareBoardGameMatchTotal(AspNetUsers match, AspNetUsers currentUser)
        {
            int matchScore = 0;

            //Algorithm that weighs input parameters to generate match score
            if (CompareBoardGameUserPref(currentUser, match))
            {
                matchScore += 100;
            }

            return matchScore;
        }

        public List<int> MatchTotalsList(List<AspNetUsers> matchList, AspNetUsers currentUser)
        {
            List<int> matchScoreList = new List<int>();
            //if (TempData["SearchType"].ToString() == "Boardgame")
            //{
            foreach (AspNetUsers user in matchList)
            {
                matchScoreList.Add(CompareBoardGameMatchTotal(user, currentUser));
            }
            //}
            return matchScoreList;
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
            List<MatchTable> matches = db.MatchTable.ToList<MatchTable>();
            MatchTable newMatch = new MatchTable();

            foreach (MatchTable match in matches)
            {
                if (match.UserSend == activeUser.Id)
                {
                    if (match.UserGet == matchUser && (match.Status == 1 | match.Status == 3))
                    {
                        match.Status = 1;
                        db.SaveChanges();
                        return Redirect("~/Home/HomePage");
                    }
                }
            }

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

        public IActionResult DenyMatch(string user, string title)
        {
            AspNetUsers activeUser = FindUser();
            List<MatchTable> matches = db.MatchTable.ToList<MatchTable>();
            MatchTable newMatch = new MatchTable();

            foreach (MatchTable match in matches)
            {
                if (match.UserSend == activeUser.Id)
                {
                    if (match.UserSend == user && match.Status != 2)
                    {
                        match.Status = 2;
                        db.SaveChanges();
                        return Redirect("~/Home/HomePage");
                    }
                }
            }

            MatchTable Deny = new MatchTable();

            Deny.UserSend = activeUser.Id;
            Deny.UserGet = user;
            Deny.Status = 2;
            db.MatchTable.Add(Deny);
            db.SaveChanges();

            ViewData["Search"] = title;

            return Redirect("~/Home/HomePage");
        }

        public IActionResult Clear()
        {
            AspNetUsers activeUser = FindUser();

            GamerMatchContext db = new GamerMatchContext();

            foreach (MatchTable match in db.MatchTable)
            {
                if (match.UserSend == activeUser.Id)
                {
                    if (match.Status == 2)
                    {
                        match.Status = 3;
                    }
                }
            }

            db.SaveChanges();

            return Redirect("~/Home/HomePage");
        }

        public IActionResult RateUser(string username, int rating)
        {
            AspNetUsers activeUser = FindUser();
            GamerMatchContext db = new GamerMatchContext();
            foreach (MatchTable match in db.MatchTable)
            {
                if (username == match.UserGet && activeUser.Id == match.UserSend)
                {
                    if (match.Rating == null)
                    {
                        match.Rating = rating;
                        db.Update(match);
                        continue;
                    }
                    else
                    {
                        return Redirect("~/Home/HomePage");
                    }

                }
            }

            db.SaveChanges();

            foreach (var person in db.AspNetUsers)
            {
                if (person.UserName == username)
                {
                    if (person.PlayerRating == null)
                    {
                        person.PlayerRating = 0;
                        person.RatingCount = 0;
                    }

                    person.PlayerRating += rating;
                    person.RatingCount += 1;
                    db.Update(person);
                }
            }

            db.SaveChanges();

            return Redirect("~/Home/HomePage");
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