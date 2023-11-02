using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Categories : EntityBase, IEntity
    {
		public string? Name { get; set; }
		public string? CategoryFA { get; set; }
		public string? Description { get; set; }
		public ICollection<Articles>? Articles { get; set; }
	}
}

