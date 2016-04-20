using MVCHomework.DataAccessLayer.Repository.Interface;
using System.Data.Entity;

namespace MVCHomework.DataAccessLayer.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public DbContext db;

        public Repository(IUnitOfWork uow)
        {
            db = uow.Get<DbContext>();
        }

        public DbSet<TEntity> Set()
        {
            return db.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Modify(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(TEntity entity)
        {
            Set().Remove(entity);
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
