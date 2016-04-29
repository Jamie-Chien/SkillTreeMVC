using Microsoft.Practices.Unity;
using MVCHomework.BusinessLogicLayer.Service;
using MVCHomework.DataAccessLayer;
using MVCHomework.DataAccessLayer.Entity;
using MVCHomework.Models;
using MVCHomework.ViewModels;
using PagedList;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace MVCHomework.Controllers
{
    public class AccountingWithAJAXHelperController : Controller
    {
        [Dependency]
        public IUnitOfWork uow { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(RecordViewModel pageData)
        {
            Thread.Sleep(800);
            if (ModelState.IsValid)
            {
                AccountBook book = new AccountBook
                {
                    Amounttt = pageData.Money,
                    Categoryyy = (int)pageData.Category,
                    Dateee = pageData.Date,
                    Remarkkk = pageData.Description
                };
                var service = uow.Get<IAccountBookService>();
                service.Add(book);
                uow.Commit();
            }

            return RedirectToAction("Records");
        }

        public ActionResult Records(int page = 1, int pageSize = 5)
        {
            var service = uow.Get<IAccountBookService>();

            var result = service.Query()
            .Select(x => new RecordViewModel
            {
                Category = (CategoryType)x.Categoryyy,
                Date = x.Dateee,
                Description = x.Remarkkk,
                Money = x.Amounttt
            }).ToPagedList(page, pageSize);

            return View(result);
        }
    }
}