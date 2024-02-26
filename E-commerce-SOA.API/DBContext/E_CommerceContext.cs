using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_SOA.API.DBContext
{
    public class E_CommerceContext : DbContext
    {
        public E_CommerceContext(DbContextOptions<E_CommerceContext> options) : base(options)
        {

        }

        public DbSet<UserRegister> UserRegisters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Userlogin> Userlogins { get; set; }
    }
}
