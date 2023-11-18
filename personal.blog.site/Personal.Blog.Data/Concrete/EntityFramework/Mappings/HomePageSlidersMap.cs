using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace Personal.Blog.Data.Concrete.EntityFramework.Mappings
{
    public class HomePageSlidersMap : IEntityTypeConfiguration<HomePageSlider>
    {
        public void Configure(EntityTypeBuilder<HomePageSlider> builder)
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
            builder.Property(x => x.ShortContent).IsRequired();
            builder.Property(x => x.ShortContent).HasMaxLength(500);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("HomePageSlider");
            builder.HasData(new HomePageSlider
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Title = ".NET Developer",
                ShortContent = "İsmim Mustafa Batı, 24 yaşındayım ve backend developer olarak Antalya Teknokent de bulunan yazılım firmasında çalışıyorum.",
                Content = "Selamlar, 2022 yılının Ocak ayında başlamış olduğum SAN Tourism Software Group firmasında Tourvisio developer team içerisinde .Net developer olarak yer almaktayım." +
                "Aynı zamanda Angular ile yazılan Önyüz projesinde de yer almaktayım. Sorumlusu olduğum, şirket içi ve kısmi olarak customer tarafına da açtığımız bir ERP projesi var." +
                "Bu ERP projesinin de Development sürecini ve aynı zamanda da destek sürecini yönetiyorum. Database olarak MSSQL kullanıyorum. ORM olarak EntityFramework kullanıyorum."
            });
        }
    }
}

