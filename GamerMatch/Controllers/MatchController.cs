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
        GamerMatchContext db = new GamerMatchContext();
        public MatchController(IConfiguration config)
        {
            _config = config;
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