using System;
using Microsoft.EntityFrameworkCore;
using Personal.Blog.Data.Abstract;
using Personal.Blog.Entities.Concrete;
using Personal.Blog.Shared.Data.Concrete.EntityFramework;

namespace Personal.Blog.Data.Concrete.EntityFramework.Repositories
{
    public class EfMessagesRepository : EfEntityRepositoryBase<Messages>, IMessagesRepository
    {
        public EfMessagesRepository(DbContext context) : base(context)
        {
        }
    }
}

