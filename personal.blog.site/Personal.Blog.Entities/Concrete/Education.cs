using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Education : EntityBase, IEntity
    {
		public string? Title { get; set; }
		public string? School { get; set; }
		public string? Duration { get; set; }
		public string? Average { get; set; }
		public string? Description { get; set; }
	}
}

