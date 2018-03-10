using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KL.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private KLShopDbContext dbContext;

        public KLShopDbContext Init()
        {
            return dbContext ?? (dbContext = new KLShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
