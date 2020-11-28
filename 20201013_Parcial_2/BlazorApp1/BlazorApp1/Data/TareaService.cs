using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        /*
        public Tarea [] GetTareas()
        {
            var bd = new TareasDbContext();

            var list = bd.Tarea.ToArray();

            return list;
        }
        */



        private TareasDbContext context;

        public TareaService(TareasDbContext _context)
        {
            context = _context;
        }
        /*
        public async Task<Tarea> Get(int id)
        {
            return await context.Tarea.Where(i => i.Id == id).SingleAsync();
        }
        
        public async Task<List<Tarea>> GetAll()
        {
            return await context.Tarea.ToListAsync();
        }
        */
        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.GetAllTareas();
        }

        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");
            return await remoteService.GetTarea(id);
        }


        public async Task<Tarea> Save(Tarea value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            if (value.Id == 0)
            {
                await remoteService.CreateTarea(value);
            }
            else
            {
                await remoteService.EditTarea(value);
            }
            return value;
        }


        public async Task<Tarea> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.DeleteTarea(id);
        }


        /*
        public async Task<Tarea> Save(Tarea value)
        {
            if (value.Id == 0)
            {
                await context.Tarea.AddAsync(value);
            }
            else
            {
                context.Tarea.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tarea.Where(i => i.Id == id).SingleAsync();
            context.Tarea.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }


        /*
        public Tarea [] GetTareasAsync()
        {
            Tarea[] res = new Tarea[1];
            res[0] = new Tarea { Id = 1, Titulo = "T1", Vencimiento = new DateTime (2008, 10, 1), Estimacion = new DateTime(2008, 10, 1), ResponsableId = 1, Estado = true };
            return res;
        }
        */
    }
}
