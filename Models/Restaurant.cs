﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhidhaLagche.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant name: ")]
        [Required, MaxLength(80)]
        public string Name { get; set; }

        [Display(Name="Cuisine name: ")]
        public CuisineType Cuisine { get; set; }
    }
}
