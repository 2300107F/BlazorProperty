using BlazorProperty.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BlazorProperty.Configurations.Entities
{
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
            new Company
            {
                CompanyId = 1,
                CompanyName = "XYZ realestate",
                CompanyDescription = "XYZ real estate provides the newest and greatest properties"
            },
            new Company
            {
                CompanyId = 2,
                CompanyName = "ABC Real Estate",
                CompanyDescription = "ABC Real Estate was founded in 1982"
            }
            );
        }
    }
}
