using System.Linq;
using MVCHomework.DataAccessLayer.Entity;

namespace MVCHomework.BusinessLogicLayer.Service
{
    public interface IAccountBookService
    {
        IQueryable<AccountBook> Query();
    }
}