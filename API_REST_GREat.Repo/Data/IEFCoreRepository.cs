using API_REST_GREat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_GREat.Data
{
    public interface IEFCoreRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        UsuarioDTO[] GetallUsers();
        UsuarioDTO[] GetUserByDoc(string doc);
        UsuarioDTO[] GetUserByName(string name);
        UsuarioDTO GetUserById(int id);
        Task<bool> SaveChangesAsync();
    }
}
