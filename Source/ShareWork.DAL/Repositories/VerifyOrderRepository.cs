using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ShareWork.BLL.Entities;
using ShareWork.BLL.Interfaces;

namespace ShareWork.BLL.Repositories
{
    public class VerifyOrderRepository : IVerifyOrderRepository
    {
        private DatabaseContext _context;

        public VerifyOrderRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Create(VerifyOrder entity)
        {
            _context.VerifyOrders.Add(entity);
        }

        public void Delete(VerifyOrder entity)
        {
            _context.VerifyOrders.Remove(entity);
        }

        public IEnumerable<VerifyOrder> GetAll()
        {
            return _context.VerifyOrders.Include(o => o.OrderId).Include(o => o.ServiceProviderId);
        }

        public IEnumerable<VerifyOrder> GetAllUserOrders(int orderId)
        {
            return _context.VerifyOrders.Include(o => o.OrderId).Include(o => o.ServiceProviderId).Where(o => o.OrderId == orderId);
        }

        public VerifyOrder GetById(int id)
        {
            return _context.VerifyOrders.Include(o => o.OrderId).Include(o => o.ServiceProviderId).Where(o => o.OrderId == id).FirstOrDefault();
        }



        public void Update(VerifyOrder entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}