using Business.Entities;

namespace Data.Core.Infrastructures
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Blog GetBlogByName(string name);
    }
}
