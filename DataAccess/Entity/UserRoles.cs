﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class UserRoles
    {
        [Key]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int UserId { get; set; }
        public User User{ get; set; }
    }
}
