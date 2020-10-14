using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        public Tarea [] GetTareasAsync()
        {
            Tarea[] res = new Tarea[5];
            res[0] = new Tarea { Id = 1, Titulo = "T1", Vencimiento = "V1", Estimacion = "E1", ResponsableId = 1, Estado = true };
            res[1] = new Tarea { Id = 2, Titulo = "T2", Vencimiento = "V2", Estimacion = "E2", ResponsableId = 2, Estado = true };
            res[2] = new Tarea { Id = 3, Titulo = "T3", Vencimiento = "V3", Estimacion = "E3", ResponsableId = 3, Estado = true };
            res[3] = new Tarea { Id = 4, Titulo = "T4", Vencimiento = "V4", Estimacion = "E4", ResponsableId = 4, Estado = true };
            res[4] = new Tarea { Id = 5, Titulo = "T5", Vencimiento = "V5", Estimacion = "E5", ResponsableId = 5, Estado = true };
            return res;
        }
    }
}
