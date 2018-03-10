using System.Collections.Generic;
using System.Linq;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories {
    public interface IFeedbackRepository : IRepository<Feedback> {

    }

    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository {
        public FeedbackRepository (DbFactory dbFactory) : base (dbFactory) { }

    }
}