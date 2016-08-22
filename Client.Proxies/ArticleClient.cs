using Client.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.Entities;

namespace Client.Proxies
{
    public class ArticleClient : ClientBaseProxy<IArticleService>, IArticleService
    {
        public void Add(Article article)
        {
            Channel.Add(article);
        }

        public void Delete(Article article)
        {
            Channel.Delete(article);
        }

        public Article[] GetAll()
        {
            return Channel.GetAll();
        }

        public Article GetById(int id)
        {
            return Channel.GetById(id);
        }

        public void Update(Article article)
        {
            Channel.Update(article);
        }
    }
}
