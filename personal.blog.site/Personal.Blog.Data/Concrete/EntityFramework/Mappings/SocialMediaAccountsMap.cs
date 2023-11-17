using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace Personal.Blog.Data.Concrete.EntityFramework.Mappings
{
    public class SocialMediaAccountsMap : IEntityTypeConfiguration<SocialMediaAccounts>
    {
        public void Configure(EntityTypeBuilder<SocialMediaAccounts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Account).IsRequired();
            builder.Property(x => x.Account).HasMaxLength(100);
            builder.Property(x => x.AccountFA).IsRequired();
            builder.Property(x => x.AccountFA).HasMaxLength(150);
            builder.Property(x => x.AccountUrl).IsRequired();
            builder.Property(x => x.AccountUrl).HasMaxLength(150);
            builder.ToTable("SocialMediaAccounts");
            builder.HasData(new SocialMediaAccounts
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Account = "LinkedIn",
                AccountFA = "<i class=\"fa fa-linkedin\" aria-hidden=\"true\"></i>",
                AccountUrl = "https://www.linkedin.com/in/mustafa-bat%C4%B1-738a00188/"
            });
        }
    }
}

