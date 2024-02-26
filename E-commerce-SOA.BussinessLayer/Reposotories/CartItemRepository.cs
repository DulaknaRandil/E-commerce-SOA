using E_commerce_SOA.BussinessLayer.DBContext;
using E_commerce_SOA.BussinessLayer.Services;
using E_commerce_SOA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Repositories
{
    public class CartItemRepository : CartItemService
    {
        private readonly CartItemContext _context;

        public CartItemRepository(CartItemContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItems()
        {
            return await _context.CartItems.ToListAsync();
        }

        public async Task<CartItem> GetCartItemById(int id)
        {
            return await _context.CartItems.FindAsync(id);
        }

        public async Task<CartItem> CreateCartItem(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            await _context.SaveChangesAsync();
            return cartItem;
        }

        public async Task<bool> UpdateCartItem(int id, CartItem cartItem)
        {
            if (id != cartItem.CartItemId)
            {
                return false;
            }

            _context.Entry(cartItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartItemExists(id))
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

        public async Task<bool> DeleteCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem == null)
            {
                return false;
            }

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItems.Any(e => e.CartItemId == id);
        }
    }
}
