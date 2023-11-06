using System;
using Personal.Blog.Entities.Concrete;
using Personal.Blog.Shared.Data.Abstract;

namespace Personal.Blog.Data.Abstract
{
	public interface IArticalRepository : IEntityRepository<Articles>
    {
	}
}

