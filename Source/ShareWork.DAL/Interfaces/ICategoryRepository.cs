using System.Collections.Generic;
using ShareWork.BLL.Entities;

namespace ShareWork.BLL.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAll();

        Categories GetById(int id);

        void Create(Categories entity);

        void Update(Categories entity);

        void Delete(Categories entity);
    }
}