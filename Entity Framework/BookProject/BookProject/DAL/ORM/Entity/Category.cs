using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.DAL.ORM.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Distription { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
