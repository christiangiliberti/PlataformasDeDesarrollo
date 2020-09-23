using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Tarea
    {
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recurso Responsable { get; set; }
        public bool Estado { get; set; }
    }
}
