﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Product
    {
        
        public int Id { get; set; }

     
        public string Name { get; set; }

        public string Description { get; set; }

    
        public decimal Price { get; set; }

       
        public string ImageUrl { get; set; }
    }
}
