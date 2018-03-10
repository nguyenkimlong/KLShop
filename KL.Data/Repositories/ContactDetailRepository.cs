using KL.Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IContactDetailRepository : IRepository<ProductCategory>
    {
       
    }

    public class ContactDetailRepository : RepositoryBase<ProductCategory>, IContactDetailRepository
    {
        public ContactDetailRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

       
    }
}