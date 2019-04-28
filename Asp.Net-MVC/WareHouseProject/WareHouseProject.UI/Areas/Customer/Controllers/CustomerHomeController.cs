using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WareHouseProject.UI.Areas.Customer.Controllers
{
    public class CustomerHomeController : Controller
    {
        // GET: Customer/CustomerHome
        public ActionResult CustomerHomeIndex()
        {
            return View();
        }
    }
}