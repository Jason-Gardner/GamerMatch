using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamerMatch.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamerMatch.Controllers
{
    public class MatchController : Controller
    {
        //Just for testing purposes
        public AspNetUsers SetTestUser()
        {
            GamerMatchContext db = new GamerMatchContext();
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
    }
}