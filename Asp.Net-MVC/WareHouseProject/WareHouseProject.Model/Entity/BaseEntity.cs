using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseProject.Model.Enum;
using WareHouseProject.Model.Interface;

namespace WareHouseProject.Model.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }


        private DateTime _update_date=DateTime.Now;

        public DateTime UpdateDate
        {
            get { return _update_date; }
            set { _update_date = value; }
        }

        private DateTime _deleteDate = DateTime.Now;

        public DateTime DeleteDate
        {
            get { return _deleteDate; }
            set { _deleteDate = value; }
        }

        private Status _status= Status.Active;

        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }

        
    }
}
