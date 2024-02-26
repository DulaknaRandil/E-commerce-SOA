using E_commerce_SOA.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Services
{
    public interface OrderService
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> CreateOrder(Order order);
        Task<bool> UpdateOrder(int id, Order order);
        Task<bool> DeleteOrder(int id);
    }
}
