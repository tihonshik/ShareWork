using System.Collections.Generic;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryVM> GetAll();

        CategoryVM GetById(int id);

        void Create(CategoryVM model);

        void Update(CategoryVM model);

        void Delete(int id);
    }
}