using System.Collections.Generic;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Interfaces
{
    public interface IClientService
    {
        IEnumerable<ClientVM> GetAll();

        void Create(ClientVM model);


    }
}