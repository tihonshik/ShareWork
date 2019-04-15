using System.Collections.Generic;
using ShareWork.DAL.Entities;

namespace ShareWork.DAL.Interfaces
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