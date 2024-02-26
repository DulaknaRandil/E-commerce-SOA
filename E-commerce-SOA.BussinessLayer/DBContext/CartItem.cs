using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.DBContext
{
    public class CartItemContext : DbContext
    {
        public CartItemContext(DbContextOptions<CartItemContext> options) : base(options)
        {

        }

       
        public DbSet<CartItem> CartItems { get; set; }
       

    }
}
