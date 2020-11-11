﻿using System.Collections.Generic;
using MyShop.Models;

namespace MyShop.ViewModels.Product
{
    public class EditProductViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Slug { get; set; }
        
        public string Summary { get; set; }
        
        public string Description { get; set; }
        
        public string ImageFile { get; set; }
        
        public decimal? UnitPrice { get; set; }
        
        public int? UnitsInStock { get; set; }

        public int CategoryId { get; set; }
        
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}