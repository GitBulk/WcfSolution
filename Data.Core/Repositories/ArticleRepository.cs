using Business.Entities;
using Data.Core.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(IDbFactory factory) : base(factory)
        {
        }

        public Article GetArticleByTitle(string articleTitle)
        {
            var article = this.DbContext.Articles.Where(a => a.Title == articleTitle).FirstOrDefault();
            return article;
        }
    }
}
