using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace Personal.Blog.Data.Concrete.EntityFramework.Mappings
{
    public class ExperiencesMap : IEntityTypeConfiguration<Experiences>
    {
        public void Configure(EntityTypeBuilder<Experiences> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.WorkPlace).IsRequired();
            builder.Property(x => x.WorkPlace).HasMaxLength(200);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.ToTable("Experiences");
            builder.HasData(new Experiences
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Title = ".Net Developer",
                WorkPlace = "SAN Tourism Software Group",
                Duration = "Ocak 2022 - Devam ediyor",
                Description = "Backend developer - .Net Developer olarak Antalya Teknokent de bulunan SAN Tourism Software Group firmasında çalışıyorum."
            });
        }
    }
}

