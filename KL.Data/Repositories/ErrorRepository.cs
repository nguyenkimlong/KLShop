using KL.Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IErrorRepository: IRepository<Error>
    {
      
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

       
    }
}