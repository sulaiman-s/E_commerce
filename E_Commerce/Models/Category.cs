﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public string Image { get; set; }

    }
}