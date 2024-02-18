using CleanArchitecture.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string UserName { get; set; }
        public int ReferenceId { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
