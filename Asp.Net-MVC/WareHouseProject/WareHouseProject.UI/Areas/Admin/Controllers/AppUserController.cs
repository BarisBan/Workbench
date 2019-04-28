using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WareHouseProject.Model.Entity;
using WareHouseProject.UI.Areas.Admin.Models.DTO;

namespace WareHouseProject.UI.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        // GET: Admin/AppUser
        public ActionResult AddUser()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserDTO model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.Password = model.Password;
                user.Role = model.Role;
                user.Gender = model.Gender;
                db.AppUsers.Add(user);
                ViewBag.ProcessCondition = 1;
                db.SaveChanges();

                return Redirect("/Admin/AppUser/UserList");
            }
            else
            {
                ViewBag.ProcessCondition = 0;
                return View();
            }
        }

        public ActionResult UserList()
        {
            List<UserDTO> model = db.AppUsers.Where(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated).Select(x => new UserDTO
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                UserName = x.UserName,
                Gender = x.Gender,
                Role = x.Role,

            }).ToList();

            return View(model);
        }

        public ActionResult UpdateUser(int id)
        {
            if (ModelState.IsValid)
            {
                AppUser user = db.AppUsers.FirstOrDefault(x => x.ID == id);
                UserDTO model = new UserDTO();
                model.ID = user.ID;
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                model.Email = user.Email;
                model.UserName = user.UserName;
                model.Password = user.Password;
                model.Gender = user.Gender;
                model.Role = user.Role;

                return View(model);
            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult UpdateUser(UserDTO model)
        {
            if(ModelState.IsValid)
            {
                AppUser user = db.AppUsers.FirstOrDefault(x => x.ID == model.ID);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.Password = model.Password;
                user.Gender = model.Gender;
                user.Role = model.Role;
                user.Status = Model.Enum.Status.Updated;
                user.UpdateDate = DateTime.Now;
                db.SaveChanges();
                return View("Admin/AppUser/UserList");
            }
            else
            {
                return View();
            }
        }
        public ActionResult DeleteUser(int id)
        {

            if (ModelState.IsValid)
            {
                AppUser user = db.AppUsers.FirstOrDefault(x => x.ID == id);
                user.Status = WareHouseProject.Model.Enum.Status.Deleted;
                user.DeleteDate = DateTime.Now;
                db.SaveChanges();
                return Redirect("/Admin/AppUser/UserList");
            }
            return Redirect("/Admin/AppUser/UserList");
        }

    }
}