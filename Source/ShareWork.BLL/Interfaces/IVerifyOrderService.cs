using System.Collections.Generic;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Interfaces
{
    public interface IVerifyOrderService
    {
        IEnumerable<VerifyOrderVM> GetAll();

        VerifyOrderVM GetById(int id);

        void Create(VerifyOrderVM model);

        void Update(VerifyOrderVM model);

        void Delete(int id);
    }
}