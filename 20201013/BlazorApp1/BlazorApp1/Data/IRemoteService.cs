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

        
        [Put("/Usuario")]
        public Task<Usuario> EditUsuario(Usuario usuario);
        




    }
}
