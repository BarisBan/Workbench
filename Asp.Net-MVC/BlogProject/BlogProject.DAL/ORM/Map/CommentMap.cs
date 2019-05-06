using BlogProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.ORM.Map
{
    public class CommentMap : CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.CommentContent).IsOptional();

            HasKey(x => new { x.AppUserID, x.ArticleID });
        }
    }
}
