using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.DBContext
{
    public class OrderItemContext : DbContext
    {
         public OrderItemContext(DbContextOptions<OrderItemContext> options) : base(options) { } 

        public DbSet<OrderItem>OrderItems { get; set; }





    }
}
