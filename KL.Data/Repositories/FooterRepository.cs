using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IFooterRepository: IRepository<Footer>
    {
      
    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
