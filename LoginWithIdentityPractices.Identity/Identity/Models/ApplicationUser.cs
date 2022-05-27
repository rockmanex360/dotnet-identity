using System;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace LoginWithIdentityPractices.Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [IgnoreDataMember]
        public string FullName {
            get => $"{FirstName} {LastName}";
        }
    }
}
