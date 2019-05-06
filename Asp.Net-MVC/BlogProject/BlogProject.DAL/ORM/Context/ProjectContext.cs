using BlogProject.DAL.ORM.Entity;
using BlogProject.DAL.ORM.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-SC03J1S\SQLEXPRESS;Database=BlogDB;uid=sa;pwd=bjk.1403";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new LikeMap());
            modelBuilder.Configurations.Add(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
