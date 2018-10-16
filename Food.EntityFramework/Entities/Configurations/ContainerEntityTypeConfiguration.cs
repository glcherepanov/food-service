﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food.EntityFramework.Entities.Configurations
{
    class ContainerConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure( EntityTypeBuilder<Container> builder )
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name);
            builder.Property(c => c.Price);
        }
    }
}
