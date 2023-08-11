using Microsoft.AspNetCore.Identity;
using System;

namespace PierresTreats.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime DateJoined { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}