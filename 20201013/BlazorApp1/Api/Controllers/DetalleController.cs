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
    public class DetalleController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public DetalleController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Detalle> GetAll()
        {
            return _context.Detalle.ToList();
        }
    }
}
