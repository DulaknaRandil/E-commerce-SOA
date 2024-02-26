using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.DBContext
{
    public class UserAddressContext : DbContext
    {
        public UserAddressContext(DbContextOptions<UserAddressContext> options) : base(options)
        {

        }


        public DbSet<UserAddress> UserAddresses { get; set; }


    }
}
