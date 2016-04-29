using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomework.Controllers
{
    public class VerifyController : Controller
    {
        [HttpGet]
        public ActionResult CurrentDate(DateTime date)
        {
            bool isValid = date <= DateTime.Now;
            return Json(isValid, JsonRequestBehavior.AllowGet);
        }
    }
}