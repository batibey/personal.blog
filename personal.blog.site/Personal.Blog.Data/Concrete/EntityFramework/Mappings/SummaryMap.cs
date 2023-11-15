using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Entities.Concrete;

namespace Personal.Blog.Data.Concrete.EntityFramework.Mappings
{
    public class SummaryMap : IEntityTypeConfiguration<Summary>
    {
        public void Configure(EntityTypeBuilder<Summary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Summary");
            builder.HasData(new Summary
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Content = "Hi, welcome my website"
            });
        }
    }
}

