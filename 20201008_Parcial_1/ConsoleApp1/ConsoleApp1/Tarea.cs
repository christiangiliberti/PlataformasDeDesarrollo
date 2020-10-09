using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime Estimacion { get; set; }
        public Recurso Responsable { get; set; }
        public int ResponsableId { get; set; }
        public bool Estado { get; set; }
    }
}
