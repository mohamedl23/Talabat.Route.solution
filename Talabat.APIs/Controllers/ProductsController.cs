using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.Core.Entitees;
using Talabat.Core.Repositories.Contract;

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
			var Products = await _productRepo.GetAllAsync();
			return Ok(Products);
		}
		 
    }
}
