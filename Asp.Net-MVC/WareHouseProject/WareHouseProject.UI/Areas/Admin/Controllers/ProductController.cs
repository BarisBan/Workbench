
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WareHouseProject.Model.Entity;
using WareHouseProject.UI.Areas.Admin.Models.DTO;
using WareHouseProject.UI.Areas.Admin.Models.VM;

namespace WareHouseProject.UI.Areas.Admin.Controllers
{


    public class ProductController : BaseController
    {
        // GET: Admin/Product
        public ActionResult AddProduct()
        {
            List<Category> model = db.Categories.Where(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated).OrderBy(x => x.AddDate).ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddProduct(ProductDTO model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.UnitPrice = model.UnitPrice;
                product.UnitStock = model.UnitStock;
                product.CategoryID = model.CategoryID;
                db.Products.Add(product);
                ViewBag.ProcessCondition = 1;

                db.SaveChanges();
                return Redirect("/Admin/Product/ProductList");
            }
            else
            {
                ViewBag.ProcessCondition = 0;
                return View();
            }
        }

        public ActionResult ProductList()
        {
            List<ProductDTO> model = db.Products.Where(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated).Select(x => new ProductDTO
            {
                ID = x.ID,
                ProductName = x.ProductName,
                Description = x.Description,
                UnitPrice = x.UnitPrice,
                UnitStock = x.UnitStock,
                CategoryID = x.CategoryID,
                CategoryName = x.Category.CategoryName
            }).ToList();

            return View(model);
        }

        public ActionResult UpdateProduct(int id)
        {

            AddProductVM model= new AddProductVM();
            Product product = db.Products.FirstOrDefault(x => x.ID == id);
            model.Product.ID = product.ID;
            model.Product.ProductName = product.ProductName;
            model.Product.Description = product.Description;
            model.Product.UnitPrice = product.UnitPrice;
            model.Product.UnitStock = product.UnitStock;

            List<Category> categorymodel = db.Categories.Where(x => x.Status == Model.Enum.Status.Active || x.Status == Model.Enum.Status.Updated).ToList();

            model.Categories = categorymodel;

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateProduct(ProductDTO model)
        {
            if(ModelState.IsValid)
            {
                Product product = db.Products.FirstOrDefault(x => x.ID == model.ID);
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.UnitPrice = model.UnitPrice;
                product.UnitStock = model.UnitStock;
                product.CategoryID = model.CategoryID;
                product.Status = Model.Enum.Status.Updated;
                product.UpdateDate = DateTime.Now;
                db.SaveChanges();
                return Redirect("/Admin/Product/ProductList");
            }
            else
            {
                return View();
            }
        }

        public ActionResult DeleteProduct(int id)
        {
            if (ModelState.IsValid)
            {
                Product product = db.Products.FirstOrDefault(x => x.ID == id);
                product.Status = WareHouseProject.Model.Enum.Status.Deleted;
                product.DeleteDate = DateTime.Now;
                db.SaveChanges();
                return Redirect("/Admin/Product/ProductList");
            }
            return Redirect("/Admin/Product/ProductList");
        }
    }
}