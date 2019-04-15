using System.Collections.Generic;
using System.Linq;
using ShareWork.BLL.Interfaces;
using ShareWork.DAL.Entities;
using ShareWork.DAL.Interfaces;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Service
{
    public class VerifyOrderService : IVerifyOrderService
    {
        private IUnitOfWork _unitOfWork;

        public VerifyOrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<VerifyOrderVM> GetAll()
        {
            return _unitOfWork.VerifyOrderRep.GetAll()
                .Select(tour => new VerifyOrderVM { OrderId = tour.OrderId });
        }

        public VerifyOrderVM GetById(int id)
        {
            VerifyOrder verifyOrderService = _unitOfWork.VerifyOrderRep.GetById(id);

            return new VerifyOrderVM { OrderId = verifyOrderService.OrderId };
        }

        public void Create(VerifyOrderVM model)
        {
            _unitOfWork.VerifyOrderRep.Create(new VerifyOrder { OrderId = model.OrderId });
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            VerifyOrder verifyOrderService = _unitOfWork.VerifyOrderRep.GetById(id);

            if (verifyOrderService != null)
            {
                _unitOfWork.VerifyOrderRep.Delete(verifyOrderService);
                _unitOfWork.Save();
            }
        }

        public void Update(VerifyOrderVM model)
        {
            _unitOfWork.VerifyOrderRep.Update(new VerifyOrder { OrderId = model.OrderId});
            _unitOfWork.Save();
        }
    }
}