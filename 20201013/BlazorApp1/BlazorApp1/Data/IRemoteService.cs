using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {
        [Get("/Usuario")]
        public Task<List<Usuario>> GetAllUsuarios();

        [Get("/Usuario/{id}")]
        public Task<Usuario> GetUsuario(int id);
        
        [Delete("/Usuario/{id}")]
        public Task<Usuario> DeleteUsuario(int id);

        [Post("/Usuario")]
        public Task<Usuario> CreateUsuario([Body] Usuario usuario);

        [Put("/Usuario")]
        public Task<Usuario> EditUsuario([Body] Usuario usuario);
        

        [Get("/Tarea")]
        public Task<List<Tarea>> GetAllTareas();

        [Get("/Recurso")]
        public Task<List<Recurso>> GetAllRecursos();

        [Get("/Detalle")]
        public Task<List<Detalle>> GetAllDetalles();

    }
}
