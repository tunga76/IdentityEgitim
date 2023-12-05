using Microsoft.AspNetCore.Identity;

namespace IdentityEgitim.API.Models
{
    public class AppUser : IdentityUser
    {
        public string? City { get; set; }
    }
}
