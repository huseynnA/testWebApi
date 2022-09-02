using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class User
    {
        [Key]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        [NotNull]
        public string Password{ get; set; }

        public List<Contact> Contacts { get; set; }       
        public List<Role> Roles { get; set; }       
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
