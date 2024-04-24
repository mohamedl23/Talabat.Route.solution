using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entitees;
using Talabat.Core.Specification;

namespace Talabat.Core.Repositories.Contract
{
	public interface IgenaricRepository<T> where T : BaseEntity
	{
		Task<T?> GetAsync(int id);
		Task<IEnumerable<T>> GetAllAsync();

		Task<IEnumerable<T>> GetAllWithSpecAsync(ISpecifiction<T> spec);
		Task<T?> GetWithSpecAsync(ISpecifiction<T> spec); 


	}
}
