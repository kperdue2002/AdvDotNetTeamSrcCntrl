using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
        /// <param name="orderContext">DB Context</param>
        public async static Task<int> GetNumOrders(OrderContext orderContext)
        {
            return await orderContext.Orders.CountAsync();
        }

        // For testing purposes.
        /// <summary>
        /// Returns all of the Order items.
        /// </summary>
        /// <param name="orderContext">DB Context</param>
        public static List<Order> GetAllOrders(OrderContext orderContext)
        {
            using (SqlConnection con = orderContext.Database.Connection as SqlConnection)
            {
                con.Open();
                SqlCommand getCommand = new SqlCommand
                {
                    Connection = con,
                    CommandText = "SELECT *"
                                + "FROM Orders"
                };
                SqlDataReader reader = getCommand.ExecuteReader();
                var result = new List<Order>();
                while (reader.Read())
                {
                    Order item = new Order()
                    {
                        OrderID = (int)reader[0],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        ZipCode = reader["ZipCode"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Quantity = (byte)reader["Quantity"],
                        SpecialDirections = reader["SpecialDirections"].ToString(),
                        DateOfOrder = (DateTime)reader["DateOfOrder"],
                        IsDelivered = (bool)reader["IsDelivered"]
                    };
                    result.Add(item);
                }
                con.Close();
                return result;
            }


            //return await
            /*(
                from o in orderContext.Orders
                orderby o.OrderID descending
                select o
            ).ToListAsync();
            */
        }

        /// <summary>
        /// Returns a page of Order items based upon the pageNum & pageSize values.
        /// </summary>
        /// <param name="pageNum">Which page is being looked at.</param>
        /// <param name="pageSize">The number of orders per page.</param>
        /// <param name="orderContext">DB Context</param>
        public static async Task<List<Order>> GetOrdersByPage(
                           int pageNum, byte pageSize, OrderContext orderContext)
        {
            const int PageOffset = 1;
            //orderContext.Orders

            IOrderedQueryable<Order> query = from o in orderContext.Orders
                                             orderby o.OrderID descending
                                             select o;

            return await query.Skip(pageSize * (pageNum - PageOffset))
                              .Take(pageSize)
                              .ToListAsync();
        }

        /// <summary>
        /// Returns an order object by its OrderID. Will return null if 
        /// there is no object that matches the ID
        /// </summary>
        /// <param name="id">the OrderID</param>
        /// <param name="orderContext">DB Context</param>
        public static async Task<Order> GetOrderbyID(int id, OrderContext orderContext)
        {
            return await (
                from o in orderContext.Orders
                where o.OrderID == id
                select o
            ).SingleOrDefaultAsync();
        }

        /*
        public static Task<List<Order>> GetOrdersByPageWorkaround(int pageNum, byte pageSize, OrderContext orderContext)
        {
            SqlConnection con = orderContext.Database.SqlQuery.
        }
        */

        /// <summary>
        /// Adds/manipulates a new order in the database depending on the input.
        /// </summary>
        /// <param name="o">The order to be input</param>
        /// <param name="state">The EntityState to determine what happens</param>
        /// <param name="orderContext">DB Context</param>
        /// <returns></returns>
        private static async Task<Order> OrderAction(
            Order o, OrderContext orderContext, EntityState state)
        {
            orderContext.Orders.Add(o);
            orderContext.Entry(o).State = state;
            await orderContext.SaveChangesAsync();
            return o;
        }

        /// <summary>
        /// Adds a new order to the database.
        /// </summary>
        /// <param name="o">The order to be added</param>
        /// <param name="orderContext">DB Context</param>
        /// <returns></returns>
        public static async Task<Order> Add(Order o, OrderContext orderContext)
        {
            return await OrderAction(o, orderContext, EntityState.Added);
        }

        /// <summary>
        /// Removes an existing Order entry from the database.
        /// </summary>
        /// <param name="o">The order to be deleted</param>
        /// <param name="orderContext">DB Context</param>
        /// <returns></returns>
        public static async Task<Order> Delete(Order o, OrderContext orderContext)
        {
            return await OrderAction(o, orderContext, EntityState.Deleted);
        }

        /// <summary>
        /// Edits an existing Order entry in the database.
        /// </summary>
        /// <param name="o">The order to be edited</param>
        /// <param name="orderContext">DB Context</param>
        /// <returns></returns>
        public static async Task<Order> Edit(Order o, OrderContext orderContext)
        {
            return await OrderAction(o, orderContext, EntityState.Modified);
        }
    }
}
