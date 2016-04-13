using MVCHomework.Infra;
using MVCHomework.Models;
using MVCHomework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCHomework.Controllers
{
    public class HomeController : Controller
    {
        private static List<RecordViewModel> records = null;

        static HomeController()
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
            return View();
        }

        public ActionResult Add(RecordViewModel pageData)
        {
            pageData.No = records.Max(x => x.No) + 1;
            records.Add(pageData);
            return Redirect("Index");
        }

        [ChildActionOnly]
        public ActionResult Records()
        {
            return View("_Records", records);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}