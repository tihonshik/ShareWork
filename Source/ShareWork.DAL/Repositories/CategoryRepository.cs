using System.Collections.Generic;
using System.Data.Entity.Migrations;

using ShareWork.DAL.Entities;
using ShareWork.DAL.Interfaces;

namespace ShareWork.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private DatabaseContext _context;

        public CategoryRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Create(Categories entity)
        {
            _context.Categorieses.Add(entity);
        }

        public void Delete(Categories entity)
        {
            _context.Categorieses.Remove(entity);
        }

        public IEnumerable<Categories> GetAll()
        {
            return _context.Categorieses;
        }

        public Categories GetById(int id)
        {
            return _context.Categorieses.Find(id);
        }

        public void Update(Categories entity)
        {
            _context.Set<Categories>().AddOrUpdate(entity);
        }
    }
}