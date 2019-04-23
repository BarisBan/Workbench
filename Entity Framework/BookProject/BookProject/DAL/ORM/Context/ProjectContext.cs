using BookProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.DAL.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-SC03J1S\SQLEXPRESS;Database=Book;UID=sa;PWD=bjk.1403;";
            //Database.Connection.ConnectionString = "Server=.;Database=Book;UID=sa;PWD=1234;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }

    
}
