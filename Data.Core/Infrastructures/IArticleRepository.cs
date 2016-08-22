using Business.Entities;

namespace Data.Core.Infrastructures
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleByTitle(string articleTitle);
    }
}
