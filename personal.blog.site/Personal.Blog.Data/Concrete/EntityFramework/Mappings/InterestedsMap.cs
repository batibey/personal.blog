using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace Personal.Blog.Data.Concrete.EntityFramework.Mappings
{
    public class InterestedsMap : IEntityTypeConfiguration<Interesteds>
    {
        public void Configure(EntityTypeBuilder<Interesteds> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(300);
            builder.ToTable("Interesteds");
            builder.HasData(new Interesteds
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Text = "OOP technologies, .net, docker and more than..."
            });
        }
    }
}

