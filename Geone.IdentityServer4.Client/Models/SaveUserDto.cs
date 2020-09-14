using System;
using System.Collections.Generic;

namespace Geone.IdentityServer4.Client.Models
{
    public class SaveUserDto
    {

        public string UserName { get; set; }
        public string Email { get; set; } = "";
        public bool? EmailConfirmed { get; set; } = true;
        public string PhoneNumber { get; set; } = "";
        public bool? PhoneNumberConfirmed { get; set; } = true;
        public bool? LockoutEnabled { get; set; } = true;
        public bool? TwoFactorEnabled { get; set; } = true;
        public int? AccessFailedCount { get; set; } = 0;
        public DateTime? LockoutEnd { get; set; } = DateTime.Now;
    }
    public class UpdateUserDto : SaveUserDto
    {
        public Guid Id { get; set; }
    }
        public class UpdatePasswordInput
    {
        public Guid UserId { get; set; }
        public string PassWord { get; set; }
        public string ConfirmPassword { get; set; } 

    }
    public class SaveClaimsInput
    {
        public Guid UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

    }
}
