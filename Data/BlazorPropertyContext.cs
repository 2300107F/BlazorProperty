using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorProperty.Data;
using BlazorProperty.Configurations.Entities;

namespace BlazorProperty.Data
{
    public class BlazorPropertyContext : IdentityDbContext<ApplicationUser>
    {
        public BlazorPropertyContext(DbContextOptions<BlazorPropertyContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorProperty.Domain.Company> Company { get; set; } = default!;
        public DbSet<BlazorProperty.Domain.Facility> Facility { get; set; } = default!;
        public DbSet<BlazorProperty.Domain.Region> Region { get; set; } = default!;
        public DbSet<BlazorProperty.Domain.Property> Property { get; set; } = default!;
        public DbSet<BlazorProperty.Domain.PropertyImage> PropertyImage { get; set; } = default!;
        public DbSet<BlazorProperty.Domain.Inquiry> Inquiry { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new CompanySeed());
            builder.ApplyConfiguration(new RegionSeed());
            builder.ApplyConfiguration(new FacilitySeed());
            builder.ApplyConfiguration(new PropertySeed());
        }
    }
}
