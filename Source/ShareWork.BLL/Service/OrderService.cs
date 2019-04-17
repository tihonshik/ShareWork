using System.Collections.Generic;
using System.Linq;
using ShareWork.BLL.Interfaces;
using ShareWork.DAL.Entities;
using ShareWork.DAL.Interfaces;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Service
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<OrderVM> GetAll()
        {
            return _unitOfWork.OrdersRep.GetAll()
                .Select(o => 
                    new OrderVM
                    {
                        OrderId = o.Id,
                        CategoryId = o.CategoryId,
                        Header = o.Header,
                        Discription = o.Discription,
                        City = o.City,
                        CustomerId = o.CustomerId
                    });
        }

        public OrderVM GetById(int id)
        {
            Order o = _unitOfWork.OrdersRep.GetById(id);

            return new OrderVM
            {
                OrderId = o.Id,
                CategoryId = o.CategoryId,
                Header = o.Header,
                Discription = o.Discription,
                City = o.City,
                CustomerId = o.CustomerId
            };
        }

        public void Create(OrderVM model)
        {
            _unitOfWork.OrdersRep.Create(
                new Order
                {
                Id = model.OrderId,
                CategoryId = model.CategoryId,
                Header = model.Header,
                Discription = model.Discription,
                City = model.City,
                CustomerId = model.CustomerId
                });
            _unitOfWork.Save();
        }

        public void Update(OrderVM model)
        {
            Order order = _unitOfWork.OrdersRep.GetById(model.OrderId);


            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            Order order = _unitOfWork.OrdersRep.GetById(id);

            if (order != null)
            {
                _unitOfWork.OrdersRep.Delete(order);
                _unitOfWork.Save();
            }
        }
    }
}