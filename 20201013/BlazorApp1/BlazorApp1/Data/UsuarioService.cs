using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        public Usuario[] GetUsuarios()
        {
            var bd = new TareasDbContext();

            var list = bd.Usuarios.ToArray();

            return list;
            
        }




        private TareasDbContext context;

        public UsuarioService(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<Usuario> Get(int id)
        {
            return await context.Usuarios.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            if (value.Id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        /*
        public Usuario[] GetUsuarios()
        {
            Usuario[] res = new Usuario[5];
            res[0] = new Usuario { Id = 1, User = "U1", Clave = "C1" };
            res[1] = new Usuario { Id = 2, User = "U2", Clave = "C2" };
            res[2] = new Usuario { Id = 3, User = "U3", Clave = "C3" };
            res[3] = new Usuario { Id = 4, User = "U4", Clave = "C4" };
            res[4] = new Usuario { Id = 5, User = "U5", Clave = "C5" };
            return res;
        }
        */
    }
}
