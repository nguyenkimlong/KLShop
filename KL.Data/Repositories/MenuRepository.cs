using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
      
    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
