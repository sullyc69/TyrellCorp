﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Factory
    {
        [Key]
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
