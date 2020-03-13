﻿using System;
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
        GamerMatchContext db = new GamerMatchContext();

        public MatchController(IConfiguration config)
        {
            _config = config;
            databaseController = new DatabaseController(config);
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

            for(int i = 0; i < gameListActive.Count; i++)
            {
                for(int j = 0; j < gameListMatched.Count; j++)
                {
                    if(gameListActive[i] == gameListMatched[j])
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

        public void MatchUsers(AspNetUsers matchUser)
        {
            AspNetUsers activeUser = FindUser();
            UserMatch newMatch = new UserMatch()
            {
                UserSend = activeUser.Id,
                UserGet = matchUser.Email
            };

            db.UserMatch.Add(newMatch);
            
        }

        public AspNetUsers FindUser()
        {
            AspNetUsers activeUser = new AspNetUsers();

            foreach (var person in db.AspNetUsers)
            {
                if (person.Email == User.Identity.Name)
                {
                    activeUser = person;
                }
            }

            return activeUser;
        }
    }
}