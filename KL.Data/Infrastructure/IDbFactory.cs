﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KL.Data.Infrastructure
{
    public interface IDbFactory :IDisposable
    {
        KLShopDbContext Init();
    }
}
