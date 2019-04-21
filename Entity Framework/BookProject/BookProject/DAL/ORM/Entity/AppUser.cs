using BookProject.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.DAL.ORM.Entity
{
    public class AppUser : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _fullName;
        [NotMapped]
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }
                else
                {
                    return FirstName + " " + LastName;
                }
            }

            set {
                _fullName = value;
            }
        }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender  Gender { get; set; }
        public Role Role { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
