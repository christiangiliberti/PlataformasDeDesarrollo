using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Insertar();
            //Borrado();

        }
        
        static void Insertar()
        {
            var ctx = new TareasDbContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                Id = 2,
                User="Test2",
                Clave ="112233"

            });

            ctx.SaveChanges();

        }

        static void Borrado()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.Id == 2).Single();
            ctx.Usuarios.Remove(usuario);
            ctx.SaveChanges();
        }


    }
}
