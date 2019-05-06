using BlogProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.ORM.Map
{
    public class CategoryMap : CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Category");
            Property(x => x.CategoryName).IsOptional();
            Property(x => x.Description).IsOptional();

        }

    }
}
