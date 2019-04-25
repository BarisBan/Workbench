using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WareHouseProject.DAT.Context;

namespace WareHouseProject.UI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public ProjectContext db;
        // GET: Admin/Base
        public BaseController()
        {
            db = new ProjectContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}