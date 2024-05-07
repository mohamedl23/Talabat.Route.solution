using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.APIs.Dtos;
using Talabat.APIs.Errors;
using Talabat.Core.Entitees;
using Talabat.Core.Repositories.Contract;
using Talabat.Core.Specification;
using Talabat.Core.Specification.Product_Specs;

namespace Talabat.APIs.Controllers
{
	
	public class ProductsController : BaseApiController
	{
		private readonly IgenaricRepository<Product> _productRepo;
		private readonly IMapper _mapper;

		public ProductsController(IgenaricRepository<Product> ProductRepo , IMapper mapper)
        {
			_productRepo = ProductRepo;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			var spec = new ProductWithBrandAndCategorySpecification();
			var Products = await _productRepo.GetAllWithSpecAsync(spec);
			return Ok(_mapper.Map<IEnumerable<Product>, IEnumerable<productToReturnDto>>(Products));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProducts(int id)
		{
			var spec = new ProductWithBrandAndCategorySpecification(id);
			var Product = await _productRepo.GetWithSpecAsync(spec);
			if (Product is null)
			{
				return NotFound(new ApiResponse(404));
			}
			return Ok(_mapper.Map<Product, productToReturnDto>(Product));
		}

		
		

	}
}
