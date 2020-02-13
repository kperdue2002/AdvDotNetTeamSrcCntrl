using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace Burg_s_Burgers
{

    public partial class OrderContext : DbContext
    {

        public OrderContext()
            : base("name=OrderContext")
        { }

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
