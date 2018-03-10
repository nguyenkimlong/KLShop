using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
      
    }
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
