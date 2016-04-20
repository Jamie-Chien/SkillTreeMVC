using System.Data.Entity;

namespace MVCHomework.DataAccessLayer.Repository.Interface
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        DbSet<TEntity> Set();

        void Attach(TEntity entity);

        void Modify(TEntity entity);

        void Remove(TEntity entity);
    }
}
