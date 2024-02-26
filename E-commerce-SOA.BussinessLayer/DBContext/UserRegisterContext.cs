using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.DBContext
{
    public class UserRegisterContext : DbContext
    {
        public UserRegisterContext(DbContextOptions<UserRegisterContext> options) : base(options)
        {

        }

        public DbSet<UserRegister> UserRegisters { get; set; }
       

    }
}
