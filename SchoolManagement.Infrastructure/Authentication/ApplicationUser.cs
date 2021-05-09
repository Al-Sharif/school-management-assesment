﻿
using Microsoft.AspNetCore.Identity;

namespace SchoolManagement.Infrastructure.Authentication
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
