using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Messages : EntityBase, IEntity
    {
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public string? Subject { get; set; }
		public string? Text { get; set; }
	}
}

