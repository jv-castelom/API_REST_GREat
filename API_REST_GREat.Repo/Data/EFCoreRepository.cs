using API_REST_GREat.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_GREat.Data
{
    public class EFCoreRepository : IEFCoreRepository
    {
        private readonly DataContext _context;

        public EFCoreRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            
            _context.Update(entity);
        }

        public string Implementado()
        {
            return "Implementado";
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        

        public Usuario[] GetallUsers()
        {
            IQueryable<Usuario> query = _context.Usuarios;
            query.AsNoTracking().OrderBy(h => h.Id);
            return query.ToArray();
        }

        public Usuario GetUserByDoc(string doc)
        {
            IQueryable<Usuario> query = _context.Usuarios;
            query.AsNoTracking().OrderBy(h => h.Id);
            return query.FirstOrDefault(h => h.CPF == doc || h.RG == doc);
        }

        public Usuario[] GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public Usuario GetUserById(int id)
        {
            IQueryable<Usuario> query = _context.Usuarios;
            query.AsNoTracking().OrderBy(h => h.Id);
            return query.AsNoTracking().FirstOrDefault(h => h.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
