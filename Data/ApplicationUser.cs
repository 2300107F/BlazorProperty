using Microsoft.AspNetCore.Identity;

namespace BlazorProperty.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public string? DisplayName { get; set; }
    }
}
