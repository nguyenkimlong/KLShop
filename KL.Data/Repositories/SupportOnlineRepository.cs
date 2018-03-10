using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {
      
    }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
