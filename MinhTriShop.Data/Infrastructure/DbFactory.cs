using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhTriShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MinhTriShopDbContext dbContext;

        public MinhTriShopDbContext Init()
        {
            //nếu dbcontext = null, khởi tạo 1 đối tượng mới = new MinhTriShopDbConText();
            return dbContext ?? (dbContext = new MinhTriShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
