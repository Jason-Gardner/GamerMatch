using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerMatch.Models
{
    public class userProfile
    {
        public string steamid { get; set; }
        public int profilestate { get; set; }
        public string profileurl { get; set; }
        public int personastateflags { get; set; }
    }
}
