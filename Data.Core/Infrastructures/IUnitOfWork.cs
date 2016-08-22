namespace Data.Core.Infrastructures
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
