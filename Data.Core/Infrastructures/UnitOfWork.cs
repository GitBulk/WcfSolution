using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private BlogContext blogContext;
        public UnitOfWork(IDbFactory factory)
        {
            dbFactory = factory;
        }

        public BlogContext DbContext
        {
            get
            {
                return this.blogContext ?? (this.blogContext = this.dbFactory.Init());
            }
        }

        public void Commit()
        {
            this.blogContext.Commit();
        }
    }
}
