namespace MVCHomework.DataAccessLayer
{
    public interface IUnitOfWork
    {
        T Get<T>() where T : class;
        int Commit();
    }
}
