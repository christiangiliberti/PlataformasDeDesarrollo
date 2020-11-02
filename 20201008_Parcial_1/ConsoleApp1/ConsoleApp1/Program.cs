using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //InsertarUsuario();
            //BorrarUsuario();
            //ConsultarUsuario();
            //ActualizarUsuario();
            //InsertarTarea();
            InsertarRecurso();
            //ConsultarRecurso();
            
        }
        
        static void InsertarUsuario()
        {
            var bd = new TareasDbContext();

            bd.Set<Usuario>().Add(new Usuario{

                //Id = 2,
                User="Test9",
                Clave ="123456"

            });

            bd.SaveChanges();

        }

        static void BorrarUsuario(){
            var bd = new TareasDbContext();
            var user= bd.Usuarios.Where(i => i.Id == 10).Single();
            bd.Usuarios.Remove(user);
            bd.SaveChanges();
        }

        static void ConsultarUsuario()
        {
            var bd = new TareasDbContext();

            var list = bd.Usuarios.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Id:{item.Id} \nNombre: {item.User}");
            }
        }

        static void ActualizarUsuario()
        {
            var bd = new TareasDbContext();
            var list = bd.Usuarios.Where(i => i.Id == 5).ToList();
            list[0].User = "Test5";
            list[0].Clave = "654321";
            bd.SaveChanges();
        }

        static void InsertarTarea()
        {
            var bd = new TareasDbContext();
            var list = bd.Usuarios.Where(i => i.Id == 2).ToList();
            bd.Set<Tarea>().Add(new Tarea
            {
                //Id = 2,
                Titulo= "Tarea 1",
                Vencimiento = new DateTime (2008, 10, 1),
                Estimacion = new DateTime(2008, 10, 1),
                Responsable = new Recurso {Nombre = "Router", Usuario = list[0] },
                ResponsableId = 2,
                Estado = true,
            });

            bd.SaveChanges();

        }


        static void InsertarRecurso(){
            var bd = new TareasDbContext();
            var list = bd.Usuarios.Where(i => i.Id == 9).ToList();
            bd.Set<Recurso>().Add(new Recurso{

                //Id = 2,
                Nombre = "Recurso3",
                Usuario = list[0],

            });

            bd.SaveChanges();

        }


        static void ConsultarRecurso(){
            var bd = new TareasDbContext();

            var list = bd.Recurso.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Id:{item.Id} \nNombre: {item.Nombre}");
            }
        }



    }
}

