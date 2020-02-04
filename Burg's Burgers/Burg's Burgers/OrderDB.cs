using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burg_s_Burgers
{
    public static class OrderDB
    {
        /// <summary>
        /// Returns the total number of Order items
        /// </summary>
        public async static Task<int> GetNumOrders(OrderContext orderContext)
        {
            return await orderContext.Orders.CountAsync();
        }

        // Might never use this function, but I'm adding it anyway.
        /// <summary>
        /// Returns all of the Order items.
        /// </summary>
        private static async Task<List<Order>> GetAllOrders(OrderContext orderContext)
        {
            return await
            (
                from o in orderContext.Orders
                orderby o.OrderID descending
                select o
            ).ToListAsync();
        }

        /// <summary>
        /// Returns a page of Order items based upon the pageNum & pageSize values.
        /// </summary>
        /// <param name="orderContext"></param>
        /// <param name="pageNum">Which page is being looked at.</param>
        /// <param name="pageSize">The number of orders per page.</param>
        public static async Task<List<Order>> GetOrdersByPage(
                           OrderContext orderContext, int pageNum, byte pageSize)
        {
            const int PageOffset = 1;

            return await
            (
                from o in orderContext.Orders
                orderby o.OrderID descending
                select o
            ).Skip(pageSize * (pageNum - PageOffset))
             .Take(pageSize)
             .OrderBy(c => c.OrderID)
             .ToListAsync();
        }
    }
}
