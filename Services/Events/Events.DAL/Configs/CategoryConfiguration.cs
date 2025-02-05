﻿using Events.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Events.DAL.Seeding;

namespace Events.DAL.Configs
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

            builder.Property(c => c.CreatedAt)
                   .IsRequired();

            builder.Property(c => c.UpdatedAt);


        }
    }
}
