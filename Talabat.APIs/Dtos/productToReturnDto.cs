﻿using Talabat.Core.Entitees;

namespace Talabat.APIs.Dtos
{
	public class productToReturnDto : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string PictureUrl { get; set; } 

		public int CategoryId { get; set; }
		public string Category { get; set; }
		public int BrandId { get; set; }
		public string Brand { get; set; }
	}
}
