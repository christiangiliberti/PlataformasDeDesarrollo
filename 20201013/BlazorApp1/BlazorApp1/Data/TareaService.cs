using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public BlazorApp1.Data.Tarea [] GetTareasAsync()
        {
            Tarea[] resultado = new Tarea[10];
            resultado[0] = new Tarea ("1","Tarea 1",20200101,20200101,"2",true);

            return resultado;
        }
    }
}
