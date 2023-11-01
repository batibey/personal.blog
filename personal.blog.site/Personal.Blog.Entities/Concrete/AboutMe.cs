using System;
using Personal.Blog.Shared.Entities.Abstract;

namespace Personal.Blog.Entities.Concrete
{
	public class AboutMe : EntityBase, IEntity
    {
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? ImagePath { get; set; }
		public string? MyJob { get; set; }
		public string? MyJobFA { get; set; }
		public DateTime BirthDate { get; set; }
		public string? MyCVPath { get; set; }
	}
}

