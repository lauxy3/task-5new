using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class OrderDBContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderDBContext(DbContextOptions<OrderDBContext> options)
            : base(options)
        {
        }
        public DbSet<Order> Order { get; set; }
    }
}
