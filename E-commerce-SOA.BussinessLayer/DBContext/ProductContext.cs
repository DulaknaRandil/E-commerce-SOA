using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.DBContext
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions< ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
      

    }
}
