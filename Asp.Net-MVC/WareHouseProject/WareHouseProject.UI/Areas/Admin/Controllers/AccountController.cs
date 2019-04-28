using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WareHouseProject.UI.Areas.Admin.Models.DTO;

namespace WareHouseProject.UI.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {

        public ActionResult UserLogin()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminHomeIndex", "Home");
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult UserLogin(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                if (db.AppUsers.Any(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated))
                {
                    if (db.AppUsers.Any(x => x.Role == Model.Enum.Role.Admin))
                    {
                        FormsAuthentication.SetAuthCookie(model.FirstName + " " + model.LastName, true);
                        return Redirect("/Admin/Home/AdminHomeIndex");
                    }//Employye
                    else
                    {
                        ViewBag.Message = "Email or password is wrong";
                        return View();
                    }

                }
                else if (db.AppUsers.Any(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated))
                {
                    if (db.AppUsers.Any(x => x.Role == Model.Enum.Role.Employee))
                    {
                        FormsAuthentication.SetAuthCookie(model.FirstName + " " + model.LastName, true);
                        return Redirect("/Employee/Home/EmployeeHomeIndex");
                    }
                    else
                    {
                        ViewBag.Message = "Email or password is wrong";
                        return View();
                    }
                }
                else if (db.AppUsers.Any(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated))
                {
                    if (db.AppUsers.Any(x => x.Role == Model.Enum.Role.Customer))
                    {
                        FormsAuthentication.SetAuthCookie(model.FirstName + " " + model.LastName, true);
                        return Redirect("/Customer/Home/CustomerHomeIndex");
                    }
                    else
                    {
                        ViewBag.Message = "Email or password is wrong";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Email or password is wrong";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Email or password is wrong";
                return View();
            }
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Admin/Account/UserLogin");
        }
    }
}