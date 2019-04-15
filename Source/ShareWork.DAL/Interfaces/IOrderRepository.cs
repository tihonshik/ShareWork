using System.Collections.Generic;
using ShareWork.BLL.Entities;

namespace ShareWork.BLL.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();

        IEnumerable<Order> GetAllUserOrders(int userId);

        Order GetById(int id);

        Order GetByIdUserOrder(int userId, int orderId);

        void Create(Order entity);

        void Update(Order entity);

        void Delete(Order entity);
    }
}