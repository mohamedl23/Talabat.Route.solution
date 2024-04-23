using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.Core.Entitees;

namespace Talabat.Repository.Data
{
	public static class StoreContextSeed
	{
		public static async Task seedAsync(StoreContext _dbContext)
		{
			if (_dbContext.productBrands.Count()== 0)
			{
				var BrandData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/brands.json");
				var Brands = JsonSerializer.Deserialize<List<ProductBrand>>(BrandData);
				if(Brands is not null && Brands.Count() > 0 )
				{
					foreach( var Brand in Brands )
					{
						await _dbContext.Set<ProductBrand>().AddAsync( Brand );

					}
					await _dbContext.SaveChangesAsync();
				}
			}
			if (_dbContext.productCategories.Count() == 0)
			{
				var CategorieData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/categories.json");
				var Categories = JsonSerializer.Deserialize<List<ProductCategory>>(CategorieData);
				if (Categories is not null && Categories.Count() > 0)
				{
					foreach (var Categorie in Categories)
					{
						await _dbContext.Set<ProductCategory>().AddAsync(Categorie);

					}
					await _dbContext.SaveChangesAsync();
				}
			}
			if (_dbContext.products.Count() == 0)
			{
				var productsData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/products.json");
				var products = JsonSerializer.Deserialize<List<Product>>(productsData);
				if (products is not null && products.Count() > 0)
				{
					foreach (var product in products)
					{
						await _dbContext.Set<Product>().AddAsync(product);

					}
					await _dbContext.SaveChangesAsync();
				}
			}
		}
	}
}
