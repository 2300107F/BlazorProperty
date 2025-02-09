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
                PropertyName = "Tampines Blk 123 HDB",
                Address = "Tampines Blk 123",
                Price = 1000000,
                PropertyType = "HDB",
                Bedrooms = 5,
                Bathrooms = 3,
                Sqft = 1100,
                //AgentId = 1, // FK reference to Agent
                //CompanyId = 1,
                RegionId = 1
            },
            new Property
            {
                PropertyId = 2,
                PropertyName = "Bedok Blk 456 HDB",
                Address = "Bedok Blk 456",
                Price = 400000,
                PropertyType = "HDB",
                Bedrooms = 3,
                Bathrooms = 2,
                Sqft = 700,
                //AgentId = 2, // Fk Reference to Agent
                //CompanyId = 1,
                RegionId = 1
            },
            new Property
            {
                PropertyId = 3,
                PropertyName = "Kallang Blk 123 HDB",
                Address = "Kallang Blk 123",
                Price = 750000,
                PropertyType = "HDB",
                Bedrooms = 4,
                Bathrooms = 2,
                Sqft = 890,
                //AgentId = 1,
                //CompanyId = 1,
                RegionId = 2,
            },
            new Property
            {
                PropertyId = 4,
                PropertyName = "Jurong East Blk456 HDB",
                Address = "Jurong East Blk456",
                Price = 888888,
                PropertyType = "HDB",
                Bedrooms = 4,
                Bathrooms = 2,
                Sqft = 888,
                //CompanyId = 2,
                RegionId = 4,
            }
            );
        }
    }
}
