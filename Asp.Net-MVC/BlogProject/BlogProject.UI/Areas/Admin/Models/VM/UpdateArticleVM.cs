using BlogProject.DAL.ORM.Entity;
using BlogProject.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.UI.Areas.Admin.Models.VM
{
    public class UpdateArticleVM
    {
        public UpdateArticleVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
            Article = new ArticleDTO();
        }

        public List<Category> Categories { get; set; }
        public List<AppUser> AppUsers { get; set; }
        public ArticleDTO Article { get; set; }
    }
}