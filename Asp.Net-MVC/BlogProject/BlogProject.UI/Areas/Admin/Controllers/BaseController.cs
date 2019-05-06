using BlogProject.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.UI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected EntityService service;

        public BaseController()
        {
            service = new EntityService();
        }
    }
}