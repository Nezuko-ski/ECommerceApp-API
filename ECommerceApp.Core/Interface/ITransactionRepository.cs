﻿using ECommerceApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Core.Interface
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
    }
}
