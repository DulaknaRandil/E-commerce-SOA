using E_commerce_SOA.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Services
{
    public interface ShoppingCartService
    {
        Task<IEnumerable<ShoppingCart>> GetAllShoppingCarts();
        Task<ShoppingCart> GetShoppingCartById(int id);
        Task<ShoppingCart> CreateShoppingCart(ShoppingCart shoppingCart);
        Task<bool> UpdateShoppingCart(int id, ShoppingCart shoppingCart);
        Task<bool> DeleteShoppingCart(int id);
    }
}
