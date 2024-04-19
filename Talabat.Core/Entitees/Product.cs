﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entitees
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public string Discription { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; } 
        public ProductCategory Category { get; set; }
        public int ProductBrandId { get; set; }
        public ProductBrand Brand { get; set; }

    }

}