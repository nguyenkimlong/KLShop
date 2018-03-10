using KL.Data.Infrastructure;
using KLShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace KL.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int Pageindex, int PageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        IEnumerable<Post> IPostRepository.GetAllByTag(string tag, int Pageindex, int PageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status == true
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((Pageindex - 1) * PageSize).Take(PageSize);
            return query;
        }
    }
}