﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Description { get; set; }
       
    }
}
