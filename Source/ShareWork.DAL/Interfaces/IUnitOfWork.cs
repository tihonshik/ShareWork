using System;

namespace ShareWork.BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository ClientRep { get; }
        ICategoryRepository CategoryRep { get; }
        IVerifyOrderRepository VerifyOrderRep { get; }
        IOrderRepository OrdersRep { get; }

        void Save();
    }
}