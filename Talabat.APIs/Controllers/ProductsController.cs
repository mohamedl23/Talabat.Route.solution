using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.Core.Entitees;
using Talabat.Core.Repositories.Contract;
using Talabat.Core.Specification;
using Talabat.Core.Specification.Product_Specs;

namespace Talabat.APIs.Controllers
{
	
	public class ProductsController : BaseApiController
	{
		private readonly IgenaricRepository<Product> _productRepo;

		public ProductsController(IgenaricRepository<Product> ProductRepo)
        {
			_productRepo = ProductRepo;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			var spec = new ProductWithBrandAndCategorySpecification();
			var Products = await _productRepo.GetAllWithSpecAsync(spec);
			return Ok(Products);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProducts(int id)
		{
			var spec = new ProductWithBrandAndCategorySpecification(id);
			var Product = await _productRepo.GetWithSpecAsync(spec);
			if (Product is null)
			{
				return NotFound();
			}
			return Ok(Product);
		}


	}
}
