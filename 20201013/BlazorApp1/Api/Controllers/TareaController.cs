using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entidades;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public TareaController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Tarea> GetAll()
        {
            return _context.Tarea.ToList();
        }
    }
}
