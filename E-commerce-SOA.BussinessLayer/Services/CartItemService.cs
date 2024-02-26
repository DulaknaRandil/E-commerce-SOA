using E_commerce_SOA.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Services
{
    public interface CartItemService
    {
        Task<IEnumerable<CartItem>> GetAllCartItems();
        Task<CartItem> GetCartItemById(int id);
        Task<CartItem> CreateCartItem(CartItem cartItem);
        Task<bool> UpdateCartItem(int id, CartItem cartItem);
        Task<bool> DeleteCartItem(int id);
    }
}
