using MinhTriShop.Data.Infrastructure;
using MinhTriShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhTriShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
