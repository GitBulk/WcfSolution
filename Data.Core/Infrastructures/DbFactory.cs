namespace Data.Core.Infrastructures
{
    public class DbFactory : Disposable, IDbFactory
    {
        BlogContext dbContext;
        public BlogContext Init()
        {
            return this.dbContext ?? (this.dbContext = new BlogContext());
        }

        protected override void DisposeCore()
        {
            if (this.dbContext != null)
            {
                this.dbContext.Dispose();
            }
        }
    }
}
