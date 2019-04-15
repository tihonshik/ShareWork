using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ShareWork.BLL.Entities;
using ShareWork.BLL.Interfaces;
using EntityState = System.Data.Entity.EntityState;

namespace ShareWork.BLL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private DatabaseContext _context;

        public OrderRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.Include(o => o.OrderId).Include(o => o.CustomerId);
        }

        public IEnumerable<Order> GetAllUserOrders(int userId)
        {
            return _context.Orders.Include(o => o.OrderId).Include(o => o.CategoryId).Where(o => o.CustomerId == userId);
        }

        public Order GetById(int id)
        {
            return _context.Orders.Include(o => o.OrderId).Include(o => o.CustomerId).Where(o => o.OrderId == id).FirstOrDefault();
        }

        public Order GetByIdUserOrder(int userId, int orderId)
        {
            return _context.Orders.Include(o => o.CustomerId).Include(o => o.OrderId).Where(o => o.CustomerId == userId && o.OrderId == orderId).FirstOrDefault();
        }

        //Booking
        public void Create(Order entity)
        {
            _context.Orders.Add(entity);
        }

        //Buy
        public void Update(Order entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }
    }
}