using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Models
{
    public class SampleAPIContext : DbContext
    {
        public SampleAPIContext(DbContextOptions<SampleAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> customer { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }


    }
}
