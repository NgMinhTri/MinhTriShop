using MinhTriShop.Data.Infrastructure;
using MinhTriShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhTriShop.Data.Repositories
{
    public interface IProductCategoryrepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public  class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryrepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            :base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
