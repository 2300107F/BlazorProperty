namespace BlazorProperty.Domain
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        //public ICollection<Agent> Agents { get; set; } = new List<Agent>();
    }
}
