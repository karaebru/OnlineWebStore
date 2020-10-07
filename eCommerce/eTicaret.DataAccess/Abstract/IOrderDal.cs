using eTicaret.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.DataAccess.Abstract
{
    public interface IOrderDal : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}
