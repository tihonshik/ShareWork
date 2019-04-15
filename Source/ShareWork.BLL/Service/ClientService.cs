using System.Collections.Generic;
using System.Linq;
using ShareWork.BLL.Interfaces;
using ShareWork.DAL.Entities;
using ShareWork.DAL.Interfaces;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Service
{
    public class ClientService : IClientService
    {
        private IUnitOfWork _unitOfWork;

        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ClientVM> GetAll()
        {
            return _unitOfWork.ClientRep.GetAll()
                .Select(u => 
                    new ClientVM
                    {
                        ClientId = u.ClientId,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        PhoneNumber = u.PhoneNumber
                    });
        }

        public void Create(ClientVM model)
        {
            _unitOfWork.ClientRep.Create(
                new Client
                {
                    ClientId = model.ClientId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber
                });
            _unitOfWork.Save();
        }

        public Client GetUser(ClientVM model)
        {
            Client user = new Client
            {
                ClientId = model.ClientId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber
            };

            return user;
        }

    }
}