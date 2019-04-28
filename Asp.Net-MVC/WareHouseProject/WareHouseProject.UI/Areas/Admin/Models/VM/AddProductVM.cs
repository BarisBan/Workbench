using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WareHouseProject.Model.Entity;
using WareHouseProject.UI.Areas.Admin.Models.DTO;

namespace WareHouseProject.UI.Areas.Admin.Models.VM
{
    public class AddProductVM
    {
        public AddProductVM()
        {
            Categories = new List<Category>();
            Product = new ProductDTO();
        }

        public List<Category> Categories { get; set; }
        public ProductDTO Product { get; set; }

    }
}