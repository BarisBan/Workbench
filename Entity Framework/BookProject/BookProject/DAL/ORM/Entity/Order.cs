using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.DAL.ORM.Entity
{
    public class Order : BaseEntity
    {
        public DateTime _orderDate = DateTime.Now;
        public DateTime OrderDate { get { return _orderDate; } set { _orderDate = value; } }
        public int Quantity { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
    }
}
