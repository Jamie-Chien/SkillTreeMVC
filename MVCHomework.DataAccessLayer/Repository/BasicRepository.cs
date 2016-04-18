using MVCHomework.DataAccessLayer.Repository.Interface;

namespace MVCHomework.DataAccessLayer.Repository
{
    public class BasicRepository<TEntity> : IBasicRepository<TEntity>
        where TEntity : class
    {
    }
}
