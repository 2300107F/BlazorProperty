namespace BlazorProperty.Domain
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public string PropertyType { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Sqft { get; set; }

        // Navigation Property 
        //public Agent? Agent { get; set; }
        //public int AgentId { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }

        //public int CompanyId { get; set; }
        //public Company Company { get; set; } // Navigation property

        public ICollection<Inquiry> PropertiesInquiries { get; set; } = new List<Inquiry>();

        public ICollection<PropertyImage> PropertyImages { get; set; } = new List<PropertyImage>();
    }
}
