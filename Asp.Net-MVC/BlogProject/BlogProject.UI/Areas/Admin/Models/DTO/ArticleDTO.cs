using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.UI.Areas.Admin.Models.DTO
{
    public class ArticleDTO : BaseDTO
    {
        public string Header { get; set; }
        public string Content { get; set; }

        public Guid CategoryID { get; set; }
        public Guid AppUserID { get; set; }

    }
}