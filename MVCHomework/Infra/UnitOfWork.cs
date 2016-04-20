using MVCHomework.DataAccessLayer;
using System.Data.Entity;
using System.Web.Mvc;

namespace MVCHomework.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext db = null;

        public UnitOfWork(DbContext db)
        {
            this.db = db;
        }

        public T Get<T>()
            where T : class
        {
            return DependencyResolver.Current.GetService<T>();
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
