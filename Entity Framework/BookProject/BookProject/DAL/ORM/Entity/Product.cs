using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.DAL.ORM.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName  { get; set; }
        public virtual  List<Category> Categories { get; set; }
    }
}
