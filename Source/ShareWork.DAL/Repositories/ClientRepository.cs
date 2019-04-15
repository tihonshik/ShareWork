using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ShareWork.DAL.Entities;
using ShareWork.DAL.Interfaces;

namespace ShareWork.DAL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DatabaseContext _context;

        public ClientRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients;
        }

        public void Create(Client entity)
        {
            _context.Clients.Add(entity);
        }

        public void Update(Client entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            //_context.Set<User>().AddOrUpdate(entity);
        }
    }
}