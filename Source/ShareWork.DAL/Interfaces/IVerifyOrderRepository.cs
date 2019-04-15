using System.Collections.Generic;
using ShareWork.DAL.Entities;

namespace ShareWork.DAL.Interfaces
{
    public interface IVerifyOrderRepository
    {
        IEnumerable<VerifyOrder> GetAll();

        VerifyOrder GetById(int id);

        void Create(VerifyOrder entity);

        void Update(VerifyOrder entity);

        void Delete(VerifyOrder entity);
    }
}