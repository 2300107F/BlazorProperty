﻿using BlazorProperty.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BlazorProperty.Configurations.Entities
{
    public class FacilitySeed : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(
                new Facility
                {
                    FacilityId = 1,
                    FacilityName = "Hawker",
                    FacilityDescription = "Food centre for singaporean",
                    RegionId = 1,
                },
                new Facility
                {
                    FacilityId = 2,
                    FacilityName = "Gym",
                    RegionId = 1
                }
                );
        }
    }
}
