using System.Collections.Generic;
using ShareWork.DAL.Entities;

namespace ShareWork.DAL.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();

        void Create(Client entity);

        void Update(Client entity);
    }
}