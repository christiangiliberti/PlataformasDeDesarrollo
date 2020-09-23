using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Tarea
    {
        private string v1;
        private DateTime dateTime;
        private int v2;
        private Recurso recurso;
        private bool v3;

        public Tarea(string v1, DateTime dateTime, int v2, Recurso recurso, bool v3)
        {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
            this.recurso = recurso;
            this.v3 = v3;
        }

        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recurso Responsable { get; set; }
        public bool Estado { get; set; }
    }
    

}
