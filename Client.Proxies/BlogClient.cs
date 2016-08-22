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
    public class BlogClient : ClientBaseProxy<IBlogService>, IBlogService
    {
        public void Add(Blog blog)
        {
            Channel.Add(blog);
        }

        public void Delete(Blog blog)
        {
            Channel.Delete(blog);
        }

        public Blog[] GetAll()
        {
            return Channel.GetAll();
        }

        public Blog GetById(int id)
        {
            return Channel.GetById(id);
        }

        public void Update(Blog blog)
        {
            Channel.Update(blog);
        }
    }
}
