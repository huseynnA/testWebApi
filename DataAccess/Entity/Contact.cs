﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Contact
    {
        [Required]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email{ get; set; }
        [Key]
        public int UserId{ get; set; }
        public User User{ get; set; }
    }
}
