using E_commerce_SOA.BussinessLayer.DBContext;
using E_commerce_SOA.BussinessLayer.Services;
using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Repositories
{
    public class ShoppingCartRepository : ShoppingCartService
    {
        private readonly ShoppingCartContext _context;

        public ShoppingCartRepository(ShoppingCartContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ShoppingCart>> GetAllShoppingCarts()
        {
            return await _context.ShoppingCarts.ToListAsync();
        }

        public async Task<ShoppingCart> GetShoppingCartById(int id)
        {
            return await _context.ShoppingCarts.FindAsync(id);
        }

        public async Task<ShoppingCart> CreateShoppingCart(ShoppingCart shoppingCart)
        {
            _context.ShoppingCarts.Add(shoppingCart);
            await _context.SaveChangesAsync();
            return shoppingCart;
        }

        public async Task<bool> UpdateShoppingCart(int id, ShoppingCart shoppingCart)
        {
            if (id != shoppingCart.ShoppingCartId)
            {
                return false;
            }

            _context.Entry(shoppingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }

        public async Task<bool> DeleteShoppingCart(int id)
        {
            var shoppingCart = await _context.ShoppingCarts.FindAsync(id);
            if (shoppingCart == null)
            {
                return false;
            }

            _context.ShoppingCarts.Remove(shoppingCart);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool ShoppingCartExists(int id)
        {
            return _context.ShoppingCarts.Any(e => e.ShoppingCartId == id);
        }
    }
}
