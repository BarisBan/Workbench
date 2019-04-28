using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseProject.Model.Entity
{
    public  class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }

        public short UnitStock { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

       
    }
}
