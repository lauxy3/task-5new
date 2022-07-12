using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class CartDBContext : DbContext
    {
        public CartDBContext(DbContextOptions<CartDBContext> options)
            : base (options)
        {
        }
        public DbSet<Cart> Cart { get; set; }
    }
}
