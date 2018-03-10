using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
      
    }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
