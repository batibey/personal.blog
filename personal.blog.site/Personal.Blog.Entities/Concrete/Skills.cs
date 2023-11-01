using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Skills : EntityBase, IEntity
    {
		public string? Title { get; set; }
		public int PercentageValue { get; set; }
	}
}

