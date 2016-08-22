using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Infrastructures
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private BlogContext dbContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected BlogContext DbContext
        {
            get
            {
                return this.dbContext ?? (this.dbContext = DbFactory.Init());
            }
        }

        public BaseRepository(IDbFactory factory)
        {
            this.DbFactory = factory;
            this.dbSet = this.DbContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            this.dbSet.Add(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = this.dbSet.Where(where).AsEnumerable();
            foreach (T obj in objects)
            {
                this.dbSet.Remove(obj);
            }
        }

        public void Delete(T entity)
        {
            this.dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return this.dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet.ToList();
        }

        public T GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return this.dbSet.Where(where).ToList();
        }

        public void Update(T entity)
        {
            this.dbSet.Attach(entity);
            this.DbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
