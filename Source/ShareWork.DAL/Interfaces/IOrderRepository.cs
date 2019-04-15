using System.Collections.Generic;
using ShareWork.DAL.Entities;


namespace ShareWork.DAL.Interfaces
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