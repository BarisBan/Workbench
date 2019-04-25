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
                Description = x.Description
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
                category.Description = model.Description;
                category.Status = Model.Enum.Status.Active;
                category.AddDate = DateTime.Now;
                db.Categories.Add(category);
                db.SaveChanges();

                
                return Redirect("CategoryList");
            }
            else
            {
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
                model.Description = category.Description;

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
                category.Description = model.Description;
                category.Status = Model.Enum.Status.Updated;
                category.UpdateDate = DateTime.Now;                

                db.SaveChanges();

                return Redirect("CategoryList");
            }
            else
            {
                return View();
            }
        }

        public ActionResult DeleteCategory(int id)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.Status = Model.Enum.Status.Deleted;
            category.DeleteDate = DateTime.Now;

            db.SaveChanges();

            return Redirect("CategoryList");

        }

    }
}