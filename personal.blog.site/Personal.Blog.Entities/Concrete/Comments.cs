using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Comments : EntityBase, IEntity
    {
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Text { get; set; }
		public int ArticleId { get; set; }
		public Articles? Articles { get; set; }
	}
}

