using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Model.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public UsuarioController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        /*
       [HttpGet("{id}")]

       public Usuario GetUsuario(int id)
       {
           Usuario usuario = _context.Usuarios.(id);
           return usuario;
       }

       
       public Usuario EditUsuario(Usuario value)
       {
           _context.Usuarios.Update(value);
           _context.SaveChanges();
           return value;
       }
       */

    }
}
