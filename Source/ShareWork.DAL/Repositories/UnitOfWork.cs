using System;
using ShareWork.BLL.Entities;
using ShareWork.BLL.Interfaces;

namespace ShareWork.BLL.Repositories
{
    public class UnitOfWork :IUnitOfWork
    {
        private DatabaseContext _context;

        private ClientRepository _clientRepository;
        private VerifyOrderRepository _verifyOrderRepository;
        private CategoryRepository _categoryRepository;
        private OrderRepository _orderRepository;

        public UnitOfWork()
        {
            _context = new DatabaseContext();
        }

        public IClientRepository ClientRep
        {
            get
            {
                if (_clientRepository == null)
                {
                    _clientRepository = new ClientRepository(_context);
                }
                return _clientRepository;
            }
        }

        public ICategoryRepository CategoryRep
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_context);
                }
                return _categoryRepository;
            }
        }

        public IVerifyOrderRepository VerifyOrderRep
        {
            get
            {
                if (_verifyOrderRepository == null)
                {
                    _verifyOrderRepository = new VerifyOrderRepository(_context);
                }
                return _verifyOrderRepository;
            }
        }

        public IOrderRepository OrdersRep
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_context);
                }
                return _orderRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}