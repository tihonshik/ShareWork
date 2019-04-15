using System.Collections.Generic;
using System.Linq;
using ShareWork.BLL.Interfaces;
using ShareWork.DAL.Entities;
using ShareWork.DAL.Interfaces;
using ShareWork.Model.ViewModel;

namespace ShareWork.BLL.Service
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CategoryVM> GetAll()
        {
            return _unitOfWork.CategoryRep.GetAll()
                .Select(h => new CategoryVM { CategoryId = h.CategoryId, CategoryName = h.CategoryName });
        }

        public CategoryVM GetById(int id)
        {
            Categories c = _unitOfWork.CategoryRep.GetById(id);

            return new CategoryVM { CategoryId = c.CategoryId, CategoryName = c.CategoryName };
        }

        public void Create(CategoryVM model)
        {
            Categories categories = new Categories { CategoryId = model.CategoryId, CategoryName = model.CategoryName };

            _unitOfWork.CategoryRep.Create(categories);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            Categories categories = _unitOfWork.CategoryRep.GetById(id);

            if (categories != null)
            {
                _unitOfWork.CategoryRep.Delete(categories);
                _unitOfWork.Save();
            }
        }

        public void Update(CategoryVM model)
        {
            _unitOfWork.CategoryRep.Update(new Categories { CategoryId = model.CategoryId, CategoryName = model.CategoryName });
            _unitOfWork.Save();
        }
    }
}