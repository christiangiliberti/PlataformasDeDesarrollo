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
    public class RecursoController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public RecursoController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Recurso> GetAll()
        {
            return _context.Recurso.ToList();
        }

    }
}
