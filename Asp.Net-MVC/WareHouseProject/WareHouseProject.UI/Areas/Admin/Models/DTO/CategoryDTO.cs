using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WareHouseProject.UI.Areas.Admin.Models.DTO
{
    public class CategoryDTO : BaseDTO
    {
        [Required(ErrorMessage = "Please add Category Name")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Please add Description")]
        public string Description { get; set; }
    }
}