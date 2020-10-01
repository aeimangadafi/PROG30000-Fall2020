using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W3_PartyInviteExample.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool WillAttend { get; set; }
    }
}
