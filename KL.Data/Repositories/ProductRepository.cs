using KL.Data.Infrastructure;
using KLShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace KL.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllByTag(string tag, int page, int pageSize, out int totalRow);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        IEnumerable<Product> IProductRepository.GetAllByTag(string tag, int Pageindex, int PageSize, out int totalRow)
        {
            var query = from p in DbContext.Products
                        join pt in DbContext.PostTags on p.ID equals pt.PostID
                        where pt.TagID == tag
                        //orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((Pageindex - 1) * PageSize).Take(PageSize);
            return query;
        }
    }
}