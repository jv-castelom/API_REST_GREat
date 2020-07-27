using API_REST_GREat.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_GREat.Data
{
    //Faz o mapeamento das classes para o db.
    public class DataContext :DbContext
    {
        //Injecao de dependencia
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<UsuarioDTO> Usuarios { get; set; }
    }
}
