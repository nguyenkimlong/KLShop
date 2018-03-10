using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
      
    }
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
