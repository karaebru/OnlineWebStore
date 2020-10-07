using eTicaret.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.Business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}
