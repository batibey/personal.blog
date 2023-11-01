using System;
namespace Personal.Blog.Shared.Entities.Abstract
{
	public abstract class EntityBase
	{
		public virtual int Id { get; set; }
		public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
		public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
		public virtual bool IsActive { get; set; } = false;
		public virtual bool IsDelete { get; set; } = false;
		public virtual string? CreatedByName { get; set; } = "Admin";
		public virtual string? ModifiedByName { get; set; } = "Admin";
	}
}

