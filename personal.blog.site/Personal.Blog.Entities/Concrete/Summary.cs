using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Summary : EntityBase, IEntity
	{
		public string? Content { get; set; }
	}
}

