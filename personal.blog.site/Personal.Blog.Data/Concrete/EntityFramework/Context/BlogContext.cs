using System;
using Microsoft.EntityFrameworkCore;
using Personal.Blog.Entities.Concrete;

namespace Personal.Blog.Data.Concrete.EntityFramework.Context
{
	public class BlogContext : DbContext
	{
		public DbSet<Summary> Summaries { get; set; }
        public DbSet<Interesteds> Interesteds { get; set; }
        public DbSet<SocialMediaAccounts> SocialMediaAccounts { get; set; }
        public DbSet<HomePageSlider> HomePageSliders { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<SiteIdentity> SiteIdentity { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server=localhost,1433;database=PersonalBlog;user id=sa;password=Metropolitan20;Trusted_Connection=true");
        }
    }
}

