using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entitees;

namespace Talabat.Core.Specification.Product_Specs
{
    public class ProductWithBrandAndCategorySpecification : BaseSpecifiction<Product>
    {
        public ProductWithBrandAndCategorySpecification() : base()
        {
            Includes.Add(P => P.Brand);
            Includes.Add(P => P.Category);
        }
    }
}
