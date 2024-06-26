﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entitees;

namespace Talabat.Core.Specification
{
	public class BaseSpecifiction<T> : ISpecifiction<T> where T : BaseEntity
	{
        public Expression<Func<T, bool>> Criteria { get; set; } = null;
		public List<Expression<Func<T, object>>> Includes { get ; set ; } = new List<Expression<Func<T, object>>>();

        public BaseSpecifiction()
        {
            
        }
        public BaseSpecifiction(Expression<Func<T ,bool>> CriteriaExpression )
        {
            Criteria = CriteriaExpression;
        }

    }
}
