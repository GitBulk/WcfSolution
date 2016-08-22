using Business.Entities;
using Data.Core.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        public BlogRepository(IDbFactory factory) : base(factory)
        {
        }

        public Blog GetBlogByName(string name)
        {
            var blog = this.DbContext.Blogs.Where(b => b.Name == name).FirstOrDefault();
            return blog;
        }
    }
}
