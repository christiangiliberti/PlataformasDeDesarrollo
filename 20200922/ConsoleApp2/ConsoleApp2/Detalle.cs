using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Detalle
    {
        public string Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }
    }
}
