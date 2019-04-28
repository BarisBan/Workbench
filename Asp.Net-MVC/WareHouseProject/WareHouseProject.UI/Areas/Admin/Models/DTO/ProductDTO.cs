using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WareHouseProject.UI.Areas.Admin.Models.DTO
{
    public class ProductDTO : BaseDTO
    {

        [Required(ErrorMessage = "Please add Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please add Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add Price")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Please add Stock")]
        public short UnitStock { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}