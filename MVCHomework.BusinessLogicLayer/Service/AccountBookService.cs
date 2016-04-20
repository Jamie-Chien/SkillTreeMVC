using MVCHomework.DataAccessLayer;
using MVCHomework.DataAccessLayer.Entity;
using MVCHomework.DataAccessLayer.Repository.Interface;
using System;
using System.Linq;

namespace MVCHomework.BusinessLogicLayer.Service
{
    public class AccountBookService : IAccountBookService
    {
        private IUnitOfWork uow = null;

        public AccountBookService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public void Add(AccountBook model)
        {
            var repo = uow.Get<IRepository<AccountBook>>();
            model.Id = Guid.NewGuid();
            repo.Create(model);
        }

        public IQueryable<AccountBook> Query()
        {
            var repo = uow.Get<IRepository<AccountBook>>();

            return repo.Set().OrderBy(x => x.Dateee);
        }
    }
}
