using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerMatch.Models
{
    public class gUser
    {
        public string username { get; set; }
        public string email { get; set; }
        userProfile stProfile { get; set; }
        public List<gUser> matchList { get; set; }
        public userPref preferences { get; set; }
        public gRating userRating { get; set; }

    }
        public class userPref
        {
            public bool hasSteam { get; set; }
            public string userExperience { get; set; }
            public List<Game> favorites { get; set; }
            public List<string> prefGenre { get; set; }
        }

        public class userProfile
        {
            public string steamid { get; set; }
            public string profileurl { get; set; }
            public int personastateflags { get; set; }
        }

        public class gRating
        {
            public int rateCount { get; set; }
            public double rating { get; set; }
        }
    

    public class Game
    {
        public string title;
    }

    abstract class videoGame : Game
    {
        public string genre;
        public double rating;
    }

    abstract class cardGame : Game
    {
        public string type;
        public string description;
    }
}
