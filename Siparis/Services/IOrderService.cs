using Siparis.DTOs;
using Siparis.Models;

namespace Siparis.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(CreateOrderDto dto);
        Task<List<Order>> GetOrdersByUser(int userId);
        Task<Order> GetOrderById(int id);
        Task<bool> DeleteOrderAsync(int id);
    }
}
