using MVCHomework.Infra;
using MVCHomework.Models;
using MVCHomework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCHomework.Controllers
{
    public class AccountingController : Controller
    {
        private static List<RecordViewModel> records = null;

        static AccountingController()
        {
            records = new List<RecordViewModel>();
            for (int i = 0; i < 5; ++i)
            {
                records.Add(new RecordViewModel
                {
                    No = i,
                    Category = CategoryType.Pay,
                    Date = DateTime.Now,
                    Money = 1000
                });
            }
        }

        public ActionResult Index()
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

        [HttpPost]
        public ActionResult Index(RecordViewModel pageData)
        {
            pageData.No = records.Max(x => x.No) + 1;
            records.Add(pageData);
            return Redirect("Index");
        }

        [ChildActionOnly]
        public ActionResult Records()
        {
            return View("Records", records);
        }
    }
}