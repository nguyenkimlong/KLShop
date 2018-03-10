using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig>
    {
      
    }
    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
