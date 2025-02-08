using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorProperty.Domain;

namespace BlazorProperty.Configurations.Entities
{
    public class RegionSeed : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData(
                new Region
                {
                    RegionId = 1,
                    RegionName = "East",
                    RegionDescription = "Located on the east side of singapore like Tampines"
                },
                new Region
                {
                    RegionId = 2,
                    RegionName = "Central",
                    RegionDescription = "The Singapore Central Region with towns like Kallang"
                },
                new Region
                {
                    RegionId = 3,
                    RegionName = "North",
                    RegionDescription = "Woodlands"
                },
                new Region
                {
                    RegionId = 4,
                    RegionName = "West",
                    RegionDescription = "Jurong"
                },
                new Region
                {
                    RegionId = 5,
                    RegionName = "North east",
                    RegionDescription = "Punggol area"
                }
                );
        }
    }
}
