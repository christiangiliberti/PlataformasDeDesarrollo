using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Tarea1", new DateTime(2020, 9, 22), 10, new Recurso(), false));
            tareas.Add(new Tarea("Tarea2", new DateTime(2020, 9, 23), 12, new Recurso(), false));
            tareas.Add(new Tarea("Tarea3", new DateTime(2020, 9, 24), 12, new Recurso(), false));
            tareas.Add(new Tarea("Tarea4", new DateTime(2020, 9, 25), 11, new Recurso(), false));
            tareas.Add(new Tarea("Tarea5", new DateTime(2020, 9, 25), 11, new Recurso(), false));

        }

       
    }
}
