using AutoMapper;
using Talabat.APIs.Dtos;
using Talabat.Core.Entitees;

namespace Talabat.APIs.Helpers
{
	public class MappingProfiles : Profile
	{
		private readonly IConfiguration _configuration;  
		public MappingProfiles(IConfiguration configuration) 
		{
			_configuration = configuration;

			//CreateMap<Product>
			CreateMap<Product, productToReturnDto>()
				.ForMember(d => d.Brand, o => o.MapFrom(S => S.Brand.Name))
				.ForMember(d => d.Category, o => o.MapFrom(S => S.Category.Name))
				.ForMember(P => P.PictureUrl, O => O.MapFrom<ProductPictureUrlResolver>());

		}

	}
}
