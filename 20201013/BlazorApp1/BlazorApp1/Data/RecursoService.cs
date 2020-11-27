using Microsoft.EntityFrameworkCore;
using System;
using Model.Entidades;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        /*
        public Recurso[] GetRecursos ()
        {
            var bd = new TareasDbContext();

            var list = bd.Recurso.ToArray();

            return list;

        }
        */


        private TareasDbContext context;

        public RecursoService(TareasDbContext _context)
        {
            context = _context;
        }


        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");
            return await remoteService.GetRecurso(id);
        }


        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.GetAllRecursos();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            if (value.Id == 0)
            {
                await remoteService.CreateRecurso(value);
            }
            else
            {
                await remoteService.EditRecurso(value);
            }
            return value;
        }


        public async Task<Recurso> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.DeleteRecurso(id);
        }


        public async Task<List<Usuario>> GetUsuarios()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.GetAllUsuarios();
        }

        /*
        public async Task<Recurso> Get(int id)
        {
            return await context.Recurso.Where(i => i.Id == id).SingleAsync();
        }
        /*
        public async Task<List<Recurso>> GetAll()
        {
            return await context.Recurso.ToListAsync();
        }
        
        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.GetAllRecursos();
        }


        public async Task<Recurso> Save(Recurso value)
        {
            if (value.Id == 0)
            {
                await context.Recurso.AddAsync(value);
            }
            else
            {
                context.Recurso.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recurso.Where(i => i.Id == id).SingleAsync();
            context.Recurso.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }


        /*
        public Recurso[] GetRecursosAsync()
        {
            Recurso[] res = new Recurso[1];
            res[0] = new Recurso { Id = 1, Nombre = "T1", Usuario = new Usuario ()};
            return res;
        }

        
        public async Task<List<Usuario>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }

        */

    }
}
