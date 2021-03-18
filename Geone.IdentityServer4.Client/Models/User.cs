using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.IdentityServer4.Client.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool LockoutEnabled { get; set; } = true;
        public bool TwoFactorEnabled { get; set; }
        public int AccessFailedCount { get; set; } = 0;
        public DateTime? LockoutEnd { get; set; }

        public string Alias { get; set; }

        public Dictionary<string, string> Claims { get; set; } = new Dictionary<string, string>();
    }

    public class UserWithId : User
    {
        public string Id { get; set; }
    }
}
