using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using Refit;
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
        /*
        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api/Usuario");
            return await context.Usuarios.Where(i => i.Id == id).SingleAsync();
        }
        */
        
        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.GetAllUsuarios();
        }
        
        public async Task<Usuario> Save(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            if (value.Id == 0)
            {
                await context.Usuarios.AddAsync(value);
                await context.SaveChangesAsync();
            }
            else
            {
                await remoteService.EditUsuario(value);
            }
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
