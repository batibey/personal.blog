using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Interesteds : EntityBase, IEntity
    {
        public string? Text { get; set; }
    }
}

