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
            //Insertar();
            //Borrado();
            //Consultar();
            Actualizacion();
        }
        
        static void Insertar()
        {
            var ctx = new TareasDbContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                //Id = 2,
                User="Test2",
                Clave ="11111"

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

        static void Consultar()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Id:{item.Id} \nNombre: {item.User}");
            }
        }

        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.Where(i => i.Id == 4).ToList();
            lista[0].User = "Pedro";
            lista[0].Clave = "123456";
            ctx.SaveChanges();
        }


    }
}
