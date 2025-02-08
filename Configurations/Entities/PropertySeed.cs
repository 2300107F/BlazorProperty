using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorProperty.Domain;

namespace BlazorProperty.Configurations.Entities
{
    public class PropertySeed : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasData(
            new Property
            {
                PropertyId = 1,
                Address = "Tampines Blk 123",
                PostalCode = "330022",
                Price = 1000000,
                PropertyType = "HDB",
                Bedrooms = 5,
                Bathrooms = 3,
                Sqft = 1100,
                //AgentId = 1, // FK reference to Agent
                RegionId = 1
            },
            new Property
            {
                PropertyId = 2,
                Address = "Bedok Blk 456",
                PostalCode = "123456",
                Price = 400000,
                PropertyType = "HDB",
                Bedrooms = 3,
                Bathrooms = 2,
                Sqft = 700,
                //AgentId = 2, // Fk Reference to Agent
                RegionId = 1
            },
            new Property
            {
                PropertyId = 3,
                Address = "Kallang Blk 123",
                PostalCode = "364029",
                Price = 750000,
                PropertyType = "HDB",
                Bedrooms = 4,
                Bathrooms = 2,
                Sqft = 890,
                //AgentId = 1,
                RegionId = 2,
            },
            new Property
            {
                PropertyId = 4,
                Address = "Jurong East Blk456",
                PostalCode = "326432",
                Price = 888888,
                PropertyType = "HDB",
                Bedrooms = 4,
                Bathrooms = 2,
                Sqft = 888,
                RegionId = 4,
            }
            );
        }
    }
}
