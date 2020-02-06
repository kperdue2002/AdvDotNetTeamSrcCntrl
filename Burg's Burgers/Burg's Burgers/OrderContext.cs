using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burg_s_Burgers
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        // Add a DbSet for each entity that needs to be tracked by the database.
        public DbSet<Order> Orders { get; set; }
        /*
        interface IPayProvider
        {
            MakePayment();
        }

        public void MakePayment(IPayProvider pay)
        {
            pay.MakePayment(50.00);
        }
        */
    }
}
