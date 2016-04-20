using MVCHomework.DataAccessLayer.Entity;
using System.Linq;

namespace MVCHomework.BusinessLogicLayer.Service
{
    public interface IAccountBookService
    {
        IQueryable<AccountBook> Query();

        void Add(AccountBook model);
    }
}