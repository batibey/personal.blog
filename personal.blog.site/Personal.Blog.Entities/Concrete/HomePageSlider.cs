using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class HomePageSlider : EntityBase, IEntity
	{
		public string? Title { get; set; }
		public string? ShortContent { get; set; }
		public string? Content { get; set; }
	}
}

