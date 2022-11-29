using Microsoft.AspNetCore.Identity;

namespace FinalP.Services.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}
