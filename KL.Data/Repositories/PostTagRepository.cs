﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KL.Data.Infrastructure;
using KLShop.Model.Models;

namespace KL.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
      
    }
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            
        }

      
    }
}
