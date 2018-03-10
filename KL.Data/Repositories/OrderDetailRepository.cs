using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
      
    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
