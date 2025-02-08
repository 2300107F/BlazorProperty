namespace BlazorProperty.Domain
{
    public class PropertyImage
    {
        public int PropertyImageId { get; set; }
        public string ImageUrl { get; set; }

        // Navigation Property
        public Property? Property { get; set; }
        public int PropertyId { get; set; }
    }
}
