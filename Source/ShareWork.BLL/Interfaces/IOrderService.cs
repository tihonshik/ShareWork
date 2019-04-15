using System.Collections.Generic;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderVM> GetAll();

        OrderVM GetById(int id);

        void Create(OrderVM model);

        void Update(OrderVM model);

        void Delete(int id);
    }
}