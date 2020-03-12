using System;
using System.Collections.Generic;

namespace GamerMatch.Models
{
    public partial class UserMatch
    {
        public string UserSend { get; set; }
        public string UserGet { get; set; }

        public virtual AspNetUsers UserSendNavigation { get; set; }
    }
}
