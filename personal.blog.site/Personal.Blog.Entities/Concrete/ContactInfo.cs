using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class ContactInfo : EntityBase, IEntity
    {
		public string? PhoneNumber { get; set; }
		public string? Email { get; set; }
		public string? ShortAddress { get; set; }
		public string? Address { get; set; }
	}
}

