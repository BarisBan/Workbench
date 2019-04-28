using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WareHouseProject.UI.Areas.Employee.Controllers
{
    public class EmployeeHomeController : Controller
    {
        // GET: Employee/EmployeeHome
        public ActionResult EmployeeHomeIndex()
        {
            return View();
        }
    }
}