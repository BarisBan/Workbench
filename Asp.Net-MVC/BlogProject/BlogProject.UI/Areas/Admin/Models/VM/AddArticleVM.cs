using BlogProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.UI.Areas.Admin.Models.VM
{
    public class AddArticleVM : BaseVM
    {
        public AddArticleVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
        }

        public List<AppUser> AppUsers { get; set; }
        public List<Category> Categories { get; set; }
    }
}