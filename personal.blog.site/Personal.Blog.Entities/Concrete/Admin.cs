using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class Admin : EntityBase, IEntity
    {
		public string? Email { get; set; }
		public string? Password { get; set; }
		public string? SecurityQuestion { get; set; }
		public string? SecurityQuestionAnswer { get; set; }
	}
}

