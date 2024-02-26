using E_commerce_SOA.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Services
{
    public interface OrderItemService
    {
        Task<IEnumerable<OrderItem>> GetAllOrderItems();
        Task<OrderItem> GetOrderItemById(int id);
        Task<OrderItem> CreateOrderItem(OrderItem orderItem);
        Task<bool> UpdateOrderItem(int id, OrderItem orderItem);
        Task<bool> DeleteOrderItem(int id);
    }
}
