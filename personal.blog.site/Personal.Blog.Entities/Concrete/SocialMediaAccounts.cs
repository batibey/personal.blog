using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class SocialMediaAccounts : EntityBase, IEntity
    {
		public string? Account { get; set; }
		public string? AccountFA { get; set; }
        public string? AccountUrl { get; set; }
    }
}

