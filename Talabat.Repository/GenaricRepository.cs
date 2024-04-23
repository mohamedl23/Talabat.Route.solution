using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entitees;
using Talabat.Core.Repositories.Contract;
using Talabat.Repository.Data;

namespace Talabat.Repository
{
	public class GenaricRepository<T> : IgenaricRepository<T> where T : BaseEntity
	{
		private readonly StoreContext _dbContext;

		public GenaricRepository(StoreContext dbContext)
        {
			_dbContext = dbContext;
		}
		public async Task<IEnumerable<T>> GetAllAsync()
		{
			if (typeof(T) == typeof(Product))
				return (IEnumerable<T>) await _dbContext.products.Include(P =>P.Brand).Include(P=>P.Category).ToListAsync();
				 //await _dbContext.Set<T>().ToListAsync();
				 else
				return await _dbContext.Set<T>().ToListAsync();
		}

		public async Task<T?> GetAsync(int id)
				=> await _dbContext.Set<T>().FindAsync(id);
	}
}
