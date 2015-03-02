using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOT.Controllers
{
    public class ContactUsController : Controller
    {
        //
        // GET: /ContactUs/

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult ContactPartner()
        {
            return View();
        }

    }
}
