using BlazorProperty.Data;

namespace BlazorProperty.Domain
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        // Link to ApplicationUser (agents)
        //public ICollection<ApplicationUser> Agents { get; set; } = new List<ApplicationUser>();
        //public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
