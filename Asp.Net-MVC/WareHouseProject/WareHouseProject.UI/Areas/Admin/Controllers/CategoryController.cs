using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WareHouseProject.Model.Entity;
using WareHouseProject.UI.Areas.Admin.Models.DTO;

namespace WareHouseProject.UI.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        public ActionResult CategoryList()
        {
            List<CategoryDTO> model = db.Categories.Where(x => x.Status == WareHouseProject.Model.Enum.Status.Active || x.Status == WareHouseProject.Model.Enum.Status.Updated).Select(x=> new CategoryDTO
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.CategoryDescription
            }
            ).ToList();


            return View(model);
        }

        public ActionResult AddCategory()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryDTO model)
        {
            if(ModelState.IsValid)
            {
                Category category = new Category();
                category.CategoryName = model.CategoryName;
                category.CategoryDescription = model.Description;                
                
                db.Categories.Add(category);
                ViewBag.ProcessCondition = 1 ;
                db.SaveChanges();


                return View();
            }
            else
            {
                ViewBag.ProcessCondition = 0 ;
                return View();
            }
        }

        public ActionResult UpdateCategory(int id)
        {
            if(ModelState.IsValid)
            {
                Category category = db.Categories.FirstOrDefault(x => x.ID == id);
                CategoryDTO model = new CategoryDTO();
                model.ID = category.ID;
                model.CategoryName = category.CategoryName;
                model.Description = category.CategoryDescription;

                return View(model);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult UpdateCategory(CategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                Category category = db.Categories.FirstOrDefault(x => x.ID == model.ID);

                category.CategoryName = model.CategoryName;
                category.CategoryDescription = model.Description;
                category.Status = Model.Enum.Status.Updated;
                category.UpdateDate = DateTime.Now;

                db.SaveChanges();

                return Redirect("/Admin/Category/CategoryList");
            }
            else
            {
                return View();
            }
        }


        public ActionResult DeleteCategory(int id)
        {
            if (ModelState.IsValid)
            {
                Category category = db.Categories.FirstOrDefault(x => x.ID == id);
                category.Status = WareHouseProject.Model.Enum.Status.Deleted;
                category.DeleteDate = DateTime.Now;
                db.SaveChanges();
                return Redirect("/Admin/Category/CategoryList");
            }
            return Redirect("/Admin/Category/CategoryList");
        }

    }
}