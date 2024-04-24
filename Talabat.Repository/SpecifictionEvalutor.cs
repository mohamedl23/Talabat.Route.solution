using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entitees;
using Talabat.Core.Specification;

namespace Talabat.Repository
{
	public static class SpecifictionEvalutor<TEntity> where TEntity : BaseEntity 
	{
		public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery , ISpecifiction<TEntity> spec)
		{
			var query = inputQuery;
			if (spec.Criteria is not null)
				query = query.Where(spec.Criteria);

			query = spec.Includes.Aggregate(query ,(currentQuery , IncludeExpression ) =>  currentQuery.Include(IncludeExpression));

			return query;
		}
	}
}
