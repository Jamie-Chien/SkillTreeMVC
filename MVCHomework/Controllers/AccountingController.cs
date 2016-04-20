using Microsoft.Practices.Unity;
using MVCHomework.BusinessLogicLayer.Service;
using MVCHomework.DataAccessLayer;
using MVCHomework.DataAccessLayer.Entity;
using MVCHomework.Infra.Extension;
using MVCHomework.Models;
using MVCHomework.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCHomework.Controllers
{
    public class AccountingController : Controller
    {
        [Dependency]
        public IUnitOfWork uow { get; set; }

        public ActionResult Index()
        {
            //List<SelectListItem> itemList = new List<SelectListItem>();

            //itemList.Add(new SelectListItem
            //{
            //    Text = "請選擇",
            //    Value = string.Empty
            //});

            //foreach (CategoryType category in Enum.GetValues(typeof(CategoryType)))
            //{
            //    itemList.Add(new SelectListItem
            //    {
            //        Text = category.GetEnumDisplayName(),
            //        Value = category.ToString()
            //    });
            //}
            //return View(itemList);
            return View();
        }

        [HttpPost]
        public ActionResult Index(RecordViewModel pageData)
        {
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

                int c = uow.Commit();
            }

            return View();
        }

        [ChildActionOnly]
        public ActionResult CategoryDropDownList()
        {
            List<SelectListItem> itemList = new List<SelectListItem>();

            itemList.Add(new SelectListItem
            {
                Text = "請選擇",
                Value = string.Empty
            });

            foreach (CategoryType category in Enum.GetValues(typeof(CategoryType)))
            {
                itemList.Add(new SelectListItem
                {
                    Text = category.GetEnumDisplayName(),
                    Value = category.ToString()
                });
            }

            return View(itemList);
        }

        [ChildActionOnly]
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