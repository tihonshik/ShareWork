using System.Collections.Generic;
using ShareWork.BLL.Entities;

namespace ShareWork.BLL.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();

        void Create(Client entity);

        void Update(Client entity);
    }
}