using AutoMapper;
using Talabat.APIs.Dtos;
using Talabat.Core.Entitees;

namespace Talabat.APIs.Helpers
{
	public class ProductPictureUrlResolver : IValueResolver<Product , productToReturnDto ,string>
	{
		private readonly IConfiguration _configuration;
		private readonly IMapper _mapper;

		public ProductPictureUrlResolver(IConfiguration configuration ,IMapper mapper ) 
		{
			_configuration = configuration;
			_mapper = mapper;
		}

		public string Resolve(Product source, productToReturnDto destination, string destMember, ResolutionContext context)
		{
			if (!string.IsNullOrEmpty(source.PictureUrl))
			{
				return $"{_configuration["ApiBaseUrl"]}{source.PictureUrl}";
			}
			return string.Empty;
		}
	}
}
